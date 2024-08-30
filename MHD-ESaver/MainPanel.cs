using MaterialSkin;
using MaterialSkin.Controls;
using MHD_ESaver.Encryption;
using MHD_ESaver.Message;
using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace MHD_ESaver
{
    public partial class MainPanel : MaterialForm
    {
        private MessageBoxService _messageBoxService = new MessageBoxService();
        private AdministrationLogin _administrationLogin = new AdministrationLogin();

        public MainPanel()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Red400, Primary.Red700, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void MainPanel_Load(object sender, EventArgs e)
        {
            LoadVehicles();
        }

        /// <summary>
        /// Fills the "fahrzeugBox" with the vehicles from the database
        /// </summary>
        private void LoadVehicles()
        {
            using (SQLService sqlService = new SQLService())
            {
                foreach (var vehicle in sqlService.GetVehicleTypes())
                {
                    fahrzeugBox.Items.Add(vehicle);
                }
            }
        }

        private void sendBttn_Click(object sender, EventArgs e)
        {
            if (fahrzeugBox.SelectedItem != null
                && fahrzeugBox.Text.Length != 0
                && eNummerBox.Text.Length != 0
                && startOrtBox.Text.Length != 0
                && endOrtBox.Text.Length != 0
                && startZeitBox.Text.Length != 0
                && endZeitBox.Text.Length != 0
                && kilometerLabel.Text.Length != 0
                && fahrerBeifahrerBox.Text.Length != 0)
            {
                using (SQLService sqlService = new SQLService())
                {
                    sqlService.AddTour(new ViewModel.TourVm()
                    {
                        radioName = fahrzeugBox.SelectedItem.ToString(),
                        eNumber = eNummerBox.Text,
                        startLocation = startOrtBox.Text,
                        endLocation = endOrtBox.Text,
                        startTime = startZeitBox.Text,
                        endTime = endZeitBox.Text,
                        drivenKilometer = kilometerBox.Text,
                        driverpassenger = fahrerBeifahrerBox.Text,
                        doctor = notarztCheckbox.Checked.ToString()
                    });

                    ClearDataBoxes();
                }
            }
            else
            {
                _messageBoxService.Send(MessageBoxType.ERROR, MessageConstants.MESSAGEBOX_ENTRIES_MISSING_MAIN);
            }
        }

        /// <summary>
        /// Clears all boxes
        /// </summary>
        private void ClearDataBoxes()
        {
            fahrzeugBox.SelectedItem = null;
            fahrzeugBox.Refresh();
            eNummerBox.Text = string.Empty;
            startOrtBox.Text = string.Empty;
            endOrtBox.Text = string.Empty;
            startZeitBox.Text = string.Empty;
            endZeitBox.Text = string.Empty;
            kilometerBox.Text = string.Empty;
            fahrerBeifahrerBox.Text = string.Empty;
            notarztCheckbox.Checked = false;
        }

        private void Stats_Click(object sender, EventArgs e)
        {
            var statsPanel = new StatsPanel();
            statsPanel.Show();
        }

        private void adminLabel_Click(object sender, EventArgs e)
        {
            if (_administrationLogin.IsDisposed)
            {
                _administrationLogin.Close();
                _administrationLogin = new AdministrationLogin();
            }

            _administrationLogin.Show();
        }

        private void evStrip_Click(object sender, EventArgs e)
        {
            startOrtBox.Text = "Evangelisches Krankenhaus";
        }

        private void piusStrip_Click(object sender, EventArgs e)
        {
            startOrtBox.Text = "Pius Hospital";
        }

        private void koStrip_Click(object sender, EventArgs e)
        {
            startOrtBox.Text = "Klinikum Oldenburg";
        }

        private void leerfahrtStrip_Click(object sender, EventArgs e)
        {
            startOrtBox.Text = "Leerfahrt";
        }

        private void fehlfahrtStrip_Click(object sender, EventArgs e)
        {
            startOrtBox.Text = "Fehlfahrt";
        }

        private void evStripEnd_Click(object sender, EventArgs e)
        {
            endOrtBox.Text = "Evangelisches Krankenhaus";
        }

        private void piusStripEnd_Click(object sender, EventArgs e)
        {
            endOrtBox.Text = "Pius Hospital";
        }

        private void koStripEnd_Click(object sender, EventArgs e)
        {
            endOrtBox.Text = "Klinikum Oldenburg";
        }

        private void leerfahrtStripEnd_Click(object sender, EventArgs e)
        {
            endOrtBox.Text = "Leerfahrt";
        }

        private void fehlfahrtStripEnd_Click(object sender, EventArgs e)
        {
            endOrtBox.Text = "Fehlfahrt";
        }

        private void startZeitBox_TextChanged(object sender, EventArgs e)
        {
            if (startZeitBox.Text.Length == 4 && !startZeitBox.Text.Contains(":"))
            {
                var sb = new StringBuilder();
                sb.Append(startZeitBox.Text);
                sb.Insert(2, ":");
                startZeitBox.Text = sb.ToString();
            }
        }

        private void endZeitBox_TextChanged(object sender, EventArgs e)
        {
            if (endZeitBox.Text.Length == 4 && !endZeitBox.Text.Contains(":"))
            {
                var sb = new StringBuilder();
                sb.Append(endZeitBox.Text);
                sb.Insert(2, ":");
                endZeitBox.Text = sb.ToString();
            }
        }

        private void MainPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (File.Exists(SQLConstants.DATABASE_FILE))
            {
                new EncryptionService().Encrypt();
                File.Delete(SQLConstants.DATABASE_FILE);
            }
        }
    }
}