using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Controls;
using FITAnnouncements.ViewModels;
using System.Windows.Threading;


namespace FITAnnouncements
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new MainWindowViewModel();
            
        }

        private void Window_MouseUp(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }
        
    }
}
