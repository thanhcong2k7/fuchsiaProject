using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
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
			//Blur fix when upscale
			if (Environment.OSVersion.Version.Major >= 6)
            	SetProcessDPIAware();
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			//Check host
			TcpClient cli = new TcpClient();
			bool tmp_test = false;
			try
			{
				cli.Connect("localhost",80);
				//Check info file exist
				string curFile = @"Data/usr2";
				string[] bruhstr = { "0", "0" };
				bool bruhbr = false;
				if (File.Exists(curFile))
				{
					string in4 = File.ReadAllText(curFile);
					//in4 = EncryptAesManaged(in4,false);
					bruhstr = in4.Split(' ');
					int cnt = 0;
					foreach (string s in bruhstr)
					{
						cnt += s != null ? 1 : 0;
					}
					if (cnt == 1) bruhstr[0] = "bruh";
					bruhbr = true;
				}
				//splashScr.CloseForm();
				Application.Run(new loginFrm(bruhbr, bruhstr[0], bruhstr[1]));
			} catch (Exception)
			{
				Application.Run(new msgBox("Không thể kết nối đến máy chủ!"));
				tmp_test = true;
			}
			if(tmp_test)
            	Application.Run(new fuchsiaMain("admin", "bruh"));
		}
		[System.Runtime.InteropServices.DllImport("user32.dll")]
    	private static extern bool SetProcessDPIAware();
	}
}
