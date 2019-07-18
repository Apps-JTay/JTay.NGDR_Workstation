using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JTay.FrameWork.Support;

namespace NGDR_Workstation.Forms
{
    public partial class EMRFileSystem : Form
    {
        public EMRFileSystem()
        {
            InitializeComponent();
        }

        private void EMRFileSystem_Load(object sender, EventArgs e)
        {
            lblFVersion.Text = Config.Version;
            lblDB.Text = Config.PrimaryDBName;
            lblAppVersion.Text = "v" + Assembly.GetExecutingAssembly().GetName().Version;


            if (!Directory.Exists(Config.ProjectDirectory))
                Directory.CreateDirectory(Config.ProjectDirectory);

            if (!File.Exists(Config.ProjectDirectory + "\\efts.kjf")) return;
            using (StreamReader reader = new StreamReader(Config.ProjectDirectory + "\\efts.kjf"))
            {
                while (!reader.EndOfStream)
                {
                    string[] parts = reader.ReadLine().Split('|');
                    switch (parts[0])
                    {
                        case "ZDP":
                            txtZipDocPath.Text = parts[1];
                            break;
                        case "EDP":
                            txtExtractDocPath.Text = parts[1];
                            break;
                        case "IP":
                            txtImagePath.Text = parts[1];
                            break;
                        case "IZP":
                            txtImageZipPath.Text = parts[1];
                            break;
                        case "SMTP":
                            txtSMTP.Text = parts[1];
                            break;
                        case "GC":
                            uneGC.Value = parts[1];
                            break;

                    }
                }
            }
        }

        private static void SaveLine(string item, string value)
        {
            string path = Config.ProjectDirectory + "\\efts.kjf";
            if (File.Exists(path))
            {
                string[] lines = File.ReadAllLines(path);
                File.Delete(path);
                using (StreamWriter sw = File.AppendText(path))
                {
                    foreach (string line in lines)
                    {
                        string[] parts = line.Split('|');
                        if (item != parts[0])
                            sw.WriteLine(line);

                    }
                    sw.WriteLine(item + "|" + value);
                }
            }
            else
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine(item + "|" + value);
                }
            }
        }

        private static void DeleteLine(string item)
        {
            string path = Config.ProjectDirectory + "\\efts.kjf";
            if (!File.Exists(path)) return;
            string[] lines = File.ReadAllLines(path);
            File.Delete(path);
            using (StreamWriter sw = File.AppendText(path))
            {
                foreach (string line in lines)
                {
                    string[] parts = line.Split('|');
                    if (item != parts[0])
                        sw.WriteLine(line);

                }

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveLine("ZDP", txtZipDocPath.Text);
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteLine("ZDP");
            txtZipDocPath.Text = String.Empty;
        }

        private void btnSaveEDP_Click(object sender, EventArgs e)
        {
            SaveLine("EDP", txtExtractDocPath.Text);
        }

        private void btnDeleteEDP_Click(object sender, EventArgs e)
        {
            DeleteLine("EDP");
            txtExtractDocPath.Text = String.Empty;
        }

        private void btnSaveIP_Click(object sender, EventArgs e)
        {
            SaveLine("IP", txtImagePath.Text);
        }

        private void btnDeleteIP_Click(object sender, EventArgs e)
        {
            DeleteLine("IP");
            txtImagePath.Text = String.Empty;
        }

        private void btnSaveIZP_Click(object sender, EventArgs e)
        {
            SaveLine("IZP", txtImageZipPath.Text);
        }

        private void btnDeleteIZP_Click(object sender, EventArgs e)
        {
            DeleteLine("IZP");
            txtImageZipPath.Text = String.Empty;
        }

        private void btnSaveSmtp_Click(object sender, EventArgs e)
        {
            SaveLine("SMTP", txtSMTP.Text);
        }

        private void btnDeleteSmtp_Click(object sender, EventArgs e)
        {
            DeleteLine("SMTP");
            txtSMTP.Text = String.Empty;
        }

        private void btnSaveAll_Click(object sender, EventArgs e)
        {
            SaveLine("ZDP", txtZipDocPath.Text);
            SaveLine("EDP", txtExtractDocPath.Text);
            SaveLine("IP", txtImagePath.Text);
            SaveLine("SMTP", txtSMTP.Text);
            SaveLine("IZP", txtImageZipPath.Text);
            SaveLine("GC", uneGC.Value.ToString());

        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            string path = Config.ProjectDirectory + "\\efts.jtc";
            if (!File.Exists(path)) return;
            File.Delete(path);
            txtExtractDocPath.Text = string.Empty;
            txtImagePath.Text = string.Empty;
            txtImageZipPath.Text = string.Empty;
            txtSMTP.Text = string.Empty;
            txtZipDocPath.Text = string.Empty;
            uneGC.Value = 0;


        }
        private void btnSaveGC_Click(object sender, EventArgs e)
        {
            SaveLine("GC", uneGC.Value.ToString());
        }

        private void btnDeleteGC_Click(object sender, EventArgs e)
        {
            DeleteLine("GC");
            uneGC.Value = 0;
        }

        private void btnBrowseZDP_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtZipDocPath.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnBrowseEDP_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtExtractDocPath.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnBrowseIP_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtImagePath.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnBrowseIZP_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtImageZipPath.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        
    }
}
