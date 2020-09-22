using System;
using System.Windows.Forms;

namespace Snake_mvc
{
    static class Program
    {
        /// <summary>
        /// Punto di ingresso principale dell'applicazione.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Inizio());  // avvio del form del menù iniziale
        }
    }
}
