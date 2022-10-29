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
            this.lblError = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHashIdToId32 = new System.Windows.Forms.Label();
            this.lblId1 = new System.Windows.Forms.Label();
            this.lblHashId1 = new System.Windows.Forms.Label();
            this.tbxHashId32 = new System.Windows.Forms.TextBox();
            this.tbxGenerateId32 = new System.Windows.Forms.TextBox();
            this.lblHashId2 = new System.Windows.Forms.Label();
            this.lblId2 = new System.Windows.Forms.Label();
            this.lblId32ToHashId = new System.Windows.Forms.Label();
            this.tbxGenerateHashId32 = new System.Windows.Forms.TextBox();
            this.tbxId32 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbxLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxId32)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(484, 602);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(127, 41);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // tbxSalt
            // 
            this.tbxSalt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSalt.Location = new System.Drawing.Point(114, 22);
            this.tbxSalt.MaxLength = 50;
            this.tbxSalt.Name = "tbxSalt";
            this.tbxSalt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbxSalt.Size = new System.Drawing.Size(473, 26);
            this.tbxSalt.TabIndex = 1;
            // 
            // lblSalt
            // 
            this.lblSalt.AutoSize = true;
            this.lblSalt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalt.Location = new System.Drawing.Point(18, 25);
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
            this.lblLength.Location = new System.Drawing.Point(18, 70);
            this.lblLength.Name = "lblLength";
            this.lblLength.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblLength.Size = new System.Drawing.Size(70, 20);
            this.lblLength.TabIndex = 3;
            this.lblLength.Text = "Length:";
            // 
            // tbxLength
            // 
            this.tbxLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxLength.Location = new System.Drawing.Point(114, 70);
            this.tbxLength.Name = "tbxLength";
            this.tbxLength.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbxLength.Size = new System.Drawing.Size(120, 26);
            this.tbxLength.TabIndex = 4;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.DarkRed;
            this.lblError.Location = new System.Drawing.Point(22, 573);
            this.lblError.MaximumSize = new System.Drawing.Size(500, 0);
            this.lblError.Name = "lblError";
            this.lblError.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblError.Size = new System.Drawing.Size(0, 20);
            this.lblError.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(22, 132);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(565, 3);
            this.label1.TabIndex = 6;
            // 
            // lblHashIdToId32
            // 
            this.lblHashIdToId32.AutoSize = true;
            this.lblHashIdToId32.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHashIdToId32.Location = new System.Drawing.Point(18, 174);
            this.lblHashIdToId32.Name = "lblHashIdToId32";
            this.lblHashIdToId32.Size = new System.Drawing.Size(185, 24);
            this.lblHashIdToId32.TabIndex = 7;
            this.lblHashIdToId32.Text = "HashId to Id (int32)";
            // 
            // lblId1
            // 
            this.lblId1.AutoSize = true;
            this.lblId1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId1.Location = new System.Drawing.Point(18, 270);
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
            this.lblHashId1.Location = new System.Drawing.Point(18, 225);
            this.lblHashId1.Name = "lblHashId1";
            this.lblHashId1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblHashId1.Size = new System.Drawing.Size(72, 20);
            this.lblHashId1.TabIndex = 9;
            this.lblHashId1.Text = "HashId:";
            // 
            // tbxHashId32
            // 
            this.tbxHashId32.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxHashId32.Location = new System.Drawing.Point(114, 222);
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
            this.tbxGenerateId32.Location = new System.Drawing.Point(114, 270);
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
            this.lblHashId2.Location = new System.Drawing.Point(22, 486);
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
            this.lblId2.Location = new System.Drawing.Point(22, 441);
            this.lblId2.Name = "lblId2";
            this.lblId2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblId2.Size = new System.Drawing.Size(30, 20);
            this.lblId2.TabIndex = 14;
            this.lblId2.Text = "Id:";
            // 
            // lblId32ToHashId
            // 
            this.lblId32ToHashId.AutoSize = true;
            this.lblId32ToHashId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId32ToHashId.Location = new System.Drawing.Point(22, 390);
            this.lblId32ToHashId.Name = "lblId32ToHashId";
            this.lblId32ToHashId.Size = new System.Drawing.Size(185, 24);
            this.lblId32ToHashId.TabIndex = 12;
            this.lblId32ToHashId.Text = "Id (int32) to HashId";
            // 
            // tbxGenerateHashId32
            // 
            this.tbxGenerateHashId32.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tbxGenerateHashId32.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxGenerateHashId32.Location = new System.Drawing.Point(118, 483);
            this.tbxGenerateHashId32.MaxLength = 100;
            this.tbxGenerateHashId32.Name = "tbxGenerateHashId32";
            this.tbxGenerateHashId32.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbxGenerateHashId32.Size = new System.Drawing.Size(348, 26);
            this.tbxGenerateHashId32.TabIndex = 16;
            // 
            // tbxId32
            // 
            this.tbxId32.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxId32.Location = new System.Drawing.Point(118, 438);
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
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(22, 341);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(565, 3);
            this.label2.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(18, 551);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(565, 3);
            this.label3.TabIndex = 19;
            // 
            // HashIdGeneratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(623, 655);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxId32);
            this.Controls.Add(this.tbxGenerateHashId32);
            this.Controls.Add(this.lblHashId2);
            this.Controls.Add(this.lblId2);
            this.Controls.Add(this.lblId32ToHashId);
            this.Controls.Add(this.tbxGenerateId32);
            this.Controls.Add(this.lblId1);
            this.Controls.Add(this.lblHashId1);
            this.Controls.Add(this.tbxHashId32);
            this.Controls.Add(this.lblHashIdToId32);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.tbxLength);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.lblSalt);
            this.Controls.Add(this.tbxSalt);
            this.Controls.Add(this.btnGenerate);
            this.Name = "HashIdGeneratorForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.Text = "HashId-Generator";
            this.Load += new System.EventHandler(this.HashIdGeneratorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbxLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxId32)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox tbxSalt;
        private System.Windows.Forms.Label lblSalt;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.NumericUpDown tbxLength;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHashIdToId32;
        private System.Windows.Forms.Label lblId1;
        private System.Windows.Forms.Label lblHashId1;
        private System.Windows.Forms.TextBox tbxHashId32;
        private System.Windows.Forms.TextBox tbxGenerateId32;
        private System.Windows.Forms.Label lblHashId2;
        private System.Windows.Forms.Label lblId2;
        private System.Windows.Forms.Label lblId32ToHashId;
        private System.Windows.Forms.TextBox tbxGenerateHashId32;
        private System.Windows.Forms.NumericUpDown tbxId32;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

