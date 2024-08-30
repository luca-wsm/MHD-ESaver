using System.Drawing;
using System.Windows.Forms;

namespace MHD_ESaver
{
    partial class AdministrationLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministrationLogin));
            loginButton = new MaterialSkin.Controls.MaterialButton();
            passwordBox = new MaterialSkin.Controls.MaterialTextBox();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            passwordLabel = new MaterialSkin.Controls.MaterialLabel();
            materialCard1.SuspendLayout();
            SuspendLayout();
            // 
            // loginButton
            // 
            loginButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            loginButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            loginButton.Depth = 0;
            loginButton.HighEmphasis = true;
            loginButton.Icon = null;
            loginButton.Location = new Point(126, 105);
            loginButton.Margin = new Padding(4, 6, 4, 6);
            loginButton.MouseState = MaterialSkin.MouseState.HOVER;
            loginButton.Name = "loginButton";
            loginButton.NoAccentTextColor = Color.Empty;
            loginButton.Size = new Size(102, 36);
            loginButton.TabIndex = 0;
            loginButton.Text = "Einloggen";
            loginButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            loginButton.UseAccentColor = false;
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // passwordBox
            // 
            passwordBox.AnimateReadOnly = false;
            passwordBox.AutoWordSelection = true;
            passwordBox.BorderStyle = BorderStyle.None;
            passwordBox.Depth = 0;
            passwordBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            passwordBox.LeadingIcon = null;
            passwordBox.Location = new Point(78, 46);
            passwordBox.MaxLength = 50;
            passwordBox.MouseState = MaterialSkin.MouseState.OUT;
            passwordBox.Multiline = false;
            passwordBox.Name = "passwordBox";
            passwordBox.Password = true;
            passwordBox.Size = new Size(209, 50);
            passwordBox.TabIndex = 1;
            passwordBox.Text = "";
            passwordBox.TrailingIcon = null;
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(passwordLabel);
            materialCard1.Controls.Add(passwordBox);
            materialCard1.Controls.Add(loginButton);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(17, 86);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(348, 156);
            materialCard1.TabIndex = 2;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Depth = 0;
            passwordLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            passwordLabel.Location = new Point(78, 14);
            passwordLabel.MouseState = MaterialSkin.MouseState.HOVER;
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(67, 19);
            passwordLabel.TabIndex = 2;
            passwordLabel.Text = "Passwort";
            // 
            // AdministrationLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 259);
            Controls.Add(materialCard1);
            FormStyle = FormStyles.ActionBar_48;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "AdministrationLogin";
            Padding = new Padding(3, 72, 3, 3);
            Sizable = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ACP ESaver | Login";
            FormClosing += AdministrationLogin_FormClosing;
            Load += AdministrationLogin_Load;
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialButton loginButton;
        private MaterialSkin.Controls.MaterialTextBox passwordBox;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel passwordLabel;
    }
}