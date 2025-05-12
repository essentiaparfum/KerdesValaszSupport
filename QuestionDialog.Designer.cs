namespace KerdesValaszSupport
{
    partial class QuestionDialog
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.NumericUpDown numSort;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.numSort = new System.Windows.Forms.NumericUpDown();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numSort)).BeginInit();
            this.SuspendLayout();
            // 
            // txtQuestion
            // 
            this.txtQuestion.Location = new System.Drawing.Point(12, 12);
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(360, 23);
            this.txtQuestion.TabIndex = 0;
            // 
            // numSort
            // 
            this.numSort.Location = new System.Drawing.Point(12, 50);
            this.numSort.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numSort.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            this.numSort.Name = "numSort";
            this.numSort.Size = new System.Drawing.Size(120, 23);
            this.numSort.TabIndex = 1;
            this.numSort.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(216, 88);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(297, 88);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Mégse";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // QuestionDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 123);
            this.Controls.Add(this.txtQuestion);
            this.Controls.Add(this.numSort);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "QuestionDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kérdés szerkesztése";
            ((System.ComponentModel.ISupportInitialize)(this.numSort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
