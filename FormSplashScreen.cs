using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsDialogResultDemo
{
    public partial class FormSplashScreen : Form
    {
        public FormSplashScreen()
        {
            InitializeComponent();

            // Set timerSplashScreen.Interval = 5000, in properties.
            // Start timer. It will invoke after 5 seconds.
            timerSplashScreen.Start();
        }

        private void timerSplashScreen_Tick(object sender, EventArgs e)
        {
            // Will be executed after 5 seconds.
            this.Close();
        }
    }
}
