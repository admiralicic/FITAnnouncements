using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FITAnnouncements.Data.EF.DAL;
using FITAnnouncements.Data.EF.BLL;
using System.Web;
using System.Security;
using System.Web.Security;
using System.Drawing;
using System.IO;

namespace FITAnnouncements.Data.EF.BLL
{

    public class DBBL : IDisposable
    {
        public DBEntities context;
        //CONSTRUCTOR
        public DBBL()
        {
            context = new DBEntities();
            context.Connection.Open();
        }
        //DISPOSE
        public void Dispose()
        {
            context.Connection.Close();
            context.Dispose();
        }
        public int CheckUsernameValue(string username, string password)
        {
            password = FormsAuthentication.HashPasswordForStoringInConfigFile(password, "sha1");
            try
            {
                if (context.User.Where(x => x.Username == username && x.Password == password).FirstOrDefault() != null)
                {
                    return 1;
                }
                else return 0;
            }
            catch (Exception err)
            {

                System.Windows.Forms.MessageBox.Show(err.ToString());
            }
            return 0;
        }
        public User getKorisnikByParameter(string username, string password)
        {
            password = FormsAuthentication.HashPasswordForStoringInConfigFile(password, "sha1");
            try
            {
                return context.User.Where(x => x.Username == username && x.Password == password).SingleOrDefault();
            }
            catch (Exception err)
            {

                System.Windows.Forms.MessageBox.Show(err.ToString());
                return null;
            }

        }
        public List<User> getKorisnikByAnyParameter(string param)
        {
            try
            {
                return context.User.Where(x => x.IsDeleted == false && (x.Username == param || x.Name.Contains(param) || x.Surname.Contains(param))).ToList();
            }
            catch (Exception err)
            {

                System.Windows.Forms.MessageBox.Show(err.ToString());
                return null;
            }

        }
        public void removeKorisnik(User k)
        {
            try
            {
                k.IsDeleted = true;
                context.SaveChanges();
            }
            catch (Exception err)
            {

                System.Windows.Forms.MessageBox.Show(err.ToString());
            }

        }
        public User getKorisnikByID(int id)
        {
            try
            {
                return context.User.Where(x => x.User_ID == id).SingleOrDefault();
            }
            catch (Exception err)
            {

                System.Windows.Forms.MessageBox.Show(err.ToString());
                return null;
            }

        }
        public void InsertKorisnikByAdmin(User k)
        {
            try
            {
                context.User.AddObject(k);
                context.SaveChanges();
            }
            catch (Exception err)
            {

                System.Windows.Forms.MessageBox.Show(err.ToString());
            }

        }
        public void InsertNews(News n)
        {

            try
            {
                context.News.AddObject(n);
                context.SaveChanges();
            }
            catch (Exception err)
            {

                System.Windows.Forms.MessageBox.Show(err.ToString());
            }

        }
        public Boolean checkDoubleUsername(String username)
        {
            Boolean usernameExsists = false;
            User korisnik = null;
            try
            {
                korisnik = context.User.Where(x => x.Username == username).SingleOrDefault();
            }
            catch (Exception err)
            {

                System.Windows.Forms.MessageBox.Show(err.ToString());
            }

            if (korisnik == null) usernameExsists = false;
            else usernameExsists = true;
            return usernameExsists;
        }

        public List<News> getNewsByAnyParameter(string param)
        {
            try
            {
                return context.News.Where(x => x.IsDeleted == false && x.Text.Contains(param)).ToList();
            }
            catch (Exception err)
            {

                System.Windows.Forms.MessageBox.Show(err.ToString());
                return null;
            }

        }
        public List<News> getActiveNews()
        {
            try
            {
                return context.News.Where(x => x.IsDeleted == false && x.Expired==false && x.Expiry>=DateTime.Now).ToList();
            }
            catch (Exception err)
            {

                System.Windows.Forms.MessageBox.Show(err.ToString());
                return null;
            }

        }
        public News getNewsByID(int id)
        {
            try
            {
                return context.News.Where(x => x.News_ID == id).SingleOrDefault();
            }
            catch (Exception err)
            {

                System.Windows.Forms.MessageBox.Show(err.ToString());
                return null;
            }


        }

        public void removeNews(News n)
        {
            try
            {
                n.IsDeleted = true;
                context.SaveChanges();
            }
            catch (Exception err)
            {

                System.Windows.Forms.MessageBox.Show(err.ToString());
            }

        }

        public List<Announcement> getActiveAnnouncement()
        {
            try
            {
                return context.Announcement.Where(x => x.IsDeleted == false && x.Expired == false && x.Expiry>=DateTime.Now).ToList();
            }
            catch (Exception err)
            {

                //System.Windows.Forms.MessageBox.Show(err.ToString());
                return null;
            }

        }

        public void removeAnnouncement(Announcement a)
        {
            try
            {
                a.IsDeleted = true;
                context.SaveChanges();
            }
            catch (Exception err)
            {

                System.Windows.Forms.MessageBox.Show(err.ToString());
            }

        }
        public Announcement getAnnouncementByID(int id)
        {
            try
            {
                return context.Announcement.Where(x => x.Announcement_ID == id).SingleOrDefault();
            }
            catch (Exception err)
            {

                System.Windows.Forms.MessageBox.Show(err.ToString());
                return null;
            }

        }

        public List<Announcement> getAnnouncementByAnyParameter(string param)
        {
            try
            {
                return context.Announcement.Where(x => x.IsDeleted == false && (x.Text.Contains(param) || x.Title.Contains(param))).ToList();
            }
            catch (Exception err)
            {

                //System.Windows.Forms.MessageBox.Show(err.ToString());
                return null;
            }

        }

        public void InsertAnnouncement(Announcement a)
        {
            try
            {
                context.Announcement.AddObject(a);
                context.SaveChanges();
            }
            catch (Exception err)
            {
                System.Windows.Forms.MessageBox.Show(err.ToString());
            }

        }
        public void updateNews(News news, String text, DateTime expiry)
        {
            News temp = getNewsByID(news.News_ID);
            //temp.Kredit = temp.Kredit - cijenaKupovine;
            //context.Korisnici.ApplyCurrentValues(temp);
            //context.SaveChanges();
            temp.Text = text;
            temp.Expiry = expiry;
            try
            {
                context.News.ApplyCurrentValues(temp);
                context.SaveChanges();
            }
            catch (Exception err)
            {
                System.Windows.Forms.MessageBox.Show(err.ToString());
            }
        }
        private Byte[] convertImageToByte(Image img)
        {
            try
            {
                MemoryStream ms = new MemoryStream();
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
            catch (Exception err)
            {

                System.Windows.Forms.MessageBox.Show(err.ToString());
                return null;
            }

        }
        public void updateAnnouncement(Announcement announcement, String title, String text, DateTime expiry, Image img, Image icon)
        {
            Announcement temp = null;
            try
            {
                temp = getAnnouncementByID(announcement.Announcement_ID);
                temp.Title = title;
                temp.Text = text;
                temp.Expiry = expiry;
            }
            catch (Exception)
            {
            }
            try
            {
                if (img != null)
                {
                    temp.Image = convertImageToByte(img);
                }
                if (icon != null)
                {
                    temp.Icon = convertImageToByte(icon);
                }

            }
            catch (Exception)
            {
            }
            try
            {
                context.Announcement.ApplyCurrentValues(temp);
                context.SaveChanges();
            }
            catch (Exception err)
            {
                System.Windows.Forms.MessageBox.Show(err.ToString());
            }
        }
        public void updateUser(User user, String ime, String prezime,String username,String password)
        {
            User temp = getKorisnikByID(user.User_ID);
            temp.Name = ime;
            temp.Surname = prezime;
            temp.Username = username;
            temp.Password = password;
            try
            {
                context.User.ApplyCurrentValues(temp);
                context.SaveChanges();
            }
            catch (Exception err)
            {
                System.Windows.Forms.MessageBox.Show(err.ToString());
            }
        }
    }
}
