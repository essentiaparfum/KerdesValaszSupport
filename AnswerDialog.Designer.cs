namespace KerdesValaszSupport
{
    partial class AnswerDialog
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.TextBox txtValueCode;
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
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.txtValueCode = new System.Windows.Forms.TextBox();
            this.numSort = new System.Windows.Forms.NumericUpDown();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numSort)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAnswer
            // 
            this.txtAnswer.Location = new System.Drawing.Point(12, 12);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(360, 23);
            this.txtAnswer.TabIndex = 0;
            // 
            // txtValueCode
            // 
            this.txtValueCode.Location = new System.Drawing.Point(12, 50);
            this.txtValueCode.Name = "txtValueCode";
            this.txtValueCode.Size = new System.Drawing.Size(200, 23);
            this.txtValueCode.TabIndex = 1;
            // 
            // numSort
            // 
            this.numSort.Location = new System.Drawing.Point(12, 88);
            this.numSort.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numSort.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            this.numSort.Name = "numSort";
            this.numSort.Size = new System.Drawing.Size(120, 23);
            this.numSort.TabIndex = 2;
            this.numSort.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(216, 126);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(297, 126);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Mégse";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AnswerDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.txtValueCode);
            this.Controls.Add(this.numSort);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AnswerDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Válasz szerkesztése";
            ((System.ComponentModel.ISupportInitialize)(this.numSort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}