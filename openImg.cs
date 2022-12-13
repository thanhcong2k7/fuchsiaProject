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
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void CloseBtnClick(object sender, EventArgs e)
		{
			this.Close();
		}
		void MaximizeBtnClick(object sender, EventArgs e)
		{
			//maximize stuff
		}
		void MinimizeBtnClick(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}
	}
}
