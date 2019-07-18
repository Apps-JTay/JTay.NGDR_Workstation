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
    public partial class EmailAddressCollector : Form
    {
        public EmailAddressCollector()
        {
            InitializeComponent();
        }

        private void EmailAddressCollector_Load(object sender, EventArgs e)
        {
            lblFVersion.Text = Config.Version;
            lblDB.Text = Config.PrimaryDBName;
            lblAppVersion.Text = "v" + Assembly.GetExecutingAssembly().GetName().Version;

            if (!Directory.Exists(Config.ProjectDirectory))
                Directory.CreateDirectory(Config.ProjectDirectory);

            if (!File.Exists(Config.ProjectDirectory + "\\emc.jtc")) return;
            using (StreamReader reader = new StreamReader(Config.ProjectDirectory + "\\emc.jtc"))
            {
                ultraFormattedTextEditor1.Value = reader.ReadToEnd();
            }
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string path = Config.ProjectDirectory + "\\emc.jtc";
            if (File.Exists(path))
            {
                File.Delete(path);
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine(ultraFormattedTextEditor1.Value);
                }
            }
            else
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine(ultraFormattedTextEditor1.Value);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            String path = Config.ProjectDirectory + "\\emc.jtc";
            if (!File.Exists(path)) return;
            File.Delete(path);
            ultraFormattedTextEditor1.Value = "";
        }
    }
}
