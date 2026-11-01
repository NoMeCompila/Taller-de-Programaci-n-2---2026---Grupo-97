using System;
using System.Windows.Forms;
using MobileSolutions.BusinessLayer;

namespace MobileSolutions.UILayer
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            try
            {
                BackupService.EnsureDatabaseReady();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Advertencia al inicializar la base de datos local:\n{ex.Message}",
                    "Inicialización de Base de Datos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

            Application.Run(new LoginForm());
        }
    }
}
