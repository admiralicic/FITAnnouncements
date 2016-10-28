using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace FITAnnouncements
{
    public class FITNewsViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<FITNewsItemViewModel> vijesti;
        public ObservableCollection<FITNewsItemViewModel> Vijesti
        {
            get { return vijesti; }
            set
            {
                vijesti = value;
                OnPropertyChanged("Vijesti");
            }
        }

        public FITNewsViewModel(List<FITNewsItem> fitNews)
        {
            Vijesti = new ObservableCollection<FITNewsItemViewModel>(fitNews.Select(fn => new FITNewsItemViewModel(fn)));
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
