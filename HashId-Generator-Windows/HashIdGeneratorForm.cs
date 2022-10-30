using System;
using System.Windows.Forms;
using HashidsNet;

namespace HashId_Generator_Windows
{
    public partial class HashIdGeneratorForm : Form
    {
        /// <summary>
        ///     Constructor
        /// </summary>
        public HashIdGeneratorForm()
        {
            InitializeComponent();
        }

        /// <summary>
        ///     Generate button click
        /// </summary>
        /// <param name="sender"><see cref="object"/></param>
        /// <param name="e"><see cref="EventArgs"/></param>
        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxSalt.Text) || tbxLength.Value <= 0 ||
                string.IsNullOrWhiteSpace(tbxAlphabet.Text)) return;

            var objHashids = new Hashids(tbxSalt.Text, (int)tbxLength.Value, tbxAlphabet.Text);

            tbxGenerateId32.Text = "";
            if (!string.IsNullOrWhiteSpace(tbxHashId32.Text))
            {
                // HashId to Id (int32)
                var succ = objHashids.TryDecodeSingle(tbxHashId32.Text, out var generateId32);

                if (succ)
                {
                    tbxGenerateId32.Text = $@"{generateId32}";
                }

            }

            // Id (int32) to HashId
            tbxGenerateHashId32.Text = "";
            if (!string.IsNullOrEmpty(tbxId32.Text) && tbxId32.Value >= 0)
            {
                tbxGenerateHashId32.Text = objHashids.Encode((int)tbxId32.Value);
            }

        }

        /// <summary>
        ///     When the form loads, set the saved values
        /// </summary>
        /// <param name="sender"><see cref="object"/></param>
        /// <param name="e"><see cref="EventArgs"/></param>
        private void HashIdGeneratorForm_Load(object sender, EventArgs e)
        {
            tbCtrHashId.SelectTab(Properties.Settings.Default.SelectedTab);

            // Load the inputs
            tbxSalt.Text = Properties.Settings.Default.Salt;
            tbxLength.Text = Properties.Settings.Default.Length;
            tbxAlphabet.Text = Properties.Settings.Default.Alphabet;

            tbxHashId32.Text = Properties.Settings.Default.HashId;
            tbxId32.Text = Properties.Settings.Default.Id;

            tbxGenerateHashId32.Text = Properties.Settings.Default.GenerateHashId;
            tbxGenerateId32.Text = Properties.Settings.Default.GenerateId;
        }

        /// <summary>
        ///     When the form close, save the values
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HashIdGeneratorForm_Closing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.SelectedTab = tbCtrHashId.SelectedTab.TabIndex;

            // Save the inputs
            Properties.Settings.Default.Salt = tbxSalt.Text;
            Properties.Settings.Default.Length = tbxLength.Text;
            Properties.Settings.Default.Alphabet = tbxAlphabet.Text;

            Properties.Settings.Default.HashId = tbxHashId32.Text;
            Properties.Settings.Default.Id = tbxId32.Text;

            Properties.Settings.Default.GenerateHashId = tbxGenerateHashId32.Text;
            Properties.Settings.Default.GenerateId = tbxGenerateId32.Text;

            Properties.Settings.Default.Save();
        }

        /// <summary>
        ///     Hyperlink to @hashids.net
        /// </summary>
        /// <param name="sender"><see cref="object"/></param>
        /// <param name="e"><see cref="LinkLabelLinkClickedEventArgs"/></param>
        private void LinkLblHashIdsNet_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/ullmark/hashids.net");
        }

        /// <summary>
        ///     Hyperlink to @technomic89
        /// </summary>
        /// <param name="sender"><see cref="object"/></param>
        /// <param name="e"><see cref="LinkLabelLinkClickedEventArgs"/></param>
        private void LinkLblTechnoMic89_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/technomic89");
        }
    }
}
