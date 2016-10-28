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
    public partial class frmAnnouncements : Form
    {
        public static Announcement announcement;
        public frmAnnouncements()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dtvAnnouncements.Rows.Count < 1)
            {
                MessageBox.Show("Izaberite red u tabeli.");
            }
            else
            {
                int id = Convert.ToInt32(dtvAnnouncements.CurrentRow.Cells[0].Value);
                using (DBBL data = new DBBL())
                {
                    try
                    {
                        data.removeAnnouncement(data.getAnnouncementByID(id));
                    }
                    catch (Exception err)
                    {

                        MessageBox.Show(err.ToString());
                    }
                    MessageBox.Show("Uspješno ste izbrisali objavu.");
                    dtvAnnouncements.DataSource = null;
                    dtvAnnouncements.DataSource = data.getAnnouncementByAnyParameter(tboxPretraga.Text);
                }
                AnnouncementTableWidth();
            }
        }
        private void AnnouncementTableWidth()
        {
            DataGridViewColumn ColumnID = dtvAnnouncements.Columns[1];
            ColumnID.Width = 200;
            DataGridViewColumn ColumnTekst = dtvAnnouncements.Columns[2];
            ColumnTekst.Width = 400;
            DataGridViewColumn ColumnCreated = dtvAnnouncements.Columns[5];
            ColumnCreated.Width = 100;
            DataGridViewColumn ColumnIstek = dtvAnnouncements.Columns[6];
            ColumnIstek.Width = 115;
            dtvAnnouncements.Columns[0].Visible = false;
            dtvAnnouncements.Columns[3].Visible = false;
            dtvAnnouncements.Columns[4].Visible = false;
            dtvAnnouncements.Columns[7].Visible = false;
            dtvAnnouncements.Columns[8].Visible = false;
            dtvAnnouncements.Columns[9].Visible = false;
        }

        private void frmAnnouncements_Load(object sender, EventArgs e)
        {

            using (DBBL data = new DBBL())
            {
                dtvAnnouncements.DataSource = data.getAnnouncementByAnyParameter(tboxPretraga.Text);
            }
            AnnouncementTableWidth();
            dtvAnnouncements.FirstDisplayedScrollingRowIndex = dtvAnnouncements.Rows[0].Index;
            dtvAnnouncements.Refresh();
            dtvAnnouncements.CurrentCell = dtvAnnouncements.Rows[0].Cells[1];
            dtvAnnouncements.Rows[0].Selected = true;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            frmAddAnnouncement frm = new frmAddAnnouncement();
            frm.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (DBBL data = new DBBL())
            {
                dtvAnnouncements.DataSource = data.getAnnouncementByAnyParameter(tboxPretraga.Text);
            }
            AnnouncementTableWidth();
        }

        private void lblClear_Click(object sender, EventArgs e)
        {
            tboxPretraga.Text = String.Empty;
            using (DBBL data = new DBBL())
            {
                dtvAnnouncements.DataSource = data.getAnnouncementByAnyParameter(tboxPretraga.Text);
            }
            AnnouncementTableWidth();

        }

        private void tboxPretraga_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                using (DBBL data = new DBBL())
                {
                    dtvAnnouncements.DataSource = data.getAnnouncementByAnyParameter(tboxPretraga.Text);
                }
                AnnouncementTableWidth();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dtvAnnouncements.Rows.Count < 1)
            {
                MessageBox.Show("Izaberite red u tabeli.");
            }
            else
            {
                using (DBBL data = new DBBL())
                {
                    announcement = data.getAnnouncementByID(Convert.ToInt32(dtvAnnouncements.CurrentRow.Cells[0].Value));
                }
                frmEditAnnouncement frm = new frmEditAnnouncement();
                frm.ShowDialog();
                btnSearch_Click(sender, null);
                AnnouncementTableWidth();
            }
        }

        private void dtvAnnouncements_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEdit_Click(sender, null);
        }
    }
}
