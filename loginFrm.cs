using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace fuchsia
{
	public partial class loginFrm : Form
	{
		private string usrn = "", upwd = "";
		public loginFrm(bool isFE, string bruh, string bruh2) //isFE = is file exists? ("Data/usr")
		{
			/*
			Thread t = new Thread(new ThreadStart(startf));
			t.Start();
			InitializeComponent();
			if (isFE)
			{
				new fuchsiaMain(genKey(usrn, upwd)).Show();
				this.Hide();
			}/*
			usrBox.Text = "";
			pwdBox.Text = "";
			Thread.Sleep(1000);
			t.Abort();*/
			InitializeComponent();
			usrn = bruh;
			upwd = bruh2;
			//loginFrm.BackColor = Color.FromArgb(100,30,30,30);
		}
		/*
		private void startf()
		{
			Application.Run(new splashScr());
		}
		*/
		private void guna2Button1_Click(object sender, EventArgs e)
		{
			MessageBox.Show(usrBox.Text + "_" + pwdBox.Text);
			string k = genKey(usrBox.Text, pwdBox.Text);
			if (k != null)
			{
				//new fuchsiaMain(genKey(usrBox.Text, pwdBox.Text)).Show();
				this.Hide();
			}
		}
		public string genKey(string username, string password)
		{
			string hsh = HashMD5(password);
			string kget = getdata(username);//, password);
			if (kget == "1")
			{
				MessageBox.Show("Can't connect to the server.");
				Application.Exit();
			}
			else// if (kget == "0")
			{
				MessageBox.Show("Username not found!\n" + hsh);
			}
			if (hsh == kget)
			{
				File.WriteAllText("Data/usr", EncryptAesManaged(username + " " + kget));
				return hsh;
			}
			else MessageBox.Show("sai rồi đm \n" + hsh + "\n" + kget);
			return null;
		}

		private string getdata(string usr)//,string pwd)
		{
			WebClient client = new WebClient();
			client.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
			try
			{
				Stream data = client.OpenRead("http://localhost/fuchsia/auth.php?un=" + usr);// +"&pd="+pwd);
				StreamReader reader = new StreamReader(data);
				string s = reader.ReadToEnd();
				data.Close();
				reader.Close();
				return s;
			}
			catch (Exception)
			{
				return "1";
			}
		}
		public string HashMD5(string str)
		{
			return BitConverter.ToString(MD5.Create().ComputeHash(Encoding.ASCII.GetBytes(str))).Replace("-", "").ToLower();
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
