/*
 * Created by SharpDevelop.
 * User: KamyzZ
 * Date: 12/13/2022
 * Time: 10:05 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace fuchsia
{
	partial class openImg
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
		private Guna.UI2.WinForms.Guna2Panel titleBar;
		private Guna.UI2.WinForms.Guna2Button minimizeBtn;
		private Guna.UI2.WinForms.Guna2Button maximizeBtn;
		private Guna.UI2.WinForms.Guna2Button closeBtn;
		private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox3;
		private System.Windows.Forms.Label appName;
		private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
		private Guna.UI2.WinForms.Guna2DragControl guna2DragControl3;
		
		/// <summary>
		/// Disposes resources used by the form.
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(openImg));
			this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
			this.titleBar = new Guna.UI2.WinForms.Guna2Panel();
			this.minimizeBtn = new Guna.UI2.WinForms.Guna2Button();
			this.maximizeBtn = new Guna.UI2.WinForms.Guna2Button();
			this.closeBtn = new Guna.UI2.WinForms.Guna2Button();
			this.guna2CirclePictureBox3 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
			this.appName = new System.Windows.Forms.Label();
			this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
			this.guna2DragControl3 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
			((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
			this.titleBar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox3)).BeginInit();
			this.SuspendLayout();
			// 
			// guna2PictureBox1
			// 
			this.guna2PictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.guna2PictureBox1.Location = new System.Drawing.Point(12, 36);
			this.guna2PictureBox1.Name = "guna2PictureBox1";
			this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
			this.guna2PictureBox1.Size = new System.Drawing.Size(1164, 605);
			this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.guna2PictureBox1.TabIndex = 0;
			this.guna2PictureBox1.TabStop = false;
			// 
			// titleBar
			// 
			this.titleBar.BorderColor = System.Drawing.Color.Transparent;
			this.titleBar.BorderRadius = 10;
			this.titleBar.Controls.Add(this.minimizeBtn);
			this.titleBar.Controls.Add(this.maximizeBtn);
			this.titleBar.Controls.Add(this.closeBtn);
			this.titleBar.Controls.Add(this.guna2CirclePictureBox3);
			this.titleBar.Controls.Add(this.appName);
			this.titleBar.Dock = System.Windows.Forms.DockStyle.Top;
			this.titleBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.titleBar.Location = new System.Drawing.Point(0, 0);
			this.titleBar.Name = "titleBar";
			this.titleBar.ShadowDecoration.Parent = this.titleBar;
			this.titleBar.Size = new System.Drawing.Size(1188, 30);
			this.titleBar.TabIndex = 10;
			// 
			// minimizeBtn
			// 
			this.minimizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.minimizeBtn.Animated = true;
			this.minimizeBtn.AutoRoundedCorners = true;
			this.minimizeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.minimizeBtn.BorderRadius = 10;
			this.minimizeBtn.CheckedState.Parent = this.minimizeBtn;
			this.minimizeBtn.CustomImages.Parent = this.minimizeBtn;
			this.minimizeBtn.FillColor = System.Drawing.Color.Empty;
			this.minimizeBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.minimizeBtn.ForeColor = System.Drawing.Color.White;
			this.minimizeBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(72)))), ((int)(((byte)(74)))));
			this.minimizeBtn.HoverState.Parent = this.minimizeBtn;
			this.minimizeBtn.Image = ((System.Drawing.Image)(resources.GetObject("minimizeBtn.Image")));
			this.minimizeBtn.ImageSize = new System.Drawing.Size(12, 12);
			this.minimizeBtn.Location = new System.Drawing.Point(1106, 4);
			this.minimizeBtn.Name = "minimizeBtn";
			this.minimizeBtn.ShadowDecoration.Parent = this.minimizeBtn;
			this.minimizeBtn.Size = new System.Drawing.Size(23, 23);
			this.minimizeBtn.TabIndex = 12;
			this.minimizeBtn.Click += new System.EventHandler(this.MinimizeBtnClick);
			// 
			// maximizeBtn
			// 
			this.maximizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.maximizeBtn.Animated = true;
			this.maximizeBtn.AutoRoundedCorners = true;
			this.maximizeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.maximizeBtn.BorderRadius = 10;
			this.maximizeBtn.CheckedState.Parent = this.maximizeBtn;
			this.maximizeBtn.CustomImages.Parent = this.maximizeBtn;
			this.maximizeBtn.FillColor = System.Drawing.Color.Empty;
			this.maximizeBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.maximizeBtn.ForeColor = System.Drawing.Color.White;
			this.maximizeBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(72)))), ((int)(((byte)(74)))));
			this.maximizeBtn.HoverState.Parent = this.maximizeBtn;
			this.maximizeBtn.Image = ((System.Drawing.Image)(resources.GetObject("maximizeBtn.Image")));
			this.maximizeBtn.ImageSize = new System.Drawing.Size(12, 12);
			this.maximizeBtn.Location = new System.Drawing.Point(1133, 4);
			this.maximizeBtn.Name = "maximizeBtn";
			this.maximizeBtn.ShadowDecoration.Parent = this.maximizeBtn;
			this.maximizeBtn.Size = new System.Drawing.Size(23, 23);
			this.maximizeBtn.TabIndex = 11;
			this.maximizeBtn.Click += new System.EventHandler(this.MaximizeBtnClick);
			// 
			// closeBtn
			// 
			this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.closeBtn.Animated = true;
			this.closeBtn.AutoRoundedCorners = true;
			this.closeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.closeBtn.BorderRadius = 10;
			this.closeBtn.CheckedState.Parent = this.closeBtn;
			this.closeBtn.CustomImages.Parent = this.closeBtn;
			this.closeBtn.FillColor = System.Drawing.Color.Empty;
			this.closeBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.closeBtn.ForeColor = System.Drawing.Color.White;
			this.closeBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.closeBtn.HoverState.Parent = this.closeBtn;
			this.closeBtn.Image = ((System.Drawing.Image)(resources.GetObject("closeBtn.Image")));
			this.closeBtn.ImageSize = new System.Drawing.Size(12, 12);
			this.closeBtn.Location = new System.Drawing.Point(1160, 4);
			this.closeBtn.Name = "closeBtn";
			this.closeBtn.ShadowDecoration.Parent = this.closeBtn;
			this.closeBtn.Size = new System.Drawing.Size(23, 23);
			this.closeBtn.TabIndex = 1;
			this.closeBtn.Click += new System.EventHandler(this.CloseBtnClick);
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
			// guna2Elipse1
			// 
			this.guna2Elipse1.BorderRadius = 12;
			this.guna2Elipse1.TargetControl = this;
			// 
			// guna2DragControl3
			// 
			this.guna2DragControl3.TargetControl = this.titleBar;
			// 
			// openImg
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(27)))));
			this.ClientSize = new System.Drawing.Size(1188, 653);
			this.Controls.Add(this.titleBar);
			this.Controls.Add(this.guna2PictureBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "openImg";
			this.Text = "openImg";
			((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
			this.titleBar.ResumeLayout(false);
			this.titleBar.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox3)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
