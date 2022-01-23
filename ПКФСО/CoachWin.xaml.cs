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
    /// Логика взаимодействия для CoachWin.xaml
    /// </summary>
    public partial class CoachWin : Window, INotifyPropertyChanged
    {
        private Coach selectedCoach;

        public Coach SelectedCoach
        {
            get => selectedCoach;
            set
            {
                selectedCoach = value;
                Signal();
            }
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

        public CoachWin()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void AddCoach(object sender, RoutedEventArgs e)
        {
            Coachs.Add(new Coach { LastName = "Фамилия" });
        }

        private void DeleteCoach(object sender, RoutedEventArgs e)
        {
            if (SelectedCoach == null)
                return;
            if (MessageBox.Show("Действительно удалить выбранного спортсмена?",
                "Предупреждение", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                Coachs.Remove(SelectedCoach);
            }
        }
    }
}
