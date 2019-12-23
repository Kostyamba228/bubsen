using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Регистратура.Model
{
    public class Otchet
    {
        public string sp { get; set; }
        public string doctor { get; set; }
        private DateTime Date;
        public DateTime date { get {return Date.Date; } set {Date = value;} }
        public TimeSpan time { get; set; }
        public int kabinet { get; set; }
    }

    public class Report
    {
        private ClinContext db;

        public List<Otchet> Find(DateTime date1, DateTime date2, int pat_ID)
        {
            db = new ClinContext();

            SqlParameter value1 = new SqlParameter("@date1", date1);
            SqlParameter value2 = new SqlParameter("@date2", date2);
            SqlParameter value3 = new SqlParameter("@ID", pat_ID);
            var result = db.Database.SqlQuery<Otchet>("Report @date1,@date2,@ID", new object[] { value1, value2, value3 }).ToList();
            var data = result.Select(i => new Otchet
            {
                sp = i.sp,
                doctor = i.doctor,
                date = i.date,
                time=i.time,
                kabinet=i.kabinet,
            }).ToList();
            return data;
        }
    }
}
