using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media;
using System.ComponentModel;

namespace FITAnnouncements.ViewModels
{
    public class MyContentViewModel : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public MyContentViewModel(int number, string title, string announcementText, byte[] image, byte[] icon, DateTime datumObjave)
        {
            MyCount = number;
            Title = title;
            AnnouncementText = announcementText;
            Image = image;
            Icon = icon;
            DatumObjave = datumObjave;
        }

       

        public int MyCount { get; set; }
        public string Title { get; set; }
        public string AnnouncementText { get; set; }
        public byte[] Image { get; set; }
        public byte[] Icon { get; set; }
        public DateTime DatumObjave { get; set; }


    }


}
