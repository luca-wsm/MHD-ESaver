using System;
namespace MHD_ESaver.Message
{
    public class MessageConstants
    {
        public const String MESSAGEBOX_PREFIX_TITLE = "MHD-ESaver || ";
        public const String MESSAGEBOX_TITLE_INFORMATION = "Information";
        public const String MESSAGEBOX_TITLE_SUCCESS = "Erfolgreich";
        public const String MESSAGEBOX_TITLE_WARNING = "Warnung";
        public const String MESSAGEBOX_TITLE_ERROR = "Fehler";
        public const String MESSAGEBOX_TITLE_QUESTION = "Achtung";
        public const String MESSAGEBOX_ENTRIES_MISSING_MAIN = "Es fehlen ein oder mehrere Dateneinträge!";
        public const String MESSAGEBOX_WRONG_PASSWORD = "Das Password ist falsch!";
        public const String MESSAGEBOX_DATABASE_NOT_ENCRYPTED = "Die Datenbank ist aktuell nicht verschlüsselt!";
        public const String MESSAGEBOX_DATABASE_ENCRYPTED = "Die Datenbank ist schon verschlüsselt!";
        public const String MESSAGEBOX_DATABASE_ENCRYPTED_SUCCESFULLY = "Die Datenbank wurde erfolgreich verschlüsselt!";
        public const String MESSAGEBOX_DATABASE_DECRYPTED_SUCCESFULLY = "Die Datenbank wurde erfolgreich entschlüsselt!\nACHTUNG DEBUGMODUS: Beim beenden, wird die Datenbank wieder automatisch verschlüsselt.";
        public const String MESSAGEBOX_DATABASE_DELETE_QUESTION = "ACHTUNG: Durch das klicken auf OK gehen alle Daten unwiderruflich verloren!\n\nWillst du trotzdem fortfahren?";
        public const String MESSAGEBOX_DATABASE_DELETED_SUCCESFULLY = "Die Datenbank wurde erfolgreich gelöscht.";
    }
}
