namespace Регистратура.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Record")]
    public partial class Record
    {
        [Key]
        public int Record_ID { get; set; }

        [Column(TypeName = "date")]
        public DateTime Date { get; set; }

        public TimeSpan Time { get; set; }

        public bool Status { get; set; }

        public int? Patient_FK { get; set; }

        public int Doctor_FK { get; set; }

        public int Registrar_FK { get; set; }

        public virtual Doctor Doctor { get; set; }

        public virtual Patient Patient { get; set; }

        public virtual Registrar Registrar { get; set; }
    }
}
