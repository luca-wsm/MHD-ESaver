using MHD_ESaver.ViewModel;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Windows.Forms;
using System.Runtime.Intrinsics.X86;
using System;

namespace MHD_ESaver.Service
{
    public class StatisticService
    {

        public StatisticVm GetStats(String vehicleName, string startDate = null, String endDate = null)
        {
            var sqlService = new SQLService();
            Int32 tourCountCommand;
            Int32 kilometerSumCommand;
            Int32 docCountCommand;
            Int32 fehlfahrtCountCommand;
            Int32 ambulantCountCommand;


            try
            {
                //All time stats
                if (startDate == null && endDate == null)
                {
                    tourCountCommand = Convert.ToInt32(sqlService.Execute($"SELECT COUNT(*) FROM Tours WHERE radioName = '{vehicleName}'"));
                    kilometerSumCommand = Convert.ToInt32(sqlService.Execute($"SELECT SUM(drivenKilometer) FROM Tours WHERE radioName = '{vehicleName}'"));
                    docCountCommand = Convert.ToInt32(sqlService.Execute($"SELECT COUNT(doctor) FROM Tours WHERE radioName = '{vehicleName}' AND doctor = 'True'"));
                    fehlfahrtCountCommand = Convert.ToInt32(sqlService.Execute($"SELECT COUNT(endLocation) FROM Tours WHERE radioName = '{vehicleName}' AND endLocation = 'Fehlfahrt'"));
                    ambulantCountCommand = Convert.ToInt32(sqlService.Execute($"SELECT COUNT(endLocation) FROM Tours WHERE radioName = '{vehicleName}' AND endLocation = 'Leerfahrt'"));
                }
                else
                {
                    tourCountCommand = Convert.ToInt32(sqlService.Execute($"SELECT COUNT(*) FROM Tours WHERE radioName = '{vehicleName}' AND Date BETWEEN '{startDate}' AND '{endDate}'"));
                    kilometerSumCommand = Convert.ToInt32(sqlService.Execute($"SELECT SUM(drivenKilometer) FROM Tours WHERE radioName = '{vehicleName}' AND Date BETWEEN '{startDate}' AND '{endDate}'"));
                    docCountCommand = Convert.ToInt32(sqlService.Execute($"SELECT COUNT(doctor) FROM Tours WHERE radioName = '{vehicleName}' AND doctor = 'True' AND Date BETWEEN '{startDate}' AND '{endDate}'"));
                    fehlfahrtCountCommand = Convert.ToInt32(sqlService.Execute($"SELECT COUNT(endLocation) FROM Tours WHERE radioName = '{vehicleName}' AND endLocation = 'Fehlfahrt' AND Date BETWEEN '{startDate}' AND '{endDate}'"));
                    ambulantCountCommand = Convert.ToInt32(sqlService.Execute($"SELECT COUNT(endLocation) FROM Tours WHERE radioName = '{vehicleName}' AND endLocation = 'Leerfahrt' AND Date BETWEEN '{startDate}' AND '{endDate}'"));
                }

                return new StatisticVm()
                {
                    VehicleName = vehicleName,
                    DispatchCount = Convert.ToInt32(tourCountCommand),
                    KilometerCount = Convert.ToInt32(kilometerSumCommand),
                    DocCount = Convert.ToInt32(docCountCommand),
                    AmbulantCount = Convert.ToInt32(ambulantCountCommand),
                    FehlfahrtCount = Convert.ToInt32(fehlfahrtCountCommand),
                };
            }
            catch (Exception)
            {
                return new StatisticVm()
                {
                    VehicleName = vehicleName,
                    DispatchCount = 0,
                    KilometerCount = 0,
                    DocCount = 0,
                    AmbulantCount = 0,
                    FehlfahrtCount = 0,
                };
            } finally
            {
                //Dispose to encrypt the database
                sqlService.Dispose();
            }
        }
    }
}
