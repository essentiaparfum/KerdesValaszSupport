using System;
using System.Windows.Forms;

namespace KerdesValaszSupport
{
    public partial class QuestionDialog : Form
    {
        private string _questionText;
        private int _sortOrder;

        public string QuestionText
        {
            get => _questionText;
            set
            {
                _questionText = value;
                if (txtQuestion != null)
                    txtQuestion.Text = value ?? string.Empty;
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

        public QuestionDialog()
        {
            InitializeComponent();
            // A property setterek már előre beállították a mezőket
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // Mentjük vissza a bevitt értékeket
            QuestionText = txtQuestion.Text.Trim();
            SortOrder = (int)numSort.Value;
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
