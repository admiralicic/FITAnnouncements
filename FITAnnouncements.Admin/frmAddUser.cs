using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FITAnnouncements.Data.EF.DAL;
using System.Web;
using System.Security;
using System.Web.Security;
using FITAnnouncements.Data.EF.BLL;

namespace FITAnnouncements.Admin
{
    public partial class frmAddUser : Form
    {
        public frmAddUser()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            User korisnik = new User();
            try
            {
                korisnik.Name = tboxIme.Text;
                korisnik.Surname = tboxPrezime.Text;
                korisnik.Username = tboxUsername.Text;
                korisnik.Password = FormsAuthentication.HashPasswordForStoringInConfigFile(tboxPassword.Text, "sha1");
                korisnik.IsDeleted = false;
                if (tboxUsername.Text == String.Empty || tboxPassword.Text == String.Empty)
                {
                    MessageBox.Show("Polja Korisničko ime i Lozinka moraju biti popunjena!");
                }
                else
                {
                    using (DBBL data = new DBBL())
                    {
                        if (data.checkDoubleUsername(tboxUsername.Text) == true)
                        {
                            MessageBox.Show("Korisnik sa korisničkim imenom: "+tboxUsername.Text+" već postoji.");
                            tboxUsername.Focus();
                            tboxUsername.SelectAll();
                        }
                        else
                        {
                            data.InsertKorisnikByAdmin(korisnik);
                            MessageBox.Show("Uspješno ste dodali korisnika.");
                            clearFields();
                        }
                       
                    }
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }
        private void clearFields()
        {
            tboxIme.Text = String.Empty;
            tboxPrezime.Text = String.Empty;
            tboxUsername.Text = String.Empty;
            tboxPassword.Text = String.Empty;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
