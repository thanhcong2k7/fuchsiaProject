
namespace fuchsia
{
	partial class loginFrm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginFrm));
			this.usrBox = new Guna.UI2.WinForms.Guna2TextBox();
			this.pwdBox = new Guna.UI2.WinForms.Guna2TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// usrBox
			// 
			this.usrBox.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.usrBox.DefaultText = "";
			this.usrBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.usrBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.usrBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.usrBox.DisabledState.Parent = this.usrBox;
			this.usrBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.usrBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.usrBox.FocusedState.Parent = this.usrBox;
			this.usrBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.usrBox.HoverState.Parent = this.usrBox;
			this.usrBox.Location = new System.Drawing.Point(277, 127);
			this.usrBox.Name = "usrBox";
			this.usrBox.PasswordChar = '\0';
			this.usrBox.PlaceholderText = "";
			this.usrBox.SelectedText = "";
			this.usrBox.ShadowDecoration.Parent = this.usrBox;
			this.usrBox.Size = new System.Drawing.Size(200, 36);
			this.usrBox.TabIndex = 0;
			// 
			// pwdBox
			// 
			this.pwdBox.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.pwdBox.DefaultText = "";
			this.pwdBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.pwdBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.pwdBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.pwdBox.DisabledState.Parent = this.pwdBox;
			this.pwdBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.pwdBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.pwdBox.FocusedState.Parent = this.pwdBox;
			this.pwdBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.pwdBox.HoverState.Parent = this.pwdBox;
			this.pwdBox.Location = new System.Drawing.Point(277, 169);
			this.pwdBox.Name = "pwdBox";
			this.pwdBox.PasswordChar = '\0';
			this.pwdBox.PlaceholderText = "";
			this.pwdBox.SelectedText = "";
			this.pwdBox.ShadowDecoration.Parent = this.pwdBox;
			this.pwdBox.Size = new System.Drawing.Size(200, 36);
			this.pwdBox.TabIndex = 1;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(342, 230);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 3;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.guna2Button1_Click);
			// 
			// loginFrm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.pwdBox);
			this.Controls.Add(this.usrBox);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "loginFrm";
			this.Text = "fuchsia Login";
			this.ResumeLayout(false);

		}

		#endregion

		private Guna.UI2.WinForms.Guna2TextBox usrBox;
		private Guna.UI2.WinForms.Guna2TextBox pwdBox;
		private System.Windows.Forms.Button button1;
	}
}