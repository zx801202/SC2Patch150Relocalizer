﻿namespace SC2Patch150Relocalizer
{
    partial class FormSC2RelocalizerMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSC2RelocalizerMain));
            this.buttonRelocalize = new System.Windows.Forms.Button();
            this.browserSC2Folder = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.chkLaunchSC2 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboAsset = new System.Windows.Forms.ComboBox();
            this.comboLocale = new System.Windows.Forms.ComboBox();
            this.browserSC2VarFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // buttonRelocalize
            // 
            this.buttonRelocalize.Location = new System.Drawing.Point(9, 75);
            this.buttonRelocalize.Name = "buttonRelocalize";
            this.buttonRelocalize.Size = new System.Drawing.Size(556, 50);
            this.buttonRelocalize.TabIndex = 15;
            this.buttonRelocalize.Text = "Relocalize!";
            this.buttonRelocalize.UseVisualStyleBackColor = true;
            this.buttonRelocalize.Click += new System.EventHandler(this.buttonRelocalize_Click);
            // 
            // browserSC2Folder
            // 
            this.browserSC2Folder.Description = "Please select SC2 Installation Location";
            this.browserSC2Folder.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(299, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Choose Voice Asset:";
            // 
            // chkLaunchSC2
            // 
            this.chkLaunchSC2.AutoSize = true;
            this.chkLaunchSC2.Location = new System.Drawing.Point(9, 53);
            this.chkLaunchSC2.Name = "chkLaunchSC2";
            this.chkLaunchSC2.Size = new System.Drawing.Size(178, 17);
            this.chkLaunchSC2.TabIndex = 18;
            this.chkLaunchSC2.Text = "Launch SC2 after Relocalization";
            this.chkLaunchSC2.UseVisualStyleBackColor = true;
            this.chkLaunchSC2.CheckedChanged += new System.EventHandler(this.chkLaunchSC2_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Choose Display Language + Region:";
            // 
            // comboAsset
            // 
            this.comboAsset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAsset.FormattingEnabled = true;
            this.comboAsset.Items.AddRange(new object[] {
            "enUS - AM - English (US)",
            "esMX - AM - Español (Latin America)",
            "ptBR - AM - Português (Brazil)",
            "zhCN - CN - 简体中文 (PR China, simplified)",
            "enGB - EU - English (UK)",
            "frFR - EU - Français",
            "deDE - EU - Deutsch",
            "itIT - EU - Italiano ",
            "plPL - EU - Polski",
            "ruRU - EU - Русский",
            "esES - EU - Español (Spain)",
            "koKR - KR/TW - Korean",
            "zhTW - KR/TW - 繁體中文 (Taiwan, tranditional)",
            "enSG - SEA - English (Singapore)"});
            this.comboAsset.Location = new System.Drawing.Point(302, 25);
            this.comboAsset.Name = "comboAsset";
            this.comboAsset.Size = new System.Drawing.Size(263, 21);
            this.comboAsset.TabIndex = 21;
            this.comboAsset.SelectedIndexChanged += new System.EventHandler(this.comboAsset_SelectedIndexChanged);
            // 
            // comboLocale
            // 
            this.comboLocale.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboLocale.FormattingEnabled = true;
            this.comboLocale.Items.AddRange(new object[] {
            "enUS - AM - English (US)",
            "esMX - AM - Español (Latin America)",
            "ptBR - AM - Português (Brazil)",
            "zhCN - CN - 简体中文 (PR China, simplified)",
            "enGB - EU - English (UK)",
            "frFR - EU - Français",
            "deDE - EU - Deutsch",
            "itIT - EU - Italiano ",
            "plPL - EU - Polski",
            "ruRU - EU - Русский",
            "esES - EU - Español (Spain)",
            "koKR - KR/TW - Korean",
            "zhTW - KR/TW - 繁體中文 (Taiwan, tranditional)",
            "enSG - SEA - English (Singapore)"});
            this.comboLocale.Location = new System.Drawing.Point(9, 24);
            this.comboLocale.Name = "comboLocale";
            this.comboLocale.Size = new System.Drawing.Size(263, 21);
            this.comboLocale.TabIndex = 22;
            this.comboLocale.SelectedIndexChanged += new System.EventHandler(this.comboLocale_SelectedIndexChanged);
            // 
            // browserSC2VarFolder
            // 
            this.browserSC2VarFolder.Description = "Please select SC2 Variable.txt Location:";
            this.browserSC2VarFolder.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // FormSC2RelocalizerMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 129);
            this.Controls.Add(this.comboLocale);
            this.Controls.Add(this.comboAsset);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chkLaunchSC2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRelocalize);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(582, 156);
            this.MinimumSize = new System.Drawing.Size(582, 156);
            this.Name = "FormSC2RelocalizerMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simon\'s SC2 Patch 1.5.0 Relocalizer";
            this.Load += new System.EventHandler(this.FormSC2RelocalizerMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRelocalize;
        private System.Windows.Forms.FolderBrowserDialog browserSC2Folder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkLaunchSC2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboAsset;
        private System.Windows.Forms.ComboBox comboLocale;
        private System.Windows.Forms.FolderBrowserDialog browserSC2VarFolder;
    }
}

