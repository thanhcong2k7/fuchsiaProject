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
		public enum Reactions{
			like,
			love,
			haha,
			wow,
			sad,
			angry,
			none
		}
		public Reactions react = Reactions.none;
		public postCont()
		{
			InitializeComponent();
			chose_react.Hide();
			picBox.Location = new Point(captLabel.Location.X + captLabel.Size.Height + 10, (this.Size.Width - picBox.Size.Width)/2);
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
                    picBox.Location = new Point(36,107);
				} else picBox.Hide();
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

		private void captLabel_SizeChanged(object sender, EventArgs e)
		{
			//
		}
		void react_LikeHover(object sender, EventArgs e)
		{
			react_Like.ImageSize = new Size((react_Like.Size.Width/2+7),(react_Like.Size.Height/2+7));
		}
		void react_LikeMouseLeave(object sender, EventArgs e)
		{
			react_Like.ImageSize = new Size((react_Like.Size.Width/2+3),(react_Like.Size.Height/2+3));
		}
		void React_LoveHover(object sender, EventArgs e)
		{
			react_Love.ImageSize = new Size((react_Like.Size.Width/2+7),(react_Like.Size.Height/2+7));
		}
		void React_LoveMouseLeave(object sender, EventArgs e)
		{
			react_Love.ImageSize = new Size((react_Like.Size.Width/2+3),(react_Like.Size.Height/2+3));
		}
		void React_HahaHover(object sender, EventArgs e)
		{
			react_Haha.ImageSize = new Size((react_Like.Size.Width/2+7),(react_Like.Size.Height/2+7));
		}
		void React_HahaMouseLeave(object sender, EventArgs e)
		{
			react_Haha.ImageSize = new Size((react_Like.Size.Width/2+3),(react_Like.Size.Height/2+3));
		}
		void React_SadHover(object sender, EventArgs e)
		{
			react_Sad.ImageSize = new Size((react_Like.Size.Width/2+7),(react_Like.Size.Height/2+7));
		}
		void React_SadMouseLeave(object sender, EventArgs e)
		{
			react_Sad.ImageSize = new Size((react_Like.Size.Width/2+3),(react_Like.Size.Height/2+3));
		}
		void React_WowHover(object sender, EventArgs e)
		{
			react_Wow.ImageSize = new Size((react_Like.Size.Width/2+7),(react_Like.Size.Height/2+7));
		}
		void React_WowMouseLeave(object sender, EventArgs e)
		{
			react_Wow.ImageSize = new Size((react_Like.Size.Width/2+3),(react_Like.Size.Height/2+3));
		}
		void React_AngryHover(object sender, EventArgs e)
		{
			react_Angry.ImageSize = new Size((react_Like.Size.Width/2+7),(react_Like.Size.Height/2+7));
		}
		void React_AngryMouseLeave(object sender, EventArgs e)
		{
			react_Angry.ImageSize = new Size((react_Like.Size.Width/2+3),(react_Like.Size.Height/2+3));
		}
		void react_LikeClick(object sender, EventArgs e)
		{
			if(react == Reactions.none || react != Reactions.like){
				chose_react.Location = new Point(react_Like.Location.X+react_Like.Size.Width/4,react_Like.Size.Height);
				chose_react.Show();
				react = Reactions.like;
				// add/change react stuff
			} else {
				chose_react.Hide();
				react = Reactions.none;
				// remove react stuff
			}
		}
		void React_HahaClick(object sender, EventArgs e)
		{
			if(react == Reactions.none || react != Reactions.haha){
				chose_react.Location = new Point(react_Haha.Location.X+react_Like.Size.Width/4,react_Haha.Size.Height);
				chose_react.Show();
				react = Reactions.haha;
				// add/change react stuff
			} else {
				chose_react.Hide();
				react = Reactions.none;
				// remove react stuff
			}
		}
		void React_LoveClick(object sender, EventArgs e)
		{
			if(react == Reactions.none || react != Reactions.love){
				chose_react.Location = new Point(react_Love.Location.X+react_Like.Size.Width/4,react_Love.Size.Height);
				chose_react.Show();
				react = Reactions.love;
				// add/change react stuff
			} else {
				chose_react.Hide();
				react = Reactions.none;
				// remove react stuff
			}
		}
		void React_SadClick(object sender, EventArgs e)
		{
			if(react == Reactions.none || react != Reactions.sad){
				chose_react.Location = new Point(react_Sad.Location.X+react_Like.Size.Width/4,react_Sad.Size.Height);
				chose_react.Show();
				react = Reactions.sad;
				// add/change react stuff
			} else {
				chose_react.Hide();
				react = Reactions.none;
				// remove react stuff
			}
		}
		void React_AngryClick(object sender, EventArgs e)
		{
			if(react == Reactions.none || react != Reactions.angry){
				chose_react.Location = new Point(react_Angry.Location.X+react_Like.Size.Width/4,react_Angry.Size.Height);
				chose_react.Show();
				react = Reactions.angry;
				// add/change react stuff
			} else {
				chose_react.Hide();
				react = Reactions.none;
				// remove react stuff
			}
		}
		void React_WowClick(object sender, EventArgs e)
		{
			if(react == Reactions.none || react != Reactions.wow) {
				chose_react.Location = new Point(react_Wow.Location.X+react_Like.Size.Width/4,react_Like.Size.Height);
				chose_react.Show();
				react = Reactions.wow;
				// add/change react stuff
			} else {
				chose_react.Hide();
				react = Reactions.none;
				// remove react stuff
			}
		}
		void NameLabelMouseClick(object sender, MouseEventArgs e)
		{
			//open profile stuff
		}
		void PicBoxMouseClick(object sender, MouseEventArgs e)
		{
			(new openImg(picBox.Image)).Show();
		}
	}
}
