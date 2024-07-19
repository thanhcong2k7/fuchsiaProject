/*
 * Created by SharpDevelop.
 * User: KamyzZ
 * Date: 12/13/2022
 * Time: 10:05 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace fuchsia
{
	/// <summary>
	/// Description of openImg.
	/// </summary>
	public partial class openImg : Form
	{
		public openImg(Image kkk)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			guna2PictureBox1.Image = kkk;
			this.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size;
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		Size bk = new Size();
		void CloseBtnClick(object sender, EventArgs e)
		{
			this.Close();
		}
		void MaximizeBtnClick(object sender, EventArgs e)
		{
			if (this.WindowState!=FormWindowState.Maximized){
				bk = this.Size;
				this.WindowState = FormWindowState.Maximized;
			} else {this.WindowState = FormWindowState.Normal;this.Size = bk;}
		}
		void MinimizeBtnClick(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}
		void Guna2PictureBox1Click(object sender, EventArgs e)
		{
			var diag = new SaveFileDialog(){Title = "Save Image", Filter = "JPeg Image|*.jpg"};
			DialogResult res = diag.ShowDialog();
			if(res == DialogResult.OK){
				var fs = (System.IO.FileStream)diag.OpenFile();
				guna2PictureBox1.Image.Save(fs,ImageFormat.Jpeg);
				fs.Close();
			}
		}
	}
}
