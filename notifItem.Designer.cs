/*
 * Created by SharpDevelop.
 * User: Nguyet Minh
 * Date: 7/20/2024
 * Time: 8:42 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace fuchsia
{
	partial class notifItem
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
		private System.Windows.Forms.Label caption;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label2;
		private Guna.UI2.WinForms.Guna2Chip readState;
		private Guna.UI2.WinForms.Guna2CircleButton delete;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(notifItem));
			this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.caption = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.readState = new Guna.UI2.WinForms.Guna2Chip();
			this.delete = new Guna.UI2.WinForms.Guna2CircleButton();
			((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
			this.flowLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// guna2PictureBox1
			// 
			this.guna2PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.guna2PictureBox1.BorderRadius = 15;
			this.guna2PictureBox1.Image = global::fuchsia.Properties.Resources.post;
			this.guna2PictureBox1.Location = new System.Drawing.Point(25, 14);
			this.guna2PictureBox1.Name = "guna2PictureBox1";
			this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
			this.guna2PictureBox1.Size = new System.Drawing.Size(50, 50);
			this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.guna2PictureBox1.TabIndex = 0;
			this.guna2PictureBox1.TabStop = false;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.flowLayoutPanel1.Controls.Add(this.panel1);
			this.flowLayoutPanel1.Controls.Add(this.caption);
			this.flowLayoutPanel1.Controls.Add(this.panel2);
			this.flowLayoutPanel1.Controls.Add(this.label2);
			this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(87, 9);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(464, 60);
			this.flowLayoutPanel1.TabIndex = 2;
			// 
			// panel1
			// 
			this.panel1.Location = new System.Drawing.Point(3, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(52, 1);
			this.panel1.TabIndex = 2;
			// 
			// caption
			// 
			this.caption.AutoSize = true;
			this.caption.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.caption.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.caption.Location = new System.Drawing.Point(3, 7);
			this.caption.Name = "caption";
			this.caption.Size = new System.Drawing.Size(227, 25);
			this.caption.TabIndex = 3;
			this.caption.Text = "Hai Ngu liked your photo.";
			this.caption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panel2
			// 
			this.panel2.Location = new System.Drawing.Point(3, 35);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(50, 1);
			this.panel2.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label2.Location = new System.Drawing.Point(3, 39);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(137, 15);
			this.label2.TabIndex = 5;
			this.label2.Text = "  Thursday, 00:00 11/9/1000";
			this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// readState
			// 
			this.readState.AutoRoundedCorners = true;
			this.readState.BorderRadius = 2;
			this.readState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.readState.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.readState.ForeColor = System.Drawing.Color.White;
			this.readState.Location = new System.Drawing.Point(9, 32);
			this.readState.Name = "readState";
			this.readState.ShadowDecoration.Parent = this.readState;
			this.readState.Size = new System.Drawing.Size(7, 17);
			this.readState.TabIndex = 3;
			this.readState.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
			// 
			// delete
			// 
			this.delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.delete.Animated = true;
			this.delete.CheckedState.Parent = this.delete;
			this.delete.CustomImages.Parent = this.delete;
			this.delete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(53)))));
			this.delete.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.delete.ForeColor = System.Drawing.Color.White;
			this.delete.HoverState.Parent = this.delete;
			this.delete.Image = ((System.Drawing.Image)(resources.GetObject("delete.Image")));
			this.delete.Location = new System.Drawing.Point(560, 19);
			this.delete.Name = "delete";
			this.delete.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
			this.delete.ShadowDecoration.Parent = this.delete;
			this.delete.Size = new System.Drawing.Size(40, 40);
			this.delete.TabIndex = 4;
			this.delete.Click += new System.EventHandler(this.Guna2CircleButton1Click);
			// 
			// notifItem
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
			this.Controls.Add(this.delete);
			this.Controls.Add(this.readState);
			this.Controls.Add(this.flowLayoutPanel1);
			this.Controls.Add(this.guna2PictureBox1);
			this.Name = "notifItem";
			this.Size = new System.Drawing.Size(610, 79);
			((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}
	}
}
