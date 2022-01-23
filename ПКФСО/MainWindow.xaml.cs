﻿using System;
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
    public partial class MainWindow : Window
    {
       
        private void OpenPresidium(object sender, RoutedEventArgs e)
        {
            PresidiumWin win = new PresidiumWin();
            win.ShowDialog();

        }

        private void OpenSportsman(object sender, RoutedEventArgs e)
        {
            SportsmanWin win = new SportsmanWin();
            win.ShowDialog();
        }

        private void OpenCoach(object sender, RoutedEventArgs e)
        {
            CoachWin win = new CoachWin();
            win.ShowDialog();

        }
    }
}
