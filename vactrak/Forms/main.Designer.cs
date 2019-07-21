﻿namespace vactrak
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "",
            "profiles/000000000000000000",
            "account name",
            "false",
            "00d:00h:00m:00s",
            "notes notes notes notes notes ",
            "Status text"}, -1);
            this.toolstrip = new System.Windows.Forms.ToolStrip();
            this.ddAccount = new System.Windows.Forms.ToolStripDropDownButton();
            this.ddAccountAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.ddAccountRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.ddAccountImport = new System.Windows.Forms.ToolStripMenuItem();
            this.ddAccountImportSAC = new System.Windows.Forms.ToolStripMenuItem();
            this.ddAccountSAG = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ddManage = new System.Windows.Forms.ToolStripDropDownButton();
            this.ddManageObtain = new System.Windows.Forms.ToolStripMenuItem();
            this.ddManageObtainBan = new System.Windows.Forms.ToolStripMenuItem();
            this.ddManageObtainName = new System.Windows.Forms.ToolStripMenuItem();
            this.ddManageObtainBoth = new System.Windows.Forms.ToolStripMenuItem();
            this.ddManageLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.ddManageLoginNormal = new System.Windows.Forms.ToolStripMenuItem();
            this.ddManageLoginForce = new System.Windows.Forms.ToolStripMenuItem();
            this.ddManageClipboard = new System.Windows.Forms.ToolStripMenuItem();
            this.ddManageClipboardUserPass = new System.Windows.Forms.ToolStripMenuItem();
            this.ddManageClipboardURL = new System.Windows.Forms.ToolStripMenuItem();
            this.ddManageClipboardNotes = new System.Windows.Forms.ToolStripMenuItem();
            this.ddManageClipboardAll = new System.Windows.Forms.ToolStripMenuItem();
            this.ddManageClipboardOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.ddManageCooldown = new System.Windows.Forms.ToolStripMenuItem();
            this.ddManageCooldown7days = new System.Windows.Forms.ToolStripMenuItem();
            this.ddManageCooldown7day = new System.Windows.Forms.ToolStripMenuItem();
            this.ddManageCooldown22hours = new System.Windows.Forms.ToolStripMenuItem();
            this.ddManageCooldown21hours = new System.Windows.Forms.ToolStripMenuItem();
            this.ddManageCooldown2hours = new System.Windows.Forms.ToolStripMenuItem();
            this.ddManageCooldown1hour = new System.Windows.Forms.ToolStripMenuItem();
            this.ddManageCooldown30min = new System.Windows.Forms.ToolStripMenuItem();
            this.ddManageCooldown15min = new System.Windows.Forms.ToolStripMenuItem();
            this.ddManageCooldownRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.ddManageCooldownCustom = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ddProfile = new System.Windows.Forms.ToolStripDropDownButton();
            this.addProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.copyAccountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveAccountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbProfile = new System.Windows.Forms.ToolStripComboBox();
            this.btnProfileSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ddUtils = new System.Windows.Forms.ToolStripDropDownButton();
            this.ddUtilsEditor = new System.Windows.Forms.ToolStripMenuItem();
            this.ddUtilsDump = new System.Windows.Forms.ToolStripMenuItem();
            this.ddUtilsDumpSelected = new System.Windows.Forms.ToolStripMenuItem();
            this.ddUtilsDumpProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.ddUtilsDumpAll = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSettings = new System.Windows.Forms.ToolStripButton();
            this.btnAbout = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.lblBuildInfo = new System.Windows.Forms.ToolStripLabel();
            this.lvData = new System.Windows.Forms.ListView();
            this.ch_special_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSteamURL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chUser = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chBanned = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNote = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.tbNote = new System.Windows.Forms.TextBox();
            this.toolstrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolstrip
            // 
            this.toolstrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ddAccount,
            this.toolStripSeparator1,
            this.ddManage,
            this.toolStripSeparator2,
            this.ddProfile,
            this.cbProfile,
            this.btnProfileSave,
            this.toolStripSeparator3,
            this.ddUtils,
            this.btnSettings,
            this.btnAbout,
            this.toolStripSeparator4,
            this.lblBuildInfo});
            this.toolstrip.Location = new System.Drawing.Point(0, 0);
            this.toolstrip.Name = "toolstrip";
            this.toolstrip.Size = new System.Drawing.Size(774, 25);
            this.toolstrip.TabIndex = 8;
            // 
            // ddAccount
            // 
            this.ddAccount.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ddAccount.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ddAccountAdd,
            this.ddAccountRemove,
            this.ddAccountImport,
            this.ddAccountSAG});
            this.ddAccount.ForeColor = System.Drawing.Color.Black;
            this.ddAccount.Image = ((System.Drawing.Image)(resources.GetObject("ddAccount.Image")));
            this.ddAccount.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ddAccount.Name = "ddAccount";
            this.ddAccount.Size = new System.Drawing.Size(65, 22);
            this.ddAccount.Text = "Account";
            // 
            // ddAccountAdd
            // 
            this.ddAccountAdd.Image = global::vactrak.Properties.Resources.plus;
            this.ddAccountAdd.Name = "ddAccountAdd";
            this.ddAccountAdd.Size = new System.Drawing.Size(146, 22);
            this.ddAccountAdd.Text = "Add";
            // 
            // ddAccountRemove
            // 
            this.ddAccountRemove.Image = global::vactrak.Properties.Resources.minus;
            this.ddAccountRemove.Name = "ddAccountRemove";
            this.ddAccountRemove.Size = new System.Drawing.Size(146, 22);
            this.ddAccountRemove.Text = "Remove";
            // 
            // ddAccountImport
            // 
            this.ddAccountImport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ddAccountImportSAC});
            this.ddAccountImport.Name = "ddAccountImport";
            this.ddAccountImport.Size = new System.Drawing.Size(146, 22);
            this.ddAccountImport.Text = "Import";
            // 
            // ddAccountImportSAC
            // 
            this.ddAccountImportSAC.Image = global::vactrak.Properties.Resources.steam_logo;
            this.ddAccountImportSAC.Name = "ddAccountImportSAC";
            this.ddAccountImportSAC.Size = new System.Drawing.Size(150, 22);
            this.ddAccountImportSAC.Text = "EarsKilla\'s SAC";
            // 
            // ddAccountSAG
            // 
            this.ddAccountSAG.Image = global::vactrak.Properties.Resources.cathook;
            this.ddAccountSAG.Name = "ddAccountSAG";
            this.ddAccountSAG.Size = new System.Drawing.Size(146, 22);
            this.ddAccountSAG.Text = "SAG Generate";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // ddManage
            // 
            this.ddManage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ddManage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ddManageObtain,
            this.ddManageLogin,
            this.ddManageClipboard,
            this.ddManageCooldown});
            this.ddManage.ForeColor = System.Drawing.Color.Black;
            this.ddManage.Image = ((System.Drawing.Image)(resources.GetObject("ddManage.Image")));
            this.ddManage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ddManage.Name = "ddManage";
            this.ddManage.Size = new System.Drawing.Size(63, 22);
            this.ddManage.Text = "Manage";
            // 
            // ddManageObtain
            // 
            this.ddManageObtain.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ddManageObtainBan,
            this.ddManageObtainName,
            this.ddManageObtainBoth});
            this.ddManageObtain.Image = global::vactrak.Properties.Resources.refresh;
            this.ddManageObtain.Name = "ddManageObtain";
            this.ddManageObtain.Size = new System.Drawing.Size(134, 22);
            this.ddManageObtain.Text = "Obtain Info";
            // 
            // ddManageObtainBan
            // 
            this.ddManageObtainBan.Name = "ddManageObtainBan";
            this.ddManageObtainBan.Size = new System.Drawing.Size(129, 22);
            this.ddManageObtainBan.Text = "Ban Status";
            // 
            // ddManageObtainName
            // 
            this.ddManageObtainName.Name = "ddManageObtainName";
            this.ddManageObtainName.Size = new System.Drawing.Size(129, 22);
            this.ddManageObtainName.Text = "Name";
            // 
            // ddManageObtainBoth
            // 
            this.ddManageObtainBoth.Name = "ddManageObtainBoth";
            this.ddManageObtainBoth.Size = new System.Drawing.Size(129, 22);
            this.ddManageObtainBoth.Text = "Both";
            // 
            // ddManageLogin
            // 
            this.ddManageLogin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ddManageLoginNormal,
            this.ddManageLoginForce});
            this.ddManageLogin.Image = global::vactrak.Properties.Resources.keyboard;
            this.ddManageLogin.Name = "ddManageLogin";
            this.ddManageLogin.Size = new System.Drawing.Size(134, 22);
            this.ddManageLogin.Text = "Login";
            // 
            // ddManageLoginNormal
            // 
            this.ddManageLoginNormal.Name = "ddManageLoginNormal";
            this.ddManageLoginNormal.Size = new System.Drawing.Size(114, 22);
            this.ddManageLoginNormal.Text = "Normal";
            // 
            // ddManageLoginForce
            // 
            this.ddManageLoginForce.Name = "ddManageLoginForce";
            this.ddManageLoginForce.Size = new System.Drawing.Size(114, 22);
            this.ddManageLoginForce.Text = "Force";
            // 
            // ddManageClipboard
            // 
            this.ddManageClipboard.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ddManageClipboardUserPass,
            this.ddManageClipboardURL,
            this.ddManageClipboardNotes,
            this.ddManageClipboardAll,
            this.ddManageClipboardOpen});
            this.ddManageClipboard.Image = global::vactrak.Properties.Resources.clipboard;
            this.ddManageClipboard.Name = "ddManageClipboard";
            this.ddManageClipboard.Size = new System.Drawing.Size(134, 22);
            this.ddManageClipboard.Text = "Clipboard";
            // 
            // ddManageClipboardUserPass
            // 
            this.ddManageClipboardUserPass.Name = "ddManageClipboardUserPass";
            this.ddManageClipboardUserPass.Size = new System.Drawing.Size(216, 22);
            this.ddManageClipboardUserPass.Text = "Username and Password";
            // 
            // ddManageClipboardURL
            // 
            this.ddManageClipboardURL.Name = "ddManageClipboardURL";
            this.ddManageClipboardURL.Size = new System.Drawing.Size(216, 22);
            this.ddManageClipboardURL.Text = "Steam URL";
            // 
            // ddManageClipboardNotes
            // 
            this.ddManageClipboardNotes.Name = "ddManageClipboardNotes";
            this.ddManageClipboardNotes.Size = new System.Drawing.Size(216, 22);
            this.ddManageClipboardNotes.Text = "Notes";
            // 
            // ddManageClipboardAll
            // 
            this.ddManageClipboardAll.Name = "ddManageClipboardAll";
            this.ddManageClipboardAll.Size = new System.Drawing.Size(216, 22);
            this.ddManageClipboardAll.Text = "All";
            // 
            // ddManageClipboardOpen
            // 
            this.ddManageClipboardOpen.Name = "ddManageClipboardOpen";
            this.ddManageClipboardOpen.Size = new System.Drawing.Size(216, 22);
            this.ddManageClipboardOpen.Text = "[Open Clipboard Manager]";
            // 
            // ddManageCooldown
            // 
            this.ddManageCooldown.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ddManageCooldown7days,
            this.ddManageCooldown7day,
            this.ddManageCooldown22hours,
            this.ddManageCooldown21hours,
            this.ddManageCooldown2hours,
            this.ddManageCooldown1hour,
            this.ddManageCooldown30min,
            this.ddManageCooldown15min,
            this.ddManageCooldownRemove,
            this.ddManageCooldownCustom});
            this.ddManageCooldown.Image = global::vactrak.Properties.Resources.alarm_clock;
            this.ddManageCooldown.Name = "ddManageCooldown";
            this.ddManageCooldown.Size = new System.Drawing.Size(134, 22);
            this.ddManageCooldown.Text = "Cooldown";
            // 
            // ddManageCooldown7days
            // 
            this.ddManageCooldown7days.Name = "ddManageCooldown7days";
            this.ddManageCooldown7days.Size = new System.Drawing.Size(132, 22);
            this.ddManageCooldown7days.Text = "7 Days";
            // 
            // ddManageCooldown7day
            // 
            this.ddManageCooldown7day.Name = "ddManageCooldown7day";
            this.ddManageCooldown7day.Size = new System.Drawing.Size(132, 22);
            this.ddManageCooldown7day.Text = "1 Day";
            // 
            // ddManageCooldown22hours
            // 
            this.ddManageCooldown22hours.Name = "ddManageCooldown22hours";
            this.ddManageCooldown22hours.Size = new System.Drawing.Size(132, 22);
            this.ddManageCooldown22hours.Text = "22 Hours";
            // 
            // ddManageCooldown21hours
            // 
            this.ddManageCooldown21hours.Name = "ddManageCooldown21hours";
            this.ddManageCooldown21hours.Size = new System.Drawing.Size(132, 22);
            this.ddManageCooldown21hours.Text = "21 Hours";
            // 
            // ddManageCooldown2hours
            // 
            this.ddManageCooldown2hours.Name = "ddManageCooldown2hours";
            this.ddManageCooldown2hours.Size = new System.Drawing.Size(132, 22);
            this.ddManageCooldown2hours.Text = "2 Hours";
            // 
            // ddManageCooldown1hour
            // 
            this.ddManageCooldown1hour.Name = "ddManageCooldown1hour";
            this.ddManageCooldown1hour.Size = new System.Drawing.Size(132, 22);
            this.ddManageCooldown1hour.Text = "1 Hour";
            // 
            // ddManageCooldown30min
            // 
            this.ddManageCooldown30min.Name = "ddManageCooldown30min";
            this.ddManageCooldown30min.Size = new System.Drawing.Size(132, 22);
            this.ddManageCooldown30min.Text = "30 Minutes";
            // 
            // ddManageCooldown15min
            // 
            this.ddManageCooldown15min.Name = "ddManageCooldown15min";
            this.ddManageCooldown15min.Size = new System.Drawing.Size(132, 22);
            this.ddManageCooldown15min.Text = "15 Minutes";
            // 
            // ddManageCooldownRemove
            // 
            this.ddManageCooldownRemove.Image = global::vactrak.Properties.Resources.minus;
            this.ddManageCooldownRemove.Name = "ddManageCooldownRemove";
            this.ddManageCooldownRemove.Size = new System.Drawing.Size(132, 22);
            this.ddManageCooldownRemove.Text = "Remove";
            // 
            // ddManageCooldownCustom
            // 
            this.ddManageCooldownCustom.BackColor = System.Drawing.SystemColors.Control;
            this.ddManageCooldownCustom.Image = global::vactrak.Properties.Resources.plus;
            this.ddManageCooldownCustom.Name = "ddManageCooldownCustom";
            this.ddManageCooldownCustom.Size = new System.Drawing.Size(132, 22);
            this.ddManageCooldownCustom.Text = "Custom";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // ddProfile
            // 
            this.ddProfile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ddProfile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addProfileToolStripMenuItem,
            this.removeProfileToolStripMenuItem,
            this.toolStripSeparator5,
            this.copyAccountsToolStripMenuItem,
            this.moveAccountsToolStripMenuItem});
            this.ddProfile.ForeColor = System.Drawing.Color.Black;
            this.ddProfile.Image = ((System.Drawing.Image)(resources.GetObject("ddProfile.Image")));
            this.ddProfile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ddProfile.Name = "ddProfile";
            this.ddProfile.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ddProfile.Size = new System.Drawing.Size(57, 22);
            this.ddProfile.Text = ":Profile";
            // 
            // addProfileToolStripMenuItem
            // 
            this.addProfileToolStripMenuItem.Image = global::vactrak.Properties.Resources.plus;
            this.addProfileToolStripMenuItem.Name = "addProfileToolStripMenuItem";
            this.addProfileToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.addProfileToolStripMenuItem.Text = "Add Profile";
            // 
            // removeProfileToolStripMenuItem
            // 
            this.removeProfileToolStripMenuItem.Image = global::vactrak.Properties.Resources.minus;
            this.removeProfileToolStripMenuItem.Name = "removeProfileToolStripMenuItem";
            this.removeProfileToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.removeProfileToolStripMenuItem.Text = "Remove Profile";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripSeparator5.Size = new System.Drawing.Size(154, 6);
            // 
            // copyAccountsToolStripMenuItem
            // 
            this.copyAccountsToolStripMenuItem.Name = "copyAccountsToolStripMenuItem";
            this.copyAccountsToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.copyAccountsToolStripMenuItem.Text = "Copy Accounts";
            // 
            // moveAccountsToolStripMenuItem
            // 
            this.moveAccountsToolStripMenuItem.Name = "moveAccountsToolStripMenuItem";
            this.moveAccountsToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.moveAccountsToolStripMenuItem.Text = "Move Accounts";
            // 
            // cbProfile
            // 
            this.cbProfile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProfile.DropDownWidth = 300;
            this.cbProfile.Name = "cbProfile";
            this.cbProfile.Size = new System.Drawing.Size(300, 25);
            this.cbProfile.SelectedIndexChanged += new System.EventHandler(this.CbProfile_SelectedIndexChanged);
            // 
            // btnProfileSave
            // 
            this.btnProfileSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnProfileSave.Image = global::vactrak.Properties.Resources.save;
            this.btnProfileSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnProfileSave.Name = "btnProfileSave";
            this.btnProfileSave.Size = new System.Drawing.Size(23, 22);
            this.btnProfileSave.Text = "Save Profile";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // ddUtils
            // 
            this.ddUtils.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ddUtilsEditor,
            this.ddUtilsDump});
            this.ddUtils.ForeColor = System.Drawing.Color.Black;
            this.ddUtils.Image = global::vactrak.Properties.Resources.tools;
            this.ddUtils.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ddUtils.Name = "ddUtils";
            this.ddUtils.Size = new System.Drawing.Size(59, 22);
            this.ddUtils.Text = "Utils";
            // 
            // ddUtilsEditor
            // 
            this.ddUtilsEditor.Name = "ddUtilsEditor";
            this.ddUtilsEditor.Size = new System.Drawing.Size(143, 22);
            this.ddUtilsEditor.Text = "Profile Editor";
            // 
            // ddUtilsDump
            // 
            this.ddUtilsDump.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ddUtilsDumpSelected,
            this.ddUtilsDumpProfile,
            this.ddUtilsDumpAll});
            this.ddUtilsDump.Name = "ddUtilsDump";
            this.ddUtilsDump.Size = new System.Drawing.Size(143, 22);
            this.ddUtilsDump.Text = "Dump to text";
            // 
            // ddUtilsDumpSelected
            // 
            this.ddUtilsDumpSelected.Name = "ddUtilsDumpSelected";
            this.ddUtilsDumpSelected.Size = new System.Drawing.Size(170, 22);
            this.ddUtilsDumpSelected.Text = "Currently Selected";
            // 
            // ddUtilsDumpProfile
            // 
            this.ddUtilsDumpProfile.Name = "ddUtilsDumpProfile";
            this.ddUtilsDumpProfile.Size = new System.Drawing.Size(170, 22);
            this.ddUtilsDumpProfile.Text = "Current Profile";
            // 
            // ddUtilsDumpAll
            // 
            this.ddUtilsDumpAll.Name = "ddUtilsDumpAll";
            this.ddUtilsDumpAll.Size = new System.Drawing.Size(170, 22);
            this.ddUtilsDumpAll.Text = "All Profiles";
            // 
            // btnSettings
            // 
            this.btnSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSettings.Image = global::vactrak.Properties.Resources.settings;
            this.btnSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(23, 22);
            this.btnSettings.Text = "Settings";
            // 
            // btnAbout
            // 
            this.btnAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAbout.Image = global::vactrak.Properties.Resources.info;
            this.btnAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(23, 22);
            this.btnAbout.Text = "About";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // lblBuildInfo
            // 
            this.lblBuildInfo.ForeColor = System.Drawing.Color.Black;
            this.lblBuildInfo.Name = "lblBuildInfo";
            this.lblBuildInfo.Size = new System.Drawing.Size(37, 22);
            this.lblBuildInfo.Text = "v0.1.0";
            // 
            // lvData
            // 
            this.lvData.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.lvData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_special_id,
            this.chSteamURL,
            this.chUser,
            this.chBanned,
            this.chCD,
            this.chNote,
            this.chStatus});
            this.lvData.ForeColor = System.Drawing.Color.White;
            this.lvData.FullRowSelect = true;
            this.lvData.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvData.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.lvData.Location = new System.Drawing.Point(0, 25);
            this.lvData.Name = "lvData";
            this.lvData.Size = new System.Drawing.Size(774, 334);
            this.lvData.TabIndex = 9;
            this.lvData.UseCompatibleStateImageBehavior = false;
            this.lvData.View = System.Windows.Forms.View.Details;
            // 
            // ch_special_id
            // 
            this.ch_special_id.Text = "ch_special_id";
            this.ch_special_id.Width = 0;
            // 
            // chSteamURL
            // 
            this.chSteamURL.Text = "Steam URL";
            this.chSteamURL.Width = 163;
            // 
            // chUser
            // 
            this.chUser.Text = "Username";
            this.chUser.Width = 170;
            // 
            // chBanned
            // 
            this.chBanned.Text = "Banned";
            this.chBanned.Width = 56;
            // 
            // chCD
            // 
            this.chCD.Text = "Cooldown";
            this.chCD.Width = 98;
            // 
            // chNote
            // 
            this.chNote.Text = "Note";
            this.chNote.Width = 186;
            // 
            // chStatus
            // 
            this.chStatus.Text = "Status";
            this.chStatus.Width = 71;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 368);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Note:";
            // 
            // tbNote
            // 
            this.tbNote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.tbNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNote.ForeColor = System.Drawing.Color.White;
            this.tbNote.Location = new System.Drawing.Point(47, 365);
            this.tbNote.Name = "tbNote";
            this.tbNote.Size = new System.Drawing.Size(717, 22);
            this.tbNote.TabIndex = 11;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(774, 396);
            this.Controls.Add(this.tbNote);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvData);
            this.Controls.Add(this.toolstrip);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(655, 300);
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VACTrak#";
            this.Load += new System.EventHandler(this.Main_Load);
            this.toolstrip.ResumeLayout(false);
            this.toolstrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

#endregion
        private System.Windows.Forms.ToolStrip toolstrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripComboBox cbProfile;
        private System.Windows.Forms.ListView lvData;
        private System.Windows.Forms.ColumnHeader chSteamURL;
        private System.Windows.Forms.ColumnHeader chUser;
        private System.Windows.Forms.ColumnHeader chBanned;
        private System.Windows.Forms.ColumnHeader chCD;
        private System.Windows.Forms.ColumnHeader chNote;
        private System.Windows.Forms.ColumnHeader chStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNote;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel lblBuildInfo;
        private System.Windows.Forms.ToolStripDropDownButton ddProfile;
        private System.Windows.Forms.ToolStripDropDownButton ddAccount;
        private System.Windows.Forms.ToolStripMenuItem ddAccountAdd;
        private System.Windows.Forms.ToolStripMenuItem ddAccountRemove;
        private System.Windows.Forms.ToolStripMenuItem ddAccountImport;
        private System.Windows.Forms.ToolStripMenuItem ddAccountImportSAC;
        private System.Windows.Forms.ToolStripMenuItem ddAccountSAG;
        private System.Windows.Forms.ToolStripDropDownButton ddManage;
        private System.Windows.Forms.ToolStripMenuItem ddManageObtain;
        private System.Windows.Forms.ToolStripMenuItem ddManageObtainBan;
        private System.Windows.Forms.ToolStripMenuItem ddManageObtainName;
        private System.Windows.Forms.ToolStripMenuItem ddManageObtainBoth;
        private System.Windows.Forms.ToolStripMenuItem ddManageLogin;
        private System.Windows.Forms.ToolStripMenuItem ddManageLoginNormal;
        private System.Windows.Forms.ToolStripMenuItem ddManageLoginForce;
        private System.Windows.Forms.ToolStripMenuItem ddManageClipboard;
        private System.Windows.Forms.ToolStripMenuItem ddManageClipboardUserPass;
        private System.Windows.Forms.ToolStripMenuItem ddManageClipboardURL;
        private System.Windows.Forms.ToolStripMenuItem ddManageClipboardNotes;
        private System.Windows.Forms.ToolStripMenuItem ddManageClipboardAll;
        private System.Windows.Forms.ToolStripMenuItem ddManageClipboardOpen;
        private System.Windows.Forms.ToolStripMenuItem ddManageCooldown;
        private System.Windows.Forms.ToolStripMenuItem ddManageCooldown7days;
        private System.Windows.Forms.ToolStripMenuItem ddManageCooldown7day;
        private System.Windows.Forms.ToolStripMenuItem ddManageCooldown22hours;
        private System.Windows.Forms.ToolStripMenuItem ddManageCooldown21hours;
        private System.Windows.Forms.ToolStripMenuItem ddManageCooldown2hours;
        private System.Windows.Forms.ToolStripMenuItem ddManageCooldown1hour;
        private System.Windows.Forms.ToolStripMenuItem ddManageCooldown30min;
        private System.Windows.Forms.ToolStripMenuItem ddManageCooldown15min;
        private System.Windows.Forms.ToolStripMenuItem addProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem copyAccountsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moveAccountsToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton btnProfileSave;
        private System.Windows.Forms.ToolStripMenuItem ddManageCooldownRemove;
        private System.Windows.Forms.ToolStripMenuItem ddManageCooldownCustom;
        private System.Windows.Forms.ToolStripButton btnSettings;
        private System.Windows.Forms.ToolStripButton btnAbout;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripDropDownButton ddUtils;
        private System.Windows.Forms.ColumnHeader ch_special_id;
        private System.Windows.Forms.ToolStripMenuItem ddUtilsEditor;
        private System.Windows.Forms.ToolStripMenuItem ddUtilsDump;
        private System.Windows.Forms.ToolStripMenuItem ddUtilsDumpSelected;
        private System.Windows.Forms.ToolStripMenuItem ddUtilsDumpProfile;
        private System.Windows.Forms.ToolStripMenuItem ddUtilsDumpAll;
    }
}

