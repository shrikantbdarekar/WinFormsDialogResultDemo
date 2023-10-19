using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsDialogResultDemo
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FormSplashScreen FormSplashScreenObj = new FormSplashScreen();
            FormSplashScreenObj.ShowDialog();

            FormLogin FormLoginObj = new FormLogin();
            FormLoginObj.ShowDialog();

            // Login Successful. Show menu form.
            // Otherwise exit application. (By Default)
            if (FormLoginObj.DialogResult == DialogResult.OK)
            {
                FormDashboard FormDashboardObj = new FormDashboard();
                FormDashboardObj.ShowDialog();
            }

            // Perform all application exit code here.
            // 1.Close database connection.
            // 2.Database Backup.
            // 3.Delete resources.
            // 4.Add logs.
            Application.Exit();
        }
    }
}
