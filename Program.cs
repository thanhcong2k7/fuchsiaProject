using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace fuchsia
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			splashScr.ShowSplashScreen();
			System.Threading.Thread.Sleep(2000);
			splashScr.CloseForm();
			Application.Run(new loginForm());
		}
	}
}
