using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Xml.Serialization;
using System.Xml;
using System.Buffers.Text;



namespace OS_projekt
{
    public partial class CryptographyForm : Form
    {
        SHA256 alg = SHA256.Create();
        RSACryptoServiceProvider csp = new RSACryptoServiceProvider();
        public CryptographyForm()
        {
            InitializeComponent();
        }

        private void ChooseFileToEncryptButton_Click(object sender, EventArgs e)
        {
            this.openFileDialog1 = new OpenFileDialog();
            openFileDialog1.ShowDialog();
            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;
            ChooseFileToEncryptTextBox.Text = openFileDialog1.FileName;
        }

        private void CryptographyForm_Load(object sender, EventArgs e)
        {

        }

        private async void EncryptButton_Click(object sender, EventArgs e)
        {
            
            if (SymmetricRadio.Checked == true)
            {
               Aes aes = Aes.Create();
                aes.GenerateIV();
                aes.GenerateKey();
                string SecretKey = Convert.ToBase64String(aes.Key);
                await WriteToFile.WriteSecretKey(SecretKey);

                try
                {
                    using (FileStream fileStream = new("Encrypted_data_Symmetric.txt", FileMode.OpenOrCreate))
                    {
                        using (aes)
                        {
                            byte[] iv = aes.IV;
                            fileStream.Write(iv, 0, iv.Length);

                            using (CryptoStream cryptoStream = new(
                                fileStream,
                                aes.CreateEncryptor(),
                                CryptoStreamMode.Write))
                            {
                                using (StreamWriter encryptWriter = new(cryptoStream))
                                {
                                    string text = File.ReadAllText(openFileDialog1.FileName);
                                    encryptWriter.WriteLine(text);
                                }
                            }
                        }
                    }
                    MessageBox.Show("The file was encrypted.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"The encryption failed. {ex}");
                }
            }
            else if (AsymmetricRadio.Checked == true)
            {
                RSA rsa = RSA.Create(); 
                string PrivateKey = Convert.ToBase64String(rsa.ExportRSAPrivateKey());
                string PublicKey = Convert.ToBase64String(rsa.ExportRSAPublicKey());
                await WriteToFile.WritePrivateKey(PrivateKey);
                await WriteToFile.WritePublicKey(PublicKey);


                try
                {
                    csp.ImportParameters(rsa.ExportParameters(true));
                    string plainText = File.ReadAllText(openFileDialog1.FileName);
                    var bytesPlainText = System.Text.Encoding.Unicode.GetBytes(plainText);
                    byte[] hashValue;
                    string hashValueString = "";
                    SHA256 shHash = SHA256.Create();
                    hashValue = shHash.ComputeHash(bytesPlainText);

                    foreach (byte b in hashValue)
                    {
                        hashValueString += b.ToString() + " ";
                    }
                    MessageDigestTextBox.Text = hashValueString;
                    byte[] sig = csp.SignData(bytesPlainText, CryptoConfig.MapNameToOID("SHA256"));
                    string sigBase64 = Convert.ToBase64String(sig);
                        await WriteToFile.WriteDigitalSignature(sigBase64);
                    var bytesCypherText = csp.Encrypt(bytesPlainText, false);
                    string bytesCypherTextBase64 = Convert.ToBase64String(bytesCypherText);
                        await WriteToFile.WriteAssymetric(bytesCypherTextBase64);
                    MessageBox.Show("The file was encrypted and signed.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"The encryption failed. {ex}");
                }
            }
        }

        private void ChooseFileToDecryptButton_Click(object sender, EventArgs e)
        {
            this.openFileDialog2 = new OpenFileDialog();
            openFileDialog2.ShowDialog();
            openFileDialog2.DefaultExt = "txt";
            openFileDialog2.CheckFileExists = true;
            openFileDialog2.CheckPathExists = true;
            ChooseFileToDecryptTextBox.Text = openFileDialog2.FileName;
        }

        private async void DecryptButton_Click(object sender, EventArgs e)
        {
            if (SymmetricDecryptRadio.Checked)
            {
                try
                {
                    using (FileStream fileStream = new(openFileDialog2.FileName, FileMode.Open))
                    {
                        using (Aes aes = Aes.Create())
                        {
                            byte[] iv = new byte[aes.IV.Length];
                            int numBytesToRead = aes.IV.Length;
                            int numBytesRead = 0;
                            while (numBytesToRead > 0)
                            {
                                int n = fileStream.Read(iv, numBytesRead, numBytesToRead);
                                if (n == 0) break;

                                numBytesRead += n;
                                numBytesToRead -= n;
                            }
                            string KeyString = File.ReadAllText("tajni_kljuc.txt");
                            byte[] key = Convert.FromBase64String(KeyString);


                            using (CryptoStream cryptoStream = new(
                               fileStream,
                               aes.CreateDecryptor(key, iv),
                               CryptoStreamMode.Read))
                            {
                                using (StreamReader decryptReader = new(cryptoStream))
                                {
                                    string decryptedMessage = await decryptReader.ReadToEndAsync();
                                    MessageBox.Show($"The decrypted original message: {decryptedMessage}");
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"The decryption failed. {ex}");
                }
            }
            else if(AsymmetricDecryptRadio.Checked) 
            {
                var csp = new RSACryptoServiceProvider();
                csp = new RSACryptoServiceProvider();
                string PrivateKeyBase64= File.ReadAllText("privatni_kljuc.txt");
                byte[] PrivateKey = Convert.FromBase64String(PrivateKeyBase64);
                csp.ImportRSAPrivateKey(PrivateKey, out _);
                try
                {
                    string base64CypherTextData = File.ReadAllText(openFileDialog2.FileName);
                    var bytesCypherTextData = Convert.FromBase64String(base64CypherTextData);
                    var bytesPlainTextData = csp.Decrypt(bytesCypherTextData, false);
                    var plainTextData = System.Text.Encoding.Unicode.GetString(bytesPlainTextData);
                    MessageBox.Show($"The decrypted original message: {plainTextData}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"The decryption failed. {ex}");
                }
            }
        }

        private void VerifySignature()
        {
            var csp = new RSACryptoServiceProvider();
            csp = new RSACryptoServiceProvider();
            string PrivateKeyBase64 = File.ReadAllText("privatni_kljuc.txt");
            byte[] PrivateKey = Convert.FromBase64String(PrivateKeyBase64);
            csp.ImportRSAPrivateKey(PrivateKey, out _);

            string SigBase64 = File.ReadAllText(this.openFileDialog4.FileName);
            byte[] sig = Convert.FromBase64String(SigBase64);
            string cypherTextDataBytesBase64 = File.ReadAllText(this.openFileDialog3.FileName);
            byte[] cypherTextDataBytes = Convert.FromBase64String(cypherTextDataBytesBase64);
            var bytesPlainTextData = csp.Decrypt(cypherTextDataBytes, false);
            var plainTextData = System.Text.Encoding.Unicode.GetString(bytesPlainTextData);
            RSACryptoServiceProvider key = csp;

            try
            {
                if (!key.VerifyData(bytesPlainTextData, CryptoConfig.MapNameToOID("SHA256"), sig))
                   throw new CryptographicException();
                MessageBox.Show("Verification successful.");
            }
            catch(CryptographicException ex)
            {
                MessageBox.Show($"Verification unsuccessful. {ex}");
            }
        }

        private void ChooseFileToVerifyButton_Click(object sender, EventArgs e)
        {
            this.openFileDialog3 = new OpenFileDialog();
            openFileDialog3.ShowDialog();
            openFileDialog3.DefaultExt = "txt";
            openFileDialog3.CheckFileExists = true;
            openFileDialog3.CheckPathExists = true;
            ChooseFileToVerifyTextBox.Text = openFileDialog3.FileName;
        }

        private void VerifySignatureButton_Click(object sender, EventArgs e)
        {
            VerifySignature();
        }

        private void ChooseSignatureFileButton_Click(object sender, EventArgs e)
        {
            this.openFileDialog4 = new OpenFileDialog();
            openFileDialog4.ShowDialog();
            openFileDialog4.DefaultExt = "txt";
            openFileDialog4.CheckFileExists = true;
            openFileDialog4.CheckPathExists = true;
            ChooseSignatureFileTextBox.Text = openFileDialog4.FileName;
        }

        public static String sha256_hash(string value)
        {
            StringBuilder Sb = new StringBuilder();

            using (var hash = SHA256.Create())
            {
                Encoding enc = Encoding.UTF8;
                byte[] result = hash.ComputeHash(enc.GetBytes(value));

                foreach (byte b in result)
                    Sb.Append(b.ToString("x2"));
            }

            return Sb.ToString();
        }
    }
}