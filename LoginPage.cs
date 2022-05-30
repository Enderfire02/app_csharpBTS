
using app_csharpBTS.Manager;
using app_csharpBTS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BTS_Csharp
{
    public partial class LoginPage : Form
    {
        public static bool Authentified = false;
        StaffManager StaffManager;
        public LoginPage()
        {
            InitializeComponent();
            StaffManager = new StaffManager();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {
            staff staff = StaffManager.FindStaffName(USN.Text);

            if (staff is null || staff.Password != PWD.Text)
            {
                MessageBox.Show("Oups !! il semblerai que l'un des deux champs est erroné");
                return;
            }
            else if (staff.Username == USN.Text && staff.Password == PWD.Text)
            {
                Authentified = true;
                Close();
            }
        }

        private void USN_TextChanged(object sender, EventArgs e)
        {

        }

        private void PWD_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
