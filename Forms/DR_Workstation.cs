using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Reflection;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JTay.FrameWork;
using JTay.FrameWork.Enumerators;
using JTay.FrameWork.Interfaces;
using JTay.FrameWork.Support;
using JTay.NextGen;
using Microsoft.VisualBasic.Logging;

namespace NGDR_Workstation
{
    public partial class DR_Workstation : Form
    {

        private readonly string location;
        private readonly bool sameProvider;
        private readonly int appt_days = 1;
        private static readonly ArrayList filesUnzipped = new ArrayList();
        //private static readonly IDataLayer ssDataLayer = DataLayerFactory.CreateDataLayer(DataSourceType.MySql, ConnectionStrings.ConnectionString("FT"));


        public DR_Workstation()
        {
            InitializeComponent();
        }

        public DR_Workstation(string passedLoc, bool passesPro, int appt_day)
        {
            InitializeComponent();
            location = passedLoc;
            sameProvider = passesPro;
            appt_days = appt_day;

        }

        private void DR_Workstation_Load(object sender, EventArgs e)
        {
            try
            {
                lblFVersion.Text = Config.Version;
                lblDB.Text = Config.PrimaryDBName;
                lblAppVersion.Text = "v" + Assembly.GetExecutingAssembly().GetName().Version;
                BindLocations();
                CollectGarbage();
                if (!string.IsNullOrEmpty(location))
                {
                    foreach (DataRowView item in cmbLocation.Items)
                    {
                        if (string.Compare(item[0].ToString(), location, true) != 0) continue;
                        cmbLocation.SelectedItem = item;
                        break;
                    }
                    cbSameProvider.Checked = sameProvider;
                    dtApptDate.Value = DateTime.Now.AddDays(1);
                    MoveAndExtract();
                }
            }
            catch (Exception exc)
            {
                string message = "EMR Nighly File Transfer encountered the following problem: " + exc.Message;
                if (!string.IsNullOrEmpty(location))
                {

                    SendEmail("EMR Nightly File Transfer Encountered a problem", message);
                }
                else
                {
                    MessageBox.Show(message, "Encountered A Problem", 0, MessageBoxIcon.Error);
                }
            }
        }

        private static void AddFileToZip(string file, ArrayList zipList)
        {
            FileInfo info = new FileInfo(file);
            if (info.Extension != ".kjzip")
            {
                zipList.Add(file);
                //Log log = new Log(ssDataLayer)
                //{
                //    FileName = file,
                //    Image = true,
                //    Action = Actions.Zip,
                //    Date_created = DateTime.Now,
                //    Machine = Environment.MachineName
                //};
                //log.Save();
            }
        }


        #region Business Logic

        private static void SendEmail(string subject, string message)
        {
            MailMessage mailMessage = new MailMessage();
            mailMessage.To.Add(Emails);
            mailMessage.From = new MailAddress("alerts.RES@J-Tay.com", "EMR Nightly File Transfer");
            mailMessage.Subject = subject;
            mailMessage.Priority = MailPriority.High;
            mailMessage.Body = message;
            mailMessage.IsBodyHtml = true;
            SmtpClient client = new SmtpClient(SmtpServer(), 25) { UseDefaultCredentials = true };
            client.Send(mailMessage);

        }

        private void BindLocations()
        {
            cmbLocation.DataSource = CommonObjectsList.DisplayLocations(true, false);
            cmbLocation.DisplayMember = "location_name";
            cmbLocation.ValueMember = "location_id";

        }
        private void CollectGarbage()
        {
            string extractPath = GetPath("EDP");
            if (String.IsNullOrEmpty(extractPath)) return;
            if (!Directory.Exists(extractPath)) return;

            int gc = GC;
            foreach (string file in Directory.GetFiles(extractPath))
            {
                FileInfo info = new FileInfo(file);
                if (info.LastAccessTime >= DateTime.Now.AddDays(gc)) continue;
                File.Delete(file);
                //Log log = new Log(ssDataLayer)
                //{
                //    FileName = "From EMR Directory - " + file
                //               Image = false,
                //               Action = Actions.Remove,
                //               Date_created = DateTime.Now,
                //               Machine = Environment.MachineName

                //};
                //log.Save();
            }

            foreach (string directory in Directory.GetDirectories(extractPath))
            {
                foreach (string dir in Directory.GetDirectories(directory))
                {
                    foreach (string sub in Directory.GetDirectories(dir))
                    {
                        if (Directory.GetLastAccessTime(sub) >= DateTime.Now.AddDays(gc)) continue;
                        Directory.Delete(sub, true);
                    }
                }
            }

            string imageDir = GetPath("IP");
            if (string.IsNullOrEmpty(imageDir)) return;
            DirectoryInfo directoryInfo = new DirectoryInfo(imageDir);
            string tempDir = directoryInfo.Root.Name + "Transferred\\";
            if (!Directory.Exists(tempDir)) return;
            foreach (string directory in Directory.GetDirectories(tempDir))
            {
                if (Directory.GetLastAccessTime(directory) >= DateTime.Now.AddDays(gc * 2)) continue;
                Directory.Delete(directory, true);
            }
        }

        //private void MoveAndExtract()
        //{
        //    string zippedDocPath = GetPath("ZDP");
        //    string extractPath = GetPath("EDP");
        //    if (!string.IsNullOrEmpty(zippedDocPath) && !String.IsNullOrEmpty(extractPath))
        //    {
        //        extractPath += "\\";
        //        DateTime dateToUse = Convert.ToDateTime(dtApptDate.Value);
        //        string loc_name = cmbLocation.Text;
        //        string sourceDir = zippedDocPath + "\\" + loc_name + "\\" + dateToUse.ToString("MMMM_dd_yyyy") + "\\";
        //        string zipFile = "EMR_" + dateToUse.ToString("MM_dd_yyyy") + ".kjzip";
        //        ZipImagesAndSendFile(dateToUse, loc_name);
        //        if (File.Exists(sourceDir + zipFile))
        //        {
        //            if (!Directory.Exists(extractPath))
        //                Directory.CreateDirectory(extractPath);

        //            File.Copy(sourceDir + zipFile, extractPath + zipFile, true);
        //            ZipFileHelper.ExtractZipFile(extractPath + zipFile, extractPath);
        //            File.Delete(sourceDir + zipFile);
        //            ReadItemsUnZip(extractPath + "docs\\" + loc_name + "\\" + dateToUse.ToString("MMMM_dd_yyyy") + "\\");




        //            if (!String.IsNullOrEmpty(location))
        //            {
        //                string subject = "Files Unzipped for " + loc_name;
        //                string message = subject + " by " + Environment.MachineName + "<br />Unzipped " + filesUnzipped.Count + " files";
        //                message += "<br /><a href=\"http://" + Environment.MachineName + "/SSLog_root/log.aspx?d=" + DateTime.Now.ToString("yyyy/MM/dd") + "&a=" + (int)Actions.Unzip + "\">Click to see which files were unzipped</>";
        //                message += "<br /><a href=\"http://SSLog/log.aspx?d=" + DateTime.Now.ToString("yyyy/MM/dd") + "&a=" + (int)Actions.Zip + "&l=" + loc_name + "\">Click to see which files were Zipped by EMR Nightly Creator</>";
        //                SendEmail(subject, message);
        //                Application.Exit();
        //            }
        //            else
        //            {

        //                MessageBox.Show("Successfully Transfered and unzipped your files");
        //            }
        //        }
        //        else
        //        {
        //            DataTable table = EMRFileCreator.ExistingDocuments(
        //                    cmbLocation.SelectedValue.ToString(), Convert.ToDateTime(dtApptDate.Value),
        //                    cbSameProvider.Checked, appt_days);
        //            if (table.Rows.Count > 0)
        //            {
        //                if (!String.IsNullOrEmpty(location))
        //                {
        //                    string body = "Could not find a zip file for " + loc_name + " for appointments on " +
        //                          dateToUse.ToString("MMMM dd yyyy") +
        //                          " on the server.  There are documents that need to be transferred";
        //                    SendEmail("Could not find the zip file", body);
        //                    Application.Exit();
        //                }
        //                else
        //                {
        //                    MessageBox.Show(
        //                        "The zip file is missing from the server. Please log into the server and try running the EMR Nightly File Creator for your location manually.",
        //                        "Missing Zip file", 0, MessageBoxIcon.Error);
        //                }

        //            }
        //            else
        //            {
        //                if (!String.IsNullOrEmpty(location))
        //                    Application.Exit();
        //                else
        //                {


        //                    MessageBox.Show("There are no Documents that need to be transferred.",
        //                                    "No Documents for this location", 0, MessageBoxIcon.Information);
        //                }
        //            }


        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Please Make sure your EMR Document Path is Set", "Missing Document Path", 0,
        //                        MessageBoxIcon.Error);
        //    }
        //}

        // Replace - private static void ZipIamgesAndSendFile(DateTime dateToTuse, string location_name)

        // Replace - private static void AddItemsToZip(string path, ArrayList zipList)

        private static void ProcessDirectory(string path, ArrayList zipList)
        {
            // Process the list of files found in the directory.
            string[] fileEntries = Directory.GetFiles(path);
            foreach (string fileName in fileEntries)
                AddFileToZip(fileName, zipList);


            // Recurse into subdirectories of this directory.
            string[] subdirectoryEntries = Directory.GetDirectories(path);
            foreach (string subdirectory in subdirectoryEntries)
                ProcessDirectory(subdirectory, zipList);
        }

        // Replace - private static void ReadFilesUnZip(string file)

        // Replace - private static void ReadItemsUnZip(string path)

        // Replace - private static void ProcessUnzipDirectory(string path)

        // Replace - private static void AddFileToZip(string file, ArrayList zipList)

        #endregion

        #region Config

        private static string GetPath(string item)
        {
            string path = Config.ProjectDirectory + "\\efts.jtc";
            string docpath = string.Empty;
            if (File.Exists(path))
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    while (!reader.EndOfStream)
                    {
                        string[] parts = reader.ReadLine().Split('|');
                        if (parts[0] == item)
                            return parts[1];

                    }
                }
            }

            return docpath;
        }
        private static string Emails
        {
            get
            {
                string emails = "alerts.RES@J-tay.com";
                if (!File.Exists(Config.ProjectDirectory + "emc.jtc")) return emails;
                using (StreamReader reader = new StreamReader(Config.ProjectDirectory + "\\emc.jtc"))
                {
                    emails = reader.ReadToEnd();
                }

                if (string.IsNullOrEmpty(emails))
                    emails = "alerts.RES@J-Tay.com";
                return emails;
            }
        }
        private static string SmtpServer()
        {
            string connect = GetPath("SMTP");
            if (String.IsNullOrEmpty(connect))
                connect = "localhost";
            return connect;
        }
        private static int GC
        {
            get
            {
                string gc = GetPath("GC");
                if (StringUtility.IsNumeric(gc, NumberStyles.Number))
                    return Convert.ToInt32(gc) * -1;

                return -3;
            }
        }

        #endregion
    }
}
