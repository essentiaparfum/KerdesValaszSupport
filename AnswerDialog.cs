using System;
using System.Windows.Forms;

namespace KerdesValaszSupport
{
    public partial class AnswerDialog : Form
    {
        public int QuestionID { get; set; }

        private string _answerText;
        private string _valueCode;
        private int _sortOrder;

        /// <summary>
        /// A válasz szövege
        /// </summary>
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

        /// <summary>
        /// A kiválasztott illatkategória kódja
        /// </summary>
        public string ValueCode
        {
            get => _valueCode;
            set => _valueCode = value;
        }

        /// <summary>
        /// A megjelenési sorrend száma
        /// </summary>
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

        // A legördülő lista elemei
        private static readonly string[] Categories = new[]
        {
            "Fás illatok",
            "Friss illatok",
            "Fűszeres illatok",
            "Púderes illatok",
            "Édes illatok",
            "Gyümölcsös illatok",
            "Orientális illatok",
            "Virágos illatok"
        };

        public AnswerDialog()
        {
            InitializeComponent();

            // Combobox feltöltése a kategóriákkal
            cmbCategory.Items.AddRange(Categories);

            // A korábban beállított válasz szöveg és sorrend
            txtAnswer.Text = _answerText ?? string.Empty;
            SortOrder = _sortOrder;    // ez már belül helyesen korlátozza numSort.Value-t

            // Ha volt korábbi ValueCode, akkor jelöljük ki
            if (!string.IsNullOrEmpty(_valueCode) && cmbCategory.Items.Contains(_valueCode))
                cmbCategory.SelectedItem = _valueCode;
            else
                cmbCategory.SelectedIndex = -1;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // 1) Szöveg mentése
            AnswerText = txtAnswer.Text.Trim();

            // 2) Kategória mentése
            if (cmbCategory.SelectedIndex >= 0)
                ValueCode = cmbCategory.SelectedItem.ToString();
            else
                ValueCode = null;

            // 3) Sorrend mentése
            SortOrder = (int)numSort.Value;

            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
