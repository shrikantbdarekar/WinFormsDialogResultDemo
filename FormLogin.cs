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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            // Check user id and password using database logic.
            // Set value as per result
            bool ValidLogin = true;

            if (ValidLogin)
            {
                // If login successful
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                // else login failed
                this.DialogResult = DialogResult.Cancel;
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            // If login failed
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
