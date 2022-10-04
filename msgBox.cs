using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace fuchsia
{
	public partial class msgBox : Form
	{
		public msgBox(string notif)
		{
			InitializeComponent();
			msgTxt = notif;
		}
		private string _msgTxt = "";
		public string msgTxt
		{
			get
			{
				return _msgTxt;
			}
			set
			{
				_msgTxt = value;
				msgCtrl.Text = value;
			}
		}

		private void guna2Button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void guna2Button2_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
