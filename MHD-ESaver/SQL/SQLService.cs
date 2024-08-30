using MHD_ESaver.Encryption;
using MHD_ESaver.ViewModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.IO;

namespace MHD_ESaver
{
    /// <summary>
    /// TODO: PREPARED STATEMENTS!
    /// </summary>
    public class SQLService : IDisposable
    {
        private string databaseCombined = SQLConstants.GENERAL_PATH + SQLConstants.DATABASE_FILENAME;
        private static SQLiteConnection? _connection;
        private static SQLiteCommand? _command;
        private static EncryptionService _encryptionService = new EncryptionService();


        public SQLService()
        {
            //On startup we have to encrypt the file
            if(File.Exists(SQLConstants.DATABASE_FILE_ENCRYPTED))
            {
                _encryptionService.Decrypt();
                File.Delete(SQLConstants.DATABASE_FILE_ENCRYPTED);
            }

            // First init = fresh database
            if (!File.Exists(databaseCombined))
            {
                InitSQL();
                InitDatabase();
                InitVehicleTypes();
                InsertDefaultVehicleTypes();
                Console.WriteLine("SQLite first Database created and connected succesfully.");
            }
            else
            {
                _connection = new SQLiteConnection($"data source={databaseCombined}");             
                _command = new SQLiteCommand(_connection);
                _connection.Open();
                Console.WriteLine("SQLite Database connection established.");
            }
        }

        public void InitSQL()
        {
            Directory.CreateDirectory(SQLConstants.GENERAL_PATH);
            SQLiteConnection.CreateFile(databaseCombined);
            _connection = new SQLiteConnection($"data source={databaseCombined}");
            _command = new SQLiteCommand(_connection);
            _connection.Open();
        }

        /// <summary>
        /// Gets an dataTable set
        /// </summary>
        /// <returns></returns>
        public DataTable GetDataTable(String query)
        {
            var dataTable = new DataTable();
            using (var cmd = new SQLiteCommand(query, _connection))
            {
                using (var reader = cmd.ExecuteReader())
                {
                    dataTable.Load(reader);
                    return dataTable;
                }
            }
        }

        public void Update(String update)
        {
            try
            {
                _command.CommandText = update;
                _command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public object Execute(String command)
        {
            using (var cmd = new SQLiteCommand(command, _connection))
             {
                return cmd.ExecuteScalar();
            } 
        }

        public void InitDatabase()
        {
            var query = @"CREATE TABLE IF NOT EXISTS
                           [Tours] (
                           [Date] DATE DEFAULT (strftime('%Y-%m-%d', date('now'))),
                           [radioName] TEXT,
                           [eNumber] TEXT,
                           [startLocation] TEXT,
                           [endLocation] TEXT,
                           [startTime] TEXT,
                           [endTime] TEXT,
                           [drivenKilometer] INTEGER,
                           [driverpassenger] TEXT,
                           [doctor] TEXT
                           );";
            Update(query);
        }

        public void InitVehicleTypes()
        {
            var query = @"CREATE TABLE IF NOT EXISTS
                           [Vehicles] (
                           [shortName] TEXT,
                           [radioName] TEXT
                           );";
            Update(query);
        }

        /// <summary>
        /// Default vehicleTypes may remove in the future
        /// </summary>
        public void InsertDefaultVehicleTypes()
        {
            var query = @"INSERT INTO Vehicles (shortName, radioName)
                            VALUES 
                            ('RTW', '60-83-01'),
                            ('NKTW', '60-93-01'),
                            ('KTW-2', '60-92-02'),
                            ('KTW-3', '60-92-03'),
                            ('KTW-4', '60-92-04'),
                            ('KTW-5', '60-92-05'),
                            ('KTW-6', '60-92-06'),
                            ('GNFS', '60-89-01');";
            Update(query);
        }

        public List<String> GetVehicleTypes()
        {
            var vehicleList = new List<String>();
            var statement = "SELECT shortName FROM Vehicles";

            foreach(DataRow row in GetDataTable(statement).Rows)
            {
                vehicleList.Add(row.ItemArray[0].ToString());
            }
            return vehicleList;
        }

        public List<TourVm> GetAllTours()
        {
            var tourVmList = new List<TourVm>();
            var statement = "SELECT * FROM Tours";

            foreach (DataRow row in GetDataTable(statement).Rows)
            {
                tourVmList.Add(new TourVm()
                {
                    Date = row.ItemArray[0].ToString(),
                    radioName = row.ItemArray[1].ToString(),
                    eNumber = row.ItemArray[2].ToString(),
                    startLocation = row.ItemArray[3].ToString(),
                    endLocation = row.ItemArray[4].ToString(),
                    startTime = row.ItemArray[5].ToString(),
                    endTime = row.ItemArray[6].ToString(),
                    drivenKilometer = row.ItemArray[7].ToString(),
                    driverpassenger = row.ItemArray[8].ToString(),
                    doctor = row.ItemArray[9].ToString(),
                });
            }
            return tourVmList;
        }

        public void AddTour(TourVm tourVm)
        {
            var query = @$"INSERT INTO Tours (radioName, eNumber, startLocation, endLocation, startTime, endTime, drivenKilometer, driverpassenger, doctor)
                            VALUES 
                            ('{tourVm.radioName}', '{tourVm.eNumber}', '{tourVm.startLocation}', '{tourVm.endLocation}', '{tourVm.startTime}', '{tourVm.endTime}', '{tourVm.drivenKilometer}', '{tourVm.driverpassenger}', '{tourVm.doctor}');";
            Update(query);
        }

        /// <summary>
        /// Closes the connection, releases the file and encrypt the database file
        /// </summary>
        public void Dispose()
        {
            _connection.Close();
            _command.Dispose();
            _encryptionService.Encrypt();
            File.Delete(SQLConstants.DATABASE_FILE);
        }
    }
}
