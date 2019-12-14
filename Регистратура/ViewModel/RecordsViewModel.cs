using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Регистратура.Model;

namespace Регистратура.ViewModel
{
    class RecordsViewModel:Base
    {
        Record record;

        public RecordsViewModel(Record rec)
        {
            record = rec;
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
    }
}
