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
using System.Windows.Shapes;

namespace ПКФСО
{
    /// <summary>
    /// Логика взаимодействия для SportsmanWin.xaml
    /// </summary>
    public partial class SportsmanWin : Page, INotifyPropertyChanged
    {
        private Sportsman selectedSportsman;

        public Sportsman SelectedSportsman
        {
            get => selectedSportsman;
            set
            {
                selectedSportsman = value;
                Signal();
            }
        }

        public ObservableCollection<Sportsman> Sportsmans
        {
            get => DATA.Sportsmans;
        }

        public ObservableCollection<Coach> Coachs
        {
            get => DATA.Coachs;
        }

        void Signal([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this,
                      new PropertyChangedEventArgs(name));
        }
        public event PropertyChangedEventHandler PropertyChanged;

        public SportsmanWin()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void AddSportsman(object sender, RoutedEventArgs e)
        {
            Sportsmans.Add(new Sportsman { LastName = "Фамилия" });
        }

        private void DeleteSportsman(object sender, RoutedEventArgs e)
        {
            if (SelectedSportsman == null)
                return;
            if (MessageBox.Show("Действительно удалить выбранного спортсмена?",
                "Предупреждение", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                Sportsmans.Remove(SelectedSportsman);
            }

        }
    }
}
