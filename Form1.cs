// Form1.cs
using System;
using System.Data;
using System.Configuration;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Data.SqlClient;  // ha SqlDataAdapter-hez is ezt használod

namespace KerdesValaszSupport
{
    public partial class Form1 : Form
    {
        private readonly string _conn = ConfigurationManager
            .ConnectionStrings["SajatDNN"].ConnectionString;
        private DataTable _questionsTable;
        private DataTable _answersTable;

        public Form1()
        {
            InitializeComponent();
            LoadQuestions();
        }

        private void LoadQuestions()
        {
            using (var conn = new SqlConnection(_conn))
            using (var cmd = new SqlCommand(
                "SELECT QuestionID, QuestionText, SortOrder FROM PerfumeQuestions ORDER BY SortOrder", conn))
            using (var da = new SqlDataAdapter(cmd))
            {
                _questionsTable = new DataTable();
                da.Fill(_questionsTable);
                dgvQuestions.DataSource = _questionsTable;
            }

            // Oszlopok átcímkézése magyarul
            if (dgvQuestions.Columns["QuestionID"] != null)
                dgvQuestions.Columns["QuestionID"].HeaderText = "Kérdés ID";
            if (dgvQuestions.Columns["QuestionText"] != null)
                dgvQuestions.Columns["QuestionText"].HeaderText = "Kérdés szövege";
            if (dgvQuestions.Columns["SortOrder"] != null)
                dgvQuestions.Columns["SortOrder"].HeaderText = "Sorrend";
        }

        private void LoadAnswers(int questionId)
        {
            using (var conn = new SqlConnection(_conn))
            using (var cmd = new SqlCommand(
                "SELECT AnswerID, AnswerText, ValueCode, SortOrder FROM PerfumeAnswers WHERE QuestionID=@qId ORDER BY SortOrder",
                conn))
            {
                cmd.Parameters.AddWithValue("@qId", questionId);
                using (var da = new SqlDataAdapter(cmd))
                {
                    _answersTable = new DataTable();
                    da.Fill(_answersTable);
                    dgvAnswers.DataSource = _answersTable;
                }
            }

            // Oszlopok átcímkézése magyarul
            if (dgvAnswers.Columns["AnswerID"] != null)
                dgvAnswers.Columns["AnswerID"].HeaderText = "Válasz ID";
            if (dgvAnswers.Columns["AnswerText"] != null)
                dgvAnswers.Columns["AnswerText"].HeaderText = "Válasz szövege";
            if (dgvAnswers.Columns["ValueCode"] != null)
                dgvAnswers.Columns["ValueCode"].HeaderText = "Illatkategória";
            if (dgvAnswers.Columns["SortOrder"] != null)
                dgvAnswers.Columns["SortOrder"].HeaderText = "Sorrend";
        }

        private void dgvQuestions_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvQuestions.CurrentRow == null) return;

            object cell = dgvQuestions.CurrentRow.Cells["QuestionID"].Value;
            if (cell == null || cell == DBNull.Value)
            {
                dgvAnswers.DataSource = null;
                return;
            }

            int qid = Convert.ToInt32(cell);
            LoadAnswers(qid);
        }

        private void btnAddQuestion_Click(object sender, EventArgs e)
        {
            using (var dlg = new QuestionDialog())
            {
                if (dlg.ShowDialog() != DialogResult.OK) return;

                const string sql = @"
INSERT INTO PerfumeQuestions (QuestionText, SortOrder)
VALUES (@t, @s);";
                using (var conn = new SqlConnection(_conn))
                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@t", dlg.QuestionText);
                    cmd.Parameters.AddWithValue("@s", dlg.SortOrder);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                LoadQuestions();
            }
        }

        private void btnEditQuestion_Click(object sender, EventArgs e)
        {
            if (dgvQuestions.CurrentRow == null) return;

            var row = dgvQuestions.CurrentRow;
            int qid = Convert.ToInt32(row.Cells["QuestionID"].Value);
            string text = row.Cells["QuestionText"].Value?.ToString() ?? "";
            int sort = Convert.ToInt32(row.Cells["SortOrder"].Value);

            using (var dlg = new QuestionDialog
            {
                QuestionText = text,
                SortOrder = sort
            })
            {
                if (dlg.ShowDialog() != DialogResult.OK) return;

                const string sql = @"
UPDATE PerfumeQuestions
SET QuestionText = @t, SortOrder = @s
WHERE QuestionID = @id;";
                using (var conn = new SqlConnection(_conn))
                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@t", dlg.QuestionText);
                    cmd.Parameters.AddWithValue("@s", dlg.SortOrder);
                    cmd.Parameters.AddWithValue("@id", qid);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                LoadQuestions();
            }
        }

        private void btnDeleteQuestion_Click(object sender, EventArgs e)
        {
            if (dgvQuestions.CurrentRow == null) return;

            int qid = Convert.ToInt32(dgvQuestions.CurrentRow.Cells["QuestionID"].Value);
            if (MessageBox.Show("Biztosan törlöd a kérdést?", "Megerősítés",
                MessageBoxButtons.YesNo) != DialogResult.Yes) return;

            const string sql = @"
DELETE FROM PerfumeAnswers WHERE QuestionID = @id;
DELETE FROM PerfumeQuestions WHERE QuestionID = @id;";
            using (var conn = new SqlConnection(_conn))
            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@id", qid);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            LoadQuestions();
        }

        private void btnAddAnswer_Click(object sender, EventArgs e)
        {
            if (dgvQuestions.CurrentRow == null) return;
            int qid = Convert.ToInt32(dgvQuestions.CurrentRow.Cells["QuestionID"].Value);

            using (var dlg = new AnswerDialog { QuestionID = qid })
            {
                if (dlg.ShowDialog() != DialogResult.OK) return;

                const string sql = @"
INSERT INTO PerfumeAnswers (QuestionID, AnswerText, ValueCode, SortOrder)
VALUES (@qid, @t, @v, @s);";
                using (var conn = new SqlConnection(_conn))
                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@qid", qid);
                    cmd.Parameters.AddWithValue("@t", dlg.AnswerText);
                    cmd.Parameters.AddWithValue("@v", string.IsNullOrEmpty(dlg.ValueCode)
                        ? (object)DBNull.Value
                        : dlg.ValueCode);
                    cmd.Parameters.AddWithValue("@s", dlg.SortOrder);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                LoadAnswers(qid);
            }
        }

        private void btnEditAnswer_Click(object sender, EventArgs e)
        {
            if (dgvAnswers.CurrentRow == null) return;

            int qid = Convert.ToInt32(dgvQuestions.CurrentRow.Cells["QuestionID"].Value);
            var row = dgvAnswers.CurrentRow;
            int aid = Convert.ToInt32(row.Cells["AnswerID"].Value);

            string text = row.Cells["AnswerText"].Value?.ToString() ?? "";
            string valCat = row.Cells["ValueCode"].Value?.ToString();
            int sort = Convert.ToInt32(row.Cells["SortOrder"].Value);

            using (var dlg = new AnswerDialog
            {
                QuestionID = qid,
                AnswerText = text,
                ValueCode = valCat,
                SortOrder = sort
            })
            {
                if (dlg.ShowDialog() != DialogResult.OK) return;

                const string sql = @"
UPDATE PerfumeAnswers
SET AnswerText = @t, ValueCode = @v, SortOrder = @s
WHERE AnswerID = @id;";
                using (var conn = new SqlConnection(_conn))
                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@t", dlg.AnswerText);
                    cmd.Parameters.AddWithValue("@v", string.IsNullOrEmpty(dlg.ValueCode)
                        ? (object)DBNull.Value
                        : dlg.ValueCode);
                    cmd.Parameters.AddWithValue("@s", dlg.SortOrder);
                    cmd.Parameters.AddWithValue("@id", aid);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                LoadAnswers(qid);
            }
        }

        private void btnDeleteAnswer_Click(object sender, EventArgs e)
        {
            if (dgvAnswers.CurrentRow == null) return;

            int qid = Convert.ToInt32(dgvQuestions.CurrentRow.Cells["QuestionID"].Value);
            int aid = Convert.ToInt32(dgvAnswers.CurrentRow.Cells["AnswerID"].Value);

            if (MessageBox.Show("Biztosan törlöd a választ?", "Megerősítés",
                MessageBoxButtons.YesNo) != DialogResult.Yes) return;

            using (var conn = new SqlConnection(_conn))
            using (var cmd = new SqlCommand(
                "DELETE FROM PerfumeAnswers WHERE AnswerID = @id;", conn))
            {
                cmd.Parameters.AddWithValue("@id", aid);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            LoadAnswers(qid);
        }

        private void btnShowResults_Click(object sender, EventArgs e)
        {
            const string sql = @"
WITH Detail AS
(
    SELECT
      q.SortOrder      AS QSort,
      q.QuestionID,
      q.QuestionText,
      a.SortOrder      AS ASort,
      a.AnswerID,
      a.AnswerText,
      a.ValueCode      AS AnswerValue,
      COUNT(ua.AnswerID) AS VoteCount
    FROM dbo.PerfumeQuestions q
    JOIN dbo.PerfumeAnswers a
      ON a.QuestionID = q.QuestionID
    LEFT JOIN dbo.PerfumeUserAnswer ua
      ON ua.QuestionID  = q.QuestionID
     AND ua.AnswerValue = a.ValueCode
    GROUP BY
      q.SortOrder,
      q.QuestionID,
      q.QuestionText,
      a.SortOrder,
      a.AnswerID,
      a.AnswerText,
      a.ValueCode
),
Summary AS
(
    SELECT
      NULL             AS QSort,
      NULL             AS QuestionID,
      'Összesen'       AS QuestionText,
      NULL             AS ASort,
      NULL             AS AnswerID,
      NULL             AS AnswerText,
      ua.AnswerValue,
      COUNT(*)         AS VoteCount
    FROM dbo.PerfumeUserAnswer ua
    GROUP BY ua.AnswerValue
)
SELECT
  QuestionID,
  QuestionText,
  AnswerID,
  AnswerText,
  AnswerValue,
  VoteCount
FROM
(
  SELECT * FROM Detail
  UNION ALL
  SELECT * FROM Summary
) AS AllStats
ORDER BY
  CASE WHEN QuestionID IS NULL THEN 1 ELSE 0 END,
  QSort,
  ASort,
  CASE WHEN QuestionID IS NULL THEN AnswerValue END;
";




            DataTable dt = new DataTable();
            using (var conn = new SqlConnection(_conn))
            using (var cmd = new SqlCommand(sql, conn))
            using (var da = new SqlDataAdapter(cmd))
            {
                da.Fill(dt);
            }

            // Eredmény megjelenítése egy új Formon vagy GridView-ben
            using (var dlg = new Form())
            {
                dlg.Text = "Összes eredmény";
                var grid = new DataGridView
                {
                    Dock = DockStyle.Fill,
                    DataSource = dt,
                    ReadOnly = true,
                    AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                };
                dlg.Controls.Add(grid);
                dlg.StartPosition = FormStartPosition.CenterParent;
                dlg.Size = new Size(700, 400);
                dlg.ShowDialog(this);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvAnswers.EnableHeadersVisualStyles = false;
            dgvQuestions.EnableHeadersVisualStyles = false;
        }
    }
}
