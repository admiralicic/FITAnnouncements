using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Windows.Input;
using System.Collections.ObjectModel;
using System.Windows.Threading;
using FITAnnouncements.Data.EF.BLL;
using FITAnnouncements.Data.EF.DAL;

namespace FITAnnouncements.ViewModels
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        private List<Announcement> announcements = new List<Announcement>();
        private List<News> fitVijesti = new List<News>();
        private List<FITNewsItem> lista;

        private int announcementsCount = 0;
        private int currentAnnouncement = 0;

        public MainWindowViewModel()
        {
            LoadNews();
            LoadAnnouncements();
            announcementsCount = announcements.Count;           

            if (announcementsCount > 0)
            {
                LoadContent();
                currentAnnouncement++;
            }
            
            Vijesti = new FITNewsViewModel(lista);

            DispatcherTimer dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 10);
            dispatcherTimer.Start();
        }

        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            if (currentAnnouncement < announcementsCount)
            {
                LoadContent();
                currentAnnouncement++;
            }
            else
            {
                LoadAnnouncements();
                announcementsCount = announcements.Count;
                currentAnnouncement = 0;
            }

            LoadNews();            
            Vijesti = new FITNewsViewModel(lista);
            
        }

        private void LoadContent()
        {
            Content = new MyContentViewModel(currentAnnouncement,
                announcements[currentAnnouncement].Title, 
                announcements[currentAnnouncement].Text, 
                announcements[currentAnnouncement].Image, 
                announcements[currentAnnouncement].Icon, 
                (DateTime)announcements[currentAnnouncement].Created);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        private object m_content;
        

        public object Content
        {
            get { return m_content; }
            set
            {
                if (m_content != value)
                {
                    m_content = value;
                    RaisePropertyChanged("Content");
                }
            }
        }

        private object vijesti;
        public object Vijesti
        {
            get { return vijesti; }
            set
            {
                vijesti = value;
                RaisePropertyChanged("Vijesti");
            }
        }


        private void LoadAnnouncements()
        {
            using (DBBL data = new DBBL())
            {
                announcements = data.getActiveAnnouncement();
                
            }
        }

        private void LoadNews()
        {
            
            using (DBBL data = new DBBL())
            {
                fitVijesti = data.getActiveNews();
            }

            if (fitVijesti.Count > 0)
            {
                lista = new List<FITNewsItem>();
                foreach (var news in fitVijesti)
                {
                    FITNewsItem fn = new FITNewsItem();
                    fn.Description = news.Text;
                    lista.Add(fn);
                    
                }
            }
        }

        private void NewsTickerRestart()
        {
            
        }
               
    }
}
