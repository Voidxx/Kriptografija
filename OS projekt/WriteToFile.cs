using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OS_projekt
{
    public class WriteToFile
    {
        public static async Task WriteSecretKey(string text)
        {
            await File.WriteAllTextAsync("tajni_kljuc.txt", text);
        }
        public static async Task WritePublicKey(string text)
        {
            await File.WriteAllTextAsync("javni_kljuc.txt", text);
        }
        public static async Task WritePrivateKey(string text)
        {
            await File.WriteAllTextAsync("privatni_kljuc.txt", text);
        }

        public static async Task WriteDigitalSignature(string text)
        {
            await File.WriteAllTextAsync("digitalni_potpis.txt", text);
        }

        public static async Task WriteAssymetric(string text)
        {
            await File.WriteAllTextAsync("Encrypted_data_Asymmetric.txt", text);
        }

        public static async Task WriteSymmetric(string text)
        {
            await File.WriteAllTextAsync("Encrypted_data_Symmetric.txt", text);
        }
    }
}
