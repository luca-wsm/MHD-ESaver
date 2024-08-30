using System;
using System.Windows.Forms;

namespace MHD_ESaver
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new MainPanel());
        }
    }
}