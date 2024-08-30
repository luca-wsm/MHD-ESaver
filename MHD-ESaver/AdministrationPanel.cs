using MaterialSkin;
using MaterialSkin.Controls;
using MHD_ESaver.Encryption;
using MHD_ESaver.Message;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MHD_ESaver
{
    public partial class AdministrationPanel : MaterialForm
    {
        MessageBoxService _messageBoxService = new MessageBoxService();
        EncryptionService _encryptionService = new EncryptionService();

        public AdministrationPanel()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Red400, Primary.Red700, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void AdministrationPanel_Load(object sender, EventArgs e)
        {

        }

        private void decryptBttn_Click(object sender, EventArgs e)
        {
            if (!File.Exists(SQLConstants.DATABASE_FILE_ENCRYPTED))
            {
                _messageBoxService.Send(MessageBoxType.ERROR, MessageConstants.MESSAGEBOX_DATABASE_NOT_ENCRYPTED);
                return;
            }

            _encryptionService.Decrypt();
            File.Delete(SQLConstants.DATABASE_FILE_ENCRYPTED);
            _messageBoxService.Send(MessageBoxType.INFORMATION, MessageConstants.MESSAGEBOX_DATABASE_DECRYPTED_SUCCESFULLY);
        }

        private void encryptBttn_Click(object sender, EventArgs e)
        {
            if (!File.Exists(SQLConstants.DATABASE_FILE))
            {
                _messageBoxService.Send(MessageBoxType.ERROR, MessageConstants.MESSAGEBOX_DATABASE_ENCRYPTED);
                return;
            }

            _encryptionService.Encrypt();
            File.Delete(SQLConstants.DATABASE_FILE);
            _messageBoxService.Send(MessageBoxType.INFORMATION, MessageConstants.MESSAGEBOX_DATABASE_ENCRYPTED_SUCCESFULLY);
        }

        private void backupDatabaseBttn_Click(object sender, EventArgs e)
        {
            databaseBackupDialog.ShowDialog();
        }

        private void databaseBackupDialog_FileOk(object sender, CancelEventArgs e)
        {
            File.Copy(GetCurrentDatabasePath(), databaseBackupDialog.FileName);
        }

        private void deleteDatabaseBttn_Click(object sender, EventArgs e)
        {
            if (_messageBoxService.SendChoice("ACHTUNG: Durch das klicken auf Ja gehen alle Daten unwiderruflich verloren!\n\nWillst du trotzdem fortfahren?"))
            {
                File.Delete(GetCurrentDatabasePath());
                _messageBoxService.Send(MessageBoxType.INFORMATION, MessageConstants.MESSAGEBOX_DATABASE_DELETED_SUCCESFULLY);
            }
        }

        private String GetCurrentDatabasePath()
        {
            if (File.Exists(SQLConstants.DATABASE_FILE_ENCRYPTED))
            {
                return SQLConstants.DATABASE_FILE_ENCRYPTED;
            }
            else
            {
                return SQLConstants.DATABASE_FILE;
            }
        }

        private void showAllEntriesBttn_Click(object sender, EventArgs e)
        {
            new AllEntriesForm().Show();
        }
    }
}
