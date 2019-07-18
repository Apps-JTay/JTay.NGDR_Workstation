namespace NGDR_Workstation.Forms
{
    partial class EMRFileSystem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblAppVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblDB = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblFVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblDocLocation = new Infragistics.Win.Misc.UltraLabel();
            this.btnSaveZPD = new Infragistics.Win.Misc.UltraButton();
            this.btnDeleteZPD = new Infragistics.Win.Misc.UltraButton();
            this.txtZipDocPath = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.btnBrowseZDP = new Infragistics.Win.Misc.UltraButton();
            this.lblLocPath = new Infragistics.Win.Misc.UltraLabel();
            this.btnSaveEDP = new Infragistics.Win.Misc.UltraButton();
            this.btnDeleteEDP = new Infragistics.Win.Misc.UltraButton();
            this.txtExtractDocPath = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.btnBrowseEDP = new Infragistics.Win.Misc.UltraButton();
            this.lblUmageZipPath = new Infragistics.Win.Misc.UltraLabel();
            this.btnSaveIP = new Infragistics.Win.Misc.UltraButton();
            this.btnDeleteIP = new Infragistics.Win.Misc.UltraButton();
            this.txtImagePath = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.btnBrowseIP = new Infragistics.Win.Misc.UltraButton();
            this.lblImageExtractPath = new Infragistics.Win.Misc.UltraLabel();
            this.btnSaveIZP = new Infragistics.Win.Misc.UltraButton();
            this.btnDeleteIZP = new Infragistics.Win.Misc.UltraButton();
            this.txtImageZipPath = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.btnBrowseIZP = new Infragistics.Win.Misc.UltraButton();
            this.lblSmtp = new Infragistics.Win.Misc.UltraLabel();
            this.btnSaveSmtp = new Infragistics.Win.Misc.UltraButton();
            this.btnDeleteSmtp = new Infragistics.Win.Misc.UltraButton();
            this.txtSMTP = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.ultraLabel1 = new Infragistics.Win.Misc.UltraLabel();
            this.btnSaveGC = new Infragistics.Win.Misc.UltraButton();
            this.btnDeleteGC = new Infragistics.Win.Misc.UltraButton();
            this.uneGC = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.btnSaveAll = new Infragistics.Win.Misc.UltraButton();
            this.btnDeleteAll = new Infragistics.Win.Misc.UltraButton();
            this.btnClose = new Infragistics.Win.Misc.UltraButton();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtZipDocPath)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExtractDocPath)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtImagePath)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtImageZipPath)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSMTP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneGC)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblAppVersion,
            this.lblDB,
            this.lblFVersion});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblAppVersion
            // 
            this.lblAppVersion.Name = "lblAppVersion";
            this.lblAppVersion.Size = new System.Drawing.Size(81, 17);
            this.lblAppVersion.Text = "lblAppVersion";
            // 
            // lblDB
            // 
            this.lblDB.Name = "lblDB";
            this.lblDB.Size = new System.Drawing.Size(35, 17);
            this.lblDB.Text = "lblDB";
            // 
            // lblFVersion
            // 
            this.lblFVersion.Name = "lblFVersion";
            this.lblFVersion.Size = new System.Drawing.Size(65, 17);
            this.lblFVersion.Text = "lblFVersion";
            // 
            // lblDocLocation
            // 
            this.lblDocLocation.Location = new System.Drawing.Point(13, 18);
            this.lblDocLocation.Name = "lblDocLocation";
            this.lblDocLocation.Size = new System.Drawing.Size(265, 23);
            this.lblDocLocation.TabIndex = 1;
            this.lblDocLocation.Text = "Path to document zip file";
            // 
            // btnSaveZPD
            // 
            this.btnSaveZPD.Location = new System.Drawing.Point(284, 13);
            this.btnSaveZPD.Name = "btnSaveZPD";
            this.btnSaveZPD.Size = new System.Drawing.Size(75, 23);
            this.btnSaveZPD.TabIndex = 2;
            this.btnSaveZPD.Text = "Save";
            this.btnSaveZPD.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDeleteZPD
            // 
            this.btnDeleteZPD.Location = new System.Drawing.Point(366, 13);
            this.btnDeleteZPD.Name = "btnDeleteZPD";
            this.btnDeleteZPD.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteZPD.TabIndex = 3;
            this.btnDeleteZPD.Text = "Delete";
            this.btnDeleteZPD.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtZipDocPath
            // 
            this.txtZipDocPath.Location = new System.Drawing.Point(13, 45);
            this.txtZipDocPath.Name = "txtZipDocPath";
            this.txtZipDocPath.Size = new System.Drawing.Size(646, 21);
            this.txtZipDocPath.TabIndex = 4;
            // 
            // btnBrowseZDP
            // 
            this.btnBrowseZDP.Location = new System.Drawing.Point(673, 45);
            this.btnBrowseZDP.Name = "btnBrowseZDP";
            this.btnBrowseZDP.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseZDP.TabIndex = 5;
            this.btnBrowseZDP.Text = "Browse";
            this.btnBrowseZDP.Click += new System.EventHandler(this.btnBrowseZDP_Click);
            // 
            // lblLocPath
            // 
            this.lblLocPath.Location = new System.Drawing.Point(12, 89);
            this.lblLocPath.Name = "lblLocPath";
            this.lblLocPath.Size = new System.Drawing.Size(250, 23);
            this.lblLocPath.TabIndex = 6;
            this.lblLocPath.Text = "Path to Extract Documents";
            // 
            // btnSaveEDP
            // 
            this.btnSaveEDP.Location = new System.Drawing.Point(284, 84);
            this.btnSaveEDP.Name = "btnSaveEDP";
            this.btnSaveEDP.Size = new System.Drawing.Size(75, 23);
            this.btnSaveEDP.TabIndex = 7;
            this.btnSaveEDP.Text = "Save";
            this.btnSaveEDP.Click += new System.EventHandler(this.btnSaveEDP_Click);
            // 
            // btnDeleteEDP
            // 
            this.btnDeleteEDP.Location = new System.Drawing.Point(366, 84);
            this.btnDeleteEDP.Name = "btnDeleteEDP";
            this.btnDeleteEDP.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteEDP.TabIndex = 8;
            this.btnDeleteEDP.Text = "Delete";
            this.btnDeleteEDP.Click += new System.EventHandler(this.btnDeleteEDP_Click);
            // 
            // txtExtractDocPath
            // 
            this.txtExtractDocPath.Location = new System.Drawing.Point(13, 119);
            this.txtExtractDocPath.Name = "txtExtractDocPath";
            this.txtExtractDocPath.Size = new System.Drawing.Size(646, 21);
            this.txtExtractDocPath.TabIndex = 9;
            // 
            // btnBrowseEDP
            // 
            this.btnBrowseEDP.Location = new System.Drawing.Point(673, 117);
            this.btnBrowseEDP.Name = "btnBrowseEDP";
            this.btnBrowseEDP.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseEDP.TabIndex = 10;
            this.btnBrowseEDP.Text = "Browse";
            this.btnBrowseEDP.Click += new System.EventHandler(this.btnBrowseEDP_Click);
            // 
            // lblUmageZipPath
            // 
            this.lblUmageZipPath.Location = new System.Drawing.Point(13, 162);
            this.lblUmageZipPath.Name = "lblUmageZipPath";
            this.lblUmageZipPath.Size = new System.Drawing.Size(249, 23);
            this.lblUmageZipPath.TabIndex = 11;
            this.lblUmageZipPath.Text = "Path to images";
            // 
            // btnSaveIP
            // 
            this.btnSaveIP.Location = new System.Drawing.Point(284, 157);
            this.btnSaveIP.Name = "btnSaveIP";
            this.btnSaveIP.Size = new System.Drawing.Size(75, 23);
            this.btnSaveIP.TabIndex = 12;
            this.btnSaveIP.Text = "Save";
            this.btnSaveIP.Click += new System.EventHandler(this.btnSaveIP_Click);
            // 
            // btnDeleteIP
            // 
            this.btnDeleteIP.Location = new System.Drawing.Point(366, 157);
            this.btnDeleteIP.Name = "btnDeleteIP";
            this.btnDeleteIP.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteIP.TabIndex = 13;
            this.btnDeleteIP.Text = "Delete";
            this.btnDeleteIP.Click += new System.EventHandler(this.btnDeleteIP_Click);
            // 
            // txtImagePath
            // 
            this.txtImagePath.Location = new System.Drawing.Point(13, 192);
            this.txtImagePath.Name = "txtImagePath";
            this.txtImagePath.Size = new System.Drawing.Size(646, 21);
            this.txtImagePath.TabIndex = 14;
            // 
            // btnBrowseIP
            // 
            this.btnBrowseIP.Location = new System.Drawing.Point(673, 192);
            this.btnBrowseIP.Name = "btnBrowseIP";
            this.btnBrowseIP.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseIP.TabIndex = 15;
            this.btnBrowseIP.Text = "Browse";
            this.btnBrowseIP.Click += new System.EventHandler(this.btnBrowseIP_Click);
            // 
            // lblImageExtractPath
            // 
            this.lblImageExtractPath.Location = new System.Drawing.Point(13, 236);
            this.lblImageExtractPath.Name = "lblImageExtractPath";
            this.lblImageExtractPath.Size = new System.Drawing.Size(249, 23);
            this.lblImageExtractPath.TabIndex = 16;
            this.lblImageExtractPath.Text = "Path to send image zip file";
            // 
            // btnSaveIZP
            // 
            this.btnSaveIZP.Location = new System.Drawing.Point(284, 231);
            this.btnSaveIZP.Name = "btnSaveIZP";
            this.btnSaveIZP.Size = new System.Drawing.Size(75, 23);
            this.btnSaveIZP.TabIndex = 17;
            this.btnSaveIZP.Text = "Save";
            this.btnSaveIZP.Click += new System.EventHandler(this.btnSaveIZP_Click);
            // 
            // btnDeleteIZP
            // 
            this.btnDeleteIZP.Location = new System.Drawing.Point(366, 231);
            this.btnDeleteIZP.Name = "btnDeleteIZP";
            this.btnDeleteIZP.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteIZP.TabIndex = 18;
            this.btnDeleteIZP.Text = "Delete";
            this.btnDeleteIZP.Click += new System.EventHandler(this.btnDeleteIZP_Click);
            // 
            // txtImageZipPath
            // 
            this.txtImageZipPath.Location = new System.Drawing.Point(13, 266);
            this.txtImageZipPath.Name = "txtImageZipPath";
            this.txtImageZipPath.Size = new System.Drawing.Size(646, 21);
            this.txtImageZipPath.TabIndex = 19;
            // 
            // btnBrowseIZP
            // 
            this.btnBrowseIZP.Location = new System.Drawing.Point(673, 266);
            this.btnBrowseIZP.Name = "btnBrowseIZP";
            this.btnBrowseIZP.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseIZP.TabIndex = 20;
            this.btnBrowseIZP.Text = "Browse";
            this.btnBrowseIZP.Click += new System.EventHandler(this.btnBrowseIZP_Click);
            // 
            // lblSmtp
            // 
            this.lblSmtp.Location = new System.Drawing.Point(13, 318);
            this.lblSmtp.Name = "lblSmtp";
            this.lblSmtp.Size = new System.Drawing.Size(100, 18);
            this.lblSmtp.TabIndex = 21;
            this.lblSmtp.Text = "SMTP";
            // 
            // btnSaveSmtp
            // 
            this.btnSaveSmtp.Location = new System.Drawing.Point(120, 313);
            this.btnSaveSmtp.Name = "btnSaveSmtp";
            this.btnSaveSmtp.Size = new System.Drawing.Size(75, 23);
            this.btnSaveSmtp.TabIndex = 22;
            this.btnSaveSmtp.Text = "Save";
            this.btnSaveSmtp.Click += new System.EventHandler(this.btnSaveSmtp_Click);
            // 
            // btnDeleteSmtp
            // 
            this.btnDeleteSmtp.Location = new System.Drawing.Point(202, 313);
            this.btnDeleteSmtp.Name = "btnDeleteSmtp";
            this.btnDeleteSmtp.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteSmtp.TabIndex = 23;
            this.btnDeleteSmtp.Text = "Delete";
            this.btnDeleteSmtp.Click += new System.EventHandler(this.btnDeleteSmtp_Click);
            // 
            // txtSMTP
            // 
            this.txtSMTP.Location = new System.Drawing.Point(13, 343);
            this.txtSMTP.Name = "txtSMTP";
            this.txtSMTP.Size = new System.Drawing.Size(264, 21);
            this.txtSMTP.TabIndex = 24;
            // 
            // ultraLabel1
            // 
            this.ultraLabel1.Location = new System.Drawing.Point(322, 313);
            this.ultraLabel1.Name = "ultraLabel1";
            this.ultraLabel1.Size = new System.Drawing.Size(109, 23);
            this.ultraLabel1.TabIndex = 25;
            this.ultraLabel1.Text = "Garbage Collection";
            // 
            // btnSaveGC
            // 
            this.btnSaveGC.Location = new System.Drawing.Point(438, 313);
            this.btnSaveGC.Name = "btnSaveGC";
            this.btnSaveGC.Size = new System.Drawing.Size(75, 23);
            this.btnSaveGC.TabIndex = 26;
            this.btnSaveGC.Text = "Save";
            this.btnSaveGC.Click += new System.EventHandler(this.btnSaveGC_Click);
            // 
            // btnDeleteGC
            // 
            this.btnDeleteGC.Location = new System.Drawing.Point(520, 313);
            this.btnDeleteGC.Name = "btnDeleteGC";
            this.btnDeleteGC.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteGC.TabIndex = 27;
            this.btnDeleteGC.Text = "Delete";
            this.btnDeleteGC.Click += new System.EventHandler(this.btnDeleteGC_Click);
            // 
            // uneGC
            // 
            this.uneGC.Location = new System.Drawing.Point(322, 343);
            this.uneGC.Name = "uneGC";
            this.uneGC.Size = new System.Drawing.Size(100, 21);
            this.uneGC.TabIndex = 28;
            // 
            // btnSaveAll
            // 
            this.btnSaveAll.Location = new System.Drawing.Point(57, 382);
            this.btnSaveAll.Name = "btnSaveAll";
            this.btnSaveAll.Size = new System.Drawing.Size(75, 23);
            this.btnSaveAll.TabIndex = 29;
            this.btnSaveAll.Text = "Save All";
            this.btnSaveAll.Click += new System.EventHandler(this.btnSaveAll_Click);
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.Location = new System.Drawing.Point(139, 382);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteAll.TabIndex = 30;
            this.btnDeleteAll.Text = "Delete All";
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(248, 382);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 31;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // EMRFileSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDeleteAll);
            this.Controls.Add(this.btnSaveAll);
            this.Controls.Add(this.uneGC);
            this.Controls.Add(this.btnDeleteGC);
            this.Controls.Add(this.btnSaveGC);
            this.Controls.Add(this.ultraLabel1);
            this.Controls.Add(this.txtSMTP);
            this.Controls.Add(this.btnDeleteSmtp);
            this.Controls.Add(this.btnSaveSmtp);
            this.Controls.Add(this.lblSmtp);
            this.Controls.Add(this.btnBrowseIZP);
            this.Controls.Add(this.txtImageZipPath);
            this.Controls.Add(this.btnDeleteIZP);
            this.Controls.Add(this.btnSaveIZP);
            this.Controls.Add(this.lblImageExtractPath);
            this.Controls.Add(this.btnBrowseIP);
            this.Controls.Add(this.txtImagePath);
            this.Controls.Add(this.btnDeleteIP);
            this.Controls.Add(this.btnSaveIP);
            this.Controls.Add(this.lblUmageZipPath);
            this.Controls.Add(this.btnBrowseEDP);
            this.Controls.Add(this.txtExtractDocPath);
            this.Controls.Add(this.btnDeleteEDP);
            this.Controls.Add(this.btnSaveEDP);
            this.Controls.Add(this.lblLocPath);
            this.Controls.Add(this.btnBrowseZDP);
            this.Controls.Add(this.txtZipDocPath);
            this.Controls.Add(this.btnDeleteZPD);
            this.Controls.Add(this.btnSaveZPD);
            this.Controls.Add(this.lblDocLocation);
            this.Controls.Add(this.statusStrip1);
            this.Name = "EMRFileSystem";
            this.Text = "EMR File System";
            this.Load += new System.EventHandler(this.EMRFileSystem_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtZipDocPath)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExtractDocPath)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtImagePath)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtImageZipPath)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSMTP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneGC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblAppVersion;
        private System.Windows.Forms.ToolStripStatusLabel lblDB;
        private System.Windows.Forms.ToolStripStatusLabel lblFVersion;
        private Infragistics.Win.Misc.UltraLabel lblDocLocation;
        private Infragistics.Win.Misc.UltraButton btnSaveZPD;
        private Infragistics.Win.Misc.UltraButton btnDeleteZPD;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtZipDocPath;
        private Infragistics.Win.Misc.UltraButton btnBrowseZDP;
        private Infragistics.Win.Misc.UltraLabel lblLocPath;
        private Infragistics.Win.Misc.UltraButton btnSaveEDP;
        private Infragistics.Win.Misc.UltraButton btnDeleteEDP;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtExtractDocPath;
        private Infragistics.Win.Misc.UltraButton btnBrowseEDP;
        private Infragistics.Win.Misc.UltraLabel lblUmageZipPath;
        private Infragistics.Win.Misc.UltraButton btnSaveIP;
        private Infragistics.Win.Misc.UltraButton btnDeleteIP;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtImagePath;
        private Infragistics.Win.Misc.UltraButton btnBrowseIP;
        private Infragistics.Win.Misc.UltraLabel lblImageExtractPath;
        private Infragistics.Win.Misc.UltraButton btnSaveIZP;
        private Infragistics.Win.Misc.UltraButton btnDeleteIZP;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtImageZipPath;
        private Infragistics.Win.Misc.UltraButton btnBrowseIZP;
        private Infragistics.Win.Misc.UltraLabel lblSmtp;
        private Infragistics.Win.Misc.UltraButton btnSaveSmtp;
        private Infragistics.Win.Misc.UltraButton btnDeleteSmtp;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtSMTP;
        private Infragistics.Win.Misc.UltraLabel ultraLabel1;
        private Infragistics.Win.Misc.UltraButton btnSaveGC;
        private Infragistics.Win.Misc.UltraButton btnDeleteGC;
        private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneGC;
        private Infragistics.Win.Misc.UltraButton btnSaveAll;
        private Infragistics.Win.Misc.UltraButton btnDeleteAll;
        private Infragistics.Win.Misc.UltraButton btnClose;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}