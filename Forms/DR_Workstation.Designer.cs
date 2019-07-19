namespace NGDR_Workstation
{
    partial class DR_Workstation
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
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance9 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance10 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance11 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance12 = new Infragistics.Win.Appearance();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectionStringsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileSystemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emailAddressesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblAppVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblDB = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblFVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblDate = new Infragistics.Win.Misc.UltraLabel();
            this.dtApptDate = new Infragistics.Win.UltraWinEditors.UltraDateTimeEditor();
            this.lblLocation = new Infragistics.Win.Misc.UltraLabel();
            this.cmbLocation = new Infragistics.Win.UltraWinGrid.UltraCombo();
            this.cbSameProvider = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
            this.btnTransfer = new Infragistics.Win.Misc.UltraButton();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtApptDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbLocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSameProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectionStringsToolStripMenuItem,
            this.fileSystemToolStripMenuItem,
            this.emailAddressesToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // connectionStringsToolStripMenuItem
            // 
            this.connectionStringsToolStripMenuItem.Name = "connectionStringsToolStripMenuItem";
            this.connectionStringsToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.connectionStringsToolStripMenuItem.Text = "Connection Strings";
            // 
            // fileSystemToolStripMenuItem
            // 
            this.fileSystemToolStripMenuItem.Name = "fileSystemToolStripMenuItem";
            this.fileSystemToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.fileSystemToolStripMenuItem.Text = "File System";
            // 
            // emailAddressesToolStripMenuItem
            // 
            this.emailAddressesToolStripMenuItem.Name = "emailAddressesToolStripMenuItem";
            this.emailAddressesToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.emailAddressesToolStripMenuItem.Text = "Email Addresses";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblAppVersion,
            this.lblDB,
            this.lblFVersion});
            this.statusStrip1.Location = new System.Drawing.Point(0, 211);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
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
            // lblDate
            // 
            this.lblDate.Location = new System.Drawing.Point(13, 45);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(70, 23);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Appt Date";
            // 
            // dtApptDate
            // 
            this.dtApptDate.Location = new System.Drawing.Point(89, 41);
            this.dtApptDate.Name = "dtApptDate";
            this.dtApptDate.Size = new System.Drawing.Size(90, 21);
            this.dtApptDate.TabIndex = 3;
            // 
            // lblLocation
            // 
            this.lblLocation.Location = new System.Drawing.Point(13, 75);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(70, 23);
            this.lblLocation.TabIndex = 4;
            this.lblLocation.Text = "Location";
            // 
            // cmbLocation
            // 
            appearance1.BackColor = System.Drawing.SystemColors.Window;
            appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.cmbLocation.DisplayLayout.Appearance = appearance1;
            this.cmbLocation.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            this.cmbLocation.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False;
            appearance2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            appearance2.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance2.BorderColor = System.Drawing.SystemColors.Window;
            this.cmbLocation.DisplayLayout.GroupByBox.Appearance = appearance2;
            appearance3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.cmbLocation.DisplayLayout.GroupByBox.BandLabelAppearance = appearance3;
            this.cmbLocation.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            appearance4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            appearance4.BackColor2 = System.Drawing.SystemColors.Control;
            appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.cmbLocation.DisplayLayout.GroupByBox.PromptAppearance = appearance4;
            this.cmbLocation.DisplayLayout.MaxColScrollRegions = 1;
            this.cmbLocation.DisplayLayout.MaxRowScrollRegions = 1;
            appearance5.BackColor = System.Drawing.SystemColors.Window;
            appearance5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmbLocation.DisplayLayout.Override.ActiveCellAppearance = appearance5;
            appearance6.BackColor = System.Drawing.SystemColors.Highlight;
            appearance6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cmbLocation.DisplayLayout.Override.ActiveRowAppearance = appearance6;
            this.cmbLocation.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted;
            this.cmbLocation.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted;
            appearance7.BackColor = System.Drawing.SystemColors.Window;
            this.cmbLocation.DisplayLayout.Override.CardAreaAppearance = appearance7;
            appearance8.BorderColor = System.Drawing.Color.Silver;
            appearance8.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter;
            this.cmbLocation.DisplayLayout.Override.CellAppearance = appearance8;
            this.cmbLocation.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            this.cmbLocation.DisplayLayout.Override.CellPadding = 0;
            appearance9.BackColor = System.Drawing.SystemColors.Control;
            appearance9.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance9.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element;
            appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance9.BorderColor = System.Drawing.SystemColors.Window;
            this.cmbLocation.DisplayLayout.Override.GroupByRowAppearance = appearance9;
            appearance10.TextHAlignAsString = "Left";
            this.cmbLocation.DisplayLayout.Override.HeaderAppearance = appearance10;
            this.cmbLocation.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            this.cmbLocation.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand;
            appearance11.BackColor = System.Drawing.SystemColors.Window;
            appearance11.BorderColor = System.Drawing.Color.Silver;
            this.cmbLocation.DisplayLayout.Override.RowAppearance = appearance11;
            this.cmbLocation.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False;
            appearance12.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cmbLocation.DisplayLayout.Override.TemplateAddRowAppearance = appearance12;
            this.cmbLocation.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.cmbLocation.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.cmbLocation.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.cmbLocation.Location = new System.Drawing.Point(89, 75);
            this.cmbLocation.Name = "cmbLocation";
            this.cmbLocation.Size = new System.Drawing.Size(266, 22);
            this.cmbLocation.TabIndex = 5;
            // 
            // cbSameProvider
            // 
            this.cbSameProvider.Location = new System.Drawing.Point(13, 112);
            this.cbSameProvider.Name = "cbSameProvider";
            this.cbSameProvider.Size = new System.Drawing.Size(619, 20);
            this.cbSameProvider.TabIndex = 6;
            this.cbSameProvider.Text = "Verify ONLY dociment whose rendering provider is the same as the rendering provid" +
    "er on the upcoming appointment";
            // 
            // btnTransfer
            // 
            this.btnTransfer.Location = new System.Drawing.Point(23, 147);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(98, 23);
            this.btnTransfer.TabIndex = 7;
            this.btnTransfer.Text = "Transfer Files";
            // 
            // DR_Workstation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 233);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.cbSameProvider);
            this.Controls.Add(this.cmbLocation);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.dtApptDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DR_Workstation";
            this.Text = "NextGen Nightly File Creator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtApptDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbLocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSameProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectionStringsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileSystemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emailAddressesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblAppVersion;
        private System.Windows.Forms.ToolStripStatusLabel lblDB;
        private System.Windows.Forms.ToolStripStatusLabel lblFVersion;
        private Infragistics.Win.Misc.UltraLabel lblDate;
        private Infragistics.Win.UltraWinEditors.UltraDateTimeEditor dtApptDate;
        private Infragistics.Win.Misc.UltraLabel lblLocation;
        private Infragistics.Win.UltraWinGrid.UltraCombo cmbLocation;
        private Infragistics.Win.UltraWinEditors.UltraCheckEditor cbSameProvider;
        private Infragistics.Win.Misc.UltraButton btnTransfer;
    }
}

