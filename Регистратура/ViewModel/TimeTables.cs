using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Регистратура.Model;

namespace Регистратура.ViewModel
{
   
    class TimeTables : Base
    {
        ClinContext db;
        public List<SheduleViewModel> AllTimeTable { get; set; }

        public TimeTables(int doc_ID)
        {
            db = new ClinContext();
            AllTimeTable = db.TimeTable.Where(i => i.Doctor_FK == doc_ID).ToList().Select(i=> new SheduleViewModel(i)).ToList();
        }

        //private void Update(переменные которые нкжно передать)
        //{
        //    AllTimeTable = db.TimeTable.Where(i => i.Doctor_FK == doc_ID && i.Doctor_FK == doc_ID).ToList();
        //    AllTimeTable = AllTimeTable;
        //}
    }
}
