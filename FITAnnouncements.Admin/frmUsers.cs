using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FITAnnouncements.Data.EF.DAL;
using FITAnnouncements.Data.EF.BLL;

namespace FITAnnouncements.Admin
{
    public partial class frmUsers : Form
    {
        public static User korisnik { get; set; }
        public frmUsers()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            using (DBBL data = new DBBL())
            {
                dtvKorisnici.DataSource = data.getKorisnikByAnyParameter(tboxPretraga.Text);
            }
            KorisniciTableWidth();
        }
        private void KorisniciTableWidth()
        {
            DataGridViewColumn ColumnID = dtvKorisnici.Columns[0];
            ColumnID.Width = 70;
            DataGridViewColumn ColumnIme = dtvKorisnici.Columns[1];
            ColumnIme.Width = 200;
            DataGridViewColumn ColumnPrezime = dtvKorisnici.Columns[2];
            ColumnPrezime.Width = 200;
            DataGridViewColumn ColumnUsername = dtvKorisnici.Columns[3];
            ColumnUsername.Width = 190;
            dtvKorisnici.Columns[0].Visible = false;
            dtvKorisnici.Columns[4].Visible = false;
            dtvKorisnici.Columns[5].Visible = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dtvKorisnici.Rows.Count < 1)
            {
                MessageBox.Show("Izaberite red u tabeli.");
            }
            else
            {
                int id = Convert.ToInt32(dtvKorisnici.CurrentRow.Cells[0].Value);
                using (DBBL data = new DBBL())
                {
                    try
                    {
                        data.removeKorisnik(data.getKorisnikByID(id));
                    }
                    catch (Exception err)
                    {

                        MessageBox.Show(err.ToString());
                    }
                    MessageBox.Show("Uspješno ste izbrisali korisnika");
                    dtvKorisnici.DataSource = null;
                    dtvKorisnici.DataSource = data.getKorisnikByAnyParameter(tboxPretraga.Text);
                }
                KorisniciTableWidth();
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            frmAddUser frm = new frmAddUser();
            frm.ShowDialog();
            using (DBBL data = new DBBL())
            {
                dtvKorisnici.DataSource = null;
                dtvKorisnici.DataSource = data.getKorisnikByAnyParameter(tboxPretraga.Text);
                KorisniciTableWidth();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (DBBL data = new DBBL())
            {
                dtvKorisnici.DataSource = data.getKorisnikByAnyParameter(tboxPretraga.Text);
            }
            KorisniciTableWidth();
        }

        private void lblClear_Click(object sender, EventArgs e)
        {
            tboxPretraga.Text = String.Empty;
            btnSearch_Click(sender, null);
        }

        private void tboxPretraga_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnSearch_Click(sender, null);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dtvKorisnici.Rows.Count < 1)
            {
                MessageBox.Show("Izaberite red u tabeli.");
            }
            else
            {
                using (DBBL data = new DBBL())
                {
                    korisnik = data.getKorisnikByID(Convert.ToInt32(dtvKorisnici.CurrentRow.Cells[0].Value));
                }
                frmEditUser frm = new frmEditUser();
                frm.ShowDialog();
                btnSearch_Click(sender, null);
                KorisniciTableWidth();
            }
        }

        private void dtvKorisnici_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEdit_Click(sender, null);
        }
    }
}
