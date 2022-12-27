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
using System.Reflection;
namespace fuchsia
{
	public partial class fuchsiaMain : Form
	{
		public string userID = "abcxyz";
		public string userName = "Nguyễn Thành Công";
		private string usr_ = "", pwd_ = "";
		private AssemblyInfo a = new AssemblyInfo(Assembly.GetEntryAssembly());
		public fuchsiaMain(string user, string passw)
		{
			InitializeComponent();
			//this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi; // fix blurry
			//initPost("test",userName,getUTC_Time());
            initPost("test xd", userName, "00:00 00/00/0000");//, Image.FromFile("testImg/ab.jpg"));
            //initPost("dep chai top 1 vi en", userName, "00:00 00/00/0000", Image.FromFile("testImg/ab.jpg"));
			//(new loginForm()).Show();
            usr_ = user;
            pwd_ = passw;
            handleLnk.Text = "@" + user;
            postContainer.MouseWheel += postContainer_Scroll;
            appName.Text = "fuchsia " + a.Version.ToString() + " - Preview";// + "." + minorV.ToString() + "." + patchV.ToString() + "-pre_alpha";
            semibg.Hide();
		}

		private void guna2Button1_Click(object sender, EventArgs e)
		{
			//logout stuff
			Application.Exit();
		}

		private void infoBtn_Click(object sender, EventArgs e)
		{
			//About Window
			//(new aboutWindow()).Show();
		}

		private void closeBtn_Click(object sender, EventArgs e)
		{
			//exit stuff
			this.Close();
			Application.Exit();
		}
		private int pos = 10;
		private void initPost(string captTxt, string nameTxt, string dateT, Image postImg = null)
		{
			//get post stuff
            //wtf nothing here

			//add post to container
			this.postContainer.Controls.Add(new postCont() {
				caption = captTxt,
				name=nameTxt,
				dateposted=dateT,
				userWatchingID = userID,
				//Location = new Point(5,pos),
				Anchor = AnchorStyles.Top|AnchorStyles.Left|AnchorStyles.Right,
				Size = new Size(postContainer.Size.Width,200),
				imgPost = postImg
			});
			pos += 220;
		}

        private void tagctrl_hover(object sender, EventArgs e)
        {
            tagCtrl.FillColor = Color.FromArgb(50, 51, 52);
        }

        private void tagCtrl_MouseLeave(object sender, EventArgs e)
        {
            tagCtrl.FillColor = Color.Transparent;
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            chooseTab_state.Location = new Point(homeBtn.Location.X, homeBtn.Location.Y + msgBtn.Size.Height);
            homeBtn.FillColor = Color.FromArgb(65, 66, 67);
            msgBtn.FillColor = Color.Transparent;
            notiBtn.FillColor = Color.Transparent;
            home.BringToFront();
        }

        private void msgBtn_Click(object sender, EventArgs e)
        {
            chooseTab_state.Location = new Point(msgBtn.Location.X, msgBtn.Location.Y + msgBtn.Size.Height);
            msgBtn.FillColor = Color.FromArgb(65, 66, 67);
            homeBtn.FillColor = Color.Transparent;
            notiBtn.FillColor = Color.Transparent;
            message_vchat.BringToFront();
        }

        private void notiBtn_Click(object sender, EventArgs e)
        {
            chooseTab_state.Location = new Point(notiBtn.Location.X, notiBtn.Location.Y + notiBtn.Size.Height);
            notiBtn.FillColor = Color.FromArgb(65, 66, 67);
            homeBtn.FillColor = Color.Transparent;
            msgBtn.FillColor = Color.Transparent;
        }

        private void postContainer_Scroll(object sender, MouseEventArgs e)
        {
            /*
            postContainer.Focus();
            //postContainer.HorizontalScroll.Value += 5;
            if (e.Delta < 0)
            {
                postContainer.HorizontalScroll.Value += e.Delta;
            }
            else {
                if(postContainer.HorizontalScroll.Value >= 1)
                    postContainer.HorizontalScroll.Value += e.Delta;
            }*/
        }
		void MinimizeBtnClick(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}
		private Panel semibg = new Panel(){
			//Location = new Point(0,titleBar.Size.Height),
			//Size = new Size(this.Size.Height-navBar.Size.Height-titleBar.Size.Height,this.Size.Width),
			BackColor = Color.FromArgb(100,0,0,0)
		};
		void viewCtrl(Form anythinglmao){
			//
		}
	}
}
