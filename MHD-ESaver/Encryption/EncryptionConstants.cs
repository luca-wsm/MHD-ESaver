using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHD_ESaver.Encryption
{
    /// <summary>
    /// Because we want to run the application locally without an backend we hardcode the keys and passwords. 
    /// The protect this data the application must be obfuscated.
    /// </summary>
    public class EncryptionConstants
    {
        public const String ENCRYPTION_KEY = "erQHT6fCQbVb16pYzhG71xOcEWQcYY21ov8pa0DTzVA=";
        public const String ENCRYPTION_IV = "rkIXHTox/2rOZz2iqTcMGQ==";
    }
}
