using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FITAnnouncements.Data.EF.DAL;
using System.Web.Security;
using FITAnnouncements.Data.EF.BLL;

namespace FITAnnouncements.Admin
{
    public partial class frmEditUser : Form
    {
        public frmEditUser()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEditUser_Load(object sender, EventArgs e)
        {
            tboxIme.Text = frmUsers.korisnik.Name;
            tboxPrezime.Text = frmUsers.korisnik.Surname;
            tboxUsername.Text = frmUsers.korisnik.Username;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            User korisnik = new User();
            try
            {
                if (tboxUsername.Text == String.Empty || tboxPassword.Text == String.Empty)
                {
                    MessageBox.Show("Polja Korisničko ime i Lozinka moraju biti popunjena!");
                }
                else
                {
                    using (DBBL data = new DBBL())
                    {
                        if (data.checkDoubleUsername(tboxUsername.Text) == true && frmUsers.korisnik.Username!=tboxUsername.Text)
                        {
                            MessageBox.Show("Korisnik sa korisničkim imenom: " + tboxUsername.Text + " već postoji.");
                            tboxUsername.Focus();
                            tboxUsername.SelectAll();
                        }
                        else
                        {
                            data.updateUser(frmUsers.korisnik, tboxIme.Text, tboxPrezime.Text, tboxUsername.Text, FormsAuthentication.HashPasswordForStoringInConfigFile(tboxPassword.Text, "sha1"));
                            MessageBox.Show("Uspješno ste editovali podatke o korisniku.");
                        }

                    }
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }
    }
}
