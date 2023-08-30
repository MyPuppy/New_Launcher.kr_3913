using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KartRider.Common.Network;
using KartRider.Common.Utilities;
using KartRider.IO;
using Microsoft.Win32;
using System.Diagnostics;
using System.IO;
using System.Threading;
using Set_Data;

namespace KartRider
{
    public static class LauncherSystem
    {
        public static short KartOld_SN = 0;
        public static short KartSN = 0;

        public static bool System_ButtonClick = true;
        public static bool System_KeyError = true;
        public static bool System_Error = true;
        public static bool System_CheckOn = true;
        public static bool System_CheckOff = true;

        public static void MessageBoxType1()
        {
            LauncherSystem.Program_Error();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Please exit KartRider and try again.");
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public static void MessageBoxType2()
        {
            LauncherSystem.Program_Error();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("KartRider is already running.");
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public static void MessageBoxType3()
        {
            LauncherSystem.Program_Error();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(Program.KartRider + " file not found!");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine();
            Console.WriteLine("Press any key to continue");
            Console.ReadKey(true);
        }

        public static void MessageBoxType4()
        {
            LauncherSystem.Program_KeyError();
            Console.WriteLine("Invalid argument!");
        }

        public static void Program_ButtonClick()
        {
            string Program_ButtonClick = FileName.Sound_LoadFile + FileName.Program_ButtonClick;
            if (File.Exists(Program_ButtonClick))
            {
                if (LauncherSystem.System_ButtonClick)
                {
                    (new Thread(() =>
                    {
                        LauncherSystem.System_ButtonClick = false;
                        System.Media.SoundPlayer player = new System.Media.SoundPlayer(Program_ButtonClick); //Send
                        player.PlaySync();
                        LauncherSystem.System_ButtonClick = true;
                    })).Start();
                }
            }
        }

        public static void Program_KeyError()
        {
            string Program_KeyError = FileName.Sound_LoadFile + FileName.Program_KeyError;
            if (File.Exists(Program_KeyError))
            {
                if (LauncherSystem.System_KeyError)
                {
                    (new Thread(() =>
                    {
                        LauncherSystem.System_KeyError = false;
                        System.Media.SoundPlayer player = new System.Media.SoundPlayer(Program_KeyError);
                        player.PlaySync();
                        LauncherSystem.System_KeyError = true;
                    })).Start();
                }
            }
        }

        public static void Program_Error()
        {
            string Program_Error = FileName.Sound_LoadFile + FileName.Program_Error;
            if (File.Exists(Program_Error))
            {
                if (LauncherSystem.System_Error)
                {
                    (new Thread(() =>
                    {
                        LauncherSystem.System_Error = false;
                        System.Media.SoundPlayer player = new System.Media.SoundPlayer(Program_Error); //Go back
                        player.PlaySync();
                        LauncherSystem.System_Error = true;
                    })).Start();
                }
            }
        }

        public static void RunAsConsole()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("KartRider PV:" + Program.Version + " (by LAON)");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine();
            Console.WriteLine("Please press a key to continue...");
            Console.WriteLine("-[r]: Run KartRider");
            Console.WriteLine("-[t]: Tuning Options");
            Console.WriteLine("-[e]: Exit");
            string empty = string.Empty;
            empty = Console.ReadKey().KeyChar.ToString();
            Console.WriteLine();
            string lower = empty;
            if (lower == "r")
            {
                if (Process.GetProcessesByName("KartRider").Length != 0)
                {
                    LauncherSystem.MessageBoxType2();
                }
                else
                {
                    LauncherSystem.Program_ButtonClick();
                    LauncherSystem.StartKartRider();
                }
            }
            else if (lower == "t")
            {
                if (Process.GetProcessesByName("KartRider").Length != 0)
                {
                    LauncherSystem.MessageBoxType1();
                }
                else
                {
                    LauncherSystem.Program_ButtonClick();
                    LauncherSystem.UseKartTuning();
                }
            }
            else if (lower == "e")
            {
                if (Process.GetProcessesByName("KartRider").Length != 0)
                {
                    LauncherSystem.MessageBoxType1();
                }
                else
                {
                    Environment.Exit(1);
                }
            }
            else
            {
                LauncherSystem.MessageBoxType4();
            }
            Console.WriteLine();
            Console.WriteLine("Press any key to continue");
            Console.ReadKey(true);
            LauncherSystem.RunAsConsole();
        }

        public static void StartKartRider()
        {
            Console.WriteLine("Starting KartRider...");
            string str = Program.profilePath;
            string[] text = new string[] { "<?xml version='1.0' encoding='UTF-16'?>\r\n<profile>\r\n<username>", SetRider.UserID, "</username>\r\n</profile>" };
            File.WriteAllText(str, string.Concat(text));
            Process process = new Process()
            {
                StartInfo = new ProcessStartInfo(Program.KartRider, "-profile:launcher")
                {
                    WorkingDirectory = Program.kartRiderDirectory
                }
            };
            process.Start();
        }

        public static void UseKartTuning()
        {
            Console.Clear();
            Console.WriteLine("Welcome! Set up your kartbody tuning");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("UseKartTune: ");
            if (Set_ETC.KartTune_Use == 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("OFF");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("ON");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("UseKartPlant: ");
            if (Set_ETC.KartPlant_Use == 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("OFF");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("ON");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("UseKartLevel: ");
            if (Set_ETC.KartLevel_Use == 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("OFF");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("ON");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Please press a key to continue...");
            Console.WriteLine("-[1]: UseKartTune");
            Console.WriteLine("-[2]: UseKartPlant");
            Console.WriteLine("-[3]: UseKartLevel");
            Console.WriteLine("-[g]: Go back");
            string empty = string.Empty;
            empty = Console.ReadKey().KeyChar.ToString();
            Console.WriteLine();
            string lower = empty;
            if (lower == "1")
            {
                LauncherSystem.Program_ButtonClick();
                if (Set_ETC.KartTune_Use == 0)
                {
                    Set_ETC.KartTune_Use = 1;
                }
                else
                {
                    Set_ETC.KartTune_Use = 0;
                }
                Set_ETC.Save_KartTune();
                Set_ETC.Check_KartTune();
                Console.WriteLine("Uploading: {0}", FileName.config_LoadFile + FileName.SetETC_KartTune + FileName.Extension);
            }
            else if (lower == "2")
            {
                LauncherSystem.Program_ButtonClick();
                if (Set_ETC.KartPlant_Use == 0)
                {
                    Set_ETC.KartPlant_Use = 1;
                }
                else
                {
                    Set_ETC.KartPlant_Use = 0;
                }
                Set_ETC.Save_KartPlant();
                Set_ETC.Check_KartPlant();
                Console.WriteLine("Uploading: {0}", FileName.config_LoadFile + FileName.SetETC_KartPlant + FileName.Extension);
            }
            else if (lower == "3")
            {
                LauncherSystem.Program_ButtonClick();
                if (Set_ETC.KartLevel_Use == 0)
                {
                    Set_ETC.KartLevel_Use = 1;
                }
                else
                {
                    Set_ETC.KartLevel_Use = 0;
                }
                Set_ETC.Save_KartLevel();
                Set_ETC.Check_KartLevel();
                Console.WriteLine("Uploading: {0}", FileName.config_LoadFile + FileName.SetETC_KartLevel + FileName.Extension);
            }
            else if (lower == "g")
            {
                LauncherSystem.Program_ButtonClick();
                LauncherSystem.RunAsConsole();
            }
            else
            {
                LauncherSystem.MessageBoxType4();
            }
            Console.WriteLine();
            Console.WriteLine("Press any key to continue");
            Console.ReadKey(true);
            LauncherSystem.UseKartTuning();
        }
    }
}