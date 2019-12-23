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
    /// Логика взаимодействия для Login.xaml
    /// </summary>
    public partial class Login1 : Window
    {
        Frame frame;
        int record;
        Logins log;
        ViewModel.Records rec;

        public Login1(Frame frame )
        {
            InitializeComponent();
            rec = null;
            this.frame = frame;
            //DataContext = new Doctors(sp_ID);
            log = new Logins( record, rec);
            
            DataContext = log;
        }

       

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //this.DialogResult = true;
            record = log.rec;
            if (log.search == true)
            {
                lk lk = new View.lk(record);
                this.Close();
                lk.ShowDialog();
            }
            
        }

        public string Identification
        {
            get;
        }
    }
}
