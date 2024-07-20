using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Net;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
//using System.Timers;
using WMPLib;
namespace fuchsia
{
	public sealed partial class fuchsiaMain : Form
	{
		public string userID = "abcxyz";
		public string userName = "Nguyễn Thành Công";
		private string usr_ = "", pwd_ = "";
		public bool notifStatus = true;
		private AssemblyInfo a = new AssemblyInfo(Assembly.GetEntryAssembly());
		//System.Media.SoundPlayer player = new System.Media.SoundPlayer(){SoundLocation = "./Data/videoplayback.m4a"};
		WindowsMediaPlayer player = new WindowsMediaPlayer(){URL = "./Data/videoplayback.mp3"};
		public int timeMusic=0, totaltimeMusic=0;
		private Timer aTimer = new Timer(){Interval = 1000};
		public fuchsiaMain(string user, string passw)
		{
			InitializeComponent();
			player.controls.stop();
			//init player and its stuffs
			WindowsMediaPlayerClass wmp = new WindowsMediaPlayerClass();
			IWMPMedia mediaInfo = wmp.newMedia("./Data/videoplayback.mp3");
			//MessageBox.Show(mediaInfo.duration.ToString());
			totaltimeMusic = Convert.ToInt32(Math.Floor(mediaInfo.duration));
			string minutes = Convert.ToInt32(mediaInfo.duration/60).ToString();
			totalTime.Text = (minutes.Length > 1 ? minutes : "0" + minutes) + ":"
							 + (totaltimeMusic - Convert.ToInt32(totaltimeMusic / 60) * 60);
			aTimer.Tick += (Object obj, EventArgs e) => {
				timeMusic++;
				string minn = (timeMusic / 60).ToString();
				string secs = (timeMusic - Convert.ToInt32(timeMusic / 60) * 60).ToString();
				timeProg.Text = (minn.Length > 1 ? minn : "0" + minn) + ":" + (secs.Length > 1 ? secs : "0" + secs);
				progBar.Value = Convert.ToInt32((Convert.ToDouble(timeMusic) / Convert.ToDouble(totaltimeMusic)) * 100);
				if (timeMusic >= totaltimeMusic || player.playState != WMPPlayState.wmppsPlaying || progBar.Value == 100) {
					timeMusic = 0;
					nextsongfunc();
				}
				Debug.WriteLine(Convert.ToInt32((Convert.ToDouble(timeMusic) / Convert.ToDouble(totaltimeMusic)) * 100));
			};
			
			//
			//notif stuff
			//
			notifCont.Controls.Add(new notifItem("hai ngu hai ngu hai ngu"){Cursor = Cursors.Hand});
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
            //handleLnk.Text = "@" + user;
            postContainer.MouseWheel += postContainer_Scroll;
            appName.Text = "fuchsia " + a.Version.ToString() + " - Preview";// + "." + minorV.ToString() + "." + patchV.ToString() + "-pre_alpha";
            semibg.Hide();
            //chooseTab_state.Location = new Point(homeBtn.Location.X, homeBtn.Location.Y + msgBtn.Size.Height);
			this.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size;
			
			//
			//Scroll bar stuffs
			//
			//scrollBar.Maximum = postContainer.VerticalScroll.Maximum;
			postContainer.VerticalScroll.Visible = true;
			postContainer.WrapContents = true;
			postContainer.AutoScroll = true;
		}
		public void nextsongfunc(){
			//bruh no idea
			progBar.Value = 0;
			timeMusic = 0;
			aTimer.Enabled = false;
			playBtn.Image = fuchsia.Properties.Resources.play;
			timeProg.Text = "00:00";
		}
		public static string getFinalRedirect(string url)
	    {
	        if(string.IsNullOrWhiteSpace(url))
	            return url;
	
	        int maxRedirCount = 8;  // prevent infinite loops
	        string newUrl = url;
	        do
	        {
	            HttpWebRequest req = null;
	            HttpWebResponse resp = null;
	            try
	            {
	                req = (HttpWebRequest) HttpWebRequest.Create(url);
	                req.Method = "HEAD";
	                req.AllowAutoRedirect = false;
	                resp = (HttpWebResponse)req.GetResponse();
	                switch (resp.StatusCode)
	                {
	                    case HttpStatusCode.OK:
	                        return newUrl;
	                    case HttpStatusCode.Redirect:
	                    case HttpStatusCode.MovedPermanently:
	                    case HttpStatusCode.RedirectKeepVerb:
	                    case HttpStatusCode.RedirectMethod:
	                        newUrl = resp.Headers["Location"];
	                        if (newUrl == null)
	                            return url;
	
	                        if (newUrl.IndexOf("://", System.StringComparison.Ordinal) == -1)
	                        {
	                            // Doesn't have a URL Schema, meaning it's a relative or absolute URL
	                            Uri u = new Uri(new Uri(url), newUrl);
	                            newUrl = u.ToString();
	                        }
	                        break;
	                    default:
	                        return newUrl;
	                }
	                url = newUrl;
	            }
	            catch (WebException)
	            {
	                // Return the last known good URL
	                return newUrl;
	            }
	            catch (Exception ex)
	            {
	                return null;
	            }
	            finally
	            {
	                if (resp != null)
	                    resp.Close();
	            }
	        } while (maxRedirCount-- > 0);
	
	        return newUrl;
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
				Size = new Size(postContainer.Size.Width-30,200),
				Anchor = AnchorStyles.Top|AnchorStyles.Left|AnchorStyles.Right,
				imgPost = postImg,
				BackColor = Color.FromArgb(25, 26, 27)
			});
			pos += 220;
		}

        private void tagctrl_hover(object sender, EventArgs e)
        {
            //tagCtrl.FillColor = Color.FromArgb(50, 51, 52);
        }

        private void tagCtrl_MouseLeave(object sender, EventArgs e)
        {
            //tagCtrl.FillColor = Color.Transparent;
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            //chooseTab_state.Location = new Point(homeBtn.Location.X, homeBtn.Location.Y + msgBtn.Size.Height);
            homeBtn.FillColor = Color.FromArgb(65, 66, 67);
            msgBtn.FillColor = Color.Transparent;
            notiBtn.FillColor = Color.Transparent;
            home.BringToFront();
        }

        private void msgBtn_Click(object sender, EventArgs e)
        {
            //chooseTab_state.Location = new Point(msgBtn.Location.X, msgBtn.Location.Y + msgBtn.Size.Height);
            msgBtn.FillColor = Color.FromArgb(65, 66, 67);
            homeBtn.FillColor = Color.Transparent;
            notiBtn.FillColor = Color.Transparent;
            message_vchat.BringToFront();
        }

        private void notiBtn_Click(object sender, EventArgs e)
        {
            //chooseTab_state.Location = new Point(notiBtn.Location.X, notiBtn.Location.Y + notiBtn.Size.Height);
            notiBtn.FillColor = Color.FromArgb(65, 66, 67);
            homeBtn.FillColor = Color.Transparent;
            msgBtn.FillColor = Color.Transparent;
            notifBox.BringToFront();
            notifCont.Controls.Add(new notifItem("hai ngu hai ngu hai ngu"){Cursor = Cursors.Hand});
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
		
		Size bk = new Size();
		void MaximizeBtnClick(object sender, EventArgs e)
		{
			if (this.WindowState!=FormWindowState.Maximized){
				bk = this.Size;
				this.WindowState = FormWindowState.Maximized;
			} else {this.WindowState = FormWindowState.Normal;this.Size = bk;}
		}
		void Guna2GradientCircleButton1Click(object sender, EventArgs e)
		{
			if (player.playState != WMPPlayState.wmppsPlaying){
				player.controls.play();
				aTimer.Enabled = true;
				playBtn.Image = fuchsia.Properties.Resources.pause;
			} else {
				player.controls.pause();
				aTimer.Enabled = false;
				playBtn.Image = fuchsia.Properties.Resources.play;
			}
		}
		void Guna2GradientButton1Click(object sender, EventArgs e)
		{
			if (notifStatus){
				notifBub.Text = "Notification disabled";
				notifBub.Image = fuchsia.Properties.Resources.blocknotif;
				notifStatus = false;
			}else if (!notifStatus){
				notifBub.Text = "Notification enabled";
				notifBub.Image = fuchsia.Properties.Resources.allownotif;
				notifStatus = true;
			}
		}
		void ProgBarValueChanged(object sender, EventArgs e)
		{
			if (changedbyhooman){
				bool ee = false;
				if (!aTimer.Enabled) ee = true; else {aTimer.Enabled = false; player.controls.pause();}
				timeMusic = Convert.ToInt32((Convert.ToDouble(val)/100)*totaltimeMusic);
				string minn = (timeMusic / 60).ToString();
				string secs = (timeMusic - Convert.ToInt32(timeMusic / 60) * 60).ToString();
				timeProg.Text = (minn.Length > 1 ? minn : "0" + minn) + ":" + (secs.Length > 1 ? secs : "0" + secs);
				player.controls.currentPosition = Convert.ToInt32(timeMusic);
				if(!ee) {aTimer.Enabled = true; player.controls.play();}
				changedbyhooman = false;
			}
		}
		bool changedbyhooman = false;
		int val = 0;
		void ProgBarMouseCaptureChanged(object sender, EventArgs e)
		{
			changedbyhooman = true;
			val = progBar.Value;
		}
	}
}
