using MaterialSkin;
using MaterialSkin.Controls;
using MHD_ESaver.Service;
using System;
using System.Globalization;

namespace MHD_ESaver
{
    public partial class StatsPanel : MaterialForm
    {
        public StatsPanel()
        {
            InitializeComponent();
        }

        private void StatsPanel_Load(object sender, EventArgs e)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Red400, Primary.Red700, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            LoadVehicles();
        }

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

        private void fahrzeugBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeStats();
        }

        private void ChangeStats()
        {
            var statsService = new StatisticService();

            if (gesamtZeitraumBox.Checked)
            {
                var statsObj = statsService.GetStats(fahrzeugBox.SelectedItem.ToString());
                eBox.Text = statsObj.DispatchCount.ToString();
                kmBox.Text = statsObj.KilometerCount.ToString();
                ambulantBox.Text = statsObj.AmbulantCount.ToString();
                fehlfahrtBox.Text = statsObj.FehlfahrtCount.ToString();
                naBox.Text = statsObj.DocCount.ToString();

            }
            else
            {
                var statsObj = statsService.GetStats(fahrzeugBox.SelectedItem.ToString(), ConvertDate(startDatumPicker.Text), ConvertDate(endDatumPicker.Text));
                eBox.Text = statsObj.DispatchCount.ToString();
                kmBox.Text = statsObj.KilometerCount.ToString();
                ambulantBox.Text = statsObj.AmbulantCount.ToString();
                fehlfahrtBox.Text = statsObj.FehlfahrtCount.ToString();
                naBox.Text = statsObj.DocCount.ToString();
            }
        }

        private void startDatumPicker_ValueChanged(object sender, EventArgs e)
        {
            ChangeStats();
        }

        private void endDatumPicker_ValueChanged(object sender, EventArgs e)
        {
            ChangeStats();
        }

        private String ConvertDate(String date)
        {
            var dt = DateTime.ParseExact(date.Replace(".", "/"), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            return dt.ToString("yyyy/MM/dd").Replace(".", "-");
        }

        private void gesamtZeitraumBox_CheckedChanged(object sender, EventArgs e)
        {
            startDatumPicker.Enabled = !gesamtZeitraumBox.Checked;
            endDatumPicker.Enabled = !gesamtZeitraumBox.Checked;
            if (fahrzeugBox.SelectedItem != null)
            {
                ChangeStats();
            }
        }
    }
}
