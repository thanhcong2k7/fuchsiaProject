using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace fuchsia
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			//splashScr.ShowSplashScreen();
			//System.Threading.Thread.Sleep(2000);
			//Check info file exist
			string curFile = @"Data/usr";
			string[] bruhstr = { "0", "0" };
			bool bruhbr = false;
			if (File.Exists(curFile))
			{
				string in4 = File.ReadAllText(curFile);
				//in4 = EncryptAesManaged(in4,false);
				bruhstr = in4.Split(' ');
				int cnt = 0;
				foreach (string s in bruhstr)
				{
					cnt += s != null ? 1 : 0;
				}
				if (cnt == 1) bruhstr[0] = "bruh";
				bruhbr = true;
			}
			//splashScr.CloseForm();
			Application.Run(new loginFrm(bruhbr, bruhstr[0], bruhstr[1]));
			//Application.Run(new loginForm(bruhstr[0], bruhstr[1]));
		}
		static string EncryptAesManaged(string raw, bool needEnc = true)
		{
			try
			{
				// Create Aes that generates a new key and initialization vector (IV).    
				// Same key must be used in encryption and decryption    
				using (AesManaged aes = new AesManaged())
				{
					// Encrypt string
					if (needEnc)
					{
						byte[] encrypted = Encrypt(raw, aes.Key, aes.IV);
						return Encoding.UTF8.GetString(encrypted);
					}
					else
					{
						// Decrypt the bytes to a string.    
						string decrypted = Decrypt(Encoding.ASCII.GetBytes(raw), aes.Key, aes.IV);
						return decrypted;
					}
				}
			}
			catch (Exception exp)
			{
				MessageBox.Show(exp.Message);
				return "";
			}
		}
		static byte[] Encrypt(string plainText, byte[] Key, byte[] IV)
		{
			byte[] encrypted;
			// Create a new AesManaged.    
			using (AesManaged aes = new AesManaged())
			{
				// Create encryptor    
				ICryptoTransform encryptor = aes.CreateEncryptor(Key, IV);
				// Create MemoryStream    
				using (MemoryStream ms = new MemoryStream())
				{
					// Create crypto stream using the CryptoStream class. This class is the key to encryption    
					// and encrypts and decrypts data from any given stream. In this case, we will pass a memory stream    
					// to encrypt    
					using (CryptoStream cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
					{
						// Create StreamWriter and write data to a stream    
						using (StreamWriter sw = new StreamWriter(cs))
							sw.Write(plainText);
						encrypted = ms.ToArray();
					}
				}
			}
			// Return encrypted data    
			return encrypted;
		}
		static string Decrypt(byte[] cipherText, byte[] Key, byte[] IV)
		{
			string plaintext = null;
			// Create AesManaged    
			using (AesManaged aes = new AesManaged())
			{
				// Create a decryptor    
				ICryptoTransform decryptor = aes.CreateDecryptor(Key, IV);
				// Create the streams used for decryption.    
				using (MemoryStream ms = new MemoryStream(cipherText))
				{
					// Create crypto stream    
					using (CryptoStream cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
					{
						// Read crypto stream    
						using (StreamReader reader = new StreamReader(cs))
							plaintext = reader.ReadToEnd();
					}
				}
			}
			return plaintext;
		}
	}
}
