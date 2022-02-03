using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ПКФСО
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private Page currentPage;
        
        public Page CurrentPage
        {
            get => currentPage;
            set
            {
                currentPage = value;
                Signal();
            }
        }

        
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            CurrentPage = new PresidiumWin();
        }

        void Signal([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this,
                      new PropertyChangedEventArgs(name));
        }
        public event PropertyChangedEventHandler PropertyChanged;


        private void OpenPresidium(object sender, RoutedEventArgs e)
        {
            CurrentPage = new PresidiumWin();

        }

        private void OpenSportsman(object sender, RoutedEventArgs e)
        {
            CurrentPage = new SportsmanWin();
        }

        private void OpenCoach(object sender, RoutedEventArgs e)
        {
            CurrentPage = new CoachWin();
            

        }

    }
}
