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

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvQuestions = new System.Windows.Forms.DataGridView();
            this.dgvAnswers = new System.Windows.Forms.DataGridView();
            this.btnAddQuestion = new System.Windows.Forms.Button();
            this.btnEditQuestion = new System.Windows.Forms.Button();
            this.btnDeleteQuestion = new System.Windows.Forms.Button();
            this.btnAddAnswer = new System.Windows.Forms.Button();
            this.btnEditAnswer = new System.Windows.Forms.Button();
            this.btnDeleteAnswer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuestions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnswers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvQuestions
            // 
            this.dgvQuestions.Location = new System.Drawing.Point(12, 12);
            this.dgvQuestions.Name = "dgvQuestions";
            this.dgvQuestions.Size = new System.Drawing.Size(400, 300);
            this.dgvQuestions.TabIndex = 0;
            this.dgvQuestions.ReadOnly = true;
            this.dgvQuestions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQuestions.MultiSelect = false;
            this.dgvQuestions.SelectionChanged += new System.EventHandler(this.dgvQuestions_SelectionChanged);
            // 
            // btnAddQuestion
            // 
            this.btnAddQuestion.Location = new System.Drawing.Point(12, 320);
            this.btnAddQuestion.Name = "btnAddQuestion";
            this.btnAddQuestion.Size = new System.Drawing.Size(75, 23);
            this.btnAddQuestion.Text = "Új kérdés";
            this.btnAddQuestion.UseVisualStyleBackColor = true;
            this.btnAddQuestion.Click += new System.EventHandler(this.btnAddQuestion_Click);
            // 
            // btnEditQuestion
            // 
            this.btnEditQuestion.Location = new System.Drawing.Point(93, 320);
            this.btnEditQuestion.Name = "btnEditQuestion";
            this.btnEditQuestion.Size = new System.Drawing.Size(75, 23);
            this.btnEditQuestion.Text = "Módosít";
            this.btnEditQuestion.UseVisualStyleBackColor = true;
            this.btnEditQuestion.Click += new System.EventHandler(this.btnEditQuestion_Click);
            // 
            // btnDeleteQuestion
            // 
            this.btnDeleteQuestion.Location = new System.Drawing.Point(174, 320);
            this.btnDeleteQuestion.Name = "btnDeleteQuestion";
            this.btnDeleteQuestion.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteQuestion.Text = "Töröl";
            this.btnDeleteQuestion.UseVisualStyleBackColor = true;
            this.btnDeleteQuestion.Click += new System.EventHandler(this.btnDeleteQuestion_Click);
            // 
            // dgvAnswers
            // 
            this.dgvAnswers.Location = new System.Drawing.Point(430, 12);
            this.dgvAnswers.Name = "dgvAnswers";
            this.dgvAnswers.Size = new System.Drawing.Size(400, 300);
            this.dgvAnswers.TabIndex = 1;
            this.dgvAnswers.ReadOnly = true;
            this.dgvAnswers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAnswers.MultiSelect = false;
            // 
            // btnAddAnswer
            // 
            this.btnAddAnswer.Location = new System.Drawing.Point(430, 320);
            this.btnAddAnswer.Name = "btnAddAnswer";
            this.btnAddAnswer.Size = new System.Drawing.Size(75, 23);
            this.btnAddAnswer.Text = "Új válasz";
            this.btnAddAnswer.UseVisualStyleBackColor = true;
            this.btnAddAnswer.Click += new System.EventHandler(this.btnAddAnswer_Click);
            // 
            // btnEditAnswer
            // 
            this.btnEditAnswer.Location = new System.Drawing.Point(511, 320);
            this.btnEditAnswer.Name = "btnEditAnswer";
            this.btnEditAnswer.Size = new System.Drawing.Size(75, 23);
            this.btnEditAnswer.Text = "Módosít";
            this.btnEditAnswer.UseVisualStyleBackColor = true;
            this.btnEditAnswer.Click += new System.EventHandler(this.btnEditAnswer_Click);
            // 
            // btnDeleteAnswer
            // 
            this.btnDeleteAnswer.Location = new System.Drawing.Point(592, 320);
            this.btnDeleteAnswer.Name = "btnDeleteAnswer";
            this.btnDeleteAnswer.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteAnswer.Text = "Töröl";
            this.btnDeleteAnswer.UseVisualStyleBackColor = true;
            this.btnDeleteAnswer.Click += new System.EventHandler(this.btnDeleteAnswer_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(844, 360);
            this.Controls.Add(this.dgvQuestions);
            this.Controls.Add(this.btnAddQuestion);
            this.Controls.Add(this.btnEditQuestion);
            this.Controls.Add(this.btnDeleteQuestion);
            this.Controls.Add(this.dgvAnswers);
            this.Controls.Add(this.btnAddAnswer);
            this.Controls.Add(this.btnEditAnswer);
            this.Controls.Add(this.btnDeleteAnswer);
            this.Name = "Form1";
            this.Text = "Kérdés–Válasz Szerkesztő";
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuestions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnswers)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
