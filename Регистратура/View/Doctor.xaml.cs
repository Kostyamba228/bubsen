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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Регистратура.ViewModel;

namespace Регистратура.View
{
    public partial class Doctor : Page
    {
        public Frame frame;    //ссылка на фрейм
        Doctors sp;

        public Doctor(Frame fr,int sp_ID)
        {
            InitializeComponent();
            frame = fr;
            //DataContext = new Doctors(sp_ID);
            sp = new Doctors(sp_ID);
            DataContext = sp;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            frame.Content = new View.TimeTable(frame,sp.SelectDoctor.Doctor_ID);
        }
    }
}
