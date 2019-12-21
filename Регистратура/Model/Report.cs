﻿using System;
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
        public DateTime date { get; set; }
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
            //var data = result.Select(i => new { i.Oblast, i.God, i.Projitoznmin }).ToList();
            return result;
        }
    }
}
