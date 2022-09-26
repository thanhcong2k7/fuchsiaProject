using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using System.Threading;
using System.Net.NetworkInformation;

namespace fuchsia
{
	public partial class loginForm : Form
	{
		string usrn = "", upwd = "";
		public loginForm(string bruh, string bruh2)
		{
			usrn = bruh;
			upwd = bruh2;
			InitializeComponent();
			if (usrn != null)
			{
				new fuchsiaMain(genKey(usrn, upwd)).Show();
				this.Hide();
			}
			//loginFrm.BackColor = Color.FromArgb(100,30,30,30);
		}

		private void loginForm_Load(object sender, EventArgs e)
		{
		}

		private void guna2Button2_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void guna2Button1_Click(object sender, EventArgs e)
		{
			string k = genKey(usrBox.Text, pwdBox.Text);
			if (k != null)
			{
				new fuchsiaMain(genKey(usrBox.Text, pwdBox.Text)).Show();
				this.Hide();
			}
		}
		public string genKey(string username, string password)
		{
			string hsh = HashMD5(password);
			string kget = getdata(username, password);
			if (hsh == kget)
			{
				File.WriteAllText("Data/usr",EncryptAesManaged(username+" "+kget));
				return hsh;
			}
			else MessageBox.Show("sai rồi đm \n" + hsh + "\n" + kget);
			return null;
		}

		private string getdata(string usr,string pwd)
		{
			WebClient client = new WebClient();
			client.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
			try
			{
				Stream data = client.OpenRead("http://localhost/fuchsia/auth.php?un="+usr+"&pd="+pwd);
				StreamReader reader = new StreamReader(data);
				string s = reader.ReadToEnd();
				data.Close();
				reader.Close();
				return s;
			}
			catch (Exception e)
			{
				MessageBox.Show(e.Message);
				return "1";
			}
			//return "";
		}
		public string HashMD5(string str)
		{
			return BitConverter.ToString(MD5.Create().ComputeHash(Encoding.ASCII.GetBytes(str))).Replace("-", "").ToLower();
		}
		/*
		private string status(bool stt)
		{
			if (stt == true)
			{
				return "OK";
				intStatus.ForeColor = Color.FromArgb(0,192,0);
			}else return "bruh";
		}

		public static bool CheckForInternetConnection(int timeoutMs = 10000, string url = null)
		{
			try
			{
				Ping myPing = new Ping();
				String host = "localhost";
				byte[] buffer = new byte[32];
				int timeout = 10000;
				PingOptions pingOptions = new PingOptions();
				PingReply reply = myPing.Send(host, timeout, buffer, pingOptions);
				return (reply.Status == IPStatus.Success);
			}
			catch (Exception)
			{
				return false;
			}
		}
		*/
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
