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
    /// <summary>
    /// Логика взаимодействия для TimeTable.xaml
    /// </summary>
    public partial class TimeTable : Page
    {
        Frame frame;
        TimeTables sp;
        int doc_ID;
        public TimeTable(Frame fr, int doc_ID)
        {
            InitializeComponent();
            frame = fr;
            this.doc_ID = doc_ID;
            sp = new TimeTables(doc_ID);
            DataContext = sp;
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)   //записаться
        {
            frame.Content = new View.Records(frame,doc_ID);
        }

        private void Button1_Click(object sender, RoutedEventArgs e)  //домо1
        {
            frame.Content = new View.Spesilization(frame);
        }
    }
}
