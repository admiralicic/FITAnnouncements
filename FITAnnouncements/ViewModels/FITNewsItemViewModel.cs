using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace FITAnnouncements
{
    public class FITNewsItemViewModel : INotifyPropertyChanged
    {
        private FITNewsItem fitNewsItem;

        public FITNewsItemViewModel(FITNewsItem fitNewsItem)
        {
            this.fitNewsItem = fitNewsItem;
        }

        public string Description
        {
            get { return fitNewsItem.Description; }
            set
            {
                fitNewsItem.Description = value;
                OnPropertyChanged("Description");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            var eventToFire = PropertyChanged;
            if (eventToFire != null)
            {
                eventToFire(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
