using System;
using System.IO;

namespace MHD_ESaver {
    public class SQLConstants
    {
        // Because the specialfolder is no compile constant we have to use static here.
        public static String GENERAL_PATH = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\MHD_E-Saver\\");
        public static String DATABASE_FILENAME = "database.db3";
        public static String DATABASE_FILE = GENERAL_PATH + DATABASE_FILENAME;
        public static String DATABASE_FILE_ENCRYPTED = GENERAL_PATH + "database_encrypted.db3";
    }
}
