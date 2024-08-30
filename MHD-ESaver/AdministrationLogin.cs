using MaterialSkin;
using MaterialSkin.Controls;
using MHD_ESaver.Message;
using MHD_ESaver.Password;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MHD_ESaver
{
    public partial class AdministrationLogin : MaterialForm
    {
        public AdministrationLogin()
        {
            InitializeComponent();
        }

        private void AdministrationLogin_Load(object sender, EventArgs e)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Red400, Primary.Red700, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            var messageBoxService = new MessageBoxService();
            var passwordService = new PasswordService();

            if (passwordService.HashPassword(passwordBox.Text) != PasswordConstants.PASSWORD_HASHED)
            {
                messageBoxService.Send(MessageBoxType.ERROR, MessageConstants.MESSAGEBOX_WRONG_PASSWORD);
                return;
            }

            var administrationPanel = new AdministrationPanel();
            administrationPanel.Show();
            this.Close();
        }

        private void AdministrationLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            passwordBox.Text = string.Empty;
            this.Dispose();
            this.Hide();
        }
    }
}
