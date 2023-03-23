namespace OS_projekt
{
    partial class CryptographyForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.EncryptGroupBox = new System.Windows.Forms.GroupBox();
            this.EncryptButton = new System.Windows.Forms.Button();
            this.ChooseFileToEncryptTextBox = new System.Windows.Forms.TextBox();
            this.AsymmetricRadio = new System.Windows.Forms.RadioButton();
            this.SymmetricRadio = new System.Windows.Forms.RadioButton();
            this.ChooseFileToEncryptButton = new System.Windows.Forms.Button();
            this.DecryptGroupBox = new System.Windows.Forms.GroupBox();
            this.SymmetricDecryptRadio = new System.Windows.Forms.RadioButton();
            this.AsymmetricDecryptRadio = new System.Windows.Forms.RadioButton();
            this.DecryptButton = new System.Windows.Forms.Button();
            this.ChooseFileToDecryptTextBox = new System.Windows.Forms.TextBox();
            this.ChooseFileToDecryptButton = new System.Windows.Forms.Button();
            this.VerifySigningGroupBox = new System.Windows.Forms.GroupBox();
            this.ChooseSignatureFileButton = new System.Windows.Forms.Button();
            this.ChooseSignatureFileTextBox = new System.Windows.Forms.TextBox();
            this.ChooseFileToVerifyButton = new System.Windows.Forms.Button();
            this.ChooseFileToVerifyTextBox = new System.Windows.Forms.TextBox();
            this.VerifySignatureButton = new System.Windows.Forms.Button();
            this.CalculateMessageDigestGroupBox = new System.Windows.Forms.GroupBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog3 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog4 = new System.Windows.Forms.OpenFileDialog();
            this.MessageDigestTextBox = new System.Windows.Forms.RichTextBox();
            this.EncryptGroupBox.SuspendLayout();
            this.DecryptGroupBox.SuspendLayout();
            this.VerifySigningGroupBox.SuspendLayout();
            this.CalculateMessageDigestGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // EncryptGroupBox
            // 
            this.EncryptGroupBox.Controls.Add(this.EncryptButton);
            this.EncryptGroupBox.Controls.Add(this.ChooseFileToEncryptTextBox);
            this.EncryptGroupBox.Controls.Add(this.AsymmetricRadio);
            this.EncryptGroupBox.Controls.Add(this.SymmetricRadio);
            this.EncryptGroupBox.Controls.Add(this.ChooseFileToEncryptButton);
            this.EncryptGroupBox.Location = new System.Drawing.Point(12, 12);
            this.EncryptGroupBox.Name = "EncryptGroupBox";
            this.EncryptGroupBox.Size = new System.Drawing.Size(376, 222);
            this.EncryptGroupBox.TabIndex = 8;
            this.EncryptGroupBox.TabStop = false;
            this.EncryptGroupBox.Text = "Encrypt";
            // 
            // EncryptButton
            // 
            this.EncryptButton.Location = new System.Drawing.Point(239, 175);
            this.EncryptButton.Name = "EncryptButton";
            this.EncryptButton.Size = new System.Drawing.Size(131, 41);
            this.EncryptButton.TabIndex = 4;
            this.EncryptButton.Text = "Encrypt and sign";
            this.EncryptButton.UseVisualStyleBackColor = true;
            this.EncryptButton.Click += new System.EventHandler(this.EncryptButton_Click);
            // 
            // ChooseFileToEncryptTextBox
            // 
            this.ChooseFileToEncryptTextBox.Location = new System.Drawing.Point(6, 26);
            this.ChooseFileToEncryptTextBox.Name = "ChooseFileToEncryptTextBox";
            this.ChooseFileToEncryptTextBox.ReadOnly = true;
            this.ChooseFileToEncryptTextBox.Size = new System.Drawing.Size(314, 27);
            this.ChooseFileToEncryptTextBox.TabIndex = 2;
            this.ChooseFileToEncryptTextBox.Text = "Choose file to encrypt...";
            // 
            // AsymmetricRadio
            // 
            this.AsymmetricRadio.AutoSize = true;
            this.AsymmetricRadio.Location = new System.Drawing.Point(52, 73);
            this.AsymmetricRadio.Name = "AsymmetricRadio";
            this.AsymmetricRadio.Size = new System.Drawing.Size(108, 24);
            this.AsymmetricRadio.TabIndex = 0;
            this.AsymmetricRadio.TabStop = true;
            this.AsymmetricRadio.Text = "Asymmetric";
            this.AsymmetricRadio.UseVisualStyleBackColor = true;
            // 
            // SymmetricRadio
            // 
            this.SymmetricRadio.AutoSize = true;
            this.SymmetricRadio.Location = new System.Drawing.Point(52, 103);
            this.SymmetricRadio.Name = "SymmetricRadio";
            this.SymmetricRadio.Size = new System.Drawing.Size(100, 24);
            this.SymmetricRadio.TabIndex = 1;
            this.SymmetricRadio.TabStop = true;
            this.SymmetricRadio.Text = "Symmetric";
            this.SymmetricRadio.UseVisualStyleBackColor = true;
            // 
            // ChooseFileToEncryptButton
            // 
            this.ChooseFileToEncryptButton.Location = new System.Drawing.Point(326, 26);
            this.ChooseFileToEncryptButton.Name = "ChooseFileToEncryptButton";
            this.ChooseFileToEncryptButton.Size = new System.Drawing.Size(44, 29);
            this.ChooseFileToEncryptButton.TabIndex = 3;
            this.ChooseFileToEncryptButton.Text = "...";
            this.ChooseFileToEncryptButton.UseVisualStyleBackColor = true;
            this.ChooseFileToEncryptButton.Click += new System.EventHandler(this.ChooseFileToEncryptButton_Click);
            // 
            // DecryptGroupBox
            // 
            this.DecryptGroupBox.Controls.Add(this.SymmetricDecryptRadio);
            this.DecryptGroupBox.Controls.Add(this.AsymmetricDecryptRadio);
            this.DecryptGroupBox.Controls.Add(this.DecryptButton);
            this.DecryptGroupBox.Controls.Add(this.ChooseFileToDecryptTextBox);
            this.DecryptGroupBox.Controls.Add(this.ChooseFileToDecryptButton);
            this.DecryptGroupBox.Location = new System.Drawing.Point(412, 21);
            this.DecryptGroupBox.Name = "DecryptGroupBox";
            this.DecryptGroupBox.Size = new System.Drawing.Size(376, 213);
            this.DecryptGroupBox.TabIndex = 9;
            this.DecryptGroupBox.TabStop = false;
            this.DecryptGroupBox.Text = "Decrypt";
            // 
            // SymmetricDecryptRadio
            // 
            this.SymmetricDecryptRadio.AutoSize = true;
            this.SymmetricDecryptRadio.Location = new System.Drawing.Point(51, 94);
            this.SymmetricDecryptRadio.Name = "SymmetricDecryptRadio";
            this.SymmetricDecryptRadio.Size = new System.Drawing.Size(100, 24);
            this.SymmetricDecryptRadio.TabIndex = 5;
            this.SymmetricDecryptRadio.TabStop = true;
            this.SymmetricDecryptRadio.Text = "Symmetric";
            this.SymmetricDecryptRadio.UseVisualStyleBackColor = true;
            // 
            // AsymmetricDecryptRadio
            // 
            this.AsymmetricDecryptRadio.AutoSize = true;
            this.AsymmetricDecryptRadio.Location = new System.Drawing.Point(51, 64);
            this.AsymmetricDecryptRadio.Name = "AsymmetricDecryptRadio";
            this.AsymmetricDecryptRadio.Size = new System.Drawing.Size(108, 24);
            this.AsymmetricDecryptRadio.TabIndex = 5;
            this.AsymmetricDecryptRadio.TabStop = true;
            this.AsymmetricDecryptRadio.Text = "Asymmetric";
            this.AsymmetricDecryptRadio.UseVisualStyleBackColor = true;
            // 
            // DecryptButton
            // 
            this.DecryptButton.Location = new System.Drawing.Point(245, 166);
            this.DecryptButton.Name = "DecryptButton";
            this.DecryptButton.Size = new System.Drawing.Size(131, 41);
            this.DecryptButton.TabIndex = 5;
            this.DecryptButton.Text = "Decrypt";
            this.DecryptButton.UseVisualStyleBackColor = true;
            this.DecryptButton.Click += new System.EventHandler(this.DecryptButton_Click);
            // 
            // ChooseFileToDecryptTextBox
            // 
            this.ChooseFileToDecryptTextBox.Location = new System.Drawing.Point(6, 19);
            this.ChooseFileToDecryptTextBox.Name = "ChooseFileToDecryptTextBox";
            this.ChooseFileToDecryptTextBox.ReadOnly = true;
            this.ChooseFileToDecryptTextBox.Size = new System.Drawing.Size(318, 27);
            this.ChooseFileToDecryptTextBox.TabIndex = 2;
            this.ChooseFileToDecryptTextBox.Text = "Choose file to decrypt...";
            // 
            // ChooseFileToDecryptButton
            // 
            this.ChooseFileToDecryptButton.Location = new System.Drawing.Point(330, 17);
            this.ChooseFileToDecryptButton.Name = "ChooseFileToDecryptButton";
            this.ChooseFileToDecryptButton.Size = new System.Drawing.Size(44, 29);
            this.ChooseFileToDecryptButton.TabIndex = 3;
            this.ChooseFileToDecryptButton.Text = "...";
            this.ChooseFileToDecryptButton.UseVisualStyleBackColor = true;
            this.ChooseFileToDecryptButton.Click += new System.EventHandler(this.ChooseFileToDecryptButton_Click);
            // 
            // VerifySigningGroupBox
            // 
            this.VerifySigningGroupBox.Controls.Add(this.ChooseSignatureFileButton);
            this.VerifySigningGroupBox.Controls.Add(this.ChooseSignatureFileTextBox);
            this.VerifySigningGroupBox.Controls.Add(this.ChooseFileToVerifyButton);
            this.VerifySigningGroupBox.Controls.Add(this.ChooseFileToVerifyTextBox);
            this.VerifySigningGroupBox.Controls.Add(this.VerifySignatureButton);
            this.VerifySigningGroupBox.Location = new System.Drawing.Point(12, 240);
            this.VerifySigningGroupBox.Name = "VerifySigningGroupBox";
            this.VerifySigningGroupBox.Size = new System.Drawing.Size(376, 198);
            this.VerifySigningGroupBox.TabIndex = 10;
            this.VerifySigningGroupBox.TabStop = false;
            this.VerifySigningGroupBox.Text = "Verify";
            // 
            // ChooseSignatureFileButton
            // 
            this.ChooseSignatureFileButton.Location = new System.Drawing.Point(320, 59);
            this.ChooseSignatureFileButton.Name = "ChooseSignatureFileButton";
            this.ChooseSignatureFileButton.Size = new System.Drawing.Size(44, 29);
            this.ChooseSignatureFileButton.TabIndex = 8;
            this.ChooseSignatureFileButton.Text = "...";
            this.ChooseSignatureFileButton.UseVisualStyleBackColor = true;
            this.ChooseSignatureFileButton.Click += new System.EventHandler(this.ChooseSignatureFileButton_Click);
            // 
            // ChooseSignatureFileTextBox
            // 
            this.ChooseSignatureFileTextBox.Location = new System.Drawing.Point(0, 59);
            this.ChooseSignatureFileTextBox.Name = "ChooseSignatureFileTextBox";
            this.ChooseSignatureFileTextBox.ReadOnly = true;
            this.ChooseSignatureFileTextBox.Size = new System.Drawing.Size(314, 27);
            this.ChooseSignatureFileTextBox.TabIndex = 7;
            this.ChooseSignatureFileTextBox.Text = "Choose signature file...";
            // 
            // ChooseFileToVerifyButton
            // 
            this.ChooseFileToVerifyButton.Location = new System.Drawing.Point(320, 26);
            this.ChooseFileToVerifyButton.Name = "ChooseFileToVerifyButton";
            this.ChooseFileToVerifyButton.Size = new System.Drawing.Size(44, 29);
            this.ChooseFileToVerifyButton.TabIndex = 5;
            this.ChooseFileToVerifyButton.Text = "...";
            this.ChooseFileToVerifyButton.UseVisualStyleBackColor = true;
            this.ChooseFileToVerifyButton.Click += new System.EventHandler(this.ChooseFileToVerifyButton_Click);
            // 
            // ChooseFileToVerifyTextBox
            // 
            this.ChooseFileToVerifyTextBox.Location = new System.Drawing.Point(0, 26);
            this.ChooseFileToVerifyTextBox.Name = "ChooseFileToVerifyTextBox";
            this.ChooseFileToVerifyTextBox.ReadOnly = true;
            this.ChooseFileToVerifyTextBox.Size = new System.Drawing.Size(314, 27);
            this.ChooseFileToVerifyTextBox.TabIndex = 5;
            this.ChooseFileToVerifyTextBox.Text = "Choose file to verify...";
            // 
            // VerifySignatureButton
            // 
            this.VerifySignatureButton.Location = new System.Drawing.Point(239, 151);
            this.VerifySignatureButton.Name = "VerifySignatureButton";
            this.VerifySignatureButton.Size = new System.Drawing.Size(131, 41);
            this.VerifySignatureButton.TabIndex = 6;
            this.VerifySignatureButton.Text = "Verify signature";
            this.VerifySignatureButton.UseVisualStyleBackColor = true;
            this.VerifySignatureButton.Click += new System.EventHandler(this.VerifySignatureButton_Click);
            // 
            // CalculateMessageDigestGroupBox
            // 
            this.CalculateMessageDigestGroupBox.Controls.Add(this.MessageDigestTextBox);
            this.CalculateMessageDigestGroupBox.Location = new System.Drawing.Point(412, 240);
            this.CalculateMessageDigestGroupBox.Name = "CalculateMessageDigestGroupBox";
            this.CalculateMessageDigestGroupBox.Size = new System.Drawing.Size(376, 198);
            this.CalculateMessageDigestGroupBox.TabIndex = 11;
            this.CalculateMessageDigestGroupBox.TabStop = false;
            this.CalculateMessageDigestGroupBox.Text = "Calculated message digest";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // openFileDialog3
            // 
            this.openFileDialog3.FileName = "openFileDialog3";
            // 
            // openFileDialog4
            // 
            this.openFileDialog4.FileName = "openFileDialog4";
            // 
            // MessageDigestTextBox
            // 
            this.MessageDigestTextBox.Location = new System.Drawing.Point(6, 27);
            this.MessageDigestTextBox.Name = "MessageDigestTextBox";
            this.MessageDigestTextBox.Size = new System.Drawing.Size(364, 155);
            this.MessageDigestTextBox.TabIndex = 0;
            this.MessageDigestTextBox.Text = "";
            // 
            // CryptographyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CalculateMessageDigestGroupBox);
            this.Controls.Add(this.VerifySigningGroupBox);
            this.Controls.Add(this.DecryptGroupBox);
            this.Controls.Add(this.EncryptGroupBox);
            this.Name = "CryptographyForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.CryptographyForm_Load);
            this.EncryptGroupBox.ResumeLayout(false);
            this.EncryptGroupBox.PerformLayout();
            this.DecryptGroupBox.ResumeLayout(false);
            this.DecryptGroupBox.PerformLayout();
            this.VerifySigningGroupBox.ResumeLayout(false);
            this.VerifySigningGroupBox.PerformLayout();
            this.CalculateMessageDigestGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private RadioButton AsymmetricRadio;
        private RadioButton SymmetricRadio;
        private TextBox ChooseFileToEncryptTextBox;
        private Button ChooseFileToEncryptButton;
        private GroupBox EncryptGroupBox;
        private GroupBox DecryptGroupBox;
        private TextBox ChooseFileToDecryptTextBox;
        private Button ChooseFileToDecryptButton;
        private Button EncryptButton;
        private Button DecryptButton;
        private GroupBox VerifySigningGroupBox;
        private GroupBox CalculateMessageDigestGroupBox;
        private OpenFileDialog openFileDialog1;
        private OpenFileDialog openFileDialog2;
        private RadioButton SymmetricDecryptRadio;
        private RadioButton AsymmetricDecryptRadio;
        private Button ChooseFileToVerifyButton;
        private TextBox ChooseFileToVerifyTextBox;
        private Button VerifySignatureButton;
        private OpenFileDialog openFileDialog3;
        private Button ChooseSignatureFileButton;
        private TextBox ChooseSignatureFileTextBox;
        private OpenFileDialog openFileDialog4;
        private RichTextBox MessageDigestTextBox;
    }
}