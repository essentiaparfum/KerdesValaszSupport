using System;
using System.Windows.Forms;

namespace KerdesValaszSupport
{
    public partial class AnswerDialog : Form
    {
        private string _answerText;
        private string _valueCode;
        private int _sortOrder;

        public int QuestionID { get; set; }

        public string AnswerText
        {
            get => _answerText;
            set
            {
                _answerText = value;
                if (txtAnswer != null)
                    txtAnswer.Text = value ?? string.Empty;
            }
        }

        public string ValueCode
        {
            get => _valueCode;
            set
            {
                _valueCode = value;
                if (txtValueCode != null)
                    txtValueCode.Text = value ?? string.Empty;
            }
        }

        public int SortOrder
        {
            get => _sortOrder;
            set
            {
                _sortOrder = value;
                if (numSort != null)
                {
                    if (_sortOrder < numSort.Minimum)
                        numSort.Value = numSort.Minimum;
                    else if (_sortOrder > numSort.Maximum)
                        numSort.Value = numSort.Maximum;
                    else
                        numSort.Value = _sortOrder;
                }
            }
        }

        public AnswerDialog()
        {
            InitializeComponent();
            // Logikai rész: a property setter már beállította a mezőket
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            AnswerText = txtAnswer.Text.Trim();
            ValueCode = txtValueCode.Text.Trim();
            SortOrder = (int)numSort.Value;
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}