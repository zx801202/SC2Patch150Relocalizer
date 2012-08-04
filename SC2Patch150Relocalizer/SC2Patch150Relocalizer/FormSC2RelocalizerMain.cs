﻿using System;
using System.Diagnostics;
using System.Windows.Forms;
using SimonsRelocalizer.Properties;


namespace SimonsRelocalizer
{
    public partial class FormSC2RelocalizerMain : Form
    {
        public FormSC2RelocalizerMain()
        {
            InitializeComponent();
        }

        private void buttonRelocalize_Click(object sender, EventArgs e)
        {
            LocaleChanger.RunRelocalize();
            if (buttonRelocalize.Text == Resources.buttonRelocalizeText)
            {
                var message = CreateRelocalizeMessage();
                MessageBox.Show(message);
            }
            else
            {
                MessageBox.Show(Resources.waitForDownloadMessage);
            }
            if (chkLaunchSC2.Checked)
            {
                Process.Start(Settings.Default.SC2Location + "StarCraft II.exe");
            }
            Application.Exit();
        }

        private void FormSC2RelocalizerMain_Load(object sender, EventArgs e)
        {
            Text = Text + Settings.Default.VersionNumber;
            SettingsManager.checkSC2Location();
            SettingsManager.checkVarTXTLocation();
            SettingsManager.checkCurrentLocale();
            ChangeComboListValues();
            ChangeCheckBoxValue();
            CheckUpdate();
        }

        private void CheckUpdate()
        {
            var updatesAvaiable = UpdateManager.CheckIfUpdatesAvailable();
            if (updatesAvaiable)
            {
                versionsToolStripMenuItem.Text = Resources.updateAvaiableText + UpdateManager.GetNewVersionNumber() + " Click me!";
                versionsToolStripMenuItem.ForeColor = System.Drawing.Color.Blue;
            }
            else
            {
                versionsToolStripMenuItem.Text = Resources.relocalizerUpToDateText;
                versionsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            }
        }

        private void chkLaunchSC2_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.RunSC2AfterRelocalize = chkLaunchSC2.Checked;
            Settings.Default.Save();
        }

        private void comboLocale_SelectedIndexChanged(object sender, EventArgs e)
        {
            Program.newLocale = Program.languageList[comboLocale.SelectedIndex].Substring(0, 4);
        }

        private void comboAsset_SelectedIndexChanged(object sender, EventArgs e)
        {
            Program.newAsset = Program.languageList[comboAsset.SelectedIndex].Substring(0, 4);
            if (!LocaleChanger.CheckIfAssetExists(Program.newAsset))
            {
                var message = Resources.assetNotFoundMessage.Replace("xxxx", Program.newAsset);
                MessageBox.Show(message);
                comboLocale.SelectedIndex = comboAsset.SelectedIndex;
                buttonRelocalize.Text = Resources.buttonAssetNotFoundHint.Replace("xxxx", Program.newAsset);
                chkLaunchSC2.Checked = true;
                chkLaunchSC2.Enabled = false;
                comboLocale.Enabled = false;
                return;
            }
            comboLocale.Enabled = true;
            chkLaunchSC2.Enabled = true;
            buttonRelocalize.Text = Resources.buttonRelocalizeText;
        }

        public string BrowseSc2Location()
        {
            var result = browserSC2Folder.ShowDialog();
            if (result == DialogResult.OK)
            {
                return browserSC2Folder.SelectedPath + "\\";
            }
            MessageBox.Show(Resources.SC2LocationNotFoundMessage);
            Application.Exit();
            return null;
        }

        public string BrowseSc2VarTxtLocation()
        {
            var result = browserSC2VarFolder.ShowDialog();
            if (result == DialogResult.OK)
            {
                return browserSC2VarFolder.SelectedPath + "\\";
            }
            MessageBox.Show(Resources.SC2VarTXTLocationNotFoundMessage);
            Application.Exit();
            return null;
        }

        public void ChangeComboListValues()
        {
            for (int i = 0; i < Program.languageList.Length; i++)
            {
                string locale = Program.languageList[i];
                if (locale.StartsWith(Program.currentLocale))
                {
                    comboLocale.SelectedIndex = i;
                }
                if (locale.StartsWith(Program.currentAsset))
                {
                    comboAsset.SelectedIndex = i;
                }
            }
        }

        private static string CreateRelocalizeMessage()
        {
            var message = Resources.relocalizationFinishedMessage;
            message = message.Replace("aaaa", Program.currentLocale);
            message = message.Replace("bbbb", Program.newLocale);
            message = message.Replace("cccc", Program.currentAsset);
            message = message.Replace("dddd", Program.newAsset);
            return message;
        }

        private void ChangeCheckBoxValue()
        {
            chkLaunchSC2.Checked = Settings.Default.RunSC2AfterRelocalize;
        }

        private void versionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (versionsToolStripMenuItem.ForeColor == System.Drawing.Color.Blue)
            {
                Process.Start("https://github.com/downloads/lhr0909/SC2Patch150Relocalizer/SimonsRelocalizer." + UpdateManager.GetNewVersionNumber() + ".zip");
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Resources.aboutMessage);
        }

        private void theProjectPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/lhr0909/SC2Patch150Relocalizer");
        }

        private void teamliquidPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.teamliquid.net/forum/viewmessage.php?topic_id=357860");
        }
    }
}
