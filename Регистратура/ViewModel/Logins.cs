﻿using System;
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
        bool search=false;
        private string logins;
        private string password;
        int rec;
        Record record;

        public Logins(int rec_id)
        {
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

        public bool serch
        {
            get { return search; }
            set
            {
                pat = db.Patient.Where(i => i.Login == logins && i.Password == password).FirstOrDefault();
                if (pat != null)
                {
                    search = true;
                    record = db.Record.Where(i => i.Record_ID == rec).FirstOrDefault();
                    record.Patient_FK = pat.Patient_ID;
                    record.Status = true;
                }
            }
        }

       


    }
}
