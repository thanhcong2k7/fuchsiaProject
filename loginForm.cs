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
			string hsh = BitConverter.ToString(MD5.Create().ComputeHash(Encoding.ASCII.GetBytes(username+password+"abc"))).Replace("-", "").ToLower();
			string kget = getdata(username, password);
			if (hsh == kget) return hsh;
			else MessageBox.Show("sai rồi đm \n"+hsh+"\n"+kget);
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
				//Console.WriteLine(s);
				//dynObj = JsonConvert.DeserializeObject(s);
				data.Close();
				reader.Close();
				return s;
			}
			catch (Exception e)
			{
				MessageBox.Show(e.Message);
			}
			return "";
		}
	}
}
