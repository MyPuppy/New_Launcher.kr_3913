using KartRider.Common.Network;
using KartRider.Common.Utilities;
using KartRider.IO;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using Set_Data;

namespace KartRider
{
	internal static class Program
	{
		public static int MAX_EQP_P;
		public static bool UseKartTune;
		public static bool UseKartPlant;
		public static bool UseKartLevel;
		public static bool PreventItem;
		public static ushort Version;
		public static string DataTime;
		public static string kartRiderDirectory = null;
		public static string profilePath = null;
		public static string KartRider = "KartRider.exe";

		static Program()
		{
			Program.MAX_EQP_P = 29;
			Program.Version = 3913;
			Program.DataTime = "70 A7 00 00"; //2017-05-11
		}

		[STAThread]
		private static void Main()
		{
			if (File.Exists(Program.KartRider))
			{
				kartRiderDirectory = Environment.CurrentDirectory;
				string str = Path.Combine(kartRiderDirectory, "Profile", SessionGroup.Service);
				profilePath = Path.Combine(str, "launcher.xml");
				if (!Directory.Exists(str))
				{
					Directory.CreateDirectory(str);
				}
				RouterListener.Start();
				StartingLoad_ALL.StartingLoad();
			}
			else
			{
				LauncherSystem.MessageBoxType3();
			}
		}
	}
}