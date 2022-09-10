using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Net;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace fuchsia
{
	public partial class fuchsiaMain : Form
	{
		public string userID = "abcxyz";
		public string userName = "Nguyễn Thành Công";
		private string userKey = "";
		public fuchsiaMain(string privateKey)
		{
			InitializeComponent();
			initPost("test",userName,getUTC_Time());
			//(new loginForm()).Show();
			userKey = privateKey;
		}

		private void guna2Button1_Click(object sender, EventArgs e)
		{
			//logout stuff
		}

		private void infoBtn_Click(object sender, EventArgs e)
		{
			(new aboutWindow()).Show();
		}

		private void guna2TextBox1_TextChanged(object sender, EventArgs e)
		{
			if (String.IsNullOrWhiteSpace(captionInput.Text))
			{
				postBtn.Enabled = false;
			}
			else postBtn.Enabled = true;
		}

		private void closeBtn_Click(object sender, EventArgs e)
		{
			this.Close();
			Application.Exit();
		}
		private int pos = 10;
		private void postBtn_Click(object sender, EventArgs e)
		{
			//send post stuff
		}
		private void initPost(string captTxt, string nameTxt, string dateT, Image[] postImg = null)
		{
			//get post stuff
			//add post to container
			this.postContainer.Controls.Add(new postCont() {
				caption = captTxt,
				name=nameTxt,
				dateposted=dateT,
				userWatchingID = userID,
				Location = new Point(16,pos),
				Anchor = AnchorStyles.Top|AnchorStyles.Left|AnchorStyles.Right,
				Size = new Size(850,200)
			});
			pos += 220;
		}
		private string getUTC_Time()
		{
			WebClient client = new WebClient();
			dynamic dynObj;
			client.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
			try
			{
				Stream data = client.OpenRead("http://worldtimeapi.org/api/ip");
				StreamReader reader = new StreamReader(data);
				string s = reader.ReadToEnd();
				//Console.WriteLine(s);
				dynObj = JsonConvert.DeserializeObject(s);
				data.Close();
				reader.Close();
				return dynObj.utc_datetime;
			} catch (Exception e)
			{
				MessageBox.Show(e.Message);
			}
			return "";
		}
	}
}
