using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using Регистратура.Model;


namespace Регистратура.ViewModel
{
    class Lk : Base
    {
        ClinContext db;
        Report report;

        private List<Otchet> otchet;
        public List<Otchet> OOO
        {
            get { return otchet; }
            set { otchet = value; OnPropertyChanged("Otchet"); }
        }
        public DateTime date1 { get; set; } = DateTime.Now.Date;
        public DateTime date2 { get; set; } = DateTime.Now.AddMonths(1);

        int id;
        Patient pat;
        public Lk(int id)
        {
            this.id = id;
            db = new ClinContext();
            report = new Report();
            pat = db.Patient.Where(i => i.Patient_ID == id).FirstOrDefault();
            OOO = report.Find(date1.Date, date2.Date, id).ToList();
        }

        public string Fio
        {
            get { return pat.FIO; }
        }
        public string Adr
        {
            get { return pat.Adress; }
        }
        public int Polis
        {
            get { return pat.Policy; }
        }
        public string Date
        {
            get { return pat.Date_of_birthday.ToShortDateString(); }
        }
       /* public List otch
            {
            get { otchet = report.Find(date1.Date, date2.Date, id); }    //не работает гет. не выводит в грид отчет
            }*/

        public RelayCommand otch
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    
                    OOO = report.Find(date1.Date, date2.Date, id).ToList();
  
                });
            }
        }

    }
}
