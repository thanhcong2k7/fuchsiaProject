/*
 * Created by SharpDevelop.
 * User: Nguyet Minh
 * Date: 7/20/2024
 * Time: 8:42 AM
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
	/// Description of notifItem.
	/// </summary>
	public partial class notifItem : UserControl
	{
		public notifItem(string title)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			caption.Text = title;
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
	}
}
