using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Регистратура.Model;

namespace Регистратура.ViewModel
{
    class Records: Base
    {
        ClinContext db;
        int Doctor_id;
        private List<Record> allrecord;
        public List<Record> Allrecord
        { get { return allrecord; }
            set { allrecord = value; OnPropertyChanged("Allrecord"); }
        }       //список докторов

        private DateTime date = /*new DateTime(2019,12,10); */ DateTime.Now;
        public Records(int Doctor_ID)
        {
            db = new ClinContext();
            Allrecord = db.Record.Where(i => i.Doctor_FK == Doctor_ID && i.Date == date.Date).ToList();
            Doctor_id = Doctor_ID;
        }

       // private DateTime date = /*new DateTime(2019,12,10); */ DateTime.Now;
        public DateTime Date
        {
            get { return date; }
            set { date = value; Allrecord = db.Record.Where(i => i.Doctor_FK == Doctor_id && i.Date == date.Date).ToList(); OnPropertyChanged("Date"); }
        }

        private Record selectedrecord;
        public Record SelectedRecord
        {
            get { return selectedrecord; }
            set { selectedrecord = value;
                OnPropertyChanged("SelectedRecord");
                    }
        }
    }
}
