﻿/*
 * Created by SharpDevelop.
 * User: KamyzZ
 * Date: 12/26/2022
 * Time: 9:53 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace fuchsia
{
	/// <summary>
	/// fuchsia System-wide Settings Manager & account?
	/// </summary>
	public partial class settMan : Form
	{
		private AssemblyInfo a = new AssemblyInfo(Assembly.GetEntryAssembly());
		public settMan()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			sel.Location = new Point(accSetbtn.Location.X-4, accSetbtn.Location.Y);
			accSet.BringToFront();
			label9.Text = "Version "+ a.Version.ToString() + "-preview";
			nameTxtCtrl.Text = "Test User";
			handleTxtCtrl.Text = "admin";
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		bool isfull = true;
		void Guna2Button1Click(object sender, EventArgs e)
		{
			side.Size = (isfull?(new Size(58,side.Size.Height)):(new Size(268,side.Size.Height)));
			isfull = !isfull;
			//accSet.Location = new Point();
		}
		void Guna2Button2Click(object sender, EventArgs e)
		{
			sel.Show();
			sel.Location = new Point(accSetbtn.Location.X-4, accSetbtn.Location.Y);
			accSet.BringToFront();
		}
		void GuiSetClick(object sender, EventArgs e)
		{
			sel.Show();
			sel.Location = new Point(guiSetbtn.Location.X-4, guiSetbtn.Location.Y);
		}
		void NotifSetClick(object sender, EventArgs e)
		{
			sel.Show();
			sel.Location = new Point(notifSetbtn.Location.X-4, notifSetbtn.Location.Y);
		}
		void PrivSetClick(object sender, EventArgs e)
		{
			sel.Show();
			sel.Location = new Point(privSetbtn.Location.X-4, privSetbtn.Location.Y);
			//
		}
		void ClosebtnClick(object sender, EventArgs e)
		{
			this.Dispose();
		}
		void Guna2HtmlLabel1Click(object sender, EventArgs e)
		{
			//import settings
		}
		void Guna2Button4Click(object sender, EventArgs e)
		{
			about.BringToFront();
			sel.Hide();
		}
		void Guna2Button3Click(object sender, EventArgs e)
		{
			this.Close();
		}
		void ApplySettingsClick(object sender, EventArgs e)
		{
			//save settings stuff
			this.Close();
		}
		void LinkLabel1LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start("https://www.facebook.com/kmdev.4307");
		}
		void LinkLabel2LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start("https://youtube.com/@ntc_edm");
		}
		void LinkLabel3LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			//discord
			//System.Diagnostics.Process.Start("https://www.facebook.com/kmdev.4307");
		}
	}
}
