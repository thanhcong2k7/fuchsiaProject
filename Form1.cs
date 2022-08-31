using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace fuchsia
{
	public partial class Form1 : Form
	{
		public string userID = "abcxyz";
		public string userName = "Nguyễn Thành Công";
		public Form1()
		{
			InitializeComponent();
			initPost("test",userName,"10:03 30/8/2022");
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
		}
		private int pos = 0;
		private void postBtn_Click(object sender, EventArgs e)
		{
			//send post stuff
		}
		private void initPost(string captTxt, string nameTxt, string dateT)
		{
			//get post stuff
			//add post to container
			this.postContainer.Controls.Add(new postCont() {
				caption = captTxt,
				name=nameTxt,
				dateposted=dateT,
				userWatchingID = userID,
				Location = new Point(0,pos),
				Anchor = AnchorStyles.Top|AnchorStyles.Left|AnchorStyles.Right
			});
			pos += 220;
		}
	}
}
