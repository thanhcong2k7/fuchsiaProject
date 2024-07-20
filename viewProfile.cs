/*
 * Created by SharpDevelop.
 * User: KamyzZ
 * Date: 12/26/2022
 * Time: 9:33 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Reflection;
using System.Windows.Forms;
using System.Diagnostics;

namespace fuchsia
{
	/// <summary>
	/// Description of viewProfile.
	/// </summary>
	public partial class viewProfile : Form
	{
		private AssemblyInfo a = new AssemblyInfo(Assembly.GetEntryAssembly());
		private string viewID = "";
		private string pfID = "";
		public viewProfile(string ID, string broitsme)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			post.WrapContents = true;
			post.AutoScroll = true;
			post.VerticalScroll.Visible = true;
			viewID = ID;
			pfID = broitsme;
			resizeImage(cover.Image, (new Size(avatar.Size.Width,avatar.Size.Height)));
			//
			handle_tip.SetToolTip(handle,"Bấm để sao chép");
			wb.HoverState.FillColor = Color.FromArgb(130,207, 1, 116);
			yt.HoverState.FillColor = Color.FromArgb(130,207, 1, 116);
			sc.HoverState.FillColor = Color.FromArgb(130,207, 1, 116);
			fb.HoverState.FillColor = Color.FromArgb(130,207, 1, 116);
			
			wb.Click += (object sender, EventArgs e) => Process.Start(wb.Text.StartsWith("https://")?wb.Text:(wb.Text.StartsWith("http://")?"":"http://")+wb.Text);
			sc.Click += (object sender, EventArgs e) => Process.Start("https://soundcloud.com/"+sc.Text);
			yt.Click += (object sender, EventArgs e) => Process.Start("https://www.youtube.com/"+yt.Text);
			fb.Click += (object sender, EventArgs e) => Process.Start("http://fb.com/"+fb.Text);
			//
			
			//
			postCont1.caption = "bruh";
			postCont1.name = "Nguyen Thanh Cong";
			postCont1.dateposted = "00:00 1/1/2023";
			postCont1.avatar = avatar.Image;
			//
			appName.Text = "fuchsia " + a.Version.ToString() + " - preview";
			//
			// Check relationship or idk
			//
			//1 query added or not or waiting
			//1 = not, 2 = waiting, 3 = added
			int status = 1;
			if (status == 1){
				addfrBtn.Text = "Thêm bạn";
				addfrBtn.Image = fuchsia.Properties.Resources.addf;
			} else if (status==2){
				addfrBtn.Text = "Hủy lời mời";
				addfrBtn.Image = fuchsia.Properties.Resources.unf;
			} else if (status==3){
				addfrBtn.Text = "Xóa bạn bè";
				addfrBtn.Image = fuchsia.Properties.Resources.unf;
			}
			//2 followed or not? T or F
			bool fl = true;
			if (fl)
				flBtn.Image = fuchsia.Properties.Resources.follow;
			else flBtn.Image = fuchsia.Properties.Resources.unfl;
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		private static System.Drawing.Image resizeImage(System.Drawing.Image imgToResize, Size size)  
		{  
    		//Get the image current width  
    		int sourceWidth = imgToResize.Width;  
    		//Get the image current height  
    		int sourceHeight = imgToResize.Height;  
    		float nPercent = 0;  
    		float nPercentW = 0;  
    		float nPercentH = 0;  
    		//Calulate  width with new desired size  
    		nPercentW = ((float)size.Width / (float)sourceWidth);  
    		//Calculate height with new desired size  
    		nPercentH = ((float)size.Height / (float)sourceHeight);  
   			//if (nPercentH < nPercentW)  
        		//nPercent = nPercentH;  
    		//else  
     		nPercent = nPercentW;
     		//New Width  
     		int destWidth = (int)(sourceWidth * nPercent);  
     		//New Height  
     		int destHeight = (int)(sourceHeight * nPercent);  
     		Bitmap b = new Bitmap(destWidth, destHeight);
     		Graphics g = Graphics.FromImage((System.Drawing.Image)b);  
     		g.InterpolationMode = InterpolationMode.HighQualityBicubic;  
     		// Draw image with new width and height  
     		g.DrawImage(imgToResize, 0, 0, destWidth, destHeight);  
     		g.Dispose(); 
     		return (System.Drawing.Image)b;  
		}
		void ClosebtnClick(object sender, EventArgs e)
		{
			this.Close();
		}
		public bool ThumbnailCallback()
		{
    		return true;
		}
		private void getcolorscheme(Guna.UI2.WinForms.Guna2Button bx){
			int thumbSize = 32;
    	    Dictionary<Color, int> colors = new Dictionary<Color, int>();
	
    	    Bitmap thumbBmp = 
    	        new Bitmap(bx.Image.GetThumbnailImage(
    	            thumbSize, thumbSize, ThumbnailCallback, IntPtr.Zero));
	
    	    //just for test
    	    PictureBox px = new PictureBox();
    	    px.Image = thumbBmp;            
	
    	    for (int i = 0; i < thumbSize; i++)
    	    {
    	        for (int j = 0; j < thumbSize; j++)
    	        {
    	            Color col = thumbBmp.GetPixel(i, j);
    	            if (colors.ContainsKey(col))
    	                colors[col]++;
    	            else
    	                colors.Add(col, 1);
    	        }                
    	    }
	
    	    List<KeyValuePair<Color, int>> keyValueList = 
    	        new List<KeyValuePair<Color, int>>(colors);
	
    	    keyValueList.Sort(
    	        delegate(KeyValuePair<Color, int> firstPair,
    	        KeyValuePair<Color, int> nextPair)
    	        {
    	            return nextPair.Value.CompareTo(firstPair.Value);
    	        });
			/*
    	    string top10Colors = "";
    	    for (int i = 0; i < 10; i++)
    	    {
    	        top10Colors += string.Format("\n {0}. {1} > {2}",
    	            i, keyValueList[i].Key.ToString(), keyValueList[i].Value);
    	        flowLayoutPanel1.Controls[i].BackColor = keyValueList[i].Key;
	        }
    	    MessageBox.Show("Top 10 Colors: " + top10Colors);*/
		}
		void Label2Click(object sender, EventArgs e)
		{
			Clipboard.SetText(handle.Text);
		}
	}
}
