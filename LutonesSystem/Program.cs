using System;
using System.Windows.Forms;
using DevExpress.Xpo.DB;
using LutonesSystem.Forms._1___Principal;
using LutonesSystem.XPO.LutonesSystem;

namespace LutonesSystem
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(new form_MenuPrincipal());
            ConnectionHelper.Connect(AutoCreateOption.None);

            Application.Run(new form_MenuInicial());
        }
    }
}
