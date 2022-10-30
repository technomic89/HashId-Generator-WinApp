using System.Windows.Forms;

namespace HashId_Generator_Windows
{
    partial class HashIdGeneratorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGenerate = new System.Windows.Forms.Button();
            this.tbxSalt = new System.Windows.Forms.TextBox();
            this.lblSalt = new System.Windows.Forms.Label();
            this.lblLength = new System.Windows.Forms.Label();
            this.tbxLength = new System.Windows.Forms.NumericUpDown();
            this.lblId1 = new System.Windows.Forms.Label();
            this.lblHashId1 = new System.Windows.Forms.Label();
            this.tbxHashId32 = new System.Windows.Forms.TextBox();
            this.tbxGenerateId32 = new System.Windows.Forms.TextBox();
            this.lblHashId2 = new System.Windows.Forms.Label();
            this.lblId2 = new System.Windows.Forms.Label();
            this.tbxGenerateHashId32 = new System.Windows.Forms.TextBox();
            this.tbxId32 = new System.Windows.Forms.NumericUpDown();
            this.linkLblHashIdsNet = new System.Windows.Forms.LinkLabel();
            this.linkLblTechnoMic89 = new System.Windows.Forms.LinkLabel();
            this.tbCtrHashId = new System.Windows.Forms.TabControl();
            this.tbPageHashToId = new System.Windows.Forms.TabPage();
            this.tbPageIdToHash = new System.Windows.Forms.TabPage();
            this.tbPageSettings = new System.Windows.Forms.TabPage();
            this.tbxAlphabet = new System.Windows.Forms.TextBox();
            this.lblAlpabet = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbxLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxId32)).BeginInit();
            this.tbCtrHashId.SuspendLayout();
            this.tbPageHashToId.SuspendLayout();
            this.tbPageIdToHash.SuspendLayout();
            this.tbPageSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(353, 203);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(109, 30);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);
            // 
            // tbxSalt
            // 
            this.tbxSalt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSalt.Location = new System.Drawing.Point(109, 18);
            this.tbxSalt.MaxLength = 50;
            this.tbxSalt.Name = "tbxSalt";
            this.tbxSalt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbxSalt.Size = new System.Drawing.Size(348, 26);
            this.tbxSalt.TabIndex = 1;
            // 
            // lblSalt
            // 
            this.lblSalt.AutoSize = true;
            this.lblSalt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalt.Location = new System.Drawing.Point(13, 22);
            this.lblSalt.Name = "lblSalt";
            this.lblSalt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblSalt.Size = new System.Drawing.Size(46, 20);
            this.lblSalt.TabIndex = 2;
            this.lblSalt.Text = "Salt:";
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLength.Location = new System.Drawing.Point(13, 65);
            this.lblLength.Name = "lblLength";
            this.lblLength.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblLength.Size = new System.Drawing.Size(70, 20);
            this.lblLength.TabIndex = 3;
            this.lblLength.Text = "Length:";
            // 
            // tbxLength
            // 
            this.tbxLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxLength.Location = new System.Drawing.Point(109, 61);
            this.tbxLength.Name = "tbxLength";
            this.tbxLength.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbxLength.Size = new System.Drawing.Size(120, 26);
            this.tbxLength.TabIndex = 4;
            // 
            // lblId1
            // 
            this.lblId1.AutoSize = true;
            this.lblId1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId1.Location = new System.Drawing.Point(13, 65);
            this.lblId1.Name = "lblId1";
            this.lblId1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblId1.Size = new System.Drawing.Size(30, 20);
            this.lblId1.TabIndex = 10;
            this.lblId1.Text = "Id:";
            // 
            // lblHashId1
            // 
            this.lblHashId1.AutoSize = true;
            this.lblHashId1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHashId1.Location = new System.Drawing.Point(13, 22);
            this.lblHashId1.Name = "lblHashId1";
            this.lblHashId1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblHashId1.Size = new System.Drawing.Size(72, 20);
            this.lblHashId1.TabIndex = 9;
            this.lblHashId1.Text = "HashId:";
            // 
            // tbxHashId32
            // 
            this.tbxHashId32.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxHashId32.Location = new System.Drawing.Point(109, 18);
            this.tbxHashId32.MaxLength = 100;
            this.tbxHashId32.Name = "tbxHashId32";
            this.tbxHashId32.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbxHashId32.Size = new System.Drawing.Size(348, 26);
            this.tbxHashId32.TabIndex = 8;
            // 
            // tbxGenerateId32
            // 
            this.tbxGenerateId32.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tbxGenerateId32.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxGenerateId32.Location = new System.Drawing.Point(109, 61);
            this.tbxGenerateId32.MaxLength = 2147483647;
            this.tbxGenerateId32.Name = "tbxGenerateId32";
            this.tbxGenerateId32.ReadOnly = true;
            this.tbxGenerateId32.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbxGenerateId32.Size = new System.Drawing.Size(120, 26);
            this.tbxGenerateId32.TabIndex = 11;
            // 
            // lblHashId2
            // 
            this.lblHashId2.AutoSize = true;
            this.lblHashId2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHashId2.Location = new System.Drawing.Point(13, 65);
            this.lblHashId2.Name = "lblHashId2";
            this.lblHashId2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblHashId2.Size = new System.Drawing.Size(72, 20);
            this.lblHashId2.TabIndex = 15;
            this.lblHashId2.Text = "HashId:";
            // 
            // lblId2
            // 
            this.lblId2.AutoSize = true;
            this.lblId2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId2.Location = new System.Drawing.Point(13, 22);
            this.lblId2.Name = "lblId2";
            this.lblId2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblId2.Size = new System.Drawing.Size(30, 20);
            this.lblId2.TabIndex = 14;
            this.lblId2.Text = "Id:";
            // 
            // tbxGenerateHashId32
            // 
            this.tbxGenerateHashId32.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tbxGenerateHashId32.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxGenerateHashId32.Location = new System.Drawing.Point(109, 61);
            this.tbxGenerateHashId32.MaxLength = 100;
            this.tbxGenerateHashId32.Name = "tbxGenerateHashId32";
            this.tbxGenerateHashId32.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbxGenerateHashId32.Size = new System.Drawing.Size(348, 26);
            this.tbxGenerateHashId32.TabIndex = 16;
            // 
            // tbxId32
            // 
            this.tbxId32.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxId32.Location = new System.Drawing.Point(109, 18);
            this.tbxId32.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.tbxId32.Name = "tbxId32";
            this.tbxId32.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbxId32.Size = new System.Drawing.Size(120, 26);
            this.tbxId32.TabIndex = 17;
            // 
            // linkLblHashIdsNet
            // 
            this.linkLblHashIdsNet.AutoSize = true;
            this.linkLblHashIdsNet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLblHashIdsNet.Location = new System.Drawing.Point(19, 188);
            this.linkLblHashIdsNet.Name = "linkLblHashIdsNet";
            this.linkLblHashIdsNet.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.linkLblHashIdsNet.Size = new System.Drawing.Size(95, 17);
            this.linkLblHashIdsNet.TabIndex = 20;
            this.linkLblHashIdsNet.TabStop = true;
            this.linkLblHashIdsNet.Text = "@hashids.net";
            this.linkLblHashIdsNet.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLblHashIdsNet_LinkClicked);
            // 
            // linkLblTechnoMic89
            // 
            this.linkLblTechnoMic89.AutoSize = true;
            this.linkLblTechnoMic89.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLblTechnoMic89.Location = new System.Drawing.Point(19, 216);
            this.linkLblTechnoMic89.Name = "linkLblTechnoMic89";
            this.linkLblTechnoMic89.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.linkLblTechnoMic89.Size = new System.Drawing.Size(102, 17);
            this.linkLblTechnoMic89.TabIndex = 21;
            this.linkLblTechnoMic89.TabStop = true;
            this.linkLblTechnoMic89.Text = "@technomic89";
            this.linkLblTechnoMic89.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLblTechnoMic89_LinkClicked);
            // 
            // tbCtrHashId
            // 
            this.tbCtrHashId.Controls.Add(this.tbPageIdToHash);
            this.tbCtrHashId.Controls.Add(this.tbPageHashToId);
            this.tbCtrHashId.Controls.Add(this.tbPageSettings);
            this.tbCtrHashId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCtrHashId.Location = new System.Drawing.Point(1, 2);
            this.tbCtrHashId.Name = "tbCtrHashId";
            this.tbCtrHashId.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbCtrHashId.SelectedIndex = 0;
            this.tbCtrHashId.Size = new System.Drawing.Size(482, 173);
            this.tbCtrHashId.TabIndex = 22;
            // 
            // tbPageHashToId
            // 
            this.tbPageHashToId.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.tbPageHashToId.Controls.Add(this.tbxHashId32);
            this.tbPageHashToId.Controls.Add(this.lblHashId1);
            this.tbPageHashToId.Controls.Add(this.lblId1);
            this.tbPageHashToId.Controls.Add(this.tbxGenerateId32);
            this.tbPageHashToId.Location = new System.Drawing.Point(4, 25);
            this.tbPageHashToId.Name = "tbPageHashToId";
            this.tbPageHashToId.Padding = new System.Windows.Forms.Padding(3);
            this.tbPageHashToId.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbPageHashToId.Size = new System.Drawing.Size(473, 144);
            this.tbPageHashToId.TabIndex = 0;
            this.tbPageHashToId.Text = "HashId to Id32";
            // 
            // tbPageIdToHash
            // 
            this.tbPageIdToHash.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.tbPageIdToHash.Controls.Add(this.tbxId32);
            this.tbPageIdToHash.Controls.Add(this.lblId2);
            this.tbPageIdToHash.Controls.Add(this.lblHashId2);
            this.tbPageIdToHash.Controls.Add(this.tbxGenerateHashId32);
            this.tbPageIdToHash.Location = new System.Drawing.Point(4, 25);
            this.tbPageIdToHash.Name = "tbPageIdToHash";
            this.tbPageIdToHash.Padding = new System.Windows.Forms.Padding(3);
            this.tbPageIdToHash.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbPageIdToHash.Size = new System.Drawing.Size(473, 144);
            this.tbPageIdToHash.TabIndex = 1;
            this.tbPageIdToHash.Text = "Id32 to HashId";
            // 
            // tbPageSettings
            // 
            this.tbPageSettings.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.tbPageSettings.Controls.Add(this.tbxAlphabet);
            this.tbPageSettings.Controls.Add(this.lblAlpabet);
            this.tbPageSettings.Controls.Add(this.tbxSalt);
            this.tbPageSettings.Controls.Add(this.lblSalt);
            this.tbPageSettings.Controls.Add(this.lblLength);
            this.tbPageSettings.Controls.Add(this.tbxLength);
            this.tbPageSettings.Location = new System.Drawing.Point(4, 25);
            this.tbPageSettings.Name = "tbPageSettings";
            this.tbPageSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tbPageSettings.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbPageSettings.Size = new System.Drawing.Size(474, 144);
            this.tbPageSettings.TabIndex = 2;
            this.tbPageSettings.Text = "Settings";
            // 
            // tbxAlphabet
            // 
            this.tbxAlphabet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAlphabet.Location = new System.Drawing.Point(109, 104);
            this.tbxAlphabet.MaxLength = 100;
            this.tbxAlphabet.Name = "tbxAlphabet";
            this.tbxAlphabet.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbxAlphabet.Size = new System.Drawing.Size(348, 26);
            this.tbxAlphabet.TabIndex = 6;
            // 
            // lblAlpabet
            // 
            this.lblAlpabet.AutoSize = true;
            this.lblAlpabet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlpabet.Location = new System.Drawing.Point(13, 108);
            this.lblAlpabet.Name = "lblAlpabet";
            this.lblAlpabet.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblAlpabet.Size = new System.Drawing.Size(86, 20);
            this.lblAlpabet.TabIndex = 5;
            this.lblAlpabet.Text = "Alphabet:";
            // 
            // HashIdGeneratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(484, 250);
            this.Controls.Add(this.tbCtrHashId);
            this.Controls.Add(this.linkLblTechnoMic89);
            this.Controls.Add(this.linkLblHashIdsNet);
            this.Controls.Add(this.btnGenerate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HashIdGeneratorForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.Text = "HashId-Generator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HashIdGeneratorForm_Closing);
            this.Load += new System.EventHandler(this.HashIdGeneratorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbxLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxId32)).EndInit();
            this.tbCtrHashId.ResumeLayout(false);
            this.tbPageHashToId.ResumeLayout(false);
            this.tbPageHashToId.PerformLayout();
            this.tbPageIdToHash.ResumeLayout(false);
            this.tbPageIdToHash.PerformLayout();
            this.tbPageSettings.ResumeLayout(false);
            this.tbPageSettings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox tbxSalt;
        private System.Windows.Forms.Label lblSalt;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.NumericUpDown tbxLength;
        private System.Windows.Forms.Label lblId1;
        private System.Windows.Forms.Label lblHashId1;
        private System.Windows.Forms.TextBox tbxHashId32;
        private System.Windows.Forms.TextBox tbxGenerateId32;
        private System.Windows.Forms.Label lblHashId2;
        private System.Windows.Forms.Label lblId2;
        private System.Windows.Forms.TextBox tbxGenerateHashId32;
        private System.Windows.Forms.NumericUpDown tbxId32;
        private System.Windows.Forms.LinkLabel linkLblHashIdsNet;
        private System.Windows.Forms.LinkLabel linkLblTechnoMic89;
        private System.Windows.Forms.TabControl tbCtrHashId;
        private System.Windows.Forms.TabPage tbPageHashToId;
        private System.Windows.Forms.TabPage tbPageIdToHash;
        private System.Windows.Forms.TabPage tbPageSettings;
        private System.Windows.Forms.Label lblAlpabet;
        private System.Windows.Forms.TextBox tbxAlphabet;
    }
}

