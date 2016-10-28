using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FITAnnouncements.Data.EF.BLL;
using FITAnnouncements;

namespace FITAnnouncements.Admin
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void pregledToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsers frm = new frmUsers();
            frm.ShowDialog();
        }

        private void dodajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUser frm = new frmAddUser();
            frm.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lblLoggedInUser.Text ="Korisnik: "+ Session.LoggedInUser.Name + " " + Session.LoggedInUser.Surname;
            using (DBBL data = new DBBL())
            {
                dtvAnnouncements.DataSource = data.getActiveAnnouncement();
            }
            AnnouncementTableWidth();
            dtvAnnouncements.FirstDisplayedScrollingRowIndex = dtvAnnouncements.Rows[0].Index;
            dtvAnnouncements.Refresh();
            dtvAnnouncements.CurrentCell = dtvAnnouncements.Rows[0].Cells[1];
            dtvAnnouncements.Rows[0].Selected = true;
        }
        private void AnnouncementTableWidth()
        {
            try
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
            catch (Exception err)
            {
            }

        }
        private void dodajToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAddNews frm = new frmAddNews();
            frm.ShowDialog();
        }

        private void pregledToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmNews frm = new frmNews();
            frm.ShowDialog();
        }

        private void pregledToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmAnnouncements frm = new frmAnnouncements();
            frm.ShowDialog();
            using (DBBL data = new DBBL())
            {
                dtvAnnouncements.DataSource = data.getActiveAnnouncement();
            }
            AnnouncementTableWidth();
        }

        private void dodajToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmAddAnnouncement frm = new frmAddAnnouncement();
            frm.ShowDialog();
            using (DBBL data = new DBBL())
            {
                dtvAnnouncements.DataSource = data.getActiveAnnouncement();
            }
            AnnouncementTableWidth();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            using (DBBL data = new DBBL())
            {
                dtvAnnouncements.DataSource = data.getActiveAnnouncement();
            }
            AnnouncementTableWidth();
        }

        private void animationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainWindow frm = new MainWindow();
            frm.Show();
       

        }
    }
}
