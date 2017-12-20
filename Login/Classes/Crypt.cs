using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login.Classes
{
    class Crypt
    {
        private string MakePasswordGreatAgain(string password)
        {
            char[] great_password = new char[8];
            string to_return = "";
            if (password.Length != 8)
            {
                if (password.Length > 8)
                {
                    for (int i = 0; i < 8; i++)
                    {
                        great_password[i] = password[i];
                    }
                }
                else
                {
                    int i = 0;
                    while (i != 8)
                    {
                        for (int j = 0; j < password.Length; j++)
                        {
                            great_password[i] = password[j];
                            i++;
                        }
                    }
                }
            }

            for (int i = 0; i<great_password.Length; i++)
            {
                to_return += great_password[i];
            }
            return to_return;
        }
        
        
        ///<summary>
        /// Steve Lydford - 12/05/2008.
        ///
        /// Encrypts a file using Rijndael algorithm.
        ///</summary>
        ///<param name="inputFile"></param>
        ///<param name="outputFile"></param>
        public void EncryptFile(string inputFile, string outputFile, string pass)
        {

            //try
            {
                string password = MakePasswordGreatAgain(pass);
                UnicodeEncoding UE = new UnicodeEncoding();
                byte[] key = UE.GetBytes(password);

                string cryptFile = outputFile;
                FileStream fsCrypt = new FileStream(cryptFile, FileMode.Create);

                RijndaelManaged RMCrypto = new RijndaelManaged();

                CryptoStream cs = new CryptoStream(fsCrypt,
                    RMCrypto.CreateEncryptor(key, key),
                    CryptoStreamMode.Write);

                FileStream fsIn = new FileStream(inputFile, FileMode.Open);

                int data;
                while ((data = fsIn.ReadByte()) != -1)
                    cs.WriteByte((byte)data);


                fsIn.Close();
                cs.Close();
                fsCrypt.Close();
                //File.Delete(inputFile);
            }
            //catch
            //{
            //    MessageBox.Show("Encryption failed!", "Error");
            //}
        }
        ///<summary>
        /// Steve Lydford - 12/05/2008.
        ///
        /// Decrypts a file using Rijndael algorithm.
        ///</summary>
        ///<param name="inputFile"></param>
        ///<param name="outputFile"></param>
        public void DecryptFile(string outputFile, string inputFile, string pass)
        {

            {
                /*char[] passw = MakePasswordGreatAgain(pass);
                string password = passw; // Your Key Here

                UnicodeEncoding UE = new UnicodeEncoding();
                byte[] key = UE.GetBytes(password);

                FileStream fsCrypt = new FileStream(inputFile, FileMode.Open);

                RijndaelManaged RMCrypto = new RijndaelManaged();

                CryptoStream cs = new CryptoStream(fsCrypt,
                    RMCrypto.CreateDecryptor(key, key),
                    CryptoStreamMode.Read);

                FileStream fsOut = new FileStream(outputFile, FileMode.Create);

                int data;
                while ((data = cs.ReadByte()) != -1)
                    fsOut.WriteByte((byte)data);

                fsOut.Close();
                cs.Close();
                fsCrypt.Close();*/
            }
        }

    }    
}
