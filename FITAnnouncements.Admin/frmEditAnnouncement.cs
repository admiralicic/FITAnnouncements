using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using FITAnnouncements.Data.EF.BLL;

namespace FITAnnouncements.Admin
{
    public partial class frmEditAnnouncement : Form
    {
        public frmEditAnnouncement()
        {
            InitializeComponent();
        }

        private void frmEditAnnouncement_Load(object sender, EventArgs e)
        {
            try
            {
                dtpExpire.Value = (DateTime)frmAnnouncements.announcement.Expiry;
                tboxTitle.Text = frmAnnouncements.announcement.Title;
                tboxAnnouncementText.Text = frmAnnouncements.announcement.Text;
                MemoryStream ms = new MemoryStream(frmAnnouncements.announcement.Image);
                pcbImage.Image = Image.FromStream(ms);
                MemoryStream ms1 = new MemoryStream(frmAnnouncements.announcement.Icon);
                pcbIcon.Image = Image.FromStream(ms1);
            }
            catch (Exception err)
            {
            }
            dtpExpire.ShowUpDown = true;
        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            try
            {
                tboxImagePath.Text = openFileDialog.FileName;
                Image image = Image.FromFile(tboxImagePath.Text);
                pcbImage.Image = image;
            }
            catch (Exception err)
            {

                MessageBox.Show(err.ToString());
            }

        }

        private void btnSelectIcon_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            try
            {
                tboxIconPath.Text = openFileDialog.FileName;
                Image image = Image.FromFile(tboxIconPath.Text);
                pcbIcon.Image = image;
            }
            catch (Exception err)
            {

                MessageBox.Show(err.ToString());
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dtpExpire.Value <= DateTime.Now || tboxAnnouncementText.Text == String.Empty || tboxTitle.Text == String.Empty)
            {
                MessageBox.Show("Datum i vrijeme isteka objave vijesti mora biti veće od današnjeg.\nNaslov i tekst objave ne mogu biti prazni.");
            }
            else
            {
                using (DBBL data = new DBBL())
                {
                    Image img = null;
                    Image icon = null;
                    try
                    {
                        if (tboxImagePath.Text != "Izaberite sliku") img = Image.FromFile(tboxImagePath.Text);
                        if (tboxIconPath.Text != "Izaberite ikonu") icon = Image.FromFile(tboxIconPath.Text);
                    }
                    catch (Exception)
                    {
                    }

                    data.updateAnnouncement(frmAnnouncements.announcement, tboxTitle.Text, tboxAnnouncementText.Text, dtpExpire.Value, img, icon);
                    MessageBox.Show("Uspješno ste editovali podatke o objavi.");
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
