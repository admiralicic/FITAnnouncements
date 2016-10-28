using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FITAnnouncements.Data.EF.BLL;

namespace FITAnnouncements.Admin
{
    public partial class frmEditNews : Form
    {
        public frmEditNews()
        {
            InitializeComponent();
        }

        private void frmEditNews_Load(object sender, EventArgs e)
        {
            dtpExpire.Value = (DateTime)frmNews.news.Expiry;
            tboxNewsText.Text = frmNews.news.Text;
            dtpExpire.ShowUpDown = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dtpExpire.Value <= DateTime.Now || tboxNewsText.Text==String.Empty)
            {
                MessageBox.Show("Datum i vrijeme isteka objave vijesti mora biti veće od današnjeg.\nTekst vijesti ne može biti prazan.");
            }else
            {
                using (DBBL data = new DBBL())
                {
                    data.updateNews(frmNews.news, tboxNewsText.Text, dtpExpire.Value);
                    MessageBox.Show("Uspješno ste editovali podatke o vijesti.");
                }
            }
            
        }
    }
}
