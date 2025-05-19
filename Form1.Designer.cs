namespace KerdesValaszSupport
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvQuestions;
        private System.Windows.Forms.DataGridView dgvAnswers;
        private System.Windows.Forms.Button btnAddQuestion;
        private System.Windows.Forms.Button btnEditQuestion;
        private System.Windows.Forms.Button btnDeleteQuestion;
        private System.Windows.Forms.Button btnAddAnswer;
        private System.Windows.Forms.Button btnEditAnswer;
        private System.Windows.Forms.Button btnDeleteAnswer;
        private System.Windows.Forms.Button btnShowResults;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            dgvQuestions = new DataGridView();
            dgvAnswers = new DataGridView();
            btnAddQuestion = new Button();
            btnEditQuestion = new Button();
            btnDeleteQuestion = new Button();
            btnAddAnswer = new Button();
            btnEditAnswer = new Button();
            btnDeleteAnswer = new Button();
            btnShowResults = new Button();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvQuestions).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAnswers).BeginInit();
            SuspendLayout();
            // 
            // dgvQuestions
            // 
            dgvQuestions.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(211, 211, 253);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvQuestions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvQuestions.DefaultCellStyle = dataGridViewCellStyle2;
            dgvQuestions.GridColor = Color.Black;
            dgvQuestions.Location = new Point(13, 48);
            dgvQuestions.MultiSelect = false;
            dgvQuestions.Name = "dgvQuestions";
            dgvQuestions.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(211, 211, 253);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvQuestions.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvQuestions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvQuestions.Size = new Size(400, 300);
            dgvQuestions.TabIndex = 0;
            dgvQuestions.SelectionChanged += dgvQuestions_SelectionChanged;
            // 
            // dgvAnswers
            // 
            dgvAnswers.BackgroundColor = Color.White;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(211, 211, 253);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvAnswers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvAnswers.GridColor = Color.Black;
            dgvAnswers.Location = new Point(431, 48);
            dgvAnswers.MultiSelect = false;
            dgvAnswers.Name = "dgvAnswers";
            dgvAnswers.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(211, 211, 253);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvAnswers.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvAnswers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAnswers.Size = new Size(400, 300);
            dgvAnswers.TabIndex = 1;
            // 
            // btnAddQuestion
            // 
            btnAddQuestion.BackColor = Color.FromArgb(206, 71, 96);
            btnAddQuestion.ForeColor = SystemColors.ButtonHighlight;
            btnAddQuestion.Location = new Point(13, 356);
            btnAddQuestion.Name = "btnAddQuestion";
            btnAddQuestion.Size = new Size(75, 23);
            btnAddQuestion.TabIndex = 2;
            btnAddQuestion.Text = "Új kérdés";
            btnAddQuestion.UseVisualStyleBackColor = false;
            btnAddQuestion.Click += btnAddQuestion_Click;
            // 
            // btnEditQuestion
            // 
            btnEditQuestion.BackColor = Color.FromArgb(206, 71, 96);
            btnEditQuestion.ForeColor = SystemColors.ButtonHighlight;
            btnEditQuestion.Location = new Point(94, 356);
            btnEditQuestion.Name = "btnEditQuestion";
            btnEditQuestion.Size = new Size(75, 23);
            btnEditQuestion.TabIndex = 3;
            btnEditQuestion.Text = "Módosít";
            btnEditQuestion.UseVisualStyleBackColor = false;
            btnEditQuestion.Click += btnEditQuestion_Click;
            // 
            // btnDeleteQuestion
            // 
            btnDeleteQuestion.BackColor = Color.FromArgb(206, 71, 96);
            btnDeleteQuestion.ForeColor = SystemColors.ButtonHighlight;
            btnDeleteQuestion.Location = new Point(175, 356);
            btnDeleteQuestion.Name = "btnDeleteQuestion";
            btnDeleteQuestion.Size = new Size(75, 23);
            btnDeleteQuestion.TabIndex = 4;
            btnDeleteQuestion.Text = "Töröl";
            btnDeleteQuestion.UseVisualStyleBackColor = false;
            btnDeleteQuestion.Click += btnDeleteQuestion_Click;
            // 
            // btnAddAnswer
            // 
            btnAddAnswer.BackColor = Color.FromArgb(206, 71, 96);
            btnAddAnswer.ForeColor = SystemColors.ButtonHighlight;
            btnAddAnswer.Location = new Point(431, 356);
            btnAddAnswer.Name = "btnAddAnswer";
            btnAddAnswer.Size = new Size(75, 23);
            btnAddAnswer.TabIndex = 5;
            btnAddAnswer.Text = "Új válasz";
            btnAddAnswer.UseVisualStyleBackColor = false;
            btnAddAnswer.Click += btnAddAnswer_Click;
            // 
            // btnEditAnswer
            // 
            btnEditAnswer.BackColor = Color.FromArgb(206, 71, 96);
            btnEditAnswer.ForeColor = SystemColors.ButtonHighlight;
            btnEditAnswer.Location = new Point(512, 356);
            btnEditAnswer.Name = "btnEditAnswer";
            btnEditAnswer.Size = new Size(75, 23);
            btnEditAnswer.TabIndex = 6;
            btnEditAnswer.Text = "Módosít";
            btnEditAnswer.UseVisualStyleBackColor = false;
            btnEditAnswer.Click += btnEditAnswer_Click;
            // 
            // btnDeleteAnswer
            // 
            btnDeleteAnswer.BackColor = Color.FromArgb(206, 71, 96);
            btnDeleteAnswer.ForeColor = SystemColors.ButtonHighlight;
            btnDeleteAnswer.Location = new Point(593, 356);
            btnDeleteAnswer.Name = "btnDeleteAnswer";
            btnDeleteAnswer.Size = new Size(75, 23);
            btnDeleteAnswer.TabIndex = 7;
            btnDeleteAnswer.Text = "Töröl";
            btnDeleteAnswer.UseVisualStyleBackColor = false;
            btnDeleteAnswer.Click += btnDeleteAnswer_Click;
            // 
            // btnShowResults
            // 
            btnShowResults.BackColor = Color.FromArgb(206, 71, 96);
            btnShowResults.ForeColor = SystemColors.ButtonHighlight;
            btnShowResults.Location = new Point(323, 356);
            btnShowResults.Name = "btnShowResults";
            btnShowResults.Size = new Size(90, 23);
            btnShowResults.TabIndex = 8;
            btnShowResults.Text = "Eredmények";
            btnShowResults.UseVisualStyleBackColor = false;
            btnShowResults.Click += btnShowResults_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Control;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.ForeColor = SystemColors.InactiveCaptionText;
            textBox1.Location = new Point(288, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(299, 26);
            textBox1.TabIndex = 9;
            textBox1.Text = "ESSENTIA TESZT SZERKESZTŐ";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // Form1
            // 
            BackColor = SystemColors.Control;
            ClientSize = new Size(867, 398);
            Controls.Add(textBox1);
            Controls.Add(btnShowResults);
            Controls.Add(btnDeleteAnswer);
            Controls.Add(btnEditAnswer);
            Controls.Add(btnAddAnswer);
            Controls.Add(btnDeleteQuestion);
            Controls.Add(btnEditQuestion);
            Controls.Add(btnAddQuestion);
            Controls.Add(dgvAnswers);
            Controls.Add(dgvQuestions);
            Name = "Form1";
            Text = "Kérdés–Válasz Szerkesztő";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvQuestions).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAnswers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private TextBox textBox1;
    }
}
