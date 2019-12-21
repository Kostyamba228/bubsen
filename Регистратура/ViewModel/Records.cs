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
        private List<RecordsViewModel> allrecord;
        public List<RecordsViewModel> Allrecord
        {   get { return allrecord; }
            set { allrecord = value; OnPropertyChanged("Allrecord"); }
        }       //список докторов

        private DateTime date = /*new DateTime(2019,12,10); */ DateTime.Now;
        public Records(int Doctor_ID)
        {
            db = new ClinContext();
            Allrecord = db.Record.Where(i => i.Doctor_FK == Doctor_ID && i.Date == date.Date).ToList().Select(i => new RecordsViewModel(i)).ToList();
            Doctor_id = Doctor_ID;
        }

       // private DateTime date = /*new DateTime(2019,12,10); */ DateTime.Now;
        public DateTime Date
        { 
            get { return date; }
            set { date = value; Allrecord = db.Record.Where(i => i.Doctor_FK == Doctor_id && i.Date == date.Date).ToList().Select(i => new RecordsViewModel(i)).ToList(); ; OnPropertyChanged("Date"); }
        }

        private RecordsViewModel selectedrecord;
        public RecordsViewModel SelectedRecord
        {
            get { return selectedrecord; }
            set
            {
                    selectedrecord = value;
                   
            }
        }

        private RelayCommand selectCommand;
        public RelayCommand SelectCommand
        {
            get
            {
                return selectCommand ??
                  (selectCommand = new RelayCommand(obj => { },
                 (obj) => (selectedrecord != null && selectedrecord.Status == false)));    //условие, при котором будет доступна команда
            }
        }
    }
}
