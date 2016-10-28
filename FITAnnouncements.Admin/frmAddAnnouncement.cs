using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FITAnnouncements.Data.EF.DAL;
using System.IO;
using FITAnnouncements.Data.EF.BLL;

namespace FITAnnouncements.Admin
{
    public partial class frmAddAnnouncement : Form
    {
        public frmAddAnnouncement()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog.ShowDialog();
                tboxImagePath.Text = openFileDialog.FileName;
                Image image = Image.FromFile(tboxImagePath.Text);
                pcbImage.Image = image;
            }
            catch (Exception)
            {
                
                throw;
            }
     
        }

        private void btnSelectIcon_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog.ShowDialog();
                tboxIconPath.Text = openFileDialog.FileName;
                Image image = Image.FromFile(tboxIconPath.Text);
                pcbIcon.Image = image;
            }
            catch (Exception)
            {
                
                throw;
            }
          
        }
        private void clearFields()
        {
            tboxTitle.Text = String.Empty;
            tboxNewsText.Text = String.Empty;
            tboxImagePath.Text = String.Empty;
            tboxIconPath.Text = String.Empty;
            pcbIcon.Image = null;
            pcbImage.Image = null;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tboxTitle.Text == String.Empty || tboxNewsText.Text == String.Empty || tboxIconPath.Text == "" || tboxIconPath.Text == "Izaberite ikonu")
            {
                MessageBox.Show("Upišite naslov, tekst i ikonu objave.");
                tboxTitle.Focus();
            }
            else
            {
                Announcement objava = new Announcement();
                try
                {
                    objava.Title = tboxTitle.Text;
                    objava.Text = tboxNewsText.Text;
                    objava.Expiry = dtpExpire.Value;
                    objava.Expired = false;
                    objava.IsDeleted = false;
                    objava.Created = DateTime.Now;
                    if (dtpExpire.Value <= DateTime.Now)
                    {
                        MessageBox.Show("Datum i vrijeme isteka objave mora biti veće od današnjeg!");
                    }
                    else
                    {
                        if (!String.IsNullOrEmpty(tboxImagePath.Text) && tboxImagePath.Text!="Izaberite sliku")
                        {
                            Image img = Image.FromFile(tboxImagePath.Text);
                            //Image img = (Image)(new Bitmap(Image.FromFile(tboxImagePath.Text), new Size(80, 80)));
                            MemoryStream ms = new MemoryStream();
                            img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                            objava.Image = ms.ToArray();
                        }
                        if (!String.IsNullOrEmpty(tboxIconPath.Text) && tboxIconPath.Text != "Izaberite ikonu")
                        {

                            //byte[] img2 = System.IO.File.ReadAllBytes(tboxIconPath.Text);
                            Image img2 = (Image)(new Bitmap(Image.FromFile(tboxIconPath.Text), new Size(80, 80)));
                            MemoryStream ms = new MemoryStream();
                            img2.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                            objava.Icon = ms.ToArray();
                        }
                        using (DBBL data = new DBBL())
                        {
                            data.InsertAnnouncement(objava);
                            MessageBox.Show("Uspješno ste dodali objavu.");
                            clearFields();
                        }
                    }  
                }
                catch (Exception ee)
                {

                    MessageBox.Show(ee.ToString());
                }
            }
        }

        private void frmAddAnnouncement_Load(object sender, EventArgs e)
        {
            dtpExpire.ShowUpDown = true;
        }
    }
}
