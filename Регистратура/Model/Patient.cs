namespace Регистратура.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Patient")]
    public partial class Patient
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Patient()
        {
            Record = new HashSet<Record>();
        }

        [Key]
        public int Patient_ID { get; set; }

        [Required]
        [StringLength(100)]
        public string FIO { get; set; }

        [Required]
        [StringLength(100)]
        public string Adress { get; set; }

        public int Policy { get; set; }

        [Column(TypeName = "date")]
        public DateTime Date_of_birthday { get; set; }

        public int Area { get; set; }

        [Required]
        [StringLength(50)]
        public string Login { get; set; }

        [Required]
        [StringLength(50)]
        public string Password { get; set; }

        [Required]
        [StringLength(1)]
        public string Sex { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Record> Record { get; set; }
    }
}
