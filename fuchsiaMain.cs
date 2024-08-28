using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;
//using System.Timers;
namespace fuchsia
{
	public sealed partial class fuchsiaMain : Form
	{
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
	    public struct SHFILEINFO
	    {
	        public IntPtr hIcon;
	        public int iIcon;
	        public uint dwAttributes;
	        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
	        public string szDisplayName;
	        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
	        public string szTypeName;
	    };
		[DllImport("shell32.dll", CharSet = CharSet.Auto)]
		public static extern IntPtr SHGetFileInfo(string pszPath, uint dwFileAttributes, out SHFILEINFO psfi, uint cbFileInfo, uint uFlags);
        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool DestroyIcon(IntPtr hIcon);
        
        public const uint SHGFI_ICON = 0x000000100; 
        public const uint SHGFI_USEFILEATTRIBUTES = 0x000000010; 
        public const uint SHGFI_OPENICON = 0x000000002; 
        public const uint SHGFI_SMALLICON = 0x000000001; 
        public const uint SHGFI_LARGEICON = 0x000000000; 
        public const uint FILE_ATTRIBUTE_DIRECTORY = 0x00000010;
        
		private bool islistshown = false;
		public string userID = "abcxyz";
		public string userName = "Nguyễn Thành Công";
		private string usr_ = "", pwd_ = "";
		public bool notifStatus = true;
		private AssemblyInfo a = new AssemblyInfo(Assembly.GetEntryAssembly());
		//System.Media.SoundPlayer player = new System.Media.SoundPlayer(){SoundLocation = "./Data/videoplayback.m4a"};
		//WindowsMediaPlayer player = new WindowsMediaPlayer(){URL = "./Data/videoplayback.mp3"};
		private WaveOutEvent outputDevice;
    	private AudioFileReader audioFile;
		public int timeMusic=0, totaltimeMusic=0;
		private Timer aTimer = new Timer(){Interval = 1000};
		public enum IconSize
		{
			Large = 0,
			Small = 1
		}
		public enum FolderType
	    {
	        Closed,
	        Open
	    }
		public fuchsiaMain(string user, string passw)
		{
			InitializeComponent();
			playlistPanel.Visible = false;
			//init player and its stuffs
			outputDevice = new WaveOutEvent();
		    outputDevice.PlaybackStopped += OnPlaybackStopped;
		    audioFile = new AudioFileReader(@".\Data\videoplayback.mp3");
		    outputDevice.Init(audioFile);
			//MessageBox.Show(mediaInfo.duration.ToString());
			totaltimeMusic = Convert.ToInt32(Math.Floor(Convert.ToDouble(audioFile.TotalTime.Seconds)));
			string minutes = Convert.ToInt32(audioFile.TotalTime.Seconds/60).ToString();
			totalTime.Text = (minutes.Length > 1 ? minutes : "0" + minutes) + ":"
							 + (totaltimeMusic - Convert.ToInt32(totaltimeMusic / 60) * 60);
			aTimer.Tick += (Object obj, EventArgs e) => {
				timeMusic++;
				string minn = (timeMusic / 60).ToString();
				string secs = (timeMusic - Convert.ToInt32(timeMusic / 60) * 60).ToString();
				timeProg.Text = (minn.Length > 1 ? minn : "0" + minn) + ":" + (secs.Length > 1 ? secs : "0" + secs);
				progBar.Value = Convert.ToInt32((Convert.ToDouble(timeMusic) / Convert.ToDouble(totaltimeMusic)) * 100);
				if (timeMusic >= totaltimeMusic || outputDevice.PlaybackState != PlaybackState.Stopped || progBar.Value == 100) {
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
			if (loopState == 0){
				//
			} else if(loopState == 1){
				progBar.Value = 0;
				timeMusic = 0;
				aTimer.Enabled = false;
				playBtn.Image = fuchsia.Properties.Resources.play;
				timeProg.Text = "00:00";
			} else if(loopState == 2){
				//
			} else if(loopState == 3){
				//
			}
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
				try {
					req = (HttpWebRequest)HttpWebRequest.Create(url);
					req.Method = "HEAD";
					req.AllowAutoRedirect = false;
					resp = (HttpWebResponse)req.GetResponse();
					switch (resp.StatusCode) {
						case HttpStatusCode.OK:
							return newUrl;
						case HttpStatusCode.Redirect:
						case HttpStatusCode.MovedPermanently:
						case HttpStatusCode.RedirectKeepVerb:
						case HttpStatusCode.RedirectMethod:
							newUrl = resp.Headers["Location"];
							if (newUrl == null)
								return url;
	
							if (newUrl.IndexOf("://", System.StringComparison.Ordinal) == -1) {
								// Doesn't have a URL Schema, meaning it's a relative or absolute URL
								Uri u = new Uri(new Uri(url), newUrl);
								newUrl = u.ToString();
							}
							break;
						default:
							return newUrl;
					}
					url = newUrl;
				} catch (WebException) {
					// Return the last known good URL
					return newUrl;
				} catch {
					return null;
				} finally {
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
			if (outputDevice.PlaybackState == PlaybackState.Stopped){
				outputDevice.Play();
				aTimer.Enabled = true;
				playBtn.Image = fuchsia.Properties.Resources.pause;
			} else {
				outputDevice.Pause();
				aTimer.Enabled = false;
				playBtn.Image = fuchsia.Properties.Resources.play;
			}
		    
		}
		private void OnPlaybackStopped(object sender, StoppedEventArgs args)
		{
		    outputDevice.Dispose();
		    outputDevice = null;
		    audioFile.Dispose();
		    audioFile = null;
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
				if (!aTimer.Enabled) ee = true; else {aTimer.Enabled = false; outputDevice.Pause();}
				timeMusic = Convert.ToInt32((Convert.ToDouble(val)/100)*totaltimeMusic);
				string minn = (timeMusic / 60).ToString();
				string secs = (timeMusic - Convert.ToInt32(timeMusic / 60) * 60).ToString();
				timeProg.Text = (minn.Length > 1 ? minn : "0" + minn) + ":" + (secs.Length > 1 ? secs : "0" + secs);
				//outputDevice. = Convert.ToInt32(timeMusic);
				if(!ee) {aTimer.Enabled = true; outputDevice.Play();}
				changedbyhooman = false;
			}
		}
		bool changedbyhooman = false;
		int val = 0;
		void ProgBarMouseCaptureChanged(object sender, EventArgs e)
		{
			changedbyhooman = true;
			val = progBar.Value;
			Debug.WriteLine("sus");
		}
		void PlaylistBtnClick(object sender, EventArgs e)
		{
			if(islistshown)
			{
				playlistPanel.Visible = false;
				playlistBtn.FillColor = Color.FromArgb(40,42,43);
				islistshown = false;
			} else {
				playlistPanel.Visible = true;
				playlistBtn.FillColor = Color.FromArgb(60,62,63);
				islistshown = true;
			}
		}
		public static Icon GetFolderIcon(IconSize size, FolderType folderType)
        {    
            // Need to add size check, although errors generated at present!    
            uint flags = SHGFI_ICON | SHGFI_USEFILEATTRIBUTES;    

            if (FolderType.Open == folderType)    
            {        
                flags += SHGFI_OPENICON;    
            }    
            if (IconSize.Small == size)    
            {       flags += SHGFI_SMALLICON;    
            }     
            else     
            {       
                flags += SHGFI_LARGEICON;    
            }    
            // Get the folder icon    
            var shfi = new SHFILEINFO();    

            var res = SHGetFileInfo(@"C:\Windows",                             
                FILE_ATTRIBUTE_DIRECTORY,                             
                out shfi,                             
                (uint) Marshal.SizeOf(shfi),                             
                flags );

            if (res == IntPtr.Zero)
                throw Marshal.GetExceptionForHR(Marshal.GetHRForLastWin32Error());

            // Load the icon from an HICON handle  
            Icon.FromHandle(shfi.hIcon);    

            // Now clone the icon, so that it can be successfully stored in an ImageList
            var icon = (Icon)Icon.FromHandle(shfi.hIcon).Clone();    

            DestroyIcon( shfi.hIcon );        // Cleanup    

            return icon;
		}
		int loopState = 0; // 0 all 1 one 2 shuffle 3 none (play once only)
		void LoopBtnClick(object sender, EventArgs e)
		{
			if(loopState == 3){
				loopBtn.Image = fuchsia.Properties.Resources.repeat;
				loopState = 0;
			} else if (loopState == 0){
				loopBtn.Image = fuchsia.Properties.Resources.repeat_one;
				loopState = 1;
			} else if (loopState == 1){
				loopBtn.Image = fuchsia.Properties.Resources.shuffle;
				loopState = 2;
			} else if (loopState == 2){
				loopBtn.Image = fuchsia.Properties.Resources.shuffleoff;
				loopState = 3;
			}
		}
	}
}
