using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace KerdesValaszSupport
{
    public partial class Form1 : Form
    {
        private readonly string _conn = ConfigurationManager.ConnectionStrings["ProbaDb"].ConnectionString;
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
                "SELECT QuestionID, QuestionText, SortOrder FROM PerfumeQuestions ORDER BY SortOrder",
                conn))
            using (var da = new SqlDataAdapter(cmd))
            {
                _questionsTable = new DataTable();
                da.Fill(_questionsTable);
                dgvQuestions.DataSource = _questionsTable;
            }
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
        }
        // V�lasz szerkeszt�se
        private void btnEditAnswer_Click(object sender, EventArgs e)
        {
            if (dgvAnswers.CurrentRow == null) return;
            // Aktu�lis k�rd�s ID-ja
            int qid = Convert.ToInt32(dgvQuestions.CurrentRow.Cells["QuestionID"].Value);
            // V�lasz adatai a row-b�l
            var row = dgvAnswers.CurrentRow;
            int aid = Convert.ToInt32(row.Cells["AnswerID"].Value);
            string text = row.Cells["AnswerText"].Value.ToString();
            string valueCode = row.Cells["ValueCode"].Value as string;
            int sortOrder = Convert.ToInt32(row.Cells["SortOrder"].Value);

            using (var dlg = new AnswerDialog { QuestionID = qid, AnswerText = text, ValueCode = valueCode, SortOrder = sortOrder })
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    using (var conn = new SqlConnection(_conn))
                    using (var cmd = new SqlCommand(
                        "UPDATE PerfumeAnswers SET AnswerText=@t, ValueCode=@v, SortOrder=@s WHERE AnswerID=@id", conn))
                    {
                        cmd.Parameters.AddWithValue("@t", dlg.AnswerText);
                        cmd.Parameters.AddWithValue("@v", string.IsNullOrEmpty(dlg.ValueCode) ? (object)DBNull.Value : dlg.ValueCode);
                        cmd.Parameters.AddWithValue("@s", dlg.SortOrder);
                        cmd.Parameters.AddWithValue("@id", aid);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                    // �jrat�ltj�k az aktu�lis k�rd�shez tartoz� v�laszokat
                    LoadAnswers(qid);
                }
            }
        }

        // V�lasz t�rl�se
        private void btnDeleteAnswer_Click(object sender, EventArgs e)
        {
            if (dgvAnswers.CurrentRow == null) return;
            int qid = Convert.ToInt32(dgvQuestions.CurrentRow.Cells["QuestionID"].Value);
            int aid = Convert.ToInt32(dgvAnswers.CurrentRow.Cells["AnswerID"].Value);

            if (MessageBox.Show("Biztosan t�rl�d a v�laszt?", "Meger?s�t�s", MessageBoxButtons.YesNo)
                == DialogResult.Yes)
            {
                using (var conn = new SqlConnection(_conn))
                using (var cmd = new SqlCommand("DELETE FROM PerfumeAnswers WHERE AnswerID=@id", conn))
                {
                    cmd.Parameters.AddWithValue("@id", aid);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                LoadAnswers(qid);
            }
        }

        private void dgvQuestions_SelectionChanged(object sender, EventArgs e)
        {
            // Ha nincs kiv�lasztott sor, ne csin�ljunk semmit
            if (dgvQuestions.CurrentRow == null) return;

            // Olvassuk ki biztons�gosan a cella �rt�k�t
            object cellValue = dgvQuestions.CurrentRow.Cells["QuestionID"].Value;
            if (cellValue == null || cellValue == DBNull.Value)
            {
                // Ha nincs �rt�k vagy DBNull, nincs mit bet�lteni
                dgvAnswers.DataSource = null;
                return;
            }

            // Ha van �rt�k, konvert�ljuk int-re
            int qid = Convert.ToInt32(cellValue);

            // T�lts�k be a v�laszokat
            LoadAnswers(qid);
        }


        private void btnAddQuestion_Click(object sender, EventArgs e)
        {
            // Megnyitjuk a dial�gust
            using (var dlg = new QuestionDialog())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    // Csak az INSERT utas�t�st adjuk �t � semmilyen param�ter-deklar�ci�t ne tartalmazzon!
                    string sql = @"
INSERT INTO PerfumeQuestions
    (QuestionText, SortOrder)
VALUES
    (@t, @s);";

                    using (var conn = new SqlConnection(_conn))
                    using (var cmd = new SqlCommand(sql, conn))
                    {
                        // A param�tereket mindig a parancs l�trehoz�sa ut�n adjuk hozz�:
                        cmd.Parameters.AddWithValue("@t", dlg.QuestionText);
                        cmd.Parameters.AddWithValue("@s", dlg.SortOrder);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }

                    // Friss�tj�k a k�rd�sek list�j�t
                    LoadQuestions();
                }
            }
        }



        private void btnEditQuestion_Click(object sender, EventArgs e)
        {
            if (dgvQuestions.CurrentRow == null) return;
            var row = dgvQuestions.CurrentRow;
            int qid = Convert.ToInt32(row.Cells["QuestionID"].Value);
            string text = row.Cells["QuestionText"].Value.ToString();
            int sort = Convert.ToInt32(row.Cells["SortOrder"].Value);

            using (var dlg = new QuestionDialog { QuestionText = text, SortOrder = sort })
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    using (var conn = new SqlConnection(_conn))
                    using (var cmd = new SqlCommand(
                        "UPDATE PerfumeQuestions SET QuestionText=@t,SortOrder=@s WHERE QuestionID=@id",
                        conn))
                    {
                        cmd.Parameters.AddWithValue("@t", dlg.QuestionText);
                        cmd.Parameters.AddWithValue("@s", dlg.SortOrder);
                        cmd.Parameters.AddWithValue("@id", qid);
                        conn.Open(); cmd.ExecuteNonQuery();
                    }
                    LoadQuestions();
                }
            }
        }

        private void btnDeleteQuestion_Click(object sender, EventArgs e)
        {
            if (dgvQuestions.CurrentRow == null) return;
            int qid = Convert.ToInt32(dgvQuestions.CurrentRow.Cells["QuestionID"].Value);
            if (MessageBox.Show("Biztosan t�rl�d a k�rd�st?", "Meger?s�t�s", MessageBoxButtons.YesNo)
                == DialogResult.Yes)
            {
                using (var conn = new SqlConnection(_conn))
                using (var cmd = new SqlCommand(
                    "DELETE FROM PerfumeAnswers WHERE QuestionID=@id; DELETE FROM PerfumeQuestions WHERE QuestionID=@id",
                    conn))
                {
                    cmd.Parameters.AddWithValue("@id", qid);
                    conn.Open(); cmd.ExecuteNonQuery();
                }
                LoadQuestions();
            }
        }

        private void btnAddAnswer_Click(object sender, EventArgs e)
        {
            if (dgvQuestions.CurrentRow == null) return;
            int qid = Convert.ToInt32(dgvQuestions.CurrentRow.Cells["QuestionID"].Value);
            using (var dlg = new AnswerDialog { QuestionID = qid })
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    using (var conn = new SqlConnection(_conn))
                    using (var cmd = new SqlCommand(
                        "INSERT INTO PerfumeAnswers(QuestionID,AnswerText,ValueCode,SortOrder) VALUES(@qid,@t,@v,@s)",
                        conn))
                    {
                        cmd.Parameters.AddWithValue("@qid", dlg.QuestionID);
                        cmd.Parameters.AddWithValue("@t", dlg.AnswerText);
                        cmd.Parameters.AddWithValue("@v", string.IsNullOrEmpty(dlg.ValueCode) ? (object)DBNull.Value : dlg.ValueCode);
                        cmd.Parameters.AddWithValue("@s", dlg.SortOrder);
                        conn.Open(); cmd.ExecuteNonQuery();
                    }
                    LoadAnswers(qid);
                }
            }
        }

        // Implement�ld hasonl�an btnEditAnswer_Click �s btnDeleteAnswer_Click...
    }
}
