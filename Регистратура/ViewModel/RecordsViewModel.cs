using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Регистратура.Model;

namespace Регистратура.ViewModel
{
    public class RecordsViewModel:Base
    {
        Record record;

        public RecordsViewModel(Record rec)
        {
            record = rec;
        }

        public int Record_ID
        {
            get { return record.Record_ID; }
            set
            {
                record.Record_ID = value;
                OnPropertyChanged("Record_ID");
            }
        }

        public DateTime Date
        {
            get { return record.Date; }
            set
            {
                record.Date = value;
                OnPropertyChanged("Date");
            }
        }

        public TimeSpan Time
        {
            get { return record.Time; }
            set
            {
                record.Time = value;
                OnPropertyChanged("Time");
            }
        }

        public bool Status
        {
            get { return record.Status; }
            set
            {
                record.Status = value;
                OnPropertyChanged("Status");
            }
        }

        public string Color
        {
            get
            {
                if (record.Status)
                    return "#FFFF0000";
                else return "#FF17A800";
            }
        }
        
    }
}
