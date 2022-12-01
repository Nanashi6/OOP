using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransportLibrary;

namespace MainForm
{
    internal static class Program
    {
        public static List<ITransport> transports = new List<ITransport>();
        public static string path = "E:\\2 Курс\\ООПиП\\transport.txt";
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
