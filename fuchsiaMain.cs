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
	public sealed partial class fuchsiaMain : Form
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
            //initPost("test xd", userName, "00:00 00/00/0000");//, Image.FromFile("testImg/ab.jpg"));
			initPost("dep chai so 1 vi en", userName, "00:00 00/00/0000", null);
            initPost("dep chai so 2 vi en", userName, "00:00 00/00/0000", Image.FromFile("testImg/ab.jpg"));
            //test
            //postContainer.Size = new Size(postContainer.Size.Width, this.Size.Height-titleBar.Size.Height-navBar.Size.Height);
            //
			//(new loginForm()).Show();
            usr_ = user;
            pwd_ = passw;
            handleLnk.Text = "@" + user;
            postContainer.MouseWheel += postContainer_Scroll;
            appName.Text = "fuchsia " + a.Version.ToString() + " - Preview";// + "." + minorV.ToString() + "." + patchV.ToString() + "-pre_alpha";
            semibg.Hide();
            chooseTab_state.Location = new Point(homeBtn.Location.X, homeBtn.Location.Y + msgBtn.Size.Height);
			this.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size;
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
				Size = new Size(postContainer.Size.Width,200),
				Anchor = AnchorStyles.Top|AnchorStyles.Left|AnchorStyles.Right,
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
			BackColor = Color.FromArgb(50,0,0,0)
		};
		void viewCtrl(Form anythinglmao){/*
			this.Controls.Add(anythinglmao);
			this.Controls.Add(semibg);
			semibg.Show();
			semibg.Size = new Size(this.Size.Height-navBar.Size.Height-titleBar.Size.Height,this.Size.Width);
			semibg.Location = new Point((this.Size.Width-anythinglmao.Size.Width)/2,(this.Size.Height-anythinglmao.Size.Height)/2);//,titleBar.Size.Height);
			semibg.BringToFront();
			anythinglmao.Show();
			anythinglmao.BringToFront();
			anythinglmao.Disposed += (object sender, EventArgs e)=>{
				anythinglmao.Hide();
				semibg.Hide();
				semibg.SendToBack();
			};*/
			anythinglmao.Show();
			anythinglmao.FormClosing += (object sender, FormClosingEventArgs e) => {isSet = false;};
		}
		bool isSet = false;
		void SettingsBtnClick(object sender, EventArgs e)
		{
			if(!isSet){
				viewCtrl(new settMan());
				isSet = !isSet;
			}
		}
		void Guna2Button6Click(object sender, EventArgs e)
		{
			(new viewProfile(userID)).Show();
		}
		void TagCtrlMouseClick(object sender, MouseEventArgs e)
		{
			(new viewProfile(userID)).Show();
		}
		void NameTxtMouseClick(object sender, MouseEventArgs e)
		{
			(new viewProfile(userID)).Show();
		}
		void HandleLnkMouseClick(object sender, MouseEventArgs e)
		{
			(new viewProfile(userID)).Show();
		}
		void Guna2CirclePictureBox1MouseClick(object sender, MouseEventArgs e)
		{
			(new viewProfile(userID)).Show();
		}
		Size bk = new Size();
		void MaximizeBtnClick(object sender, EventArgs e)
		{
			if (this.WindowState!=FormWindowState.Maximized){
				bk = this.Size;
				this.WindowState = FormWindowState.Maximized;
			} else {this.WindowState = FormWindowState.Normal;this.Size = bk;}
		}
	}
}
