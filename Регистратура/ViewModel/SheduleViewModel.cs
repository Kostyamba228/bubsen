using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Регистратура.Model;

namespace Регистратура.ViewModel
{
    public class SheduleViewModel : Base
    {
        TimeTable timetable;

        public SheduleViewModel(TimeTable tt)
        {
            timetable = tt;
        }

        public int TimeTable_ID
        {
            get { return timetable.TimeTable_ID; }
            set
            {
                timetable.TimeTable_ID = value;
                OnPropertyChanged("TimeTable_ID");
            }
        }

        public TimeSpan? Reception_start_time
        {
            get { return timetable.Reception_start_time; }
            set
            {
                timetable.Reception_start_time = value;
                OnPropertyChanged("Reception_start_time");
            }
        }

        public TimeSpan? Reception_end_time
        {
            get { return timetable.Reception_end_time; }
            set
            {
                timetable.Reception_end_time = value;
                OnPropertyChanged("Reception_end_time");
            }
        }

        public string Day
        {
            get { return timetable.Day_of_week.Named; }
        }
    }
}
