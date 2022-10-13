using M13TipusHab.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace M13TipusHab.Controller
{
    //Hola nestor
    internal static class Program
    {
        /// <summary>
        /// Pues aqui se hacen tipos de habitaciones de hotel
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            new Controller1();
        }
    }
}
