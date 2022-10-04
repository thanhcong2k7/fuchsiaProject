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
		private string host = "http://localhost/fuchsia";
		public loginFrm(bool isFE, string bruh, string bruh2) //isFE = is file exists? ("Data/usr")
		{
			InitializeComponent();
			usrn = bruh;
			upwd = bruh2;
			if (isFE)
			{
				string dt = getdata(usrn);
				if (dt == upwd)
				{
					//MessageBox.Show("passed!");
					Application.Run(new fuchsiaMain(dt));
					this.Hide();
				}
			}
			//loginFrm.BackColor = Color.FromArgb(100,30,30,30);
		}
		private void guna2Button1_Click(object sender, EventArgs e)
		{
			//MessageBox.Show(usrBox.Text + "_" + pwdBox.Text);
			string k = genKey(usrBox.Text, pwdBox.Text);
			if (k != null)
			{
				new fuchsiaMain(k).Show();
				this.Hide();
			}
			//Write login in4 to Data/usr
			if (!File.Exists(@"Data/usr"))
				File.Create(@"Data/usr");
			File.WriteAllText(@"Data/usr", HashMD5(usrBox.Text + " " + pwdBox.Text));
		}
		public string genKey(string username, string password)
		{
			string hsh = HashMD5(password);
			string kget = getdata(username);//, password);
			if (kget == "1")
			{
				new msgBox("Không thể kết nối đến máy chủ.").Show();
				Application.Exit();
			}
			else if (kget == "0")
			{
				new msgBox("Username not found!\n" + username).Show();
			}
			if (hsh == kget)
			{
				File.WriteAllText("Data/usr", EncryptAesManaged(username + " " + kget));
				return hsh;
			}
			else new msgBox("sai rồi đm \n" + hsh + "\n" + kget).Show();
			return null;
		}

		private string getdata(string usr)//,string pwd)
		{
			WebClient client = new WebClient();
			client.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
			try
			{
				Stream data = client.OpenRead(host + "/auth.php?un=" + usr);// +"&pd="+pwd);
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

		private void guna2Panel1_MouseHover(object sender, EventArgs e)
		{
			guna2Panel1.FillColor = Color.FromArgb(40, 41, 42);
		}

		private void guna2Panel1_MouseLeave(object sender, EventArgs e)
		{
			guna2Panel1.FillColor = Color.Transparent;
		}

		private void guna2Panel2_MouseEnter(object sender, EventArgs e)
		{
			guna2Panel2.FillColor = Color.FromArgb(40, 41, 42);
		}

		private void guna2Panel2_MouseLeave(object sender, EventArgs e)
		{
			guna2Panel2.FillColor = Color.Transparent;
		}

		private void guna2Button2_Click(object sender, EventArgs e)
		{
			//Register stuff
			string result = reg(usrName_reg.Text, emailTxt_reg.Text, pwdTxt_reg.Text, nameTxt_reg.Text);
			if (result == "1")
			{
				new msgBox("Registered!").Show();
			}
			else if (result == "2")
			{
				new msgBox("Username existed!").Show();
			}
			else if (result == "3")
			{
				new msgBox("Internal error occurred! Please try again later.").Show();
			}
			else if (result == "0")
			{
				new msgBox("Failed to connect to server! Please check your Internet connection and try again later.").Show();
			}
			else new msgBox("bruh wtf " + result).Show();
			MessageBox.Show("check " + result);
		}

		private void writelog(string txt)
		{
			if (!File.Exists(@"Data/error_log.txt"))
				File.Create(@"Data/error_log.txt");
			File.AppendAllText(@"Data/error_log.txt", "\n" + txt);
		}

		private string reg(string usr, string email, string pwd, string nameT)
		{
			WebClient client = new WebClient();
			client.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
			try
			{
				Stream data = client.OpenRead(host + "/reg.php?un=" + usr + "&pd=" + pwd + "&name=" + nameT + "&regmail=" + email);
				StreamReader reader = new StreamReader(data);
				string s = reader.ReadToEnd();
				data.Close();
				reader.Close();
				return s;
			}
			catch (Exception)
			{
				MessageBox.Show("wtf server?");
				return "0";
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
