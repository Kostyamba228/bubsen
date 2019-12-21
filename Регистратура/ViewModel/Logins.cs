using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Регистратура.Model;

namespace Регистратура.ViewModel
{
    class Logins : Base
    {
        
        ClinContext db;
        Patient pat;
        public bool search=false;
        private string logins;
        private string password;
        public int rec;
        Record record;

        public Logins(int rec_id)
        {
            db = new ClinContext();
            rec = rec_id;
        }

        public string Loginss
        {
            get { return logins; }
            set { logins = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public RelayCommand SelectCommand
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    pat = db.Patient.Where(i => i.Login == logins && i.Password == password).FirstOrDefault();
                    if (pat != null)
                    {
                        record = db.Record.Where(i => i.Record_ID == rec).FirstOrDefault();
                        record.Patient_FK = pat.Patient_ID;
                        record.Status = true;
                        
                        db.SaveChanges();
                    }
                });
            }
        }

        public RelayCommand Login
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    pat = db.Patient.Where(i => i.Login == logins && i.Password == password).FirstOrDefault();
                    if (pat != null)
                    {
                        rec = pat.Patient_ID;
                        search = true;
                    }
                });
            }
        }

        //public bool serch
        //{
        //    get { return search; }
        //    set
        //    {
        //        pat = db.Patient.Where(i => i.Login == logins && i.Password == password).FirstOrDefault();
        //        if (pat != null)
        //        {
        //            search = true;
        //            record = db.Record.Where(i => i.Record_ID == rec).FirstOrDefault();
        //            record.Patient_FK = pat.Patient_ID;
        //            record.Status = true;
        //        }
        //    }
        //}




    }
}
