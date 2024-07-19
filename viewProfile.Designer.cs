/*
 * Created by SharpDevelop.
 * User: KamyzZ
 * Date: 12/26/2022
 * Time: 9:33 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace fuchsia
{
	partial class viewProfile
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
		private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
		private Guna.UI2.WinForms.Guna2Panel prof;
		private Guna.UI2.WinForms.Guna2PictureBox cover;
		private Guna.UI2.WinForms.Guna2PictureBox avatar;
		private Guna.UI2.WinForms.Guna2Panel titleBar;
		private Guna.UI2.WinForms.Guna2Button guna2Button1;
		private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox3;
		private System.Windows.Forms.Label appName;
		private System.Windows.Forms.FlowLayoutPanel post;
		private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
		private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label handle;
		private System.Windows.Forms.Label label3;
		private Guna.UI2.WinForms.Guna2Button msg;
		private Guna.UI2.WinForms.Guna2Button guna2Button2;
		private Guna.UI2.WinForms.Guna2Button guna2Button4;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private Guna.UI2.WinForms.Guna2Button wb;
		private Guna.UI2.WinForms.Guna2Button fb;
		private Guna.UI2.WinForms.Guna2Button yt;
		private Guna.UI2.WinForms.Guna2Button sc;
		private System.Windows.Forms.Panel postContainer1;
		private System.Windows.Forms.ToolTip handle_tip;
		private fuchsia.postCont postCont1;
		
		/// <summary>
		/// Disposes resources used by the control.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(viewProfile));
			this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
			this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
			this.titleBar = new Guna.UI2.WinForms.Guna2Panel();
			this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
			this.guna2CirclePictureBox3 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
			this.appName = new System.Windows.Forms.Label();
			this.prof = new Guna.UI2.WinForms.Guna2Panel();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.wb = new Guna.UI2.WinForms.Guna2Button();
			this.fb = new Guna.UI2.WinForms.Guna2Button();
			this.yt = new Guna.UI2.WinForms.Guna2Button();
			this.sc = new Guna.UI2.WinForms.Guna2Button();
			this.avatar = new Guna.UI2.WinForms.Guna2PictureBox();
			this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
			this.msg = new Guna.UI2.WinForms.Guna2Button();
			this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
			this.label3 = new System.Windows.Forms.Label();
			this.handle = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.cover = new Guna.UI2.WinForms.Guna2PictureBox();
			this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
			this.postContainer1 = new System.Windows.Forms.Panel();
			this.post = new System.Windows.Forms.FlowLayoutPanel();
			this.postCont1 = new fuchsia.postCont();
			this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
			this.handle_tip = new System.Windows.Forms.ToolTip(this.components);
			this.titleBar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox3)).BeginInit();
			this.prof.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.avatar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cover)).BeginInit();
			this.postContainer1.SuspendLayout();
			this.post.SuspendLayout();
			this.SuspendLayout();
			// 
			// guna2Elipse1
			// 
			this.guna2Elipse1.BorderRadius = 10;
			this.guna2Elipse1.TargetControl = this;
			// 
			// guna2DragControl1
			// 
			this.guna2DragControl1.TargetControl = this.titleBar;
			// 
			// titleBar
			// 
			this.titleBar.BorderColor = System.Drawing.Color.Transparent;
			this.titleBar.BorderRadius = 10;
			this.titleBar.Controls.Add(this.guna2Button1);
			this.titleBar.Controls.Add(this.guna2CirclePictureBox3);
			this.titleBar.Controls.Add(this.appName);
			this.titleBar.Dock = System.Windows.Forms.DockStyle.Top;
			this.titleBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.titleBar.Location = new System.Drawing.Point(0, 0);
			this.titleBar.Name = "titleBar";
			this.titleBar.ShadowDecoration.Parent = this.titleBar;
			this.titleBar.Size = new System.Drawing.Size(938, 30);
			this.titleBar.TabIndex = 12;
			// 
			// guna2Button1
			// 
			this.guna2Button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.guna2Button1.Animated = true;
			this.guna2Button1.AutoRoundedCorners = true;
			this.guna2Button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.guna2Button1.BorderRadius = 10;
			this.guna2Button1.CheckedState.Parent = this.guna2Button1;
			this.guna2Button1.CustomImages.Parent = this.guna2Button1;
			this.guna2Button1.FillColor = System.Drawing.Color.Empty;
			this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.guna2Button1.ForeColor = System.Drawing.Color.White;
			this.guna2Button1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.guna2Button1.HoverState.Parent = this.guna2Button1;
			this.guna2Button1.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button1.Image")));
			this.guna2Button1.ImageSize = new System.Drawing.Size(12, 12);
			this.guna2Button1.Location = new System.Drawing.Point(910, 4);
			this.guna2Button1.Name = "guna2Button1";
			this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
			this.guna2Button1.Size = new System.Drawing.Size(23, 23);
			this.guna2Button1.TabIndex = 1;
			this.guna2Button1.Click += new System.EventHandler(this.ClosebtnClick);
			// 
			// guna2CirclePictureBox3
			// 
			this.guna2CirclePictureBox3.BackColor = System.Drawing.Color.Transparent;
			this.guna2CirclePictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox3.Image")));
			this.guna2CirclePictureBox3.Location = new System.Drawing.Point(7, 5);
			this.guna2CirclePictureBox3.Name = "guna2CirclePictureBox3";
			this.guna2CirclePictureBox3.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
			this.guna2CirclePictureBox3.ShadowDecoration.Parent = this.guna2CirclePictureBox3;
			this.guna2CirclePictureBox3.Size = new System.Drawing.Size(20, 20);
			this.guna2CirclePictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.guna2CirclePictureBox3.TabIndex = 8;
			this.guna2CirclePictureBox3.TabStop = false;
			// 
			// appName
			// 
			this.appName.AutoSize = true;
			this.appName.BackColor = System.Drawing.Color.Transparent;
			this.appName.Font = new System.Drawing.Font("Segoe UI", 8F);
			this.appName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(172)))), ((int)(((byte)(173)))));
			this.appName.Location = new System.Drawing.Point(32, 8);
			this.appName.Name = "appName";
			this.appName.Size = new System.Drawing.Size(139, 13);
			this.appName.TabIndex = 10;
			this.appName.Text = "fuchsia v0.2.031222-alpha";
			// 
			// prof
			// 
			this.prof.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(22)))));
			this.prof.BorderRadius = 10;
			this.prof.Controls.Add(this.flowLayoutPanel1);
			this.prof.Controls.Add(this.avatar);
			this.prof.Controls.Add(this.guna2Button4);
			this.prof.Controls.Add(this.msg);
			this.prof.Controls.Add(this.guna2Button2);
			this.prof.Controls.Add(this.label3);
			this.prof.Controls.Add(this.handle);
			this.prof.Controls.Add(this.label1);
			this.prof.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(37)))));
			this.prof.Location = new System.Drawing.Point(32, 77);
			this.prof.Margin = new System.Windows.Forms.Padding(2);
			this.prof.Name = "prof";
			this.prof.ShadowDecoration.Parent = this.prof;
			this.prof.Size = new System.Drawing.Size(270, 376);
			this.prof.TabIndex = 11;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(37)))));
			this.flowLayoutPanel1.Controls.Add(this.wb);
			this.flowLayoutPanel1.Controls.Add(this.fb);
			this.flowLayoutPanel1.Controls.Add(this.yt);
			this.flowLayoutPanel1.Controls.Add(this.sc);
			this.flowLayoutPanel1.Location = new System.Drawing.Point(11, 135);
			this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(248, 191);
			this.flowLayoutPanel1.TabIndex = 17;
			// 
			// wb
			// 
			this.wb.Animated = true;
			this.wb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(37)))));
			this.wb.BorderRadius = 10;
			this.wb.CheckedState.Parent = this.wb;
			this.wb.CustomImages.Parent = this.wb;
			this.wb.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(43)))), ((int)(((byte)(44)))));
			this.wb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.wb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
			this.wb.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.wb.HoverState.Parent = this.wb;
			this.wb.Image = ((System.Drawing.Image)(resources.GetObject("wb.Image")));
			this.wb.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.wb.ImageSize = new System.Drawing.Size(23, 23);
			this.wb.Location = new System.Drawing.Point(2, 2);
			this.wb.Margin = new System.Windows.Forms.Padding(2);
			this.wb.Name = "wb";
			this.wb.ShadowDecoration.Parent = this.wb;
			this.wb.Size = new System.Drawing.Size(245, 26);
			this.wb.TabIndex = 15;
			this.wb.Text = "linktr.ee/kamyzz";
			this.wb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.wb.TextOffset = new System.Drawing.Point(5, 0);
			// 
			// fb
			// 
			this.fb.Animated = true;
			this.fb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(37)))));
			this.fb.BorderRadius = 10;
			this.fb.CheckedState.Parent = this.fb;
			this.fb.CustomImages.Parent = this.fb;
			this.fb.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(43)))), ((int)(((byte)(44)))));
			this.fb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.fb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
			this.fb.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.fb.HoverState.Parent = this.fb;
			this.fb.Image = ((System.Drawing.Image)(resources.GetObject("fb.Image")));
			this.fb.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.fb.ImageSize = new System.Drawing.Size(23, 23);
			this.fb.Location = new System.Drawing.Point(2, 32);
			this.fb.Margin = new System.Windows.Forms.Padding(2);
			this.fb.Name = "fb";
			this.fb.ShadowDecoration.Parent = this.fb;
			this.fb.Size = new System.Drawing.Size(245, 26);
			this.fb.TabIndex = 16;
			this.fb.Text = "kmdev.4307";
			this.fb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.fb.TextOffset = new System.Drawing.Point(5, 0);
			// 
			// yt
			// 
			this.yt.Animated = true;
			this.yt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(37)))));
			this.yt.BorderRadius = 10;
			this.yt.CheckedState.Parent = this.yt;
			this.yt.CustomImages.Parent = this.yt;
			this.yt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(43)))), ((int)(((byte)(44)))));
			this.yt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.yt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
			this.yt.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.yt.HoverState.Parent = this.yt;
			this.yt.Image = ((System.Drawing.Image)(resources.GetObject("yt.Image")));
			this.yt.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.yt.ImageSize = new System.Drawing.Size(23, 23);
			this.yt.Location = new System.Drawing.Point(2, 62);
			this.yt.Margin = new System.Windows.Forms.Padding(2);
			this.yt.Name = "yt";
			this.yt.ShadowDecoration.Parent = this.yt;
			this.yt.Size = new System.Drawing.Size(245, 26);
			this.yt.TabIndex = 17;
			this.yt.Text = "@ntc_edm";
			this.yt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.yt.TextOffset = new System.Drawing.Point(5, 0);
			// 
			// sc
			// 
			this.sc.Animated = true;
			this.sc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(37)))));
			this.sc.BorderRadius = 10;
			this.sc.CheckedState.Parent = this.sc;
			this.sc.CustomImages.Parent = this.sc;
			this.sc.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(43)))), ((int)(((byte)(44)))));
			this.sc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.sc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
			this.sc.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.sc.HoverState.Parent = this.sc;
			this.sc.Image = ((System.Drawing.Image)(resources.GetObject("sc.Image")));
			this.sc.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.sc.ImageSize = new System.Drawing.Size(23, 23);
			this.sc.Location = new System.Drawing.Point(2, 92);
			this.sc.Margin = new System.Windows.Forms.Padding(2);
			this.sc.Name = "sc";
			this.sc.ShadowDecoration.Parent = this.sc;
			this.sc.Size = new System.Drawing.Size(245, 26);
			this.sc.TabIndex = 18;
			this.sc.Text = "kmrcs";
			this.sc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.sc.TextOffset = new System.Drawing.Point(5, 0);
			// 
			// avatar
			// 
			this.avatar.AutoRoundedCorners = true;
			this.avatar.BackColor = System.Drawing.Color.Transparent;
			this.avatar.BorderRadius = 30;
			this.avatar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.avatar.Image = ((System.Drawing.Image)(resources.GetObject("avatar.Image")));
			this.avatar.Location = new System.Drawing.Point(13, 15);
			this.avatar.Margin = new System.Windows.Forms.Padding(2);
			this.avatar.Name = "avatar";
			this.avatar.ShadowDecoration.Parent = this.avatar;
			this.avatar.Size = new System.Drawing.Size(62, 67);
			this.avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.avatar.TabIndex = 0;
			this.avatar.TabStop = false;
			// 
			// guna2Button4
			// 
			this.guna2Button4.Animated = true;
			this.guna2Button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(37)))));
			this.guna2Button4.BorderRadius = 10;
			this.guna2Button4.CheckedState.Parent = this.guna2Button4;
			this.guna2Button4.CustomImages.Parent = this.guna2Button4;
			this.guna2Button4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(43)))), ((int)(((byte)(44)))));
			this.guna2Button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guna2Button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.guna2Button4.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.guna2Button4.HoverState.Parent = this.guna2Button4;
			this.guna2Button4.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button4.Image")));
			this.guna2Button4.ImageSize = new System.Drawing.Size(25, 25);
			this.guna2Button4.Location = new System.Drawing.Point(184, 331);
			this.guna2Button4.Margin = new System.Windows.Forms.Padding(2);
			this.guna2Button4.Name = "guna2Button4";
			this.guna2Button4.ShadowDecoration.Parent = this.guna2Button4;
			this.guna2Button4.Size = new System.Drawing.Size(75, 33);
			this.guna2Button4.TabIndex = 16;
			this.handle_tip.SetToolTip(this.guna2Button4, "Share this profile!");
			// 
			// msg
			// 
			this.msg.Animated = true;
			this.msg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(37)))));
			this.msg.BorderRadius = 10;
			this.msg.CheckedState.Parent = this.msg;
			this.msg.CustomImages.Parent = this.msg;
			this.msg.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(43)))), ((int)(((byte)(44)))));
			this.msg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.msg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.msg.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.msg.HoverState.Parent = this.msg;
			this.msg.Image = ((System.Drawing.Image)(resources.GetObject("msg.Image")));
			this.msg.ImageSize = new System.Drawing.Size(25, 25);
			this.msg.Location = new System.Drawing.Point(98, 331);
			this.msg.Margin = new System.Windows.Forms.Padding(2);
			this.msg.Name = "msg";
			this.msg.ShadowDecoration.Parent = this.msg;
			this.msg.Size = new System.Drawing.Size(75, 33);
			this.msg.TabIndex = 15;
			this.handle_tip.SetToolTip(this.msg, "Message");
			// 
			// guna2Button2
			// 
			this.guna2Button2.Animated = true;
			this.guna2Button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(37)))));
			this.guna2Button2.BorderRadius = 10;
			this.guna2Button2.CheckedState.Parent = this.guna2Button2;
			this.guna2Button2.CustomImages.Parent = this.guna2Button2;
			this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(43)))), ((int)(((byte)(44)))));
			this.guna2Button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guna2Button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.guna2Button2.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.guna2Button2.HoverState.Parent = this.guna2Button2;
			this.guna2Button2.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button2.Image")));
			this.guna2Button2.ImageSize = new System.Drawing.Size(25, 25);
			this.guna2Button2.Location = new System.Drawing.Point(11, 331);
			this.guna2Button2.Margin = new System.Windows.Forms.Padding(2);
			this.guna2Button2.Name = "guna2Button2";
			this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
			this.guna2Button2.Size = new System.Drawing.Size(75, 33);
			this.guna2Button2.TabIndex = 14;
			this.handle_tip.SetToolTip(this.guna2Button2, "Add as friend");
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
			this.label3.Location = new System.Drawing.Point(13, 88);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(248, 45);
			this.label3.TabIndex = 13;
			this.label3.Text = "Just a 15-year-old dev.";
			this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// handle
			// 
			this.handle.BackColor = System.Drawing.Color.Transparent;
			this.handle.Cursor = System.Windows.Forms.Cursors.Hand;
			this.handle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.handle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
			this.handle.Location = new System.Drawing.Point(83, 51);
			this.handle.Name = "handle";
			this.handle.Size = new System.Drawing.Size(176, 16);
			this.handle.TabIndex = 12;
			this.handle.Text = "@admin";
			this.handle.Click += new System.EventHandler(this.Label2Click);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
			this.label1.Location = new System.Drawing.Point(80, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(191, 33);
			this.label1.TabIndex = 11;
			this.label1.Text = "Nguyen Thanh Cong";
			// 
			// cover
			// 
			this.cover.Dock = System.Windows.Forms.DockStyle.Top;
			this.cover.Image = ((System.Drawing.Image)(resources.GetObject("cover.Image")));
			this.cover.Location = new System.Drawing.Point(0, 30);
			this.cover.Margin = new System.Windows.Forms.Padding(2);
			this.cover.Name = "cover";
			this.cover.ShadowDecoration.Parent = this.cover;
			this.cover.Size = new System.Drawing.Size(938, 115);
			this.cover.TabIndex = 0;
			this.cover.TabStop = false;
			// 
			// guna2Elipse2
			// 
			this.guna2Elipse2.BorderRadius = 10;
			this.guna2Elipse2.TargetControl = this.postContainer1;
			// 
			// postContainer1
			// 
			this.postContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(37)))));
			this.postContainer1.Controls.Add(this.post);
			this.postContainer1.Location = new System.Drawing.Point(351, 77);
			this.postContainer1.Margin = new System.Windows.Forms.Padding(2);
			this.postContainer1.Name = "postContainer1";
			this.postContainer1.Size = new System.Drawing.Size(554, 474);
			this.postContainer1.TabIndex = 13;
			// 
			// post
			// 
			this.post.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(37)))));
			this.post.Controls.Add(this.postCont1);
			this.post.Location = new System.Drawing.Point(12, 12);
			this.post.Margin = new System.Windows.Forms.Padding(2);
			this.post.Name = "post";
			this.post.Size = new System.Drawing.Size(530, 459);
			this.post.TabIndex = 14;
			// 
			// postCont1
			// 
			this.postCont1.avatar = null;
			this.postCont1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
			this.postCont1.caption = null;
			this.postCont1.dateposted = null;
			this.postCont1.imgPost = null;
			this.postCont1.Location = new System.Drawing.Point(3, 3);
			this.postCont1.name = null;
			this.postCont1.Name = "postCont1";
			this.postCont1.Size = new System.Drawing.Size(500, 173);
			this.postCont1.TabIndex = 3;
			this.postCont1.userWatchingID = null;
			// 
			// guna2Elipse3
			// 
			this.guna2Elipse3.BorderRadius = 10;
			this.guna2Elipse3.TargetControl = this.prof;
			// 
			// handle_tip
			// 
			this.handle_tip.AutoPopDelay = 5000;
			this.handle_tip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
			this.handle_tip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
			this.handle_tip.InitialDelay = 200;
			this.handle_tip.ReshowDelay = 100;
			// 
			// viewProfile
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(22)))));
			this.ClientSize = new System.Drawing.Size(938, 580);
			this.Controls.Add(this.postContainer1);
			this.Controls.Add(this.prof);
			this.Controls.Add(this.cover);
			this.Controls.Add(this.titleBar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "viewProfile";
			this.titleBar.ResumeLayout(false);
			this.titleBar.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox3)).EndInit();
			this.prof.ResumeLayout(false);
			this.flowLayoutPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.avatar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cover)).EndInit();
			this.postContainer1.ResumeLayout(false);
			this.post.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}