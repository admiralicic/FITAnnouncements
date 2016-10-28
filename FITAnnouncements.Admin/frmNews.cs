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
    public partial class frmNews : Form
    {
        public static News news;
        public frmNews()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmNews_Load(object sender, EventArgs e)
        {
            using (DBBL data = new DBBL())
            {
                dtvNews.DataSource = data.getNewsByAnyParameter(tboxPretraga.Text);
            }
            NewsTableWidth();
            dtvNews.FirstDisplayedScrollingRowIndex = dtvNews.Rows[0].Index;
            dtvNews.Refresh();
            dtvNews.CurrentCell = dtvNews.Rows[0].Cells[1];
            dtvNews.Rows[0].Selected = true;
        }
        private void NewsTableWidth()
        {
            DataGridViewColumn ColumnID = dtvNews.Columns[0];
            ColumnID.Width = 70;
            DataGridViewColumn ColumnTekst = dtvNews.Columns[1];
            ColumnTekst.Width = 553;
            DataGridViewColumn ColumnCreated = dtvNews.Columns[2];
            ColumnCreated.Width = 100;
            DataGridViewColumn ColumnIstek = dtvNews.Columns[3];
            ColumnIstek.Width = 110;
            dtvNews.Columns[0].Visible = false;
            dtvNews.Columns[4].Visible = false;
            dtvNews.Columns[5].Visible = false;
            dtvNews.Columns[6].Visible = false;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            frmAddNews frm = new frmAddNews();
            frm.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dtvNews.Rows.Count < 1)
            {
                MessageBox.Show("Izaberite red u tabeli.");
            }
            else
            {
                int id = Convert.ToInt32(dtvNews.CurrentRow.Cells[0].Value);
                using (DBBL data = new DBBL())
                {
                    try
                    {
                        data.removeNews(data.getNewsByID(id));
                    }
                    catch (Exception err)
                    {

                        MessageBox.Show(err.ToString());
                    }
                    MessageBox.Show("Uspješno ste izbrisali vijest.");
                    dtvNews.DataSource = null;
                    dtvNews.DataSource = data.getNewsByAnyParameter(tboxPretraga.Text);
                }
                NewsTableWidth();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (DBBL data = new DBBL())
            {
                dtvNews.DataSource = data.getNewsByAnyParameter(tboxPretraga.Text);
            }
            NewsTableWidth();
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
            if (dtvNews.Rows.Count < 1)
            {
                MessageBox.Show("Izaberite red u tabeli.");
            }
            else
            {
                using (DBBL data = new DBBL())
                {
                    news = data.getNewsByID(Convert.ToInt32(dtvNews.CurrentRow.Cells[0].Value));
                }
                frmEditNews frm = new frmEditNews();
                frm.ShowDialog();
                btnSearch_Click(sender, null);
                NewsTableWidth();
            }
        }

        private void dtvNews_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEdit_Click(sender, null);
        }
    }
}
