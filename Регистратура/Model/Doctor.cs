namespace Регистратура.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Doctor")]
    public partial class Doctor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Doctor()
        {
            Record = new HashSet<Record>();
            TimeTable = new HashSet<TimeTable>();
        }

        [Key]
        public int Doctor_ID { get; set; }

        [Required]
        [StringLength(100)]
        public string FIO { get; set; }

        [Column("Begining_date_of work", TypeName = "date")]
        public DateTime Begining_date_of_work { get; set; }

        public int? Area { get; set; }

        public int Parlor { get; set; }

        [Required]
        [StringLength(50)]
        public string Login { get; set; }

        [Required]
        [StringLength(50)]
        public string Password { get; set; }

        public int Speciality_FK { get; set; }

        public int Status_FK { get; set; }

        public virtual Spesiality Spesiality { get; set; }

        public virtual Status Status { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Record> Record { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TimeTable> TimeTable { get; set; }
    }
}
