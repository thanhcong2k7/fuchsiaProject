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
	public partial class postCont : UserControl
	{
		public postCont()
		{
			InitializeComponent();
		}
		public string _caption;
		public string caption
		{
			get
			{
				return _caption;
			}
			set
			{
				_caption = value;
				captLabel.Text = value;
			}
		}
		public string _name;
		public string name
		{
			get
			{
				return _name;
			}
			set
			{
				_name = value;
				nameLabel.Text = value;
			}
		}
		public string _dateposted;
		public string dateposted
		{
			get
			{
				return _dateposted;
			}
			set
			{
				_dateposted = value;
				datePosted.Text = value;
			}
		}
		public string _userWatchingID;
		public string userWatchingID
		{
			get
			{
				return _userWatchingID;
			}
			set
			{
				_userWatchingID = value;
			}
		}
		//max image height = 400
		public Image _imgPost;
		public Image imgPost
		{
			get
			{
				return _imgPost;
			}
			set
			{
				_imgPost = value;
				if (value != null)
				{
					picBox.Image = value;
					if (value.Height < 350)
					{
						picBox.Height = value.Height;
					}
					else
					{
						picBox.Height = 350;
					}
					this.Height += picBox.Height;
					//captLabel.Font.Size = 13;
					Font fnt = new Font("Segoe UI", 13);
					captLabel.Font = fnt;
				}
			}
		}

		private void picBox_MouseEnter(object sender, EventArgs e)
		{
			picBox.FillColor = Color.FromArgb(55,57,58);
		}

		private void picBox_MouseLeave(object sender, EventArgs e)
		{
			picBox.FillColor = Color.Transparent;
		}
	}
}
