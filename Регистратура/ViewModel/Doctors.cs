using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Регистратура.Model;

namespace Регистратура.ViewModel
{
    public class Doctors : Base
    {
        ClinContext db;
        public List<Doctor> Alldoctor { get; set; }       //список докторов

        public Doctors(int Special_ID)
        {
            db = new ClinContext();
            Alldoctor = db.Doctor.Where(i => i.Speciality_FK == Special_ID).ToList();
        }

        private Doctor selectDoctor;      //Выбранный доктор
        public Doctor SelectDoctor
        {
            get
            {
                return selectDoctor;
            }
            set
            {
                selectDoctor = value;
                OnPropertyChanged("SelectDoctor");
            }
        }

        private RelayCommand selectCommand;
        public RelayCommand SelectCommand
        {
            get
            {
                return selectCommand ??
                  (selectCommand = new RelayCommand(obj => { },
                 (obj) => (selectDoctor != null)));    //условие, при котором будет доступна команда
            }
        }
    }
}
