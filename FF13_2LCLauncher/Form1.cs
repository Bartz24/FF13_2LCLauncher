using memory;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FF13_2LCLauncher
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        static extern int SetWindowText(IntPtr hWnd, string text);

        private static Properties.Settings settings = Properties.Settings.Default;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxDisplay.SelectedIndex = comboBoxDisplay.Items.IndexOf(settings.Display);
            comboBoxResolution.SelectedIndex = comboBoxResolution.Items.IndexOf(settings.Resolution);
            comboBoxVoices.SelectedIndex = comboBoxVoices.Items.IndexOf(settings.Voices);
            comboBoxShadows.SelectedIndex = comboBoxShadows.Items.IndexOf(settings.Shadows);
            comboBoxMSAA.SelectedIndex = comboBoxMSAA.Items.IndexOf(settings.MSAA);

            AutoSearchDir();
        }

        private void comboBoxDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {
            settings.Display = comboBoxDisplay.Text;
            settings.Save();
        }

        private void comboBoxResolution_SelectedIndexChanged(object sender, EventArgs e)
        {
            settings.Resolution = comboBoxResolution.Text;
            settings.Save();
        }

        private void comboBoxVoices_SelectedIndexChanged(object sender, EventArgs e)
        {
            settings.Voices = comboBoxVoices.Text;
            settings.Save();
        }

        private void comboBoxShadows_SelectedIndexChanged(object sender, EventArgs e)
        {
            settings.Shadows = comboBoxShadows.Text;
            settings.Save();
        }

        private void comboBoxMSAA_SelectedIndexChanged(object sender, EventArgs e)
        {
            settings.MSAA = comboBoxMSAA.Text;
            settings.Save();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            String path = GetFF13Directory();
            if (String.IsNullOrEmpty(path))
            {
                MessageBox.Show("Could not find the FF13-2 steam files! Report this issue to the dev, Bartz24!");
                return;
            }
            Process process = new Process();
            process.StartInfo.FileName = path + "\\alba_data\\prog\\win\\bin\\ffxiii2img.exe";
            process.StartInfo.Arguments = String.Join(" ", GetArgs());
            process.Start();

            Thread.Sleep(5000);

            SetWindowText(process.MainWindowHandle, "FINAL FANTASY XIII-2 160f Lucky Coin Mod");

            Scanner scanner = new Scanner(process, process.Handle, "8A D0 83 C9 FF");

            scanner.setModule(process.MainModule);
            scanner.writeBytes(process, scanner.FindPattern(), "B2 37 83 C9 FF");

            this.Close();
        }

        private List<string> GetArgs()
        {
            List<string> arguments = new List<string>();
            switch (comboBoxDisplay.Text)
            {
                case "Full Screen":
                    arguments.Add("-FullScreenMode=Force");
                    break;
                case "Windowed":
                default:
                    break;
            }

            switch (comboBoxResolution.Text)
            {
                case "1920 x 1080":
                    arguments.Add("-Width=1920 -Height=1080");
                    break;
                case "1280 x 720":
                default:
                    arguments.Add("-Width=1280 -Height=720");
                    break;
            }

            switch (comboBoxShadows.Text)
            {
                case "1024 x 1024":
                    arguments.Add("-Shadow=1024");
                    break;
                case "2048 x 2048":
                    arguments.Add("-Shadow=2048");
                    break;
                case "4096 x 4096":
                    arguments.Add("-Shadow=4096");
                    break;
                case "8192 x 8192":
                    arguments.Add("-Shadow=8192");
                    break;
                case "512 x 512":
                default:
                    arguments.Add("-Shadow=512");
                    break;
            }

            switch (comboBoxVoices.Text)
            {
                case "Japanese":
                    arguments.Add("-VoiceJPMode");
                    break;
                case "English":
                default:
                    break;
            }

            switch (comboBoxMSAA.Text)
            {
                case "x4":
                    arguments.Add("-MSAA=4");
                    break;
                case "x8":
                    arguments.Add("-MSAA=8");
                    break;
                case "x16":
                    arguments.Add("-MSAA=16");
                    break;
                case "x2":
                default:
                    arguments.Add("-MSAA=2");
                    break;
            }

            return arguments;
        }

        private void AutoSearchDir()
        {
            object returnVal = Registry.GetValue("HKEY_CURRENT_USER\\Software\\Valve\\Steam", "SteamPath", "c:/program files (x86)/steam");
            returnVal = returnVal.ToString().Replace("/", "\\");

            if (GetFF13Path(returnVal.ToString()) == null)
            {
                string text = File.ReadAllText(returnVal.ToString() + "/steamapps/libraryfolders.vdf");
                Regex regex = new Regex("\"\\d+\"\\s+\"(.*)\"");
                foreach (Match match in regex.Matches(text))
                {
                    if (match.Success)
                    {
                        if (GetFF13Path(match.Groups[1].Value) != null)
                            break;
                    }
                }
            }
        }

        public static string GetFF13Directory()
        {
            string path = GetFF13Path()?.Replace("\\\\", "\\");
            if (!String.IsNullOrEmpty(path) && path.EndsWith("\\FFXiiiSteam.dll"))
                return path.Substring(0, path.Length - "\\FFXiiiSteam.dll".Length);
            return null;
        }

        private static string FF13FilePath = null;

        private static string GetFF13Path(string directoryCheck = null)
        {
            if (String.IsNullOrEmpty(FF13FilePath) || !File.Exists(FF13FilePath) || !FF13FilePath.EndsWith("FINAL FANTASY XIII-2\\FFXiiiSteam.dll"))
            {
                FF13FilePath = null;
                if (File.Exists("ff13_2path.txt"))
                {
                    FF13FilePath = File.ReadAllText("ff13_2path.txt").Replace("/", "\\");
                    FF13FilePath = (String.IsNullOrEmpty(FF13FilePath) || !File.Exists(FF13FilePath.Substring(0, FF13FilePath.LastIndexOf("\\")) + "\\alba_data\\prog\\win\\bin\\ffxiii2img.exe")) ? null : FF13FilePath;
                    if (File.Exists(FF13FilePath))
                        return FF13FilePath;
                }
                if (directoryCheck != null && Directory.Exists(directoryCheck))
                {
                    string[] paths = Directory.GetFiles(directoryCheck, "FFXiiiSteam.dll", SearchOption.AllDirectories);
                    paths.ToList().ForEach(p =>
                    {
                        p = p.Replace("/", "\\").Replace("\\\\", "\\");
                        string path = p.Substring(0, p.LastIndexOf("\\")) + "\\alba_data\\prog\\win\\bin\\ffxiii2img.exe";
                        if (File.Exists(path))
                            FF13FilePath = p.Replace("/", "\\");
                    });
                }
            }

            if (FF13FilePath != null)
                File.WriteAllText("ff13_2path.txt", FF13FilePath);
            else
                File.WriteAllText("ff13_2path.txt", "");
            return FF13FilePath;
        }
    }
}
