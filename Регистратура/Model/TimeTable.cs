namespace Регистратура.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TimeTable")]
    public partial class TimeTable
    {
        [Key]
        public int TimeTable_ID { get; set; }

        public TimeSpan? Reception_start_time { get; set; }

        public TimeSpan? Reception_end_time { get; set; }

        public int Day_FK { get; set; }

        public int Doctor_FK { get; set; }

        public virtual Day_of_week Day_of_week { get; set; }

        public virtual Doctor Doctor { get; set; }
    }
}
