namespace KerdesValaszSupport
{
    partial class AnswerDialog
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblSort;
        private System.Windows.Forms.NumericUpDown numSort;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            // lblAnswer
            this.lblAnswer = new System.Windows.Forms.Label();
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Location = new System.Drawing.Point(12, 15);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(88, 15);
            this.lblAnswer.Text = "Válasz szövege:";

            // txtAnswer
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.txtAnswer.Location = new System.Drawing.Point(12, 35);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(360, 23);

            // lblCategory
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(12, 70);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(84, 15);
            this.lblCategory.Text = "Illatkategória:";

            // cmbCategory
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(12, 90);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(360, 23);

            // lblSort
            this.lblSort = new System.Windows.Forms.Label();
            this.lblSort.AutoSize = true;
            this.lblSort.Location = new System.Drawing.Point(12, 130);
            this.lblSort.Name = "lblSort";
            this.lblSort.Size = new System.Drawing.Size(58, 15);
            this.lblSort.Text = "Sorrend:";

            // numSort
            this.numSort = new System.Windows.Forms.NumericUpDown();
            this.numSort.Location = new System.Drawing.Point(12, 150);
            this.numSort.Minimum = 1;
            this.numSort.Maximum = 100;
            this.numSort.Name = "numSort";
            this.numSort.Size = new System.Drawing.Size(120, 23);
            this.numSort.Value = 1;

            // btnOK
            this.btnOK = new System.Windows.Forms.Button();
            this.btnOK.Location = new System.Drawing.Point(216, 200);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 25);
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);

            // btnCancel
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCancel.Location = new System.Drawing.Point(297, 200);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 25);
            this.btnCancel.Text = "Mégse";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // AnswerDialog Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 241);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.lblSort);
            this.Controls.Add(this.numSort);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AnswerDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Válasz szerkesztése";
        }

        #endregion
    }
}
