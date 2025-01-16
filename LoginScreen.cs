using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SensorMonitoring
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            if (TxtUsername.Text == "doctor" && TxtPassword.Text == "password")
            {
                this.Hide();
                MainScreen frm = new MainScreen();
                frm.Show();
            }
        }
    }
}
