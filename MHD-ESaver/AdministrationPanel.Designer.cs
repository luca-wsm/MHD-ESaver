using System.Drawing;
using System.Windows.Forms;

namespace MHD_ESaver
{
    partial class AdministrationPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministrationPanel));
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            showAllEntriesBttn = new MaterialSkin.Controls.MaterialButton();
            encryptBttn = new MaterialSkin.Controls.MaterialButton();
            backupDatabaseBttn = new MaterialSkin.Controls.MaterialButton();
            decryptBttn = new MaterialSkin.Controls.MaterialButton();
            deleteDatabaseBttn = new MaterialSkin.Controls.MaterialButton();
            databaseBackupDialog = new SaveFileDialog();
            materialCard1.SuspendLayout();
            SuspendLayout();
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(showAllEntriesBttn);
            materialCard1.Controls.Add(encryptBttn);
            materialCard1.Controls.Add(backupDatabaseBttn);
            materialCard1.Controls.Add(decryptBttn);
            materialCard1.Controls.Add(deleteDatabaseBttn);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(17, 78);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(534, 131);
            materialCard1.TabIndex = 0;
            // 
            // showAllEntriesBttn
            // 
            showAllEntriesBttn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            showAllEntriesBttn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            showAllEntriesBttn.Depth = 0;
            showAllEntriesBttn.ForeColor = Color.Red;
            showAllEntriesBttn.HighEmphasis = true;
            showAllEntriesBttn.Icon = null;
            showAllEntriesBttn.Location = new Point(209, 68);
            showAllEntriesBttn.Margin = new Padding(4, 6, 4, 6);
            showAllEntriesBttn.MouseState = MaterialSkin.MouseState.HOVER;
            showAllEntriesBttn.Name = "showAllEntriesBttn";
            showAllEntriesBttn.NoAccentTextColor = Color.Empty;
            showAllEntriesBttn.Size = new Size(127, 36);
            showAllEntriesBttn.TabIndex = 7;
            showAllEntriesBttn.Text = "Alle Einsätze";
            showAllEntriesBttn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            showAllEntriesBttn.UseAccentColor = false;
            showAllEntriesBttn.UseVisualStyleBackColor = true;
            showAllEntriesBttn.Click += showAllEntriesBttn_Click;
            // 
            // encryptBttn
            // 
            encryptBttn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            encryptBttn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            encryptBttn.Depth = 0;
            encryptBttn.HighEmphasis = true;
            encryptBttn.Icon = null;
            encryptBttn.Location = new Point(286, 20);
            encryptBttn.Margin = new Padding(4, 6, 4, 6);
            encryptBttn.MouseState = MaterialSkin.MouseState.HOVER;
            encryptBttn.Name = "encryptBttn";
            encryptBttn.NoAccentTextColor = Color.Empty;
            encryptBttn.Size = new Size(230, 36);
            encryptBttn.TabIndex = 6;
            encryptBttn.Text = "Datenbank verschlüsseln";
            encryptBttn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            encryptBttn.UseAccentColor = false;
            encryptBttn.UseVisualStyleBackColor = true;
            encryptBttn.Click += encryptBttn_Click;
            // 
            // backupDatabaseBttn
            // 
            backupDatabaseBttn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            backupDatabaseBttn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            backupDatabaseBttn.Depth = 0;
            backupDatabaseBttn.ForeColor = Color.Red;
            backupDatabaseBttn.HighEmphasis = true;
            backupDatabaseBttn.Icon = null;
            backupDatabaseBttn.Location = new Point(344, 68);
            backupDatabaseBttn.Margin = new Padding(4, 6, 4, 6);
            backupDatabaseBttn.MouseState = MaterialSkin.MouseState.HOVER;
            backupDatabaseBttn.Name = "backupDatabaseBttn";
            backupDatabaseBttn.NoAccentTextColor = Color.Empty;
            backupDatabaseBttn.Size = new Size(172, 36);
            backupDatabaseBttn.TabIndex = 5;
            backupDatabaseBttn.Text = "Datenbank sichern";
            backupDatabaseBttn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            backupDatabaseBttn.UseAccentColor = false;
            backupDatabaseBttn.UseVisualStyleBackColor = true;
            backupDatabaseBttn.Click += backupDatabaseBttn_Click;
            // 
            // decryptBttn
            // 
            decryptBttn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            decryptBttn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            decryptBttn.Depth = 0;
            decryptBttn.HighEmphasis = true;
            decryptBttn.Icon = null;
            decryptBttn.Location = new Point(18, 20);
            decryptBttn.Margin = new Padding(4, 6, 4, 6);
            decryptBttn.MouseState = MaterialSkin.MouseState.HOVER;
            decryptBttn.Name = "decryptBttn";
            decryptBttn.NoAccentTextColor = Color.Empty;
            decryptBttn.Size = new Size(230, 36);
            decryptBttn.TabIndex = 1;
            decryptBttn.Text = "Datenbank entschlüsseln";
            decryptBttn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            decryptBttn.UseAccentColor = false;
            decryptBttn.UseVisualStyleBackColor = true;
            decryptBttn.Click += decryptBttn_Click;
            // 
            // deleteDatabaseBttn
            // 
            deleteDatabaseBttn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            deleteDatabaseBttn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            deleteDatabaseBttn.Depth = 0;
            deleteDatabaseBttn.ForeColor = Color.Black;
            deleteDatabaseBttn.HighEmphasis = true;
            deleteDatabaseBttn.Icon = null;
            deleteDatabaseBttn.Location = new Point(18, 68);
            deleteDatabaseBttn.Margin = new Padding(4, 6, 4, 6);
            deleteDatabaseBttn.MouseState = MaterialSkin.MouseState.HOVER;
            deleteDatabaseBttn.Name = "deleteDatabaseBttn";
            deleteDatabaseBttn.NoAccentTextColor = Color.Empty;
            deleteDatabaseBttn.Size = new Size(177, 36);
            deleteDatabaseBttn.TabIndex = 6;
            deleteDatabaseBttn.Text = "Datenbank löschen";
            deleteDatabaseBttn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            deleteDatabaseBttn.UseAccentColor = false;
            deleteDatabaseBttn.UseVisualStyleBackColor = true;
            deleteDatabaseBttn.Click += deleteDatabaseBttn_Click;
            // 
            // databaseBackupDialog
            // 
            databaseBackupDialog.DefaultExt = "db3";
            databaseBackupDialog.Filter = "Datenbank|*.db3";
            databaseBackupDialog.Title = "Datenbank sichern";
            databaseBackupDialog.FileOk += databaseBackupDialog_FileOk;
            // 
            // AdministrationPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(572, 228);
            Controls.Add(materialCard1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "AdministrationPanel";
            Sizable = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ACP ESaver | Übersicht";
            Load += AdministrationPanel_Load;
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialButton decryptBttn;
        private MaterialSkin.Controls.MaterialButton deleteDatabaseBttn;
        private MaterialSkin.Controls.MaterialButton showAllEntriesBttn;
        private MaterialSkin.Controls.MaterialButton encryptBttn;
        private MaterialSkin.Controls.MaterialButton backupDatabaseBttn;
        private SaveFileDialog databaseBackupDialog;
    }
}