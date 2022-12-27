/*
 * Created by SharpDevelop.
 * User: KamyzZ
 * Date: 12/25/2022
 * Time: 9:57 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace fuchsia
{
	/// <summary>
	/// Description of newPost.
	/// </summary>
	public partial class newPost : UserControl
	{
		public newPost()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
            //this.dndCtrl.AllowDrop = true;
            this.dndCtrl.DragEnter += new DragEventHandler(dndEnter);
            this.dndCtrl.DragDrop += new DragEventHandler(dndDrop);
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		private void dndEnter(object sender, DragEventArgs e){
			if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
		}
		
		private void dndDrop(object sender, DragEventArgs e){
			var files = (string[])e.Data.GetData(DataFormats.FileDrop);
			//(new msgBox(files[0].Substring(files[0].Length-5, files[0].Length-1))).Show();
			foreach (string f_name in files) {
				string[] imgExt;
				imgExt = new string[] {".png",".bmp",".gif",".jpg"};
				bool kve = false;
				foreach (string kkk in imgExt) {
					if(f_name.Substring(f_name.Length-5, f_name.Length-1)==kkk){
						kve=true;
						break;
					}
				}
				if (!kve)
					(new msgBox("Không hỗ trợ định dạng file "+f_name.Substring(f_name.Length-5, f_name.Length-1)+" !")).Show();//unsupport file ext
				else {
					//
				}
			}
		}

		private void guna2TextBox1_TextChanged(object sender, EventArgs e)
		{
			if (String.IsNullOrWhiteSpace(captionInput.Text))
			{
				//postBtn.Enabled = false;
			}
			//else postBtn.Enabled = true;
		}
	}
}
