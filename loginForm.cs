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
		public loginForm()
		{
			InitializeComponent();
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
			procErC(kget);
			if (hsh == kget) return hsh;
			else MessageBox.Show("sai rồi đm \n"+hsh+"\n"+kget);
			return null;
		}

		private void procErC(string code) //Process Error Code
		{
			if (code == "3")
			{
				intStatus.ForeColor = Color.FromArgb(255,0,0);
				intStatus.Text = "Can't connect to MySQL Server. Please try again later. (Internal error)";
			} else if (code == "1")
			{
				intStatus.ForeColor = Color.FromArgb(255, 0, 0);
				intStatus.Text = "Can't connect to server. Please check your Internet connection.";
			} else
			{
				intStatus.ForeColor = Color.FromArgb(0, 192, 0);
				intStatus.Text = "OK";
			}
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
	}
}
