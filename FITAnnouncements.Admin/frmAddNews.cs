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
    public partial class frmAddNews : Form
    {
        public frmAddNews()
        {
            InitializeComponent();
        }

        private void frmAddNews_Load(object sender, EventArgs e)
        {
            dtpExpire.ShowUpDown = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            News vijest = new News();
            try
            {
                vijest.Text = tboxNewsText.Text;
                vijest.Created = DateTime.Now;
                vijest.Expiry = dtpExpire.Value;
                vijest.Expired = false;
                vijest.IsDeleted = false;
                if (dtpExpire.Value <= DateTime.Now)
                {
                    MessageBox.Show("Datum i vrijeme isteka objave vijesti mora biti veće od današnjeg!");
                }
                else
                {
                    using (DBBL data = new DBBL())
                    {
                   
                            data.InsertNews(vijest);
                            MessageBox.Show("Uspješno ste dodali vijest.");
                            clearFields();
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
            tboxNewsText.Text = String.Empty;
        }
    }
}
