using System;
using System.Windows.Forms;
using HashidsNet;

namespace HashId_Generator_Windows
{
    public partial class HashIdGeneratorForm : Form
    {

        public HashIdGeneratorForm()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            lblError.Text = "";

            if (string.IsNullOrEmpty(tbxSalt.Text))
            {
                lblError.Text += @"The Salt cannot be empty!";
            }


            if (string.IsNullOrEmpty(tbxLength.Text) || tbxLength.Text == @"0")
            {
                lblError.Text += @"
The Length must not be less than or equal to 0!";
            }

            if (!string.IsNullOrEmpty(tbxSalt.Text) && tbxLength.Value > 0)
            {
                var objHashids = new Hashids(tbxSalt.Text, (int)tbxLength.Value);

                if (!string.IsNullOrEmpty(tbxHashId32.Text))
                {

                    // HashId to Id (int32)
                    var succ = objHashids.TryDecodeSingle(tbxHashId32.Text, out var generateId32);
                    if (!succ)
                    {
                        lblError.Text += @"
The hash could not be decoded to Id.";
                    }

                    tbxGenerateId32.Text = $@"{generateId32}";
                }

                // Id (int32) to HashId
                if (!string.IsNullOrEmpty(tbxId32.Text) || tbxId32.Value >= 0)
                {
                    tbxGenerateHashId32.Text = objHashids.Encode((int)tbxId32.Value);
                }

            }

            // Save the inputs
            Properties.Settings.Default.Salt = tbxSalt.Text;
            Properties.Settings.Default.Length = tbxLength.Text;
            Properties.Settings.Default.HashId = tbxHashId32.Text;
            Properties.Settings.Default.Id = tbxId32.Text;

            Properties.Settings.Default.Save();
        }

        private void HashIdGeneratorForm_Load(object sender, EventArgs e)
        {
            tbxSalt.Text = Properties.Settings.Default.Salt;
            tbxLength.Text = Properties.Settings.Default.Length;
            tbxHashId32.Text = Properties.Settings.Default.HashId;
            tbxId32.Text = Properties.Settings.Default.Id;
        }
    }
}
