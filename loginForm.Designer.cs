
namespace fuchsia
{
	partial class loginForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginForm));
			this.loginFrm = new System.Windows.Forms.Panel();
			this.SuspendLayout();
			// 
			// loginFrm
			// 
			this.loginFrm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.loginFrm.Location = new System.Drawing.Point(43, 36);
			this.loginFrm.Name = "loginFrm";
			this.loginFrm.Size = new System.Drawing.Size(337, 367);
			this.loginFrm.TabIndex = 3;
			// 
			// loginForm
			// 
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.ClientSize = new System.Drawing.Size(801, 450);
			this.Controls.Add(this.loginFrm);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "loginForm";
			this.Text = "fuchsia Login";
			this.Load += new System.EventHandler(this.loginForm_Load);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel loginFrm;
	}
}