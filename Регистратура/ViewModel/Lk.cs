using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Регистратура.Model;


namespace Регистратура.ViewModel
{
    class Lk : Base
    {
        ClinContext db;
        int id;
        Patient pat;
        public Lk (int id)
        {
            this.id = id;
            db = new ClinContext();
            pat = db.Patient.Where(i => i.Patient_ID == id).FirstOrDefault();
        }

        string Fio
        {
            get { return pat.FIO; }            
        }
        string Adr
        {
            get { return pat.Adress; }         
        }
        int Polis
        {
            get { return pat.Policy; }
        }
        string Date
        {
            get { return pat.Date_of_birthday.ToShortDateString(); }
        }
    }
}
