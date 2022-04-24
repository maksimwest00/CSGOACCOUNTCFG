using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using CSGOMultiAccsCFG;
using Newtonsoft.Json;

namespace CSGOACCOUNTCFG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadingXml();
        }

        private string path;
        private string pathtwo;
        bool pathCorrect;

        // В целом все работает, осталось настроить параметры запуска для всех акков это чтение json localconfig и изменение launchOptions !!!

        private string getPath()
        {
            return path;
        }

        private string getPathtwo()
        {
            return pathtwo;
        }

        private void setPath(string path, string pathtwo)
        {
            this.path = path;
            this.pathtwo = pathtwo;
        }
        private void CheckPath()
        {
            if (File.Exists(getPath() + @"\steam.exe") && System.IO.File.Exists(getPath() + @"\Steam.dll"))
            {
                pathCorrect = true;
            }
            //else
            //{
            //    MessageBox.Show("Steam Path Incorrect");
            //    pathCorrect = false;
            //}
        }

        private void CheckPathSource()
        {
            if (File.Exists(getPath() + @"\steam.exe") && System.IO.File.Exists(getPath() + @"\Steam.dll"))
            {
                pathCorrect = true;
            }
            //else
            //{
            //    MessageBox.Show("Steam Path Incorrect");
            //    pathCorrect = false;
            //}
        }

        private void LoadingXml()
        {
            string FileName = "setting.xml";
            if (File.Exists(FileName))
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(FileName);
                XmlNode child = doc.SelectSingleNode("/setting/path");
                XmlNode childtwo = doc.SelectSingleNode("/setting/path2");
                if (child != null && childtwo != null)
                {
                    XmlNodeReader nr = new XmlNodeReader(child);
                    XmlNodeReader nrtwo = new XmlNodeReader(childtwo);
                    while (nr.Read() && nrtwo.Read())
                        if (nr.Value != "" && nrtwo.Value != "")
                        {
                            setPath(nr.Value, nrtwo.Value);
                            CheckPath();
                            txtPath.Text = nr.Value;
                            SourcePath.Text = nrtwo.Value;
                        }
                }
            }
            else
            {
                //Default Path
                CreatePathData("setting.xml", "C:\\Program Files (x86)\\Steam\\userdata", "C:\\Program Files (x86)\\Steam\\userdata\\cfg cs");
                LoadingXml();
            }
        }

        private void CreatePathData(string Filename, string path, string pathtwo)
        {
            XmlDocument doc = new XmlDocument();
            XmlNode docNode = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
            doc.AppendChild(docNode);
            XmlElement node = doc.CreateElement("setting");
            XmlElement userDataPath = doc.CreateElement("path");
            XmlElement sourceDataPath = doc.CreateElement("path2");
            if (path != null)
            {
                userDataPath.InnerText = path;
                sourceDataPath.InnerText = pathtwo;
            }
            else
            {
                userDataPath.InnerText = getPath();
                sourceDataPath.InnerText = getPathtwo();
            }
            node.AppendChild(userDataPath);
            node.AppendChild(sourceDataPath);
            doc.AppendChild(node);
            StreamWriter outStream = File.CreateText(Filename);
            doc.Save(outStream);
            outStream.Close();
        }

        public static string Steam64ToSteam32(long communityId)
        {
            if (communityId < 76561197960265729L || !Regex.IsMatch(communityId.ToString((IFormatProvider)CultureInfo.InvariantCulture), "^7656119([0-9]{10})$"))
            {
                return string.Empty;
            }
            return string.Format("U:1:{0}", communityId - 76561197960265728L);
        }


        public static void Copy(string sourceDirectory, string targetDirectory)
        {
            DirectoryInfo diSource = new DirectoryInfo(sourceDirectory);
            DirectoryInfo diTarget = new DirectoryInfo(targetDirectory);
            CopyAll(diSource, diTarget);
        }

        public static void CopyAll(DirectoryInfo source, DirectoryInfo target)
        {
            if (Directory.Exists(target.FullName) == false)
            {
                Directory.CreateDirectory(target.FullName);
            }
            foreach (FileInfo fi in source.GetFiles())
            {
                Console.WriteLine(@"Copying {0}\{1}", target.FullName, fi.Name);
                fi.CopyTo(Path.Combine(target.ToString(), fi.Name), true);
            }
            foreach (DirectoryInfo diSourceSubDir in source.GetDirectories())
            {
                DirectoryInfo nextTargetSubDir = target.CreateSubdirectory(diSourceSubDir.Name);
                CopyAll(diSourceSubDir, nextTargetSubDir);
            }
        }

        private void ImportMafileBtn_Click(object sender, EventArgs e)
        {
                if (Browsec.ShowDialog() != DialogResult.OK) return;
                string path = Browsec.SelectedPath;
                if (!Directory.Exists(path)) return;
                string[] files = Directory.GetFiles(path, "*.mafile");
                int counter = 0;
                for (int i = 0, a = files.Count(); i < a; i++)
                {
                    try
                    {
                        string json = File.ReadAllText(files[i]);
                        MafileDeserialize.Root accountinfo = JsonConvert.DeserializeObject<MafileDeserialize.Root>(json);
                        string accountname = accountinfo.account_name;
                        string steamid = accountinfo.Session.SteamID.ToString();
                        // ПРЕОБРАЗОВАНИЕ SteamID64toSTEAM32 
                        string steamidparse = Steam64ToSteam32(long.Parse(steamid));
                        string[] steamid32 = steamidparse.Split(':');
                        // СОЗДАНИЕ ПАПОК СО ВСЕМИ СТИМ АЙДИ32
                        string rootDir = txtPath.Text;
                        if (!Directory.Exists(Path.Combine(rootDir, steamid32[2])))
                            Directory.CreateDirectory(Path.Combine(rootDir, steamid32[2]));
                        // КОПИРОВАНИЕ В ЭТИ ПАПКИ ОПРЕДЕЛЕННОЙ ПАПКИ С ФАЙЛАМИ
                        string sourceDirectory = SourcePath.Text;
                        string targetDirectory = txtPath.Text + "/" + steamid32[2];
                        Copy(sourceDirectory, targetDirectory);
                        counter++;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                MessageBox.Show("Загруженно " + counter.ToString() + " аккаунтов");
        }

        private void Convert64to3btn_Click(object sender, EventArgs e)
        {
            string a = Steam64ToSteam32(long.Parse(SteamID64textbox.Text));
            string[] steamid32 = a.Split(':');
            STEAMID3textbox.Text = steamid32[2];
        }

        private void ImportMFOne_btn_Click(object sender, EventArgs e)
        {
            if (Importer.ShowDialog() != DialogResult.OK) return;
            string file = Importer.FileName;
            int counter = 0;
            string json = File.ReadAllText(file);
            CSGOMultiAccsCFG.MafileDeserialize.Root accountinfo = JsonConvert.DeserializeObject<CSGOMultiAccsCFG.MafileDeserialize.Root>(json);
            string steamid = accountinfo.Session.SteamID.ToString();
            string steamidparse = Steam64ToSteam32(long.Parse(steamid));
            string[] steamid32 = steamidparse.Split(':');
            string rootDir = txtPath.Text;
            if (!Directory.Exists(Path.Combine(rootDir, steamid32[2])))
                Directory.CreateDirectory(Path.Combine(rootDir, steamid32[2]));
            string sourceDirectory = SourcePath.Text;
            string targetDirectory = txtPath.Text + "/" + steamid32[2];
            Copy(sourceDirectory, targetDirectory);
            counter++;
            MessageBox.Show("Загружено " + counter + " аккаунтов");
        }

        private void ImportOneTxt_btn_Click(object sender, EventArgs e)
        {
            if (Importer.ShowDialog() != DialogResult.OK) return;
            string file = Importer.FileName;
            string[] steamiddata = File.ReadAllLines(file);
            int counter = 0;
            foreach (var line in steamiddata)
            {
                var steamid = line;
                string steamidparse = Steam64ToSteam32(long.Parse(steamid));
                string[] steamid32 = steamidparse.Split(':');
                string rootDir = txtPath.Text;
                if (!Directory.Exists(Path.Combine(rootDir, steamid32[2])))
                    Directory.CreateDirectory(Path.Combine(rootDir, steamid32[2]));
                string sourceDirectory = SourcePath.Text;
                string targetDirectory = txtPath.Text + "/" + steamid32[2];
                Copy(sourceDirectory, targetDirectory);
                counter++;
            }
            MessageBox.Show("Загружено " + counter + " аккаунтов");
        }

        private void SelectToPath_btn_Click(object sender, EventArgs e)
        {
            LoadingXml();
        }

        private void btnSelectPath_Click(object sender, EventArgs e)
        {
            if (Browsec.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = Browsec.SelectedPath;
                setPath(Browsec.SelectedPath, getPathtwo());
                CheckPath();
                CreatePathData("setting.xml", getPath(), getPathtwo());
            }
        }

        private void btnSelectSourcePath_Click(object sender, EventArgs e)
        {
            if (Browsec.ShowDialog() == DialogResult.OK)
            {
                SourcePath.Text = Browsec.SelectedPath;
                setPath(getPath(), Browsec.SelectedPath);
                CheckPathSource();
                CreatePathData("setting.xml", getPath(), getPathtwo());
            }
        }

        private void DefaultPathsBtn_Click(object sender, EventArgs e)
        {
            txtPath.Text = "C:\\Program Files (x86)\\Steam\\userdata";
            //SourcePath.Text = "C:\\Program Files (x86)\\Steam\\userdata\\cfg cs";
            SourcePath.Text = "C:\\Program Files (x86)\\Steam\\userdata\\{YOUR MAIN ACCOUNT FOR EXPORT CFG}";
        }

        private void SavePathSettings_Click(object sender, EventArgs e)
        {
            CreatePathData("setting.xml", txtPath.Text, SourcePath.Text);
            LoadingXml();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int counter = 0;
            string steamid32 = STEAMID3textbox.Text;
            if (steamid32 != "")
            {
                string rootDir = txtPath.Text;
                if (!Directory.Exists(Path.Combine(rootDir, steamid32)))
                    Directory.CreateDirectory(Path.Combine(rootDir, steamid32));
                string sourceDirectory = SourcePath.Text;
                //string sourceDirectory = @"D:\Макс Системные Папки\Desktop\ПРОКЕТ КСГО КФГ\конфиг для кс";
                string targetDirectory = txtPath.Text + "/" + steamid32;
                Copy(sourceDirectory, targetDirectory);
                counter++;
                MessageBox.Show("Загружено " + counter + " аккаунтов");
            }
            else
            {
                MessageBox.Show("STEAMID32 Пустой");
            }
        }

        private void UserDataGetFolderName_btn_Click(object sender, EventArgs e)
        {
            string pathfolder = "C:\\Program Files (x86)\\Steam\\userdata";
            string[] allfiles = Directory.GetFiles(pathfolder);
            foreach (string filename in allfiles)
            {
                Console.WriteLine(filename);
            }
        }
    }
}
    

