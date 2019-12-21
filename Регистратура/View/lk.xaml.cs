using System;
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
using System.Windows.Shapes;
using Регистратура.ViewModel;

namespace Регистратура.View
{
    /// <summary>
    /// Логика взаимодействия для lk.xaml
    /// </summary>
    public partial class lk : Window
    {
        public Frame frame;    //ссылка на фрейм
        Lk sp;
        int id;
        public lk(int ID)
        {
            InitializeComponent();

            this.id = ID;
            sp = new Lk(id);
            DataContext = sp;
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}

