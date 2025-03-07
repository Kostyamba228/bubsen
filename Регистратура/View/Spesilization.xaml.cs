﻿using System;
using System.Collections.Generic;
using System.Linq;
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
using Регистратура.ViewModel;

namespace Регистратура.View
{
    /// <summary>
    /// Логика взаимодействия для Spesilization.xaml
    /// </summary>
    public partial class Spesilization : Page
    {
        Frame frame;    //ссылка на фрейм
        Spesializations sp;

        public Spesilization(Frame fr)
        {
            InitializeComponent();
            frame = fr;
            sp = new Spesializations();
            DataContext = sp;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            frame.Content = new View.Doctor(frame,sp.SelectSpesialities.Spesiality_ID);
        }
    }
}
