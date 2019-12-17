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
    public partial class Login : Window
    {
        Frame frame;
        int record;
        Logins log;


        public Login( int rec_id)
        {
            InitializeComponent();
            
            record = rec_id;
            //DataContext = new Doctors(sp_ID);
            log = new Logins( record);
            
            DataContext = log;
        }

        public Login()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //this.DialogResult = true;
            this.Close();
            
        }

        public string Identification
        {
            get;
        }
    }
}
