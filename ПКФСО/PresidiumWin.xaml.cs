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
    /// Логика взаимодействия для PresidiumWin.xaml
    /// </summary>
    public partial class PresidiumWin : Window, INotifyPropertyChanged
    { 
    private Presidium selectedPresidium;

    public Presidium SelectedPresidium
        {
        get => selectedPresidium;
        set
        {
                selectedPresidium = value;
            Signal();
        }
    }

    public ObservableCollection<Presidium> Presidiums
        {
        get => DATA.Presidiums;
    }
    public PresidiumWin()
    {
        InitializeComponent();
        DataContext = this;
    }

    void Signal([CallerMemberName] string name = null)
    {
        PropertyChanged?.Invoke(this,
                  new PropertyChangedEventArgs(name));
    }
    public event PropertyChangedEventHandler PropertyChanged;

    private void AddPresidium(object sender, RoutedEventArgs e)
    {
            Presidiums.Add(new Presidium { FirstName = "Имя",
                Patronymic= "Отчество",
                LastName = "Фамилия"
            }) ;
    }

    private void DeletePresidium(object sender, RoutedEventArgs e)
    {
        if (SelectedPresidium == null)
            return;
        if (MessageBox.Show("Действительно удалить выбранного члена Президиума?",
            "Предупреждение", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
        {
                Presidiums.Remove(SelectedPresidium);
        }
    }
}
}
