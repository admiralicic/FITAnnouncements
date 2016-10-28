using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FITAnnouncements.Data.EF.BLL;
using FITAnnouncements.Data.EF.DAL;

namespace FITAnnouncements.Admin
{
    public partial class frmLogin : Form
    {
        int ccounter = 0;
        int AttemptCounter = 1;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void LoginCancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginCheckButton_Click(object sender, EventArgs e)
        {
            if (CheckUserName() == true)
            {
                this.Close();
            }
        }
        private bool CheckUserName()
        {
            try
            {
                using (DBBL data = new DBBL())
                {
                    ccounter = data.CheckUsernameValue(tboxUsername.Text, tboxPassword.Text);
                }

            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString());
            }
            if (ccounter == 0)
            {
                AttemptCounter = AttemptCounter + 1;
                if (AttemptCounter > 5)
                {
                    Application.Exit();
                    return false;
                }
                else
                {
                    WrongUsernameLabel.Text = "Pristup odbijen. Ovo je Vaš " + AttemptCounter + ". pokušaj.";
                    WrongUsernameLabel.Visible = true;
                    WrongUsernameLabel.Refresh();
                    return false;
                }
            }
            else
            {
                try
                {
                    using (DBBL data = new DBBL())
                    {
                        User k = data.getKorisnikByParameter(tboxUsername.Text, tboxPassword.Text);
                        Session.LoggedInUser = k;
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                }
                return true;
            }
        }

        private void tboxUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) tboxPassword.Focus();
        }

        private void tboxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) btnLogin.Focus();
        }

        private void PassMaskCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            tboxPassword.PasswordChar = '\0';
            if (PassMaskCheckBox.Checked == true)
            {
                tboxPassword.PasswordChar = '*';
            }
        }
    }
}
