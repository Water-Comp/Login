using Login.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace Login
{
    static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Crypt Crypt = new Crypt();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new login_Form());
            Crypt.EncryptFile("F:\\Login\\zz_de\\abc.txt", "F:\\Login\\zz_en\\test.txt", "a");
        }
    }
}
