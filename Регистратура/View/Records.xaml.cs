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
    /// Логика взаимодействия для Records.xaml
    /// </summary>
    public partial class Records : Page
    {
        public Frame frame;    //ссылка на фрейм
        ViewModel.Records rec;
        public Records(Frame fr,int doc_ID)
        {
            InitializeComponent();

            frame = fr;
            
            rec = new Регистратура.ViewModel.Records(doc_ID);
            DataContext = rec;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Login lg = new Login(rec.SelectedRecord.Record_ID);
            //frame.Content = Login(frame, rec.SelectedRecord);
        }
    }
}
