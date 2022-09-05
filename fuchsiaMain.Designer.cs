
namespace fuchsia
{
	partial class fuchsiaMain
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fuchsiaMain));
			this.navBar = new Guna.UI2.WinForms.Guna2Panel();
			this.titleBar = new Guna.UI2.WinForms.Guna2Panel();
			this.appName = new System.Windows.Forms.Label();
			this.closeBtn = new Guna.UI2.WinForms.Guna2Button();
			this.settings = new Guna.UI2.WinForms.Guna2Button();
			this.infoBtn = new Guna.UI2.WinForms.Guna2Button();
			this.notiBtn = new Guna.UI2.WinForms.Guna2Button();
			this.msgBtn = new Guna.UI2.WinForms.Guna2Button();
			this.uidCtrl = new System.Windows.Forms.Label();
			this.nameTxt = new System.Windows.Forms.Label();
			this.homeBtn = new Guna.UI2.WinForms.Guna2Button();
			this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
			this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
			this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
			this.postContainer = new Guna.UI2.WinForms.Guna2Panel();
			this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
			this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
			this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
			this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
			this.guna2CirclePictureBox2 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
			this.postBtn = new Guna.UI2.WinForms.Guna2Button();
			this.captionInput = new Guna.UI2.WinForms.Guna2TextBox();
			this.guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
			this.guna2DragControl3 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
			this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
			this.guna2CirclePictureBox3 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
			this.navBar.SuspendLayout();
			this.titleBar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
			this.guna2Panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox3)).BeginInit();
			this.SuspendLayout();
			// 
			// navBar
			// 
			this.navBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.navBar.BackColor = System.Drawing.Color.Transparent;
			this.navBar.BorderRadius = 10;
			this.navBar.Controls.Add(this.infoBtn);
			this.navBar.Controls.Add(this.settings);
			this.navBar.Controls.Add(this.notiBtn);
			this.navBar.Controls.Add(this.msgBtn);
			this.navBar.Controls.Add(this.uidCtrl);
			this.navBar.Controls.Add(this.nameTxt);
			this.navBar.Controls.Add(this.homeBtn);
			this.navBar.Controls.Add(this.guna2Button1);
			this.navBar.Controls.Add(this.guna2CirclePictureBox1);
			this.navBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
			this.navBar.Location = new System.Drawing.Point(14, 43);
			this.navBar.Name = "navBar";
			this.navBar.ShadowDecoration.Parent = this.navBar;
			this.navBar.Size = new System.Drawing.Size(231, 709);
			this.navBar.TabIndex = 0;
			// 
			// titleBar
			// 
			this.titleBar.BorderColor = System.Drawing.Color.Transparent;
			this.titleBar.BorderRadius = 10;
			this.titleBar.Controls.Add(this.guna2CirclePictureBox3);
			this.titleBar.Controls.Add(this.appName);
			this.titleBar.Controls.Add(this.closeBtn);
			this.titleBar.Dock = System.Windows.Forms.DockStyle.Top;
			this.titleBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.titleBar.Location = new System.Drawing.Point(0, 0);
			this.titleBar.Name = "titleBar";
			this.titleBar.ShadowDecoration.Parent = this.titleBar;
			this.titleBar.Size = new System.Drawing.Size(1375, 30);
			this.titleBar.TabIndex = 9;
			// 
			// appName
			// 
			this.appName.AutoSize = true;
			this.appName.BackColor = System.Drawing.Color.Transparent;
			this.appName.Font = new System.Drawing.Font("Segoe UI", 8F);
			this.appName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(172)))), ((int)(((byte)(173)))));
			this.appName.Location = new System.Drawing.Point(32, 8);
			this.appName.Name = "appName";
			this.appName.Size = new System.Drawing.Size(133, 13);
			this.appName.TabIndex = 10;
			this.appName.Text = "fuchsia v0.1.31822-alpha";
			// 
			// closeBtn
			// 
			this.closeBtn.AutoRoundedCorners = true;
			this.closeBtn.BorderRadius = 5;
			this.closeBtn.CheckedState.Parent = this.closeBtn;
			this.closeBtn.CustomImages.Parent = this.closeBtn;
			this.closeBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.closeBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.closeBtn.ForeColor = System.Drawing.Color.White;
			this.closeBtn.HoverState.Parent = this.closeBtn;
			this.closeBtn.Location = new System.Drawing.Point(1351, 10);
			this.closeBtn.Name = "closeBtn";
			this.closeBtn.ShadowDecoration.Parent = this.closeBtn;
			this.closeBtn.Size = new System.Drawing.Size(12, 12);
			this.closeBtn.TabIndex = 1;
			this.closeBtn.Text = "guna2Button2";
			this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
			// 
			// settings
			// 
			this.settings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.settings.BackColor = System.Drawing.Color.Transparent;
			this.settings.BorderRadius = 10;
			this.settings.CheckedState.Parent = this.settings;
			this.settings.CustomImages.Parent = this.settings;
			this.settings.FillColor = System.Drawing.Color.Transparent;
			this.settings.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.settings.ForeColor = System.Drawing.Color.White;
			this.settings.HoverState.Parent = this.settings;
			this.settings.Image = ((System.Drawing.Image)(resources.GetObject("settings.Image")));
			this.settings.ImageSize = new System.Drawing.Size(15, 15);
			this.settings.Location = new System.Drawing.Point(186, 93);
			this.settings.Name = "settings";
			this.settings.ShadowDecoration.Parent = this.settings;
			this.settings.Size = new System.Drawing.Size(20, 20);
			this.settings.TabIndex = 0;
			// 
			// infoBtn
			// 
			this.infoBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.infoBtn.BackColor = System.Drawing.Color.Transparent;
			this.infoBtn.BorderRadius = 10;
			this.infoBtn.CheckedState.Parent = this.infoBtn;
			this.infoBtn.CustomImages.Parent = this.infoBtn;
			this.infoBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(77)))), ((int)(((byte)(78)))));
			this.infoBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.infoBtn.ForeColor = System.Drawing.Color.White;
			this.infoBtn.HoverState.Parent = this.infoBtn;
			this.infoBtn.Image = ((System.Drawing.Image)(resources.GetObject("infoBtn.Image")));
			this.infoBtn.ImageSize = new System.Drawing.Size(23, 23);
			this.infoBtn.Location = new System.Drawing.Point(13, 646);
			this.infoBtn.Name = "infoBtn";
			this.infoBtn.ShadowDecoration.Parent = this.infoBtn;
			this.infoBtn.Size = new System.Drawing.Size(45, 45);
			this.infoBtn.TabIndex = 7;
			this.infoBtn.Click += new System.EventHandler(this.infoBtn_Click);
			// 
			// notiBtn
			// 
			this.notiBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.notiBtn.Animated = true;
			this.notiBtn.BackColor = System.Drawing.Color.Transparent;
			this.notiBtn.BorderRadius = 10;
			this.notiBtn.CheckedState.Parent = this.notiBtn;
			this.notiBtn.CustomImages.Parent = this.notiBtn;
			this.notiBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(77)))), ((int)(((byte)(78)))));
			this.notiBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.notiBtn.ForeColor = System.Drawing.Color.White;
			this.notiBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(1)))), ((int)(((byte)(116)))));
			this.notiBtn.HoverState.Parent = this.notiBtn;
			this.notiBtn.Image = ((System.Drawing.Image)(resources.GetObject("notiBtn.Image")));
			this.notiBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.notiBtn.Location = new System.Drawing.Point(11, 258);
			this.notiBtn.Name = "notiBtn";
			this.notiBtn.ShadowDecoration.Parent = this.notiBtn;
			this.notiBtn.Size = new System.Drawing.Size(205, 45);
			this.notiBtn.TabIndex = 6;
			this.notiBtn.Text = "Thông báo";
			this.notiBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// msgBtn
			// 
			this.msgBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.msgBtn.Animated = true;
			this.msgBtn.BackColor = System.Drawing.Color.Transparent;
			this.msgBtn.BorderRadius = 10;
			this.msgBtn.CheckedState.Parent = this.msgBtn;
			this.msgBtn.CustomImages.Parent = this.msgBtn;
			this.msgBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(77)))), ((int)(((byte)(78)))));
			this.msgBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.msgBtn.ForeColor = System.Drawing.Color.White;
			this.msgBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(1)))), ((int)(((byte)(116)))));
			this.msgBtn.HoverState.Parent = this.msgBtn;
			this.msgBtn.Image = ((System.Drawing.Image)(resources.GetObject("msgBtn.Image")));
			this.msgBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.msgBtn.Location = new System.Drawing.Point(11, 207);
			this.msgBtn.Name = "msgBtn";
			this.msgBtn.ShadowDecoration.Parent = this.msgBtn;
			this.msgBtn.Size = new System.Drawing.Size(205, 45);
			this.msgBtn.TabIndex = 5;
			this.msgBtn.Text = "Tin nhắn";
			this.msgBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// uidCtrl
			// 
			this.uidCtrl.AutoSize = true;
			this.uidCtrl.BackColor = System.Drawing.Color.Transparent;
			this.uidCtrl.Font = new System.Drawing.Font("Segoe UI", 8F);
			this.uidCtrl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(172)))), ((int)(((byte)(173)))));
			this.uidCtrl.Location = new System.Drawing.Point(66, 45);
			this.uidCtrl.Name = "uidCtrl";
			this.uidCtrl.Size = new System.Drawing.Size(104, 13);
			this.uidCtrl.TabIndex = 4;
			this.uidCtrl.Text = "User ID: 000000001";
			// 
			// nameTxt
			// 
			this.nameTxt.AutoSize = true;
			this.nameTxt.BackColor = System.Drawing.Color.Transparent;
			this.nameTxt.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nameTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(222)))), ((int)(((byte)(223)))));
			this.nameTxt.Location = new System.Drawing.Point(62, 19);
			this.nameTxt.Name = "nameTxt";
			this.nameTxt.Size = new System.Drawing.Size(111, 23);
			this.nameTxt.TabIndex = 3;
			this.nameTxt.Text = "Test_user001";
			// 
			// homeBtn
			// 
			this.homeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.homeBtn.Animated = true;
			this.homeBtn.BackColor = System.Drawing.Color.Transparent;
			this.homeBtn.BorderRadius = 10;
			this.homeBtn.CheckedState.Parent = this.homeBtn;
			this.homeBtn.CustomImages.Parent = this.homeBtn;
			this.homeBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(77)))), ((int)(((byte)(78)))));
			this.homeBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.homeBtn.ForeColor = System.Drawing.Color.White;
			this.homeBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(1)))), ((int)(((byte)(116)))));
			this.homeBtn.HoverState.Parent = this.homeBtn;
			this.homeBtn.Image = ((System.Drawing.Image)(resources.GetObject("homeBtn.Image")));
			this.homeBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.homeBtn.Location = new System.Drawing.Point(11, 156);
			this.homeBtn.Name = "homeBtn";
			this.homeBtn.ShadowDecoration.Parent = this.homeBtn;
			this.homeBtn.Size = new System.Drawing.Size(205, 45);
			this.homeBtn.TabIndex = 1;
			this.homeBtn.Text = "Trang chủ";
			this.homeBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// guna2Button1
			// 
			this.guna2Button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.guna2Button1.Animated = true;
			this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
			this.guna2Button1.BorderRadius = 10;
			this.guna2Button1.CheckedState.Parent = this.guna2Button1;
			this.guna2Button1.CustomImages.Parent = this.guna2Button1;
			this.guna2Button1.FillColor = System.Drawing.Color.Transparent;
			this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.guna2Button1.ForeColor = System.Drawing.Color.White;
			this.guna2Button1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(1)))), ((int)(((byte)(126)))));
			this.guna2Button1.HoverState.Parent = this.guna2Button1;
			this.guna2Button1.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button1.Image")));
			this.guna2Button1.ImageSize = new System.Drawing.Size(17, 17);
			this.guna2Button1.Location = new System.Drawing.Point(186, 40);
			this.guna2Button1.Name = "guna2Button1";
			this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
			this.guna2Button1.Size = new System.Drawing.Size(30, 30);
			this.guna2Button1.TabIndex = 2;
			this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
			// 
			// guna2CirclePictureBox1
			// 
			this.guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.guna2CirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox1.Image")));
			this.guna2CirclePictureBox1.Location = new System.Drawing.Point(13, 20);
			this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
			this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
			this.guna2CirclePictureBox1.ShadowDecoration.Parent = this.guna2CirclePictureBox1;
			this.guna2CirclePictureBox1.Size = new System.Drawing.Size(45, 45);
			this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.guna2CirclePictureBox1.TabIndex = 1;
			this.guna2CirclePictureBox1.TabStop = false;
			// 
			// guna2DragControl1
			// 
			this.guna2DragControl1.TargetControl = this.navBar;
			// 
			// postContainer
			// 
			this.postContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.postContainer.Location = new System.Drawing.Point(272, 150);
			this.postContainer.Name = "postContainer";
			this.postContainer.ShadowDecoration.Parent = this.postContainer;
			this.postContainer.Size = new System.Drawing.Size(833, 602);
			this.postContainer.TabIndex = 2;
			// 
			// guna2Panel2
			// 
			this.guna2Panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.guna2Panel2.BorderRadius = 15;
			this.guna2Panel2.Controls.Add(this.guna2Button2);
			this.guna2Panel2.Controls.Add(this.guna2Button3);
			this.guna2Panel2.Controls.Add(this.guna2Button4);
			this.guna2Panel2.Controls.Add(this.guna2CirclePictureBox2);
			this.guna2Panel2.Controls.Add(this.postBtn);
			this.guna2Panel2.Controls.Add(this.captionInput);
			this.guna2Panel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
			this.guna2Panel2.Location = new System.Drawing.Point(272, 43);
			this.guna2Panel2.Name = "guna2Panel2";
			this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
			this.guna2Panel2.Size = new System.Drawing.Size(833, 101);
			this.guna2Panel2.TabIndex = 1;
			// 
			// guna2Button2
			// 
			this.guna2Button2.BackColor = System.Drawing.Color.Transparent;
			this.guna2Button2.BorderRadius = 5;
			this.guna2Button2.CheckedState.Parent = this.guna2Button2;
			this.guna2Button2.CustomImages.Parent = this.guna2Button2;
			this.guna2Button2.FillColor = System.Drawing.Color.Transparent;
			this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.guna2Button2.ForeColor = System.Drawing.Color.White;
			this.guna2Button2.HoverState.Parent = this.guna2Button2;
			this.guna2Button2.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button2.Image")));
			this.guna2Button2.ImageSize = new System.Drawing.Size(18, 18);
			this.guna2Button2.Location = new System.Drawing.Point(18, 58);
			this.guna2Button2.Name = "guna2Button2";
			this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
			this.guna2Button2.Size = new System.Drawing.Size(30, 30);
			this.guna2Button2.TabIndex = 0;
			// 
			// guna2Button3
			// 
			this.guna2Button3.BackColor = System.Drawing.Color.Transparent;
			this.guna2Button3.BorderRadius = 5;
			this.guna2Button3.CheckedState.Parent = this.guna2Button3;
			this.guna2Button3.CustomImages.Parent = this.guna2Button3;
			this.guna2Button3.FillColor = System.Drawing.Color.Transparent;
			this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.guna2Button3.ForeColor = System.Drawing.Color.White;
			this.guna2Button3.HoverState.Parent = this.guna2Button3;
			this.guna2Button3.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button3.Image")));
			this.guna2Button3.ImageSize = new System.Drawing.Size(18, 18);
			this.guna2Button3.Location = new System.Drawing.Point(54, 58);
			this.guna2Button3.Name = "guna2Button3";
			this.guna2Button3.ShadowDecoration.Parent = this.guna2Button3;
			this.guna2Button3.Size = new System.Drawing.Size(30, 30);
			this.guna2Button3.TabIndex = 1;
			// 
			// guna2Button4
			// 
			this.guna2Button4.BackColor = System.Drawing.Color.Transparent;
			this.guna2Button4.BorderRadius = 5;
			this.guna2Button4.CheckedState.Parent = this.guna2Button4;
			this.guna2Button4.CustomImages.Parent = this.guna2Button4;
			this.guna2Button4.FillColor = System.Drawing.Color.Transparent;
			this.guna2Button4.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.guna2Button4.ForeColor = System.Drawing.Color.White;
			this.guna2Button4.HoverState.Parent = this.guna2Button4;
			this.guna2Button4.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button4.Image")));
			this.guna2Button4.ImageSize = new System.Drawing.Size(18, 18);
			this.guna2Button4.Location = new System.Drawing.Point(90, 58);
			this.guna2Button4.Name = "guna2Button4";
			this.guna2Button4.ShadowDecoration.Parent = this.guna2Button4;
			this.guna2Button4.Size = new System.Drawing.Size(30, 30);
			this.guna2Button4.TabIndex = 2;
			// 
			// guna2CirclePictureBox2
			// 
			this.guna2CirclePictureBox2.BackColor = System.Drawing.Color.Transparent;
			this.guna2CirclePictureBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(50)))), ((int)(((byte)(136)))));
			this.guna2CirclePictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox2.Image")));
			this.guna2CirclePictureBox2.Location = new System.Drawing.Point(10, 9);
			this.guna2CirclePictureBox2.Name = "guna2CirclePictureBox2";
			this.guna2CirclePictureBox2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
			this.guna2CirclePictureBox2.ShadowDecoration.Parent = this.guna2CirclePictureBox2;
			this.guna2CirclePictureBox2.Size = new System.Drawing.Size(38, 38);
			this.guna2CirclePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.guna2CirclePictureBox2.TabIndex = 7;
			this.guna2CirclePictureBox2.TabStop = false;
			// 
			// postBtn
			// 
			this.postBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.postBtn.Animated = true;
			this.postBtn.BackColor = System.Drawing.Color.Transparent;
			this.postBtn.BorderRadius = 10;
			this.postBtn.CheckedState.Parent = this.postBtn;
			this.postBtn.CustomImages.Parent = this.postBtn;
			this.postBtn.Enabled = false;
			this.postBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(0)))), ((int)(((byte)(106)))));
			this.postBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.postBtn.ForeColor = System.Drawing.Color.White;
			this.postBtn.HoverState.Parent = this.postBtn;
			this.postBtn.Location = new System.Drawing.Point(736, 9);
			this.postBtn.Name = "postBtn";
			this.postBtn.ShadowDecoration.Parent = this.postBtn;
			this.postBtn.Size = new System.Drawing.Size(85, 38);
			this.postBtn.TabIndex = 0;
			this.postBtn.Text = "Đăng";
			this.postBtn.Click += new System.EventHandler(this.postBtn_Click);
			// 
			// captionInput
			// 
			this.captionInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.captionInput.BackColor = System.Drawing.Color.Transparent;
			this.captionInput.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
			this.captionInput.BorderRadius = 15;
			this.captionInput.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.captionInput.DefaultText = "";
			this.captionInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.captionInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.captionInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.captionInput.DisabledState.Parent = this.captionInput;
			this.captionInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.captionInput.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
			this.captionInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.captionInput.FocusedState.Parent = this.captionInput;
			this.captionInput.ForeColor = System.Drawing.Color.White;
			this.captionInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.captionInput.HoverState.Parent = this.captionInput;
			this.captionInput.Location = new System.Drawing.Point(52, 9);
			this.captionInput.Name = "captionInput";
			this.captionInput.PasswordChar = '\0';
			this.captionInput.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
			this.captionInput.PlaceholderText = "Hãy chia sẻ những suy nghĩ của bạn với mọi người nhé!";
			this.captionInput.SelectedText = "";
			this.captionInput.ShadowDecoration.Parent = this.captionInput;
			this.captionInput.Size = new System.Drawing.Size(678, 38);
			this.captionInput.TabIndex = 0;
			this.captionInput.TextOffset = new System.Drawing.Point(5, 0);
			this.captionInput.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
			// 
			// guna2DragControl2
			// 
			this.guna2DragControl2.TargetControl = this.appName;
			// 
			// guna2DragControl3
			// 
			this.guna2DragControl3.TargetControl = this.titleBar;
			// 
			// guna2Panel1
			// 
			this.guna2Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
			this.guna2Panel1.BorderRadius = 10;
			this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
			this.guna2Panel1.Location = new System.Drawing.Point(1132, 43);
			this.guna2Panel1.Name = "guna2Panel1";
			this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
			this.guna2Panel1.Size = new System.Drawing.Size(231, 709);
			this.guna2Panel1.TabIndex = 10;
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
			// fuchsiaMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(27)))));
			this.ClientSize = new System.Drawing.Size(1375, 764);
			this.Controls.Add(this.titleBar);
			this.Controls.Add(this.guna2Panel1);
			this.Controls.Add(this.postContainer);
			this.Controls.Add(this.guna2Panel2);
			this.Controls.Add(this.navBar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "fuchsiaMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "fuchsia";
			this.navBar.ResumeLayout(false);
			this.navBar.PerformLayout();
			this.titleBar.ResumeLayout(false);
			this.titleBar.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
			this.guna2Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox3)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Guna.UI2.WinForms.Guna2Panel navBar;
		private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
		private Guna.UI2.WinForms.Guna2Button homeBtn;
		private Guna.UI2.WinForms.Guna2Button guna2Button1;
		private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
		private System.Windows.Forms.Label nameTxt;
		private System.Windows.Forms.Label uidCtrl;
		private Guna.UI2.WinForms.Guna2Button msgBtn;
		private Guna.UI2.WinForms.Guna2Button notiBtn;
		private Guna.UI2.WinForms.Guna2Panel postContainer;
		private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
		private Guna.UI2.WinForms.Guna2Button settings;
		private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox2;
		private Guna.UI2.WinForms.Guna2TextBox captionInput;
		private Guna.UI2.WinForms.Guna2Button postBtn;
		private Guna.UI2.WinForms.Guna2Button infoBtn;
		private Guna.UI2.WinForms.Guna2Panel titleBar;
		private Guna.UI2.WinForms.Guna2Button closeBtn;
		private System.Windows.Forms.Label appName;
		private Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;
		private Guna.UI2.WinForms.Guna2DragControl guna2DragControl3;
		private Guna.UI2.WinForms.Guna2Button guna2Button2;
		private Guna.UI2.WinForms.Guna2Button guna2Button4;
		private Guna.UI2.WinForms.Guna2Button guna2Button3;
		private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
		private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox3;
	}
}

