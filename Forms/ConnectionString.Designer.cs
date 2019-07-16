namespace NGDR_Workstation.Forms
{
    partial class ConnectionString
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
            this.connectionStringManager1 = new JTay.ConnectionStringManager.ConnectionStringManager();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblAppVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblDB = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblFVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnClose = new Infragistics.Win.Misc.UltraButton();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // connectionStringManager1
            // 
            this.connectionStringManager1.Location = new System.Drawing.Point(2, 1);
            this.connectionStringManager1.Name = "connectionStringManager1";
            this.connectionStringManager1.Size = new System.Drawing.Size(1054, 340);
            this.connectionStringManager1.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblAppVersion,
            this.lblDB,
            this.lblFVersion});
            this.statusStrip1.Location = new System.Drawing.Point(0, 391);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1059, 22);
            this.statusStrip1.TabIndex = 1;
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
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(967, 348);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            // 
            // ConnectionString
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 413);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.connectionStringManager1);
            this.Name = "ConnectionString";
            this.Text = "Connection String";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private JTay.ConnectionStringManager.ConnectionStringManager connectionStringManager1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblAppVersion;
        private System.Windows.Forms.ToolStripStatusLabel lblDB;
        private System.Windows.Forms.ToolStripStatusLabel lblFVersion;
        private Infragistics.Win.Misc.UltraButton btnClose;
    }
}