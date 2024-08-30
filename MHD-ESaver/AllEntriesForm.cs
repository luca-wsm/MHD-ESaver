using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Windows.Forms;

namespace MHD_ESaver
{
    public partial class AllEntriesForm : MaterialForm
    {
        public AllEntriesForm()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Red400, Primary.Red700, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void AllEntriesForm_Load(object sender, EventArgs e)
        {
            using (var sqlService = new SQLService())
            {
                foreach (var tour in sqlService.GetAllTours())
                {
                    var item = new ListViewItem(tour.Date);
                    item.SubItems.Add(tour.radioName);
                    item.SubItems.Add(tour.eNumber);
                    item.SubItems.Add(tour.startLocation);
                    item.SubItems.Add(tour.endLocation);
                    item.SubItems.Add(tour.startTime);
                    item.SubItems.Add(tour.endTime);
                    item.SubItems.Add(tour.drivenKilometer);
                    item.SubItems.Add(tour.driverpassenger);
                    item.SubItems.Add(tour.doctor.Replace("True", "Ja").Replace("False", "Nein"));
                    dataView.Items.Add(item);
                }
            }
        }
    }
}
