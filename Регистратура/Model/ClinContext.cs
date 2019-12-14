namespace Регистратура.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ClinContext : DbContext
    {
        public ClinContext()
            : base("name=ClinContext")
        {
        }

        public virtual DbSet<Day_of_week> Day_of_week { get; set; }
        public virtual DbSet<Doctor> Doctor { get; set; }
        public virtual DbSet<Patient> Patient { get; set; }
        public virtual DbSet<Record> Record { get; set; }
        public virtual DbSet<Registrar> Registrar { get; set; }
        public virtual DbSet<Spesiality> Spesiality { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<TimeTable> TimeTable { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Day_of_week>()
                .Property(e => e.Named)
                .IsUnicode(false);

            modelBuilder.Entity<Day_of_week>()
                .HasMany(e => e.TimeTable)
                .WithRequired(e => e.Day_of_week)
                .HasForeignKey(e => e.Day_FK)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Doctor>()
                .Property(e => e.FIO)
                .IsUnicode(false);

            modelBuilder.Entity<Doctor>()
                .Property(e => e.Login)
                .IsUnicode(false);

            modelBuilder.Entity<Doctor>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Doctor>()
                .HasMany(e => e.Record)
                .WithRequired(e => e.Doctor)
                .HasForeignKey(e => e.Doctor_FK)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Doctor>()
                .HasMany(e => e.TimeTable)
                .WithRequired(e => e.Doctor)
                .HasForeignKey(e => e.Doctor_FK)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Patient>()
                .Property(e => e.FIO)
                .IsUnicode(false);

            modelBuilder.Entity<Patient>()
                .Property(e => e.Adress)
                .IsUnicode(false);

            modelBuilder.Entity<Patient>()
                .Property(e => e.Login)
                .IsUnicode(false);

            modelBuilder.Entity<Patient>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Patient>()
                .Property(e => e.Sex)
                .IsUnicode(false);

            modelBuilder.Entity<Patient>()
                .HasMany(e => e.Record)
                .WithOptional(e => e.Patient)
                .HasForeignKey(e => e.Patient_FK);

            modelBuilder.Entity<Registrar>()
                .Property(e => e.FIO)
                .IsUnicode(false);

            modelBuilder.Entity<Registrar>()
                .Property(e => e.Login)
                .IsUnicode(false);

            modelBuilder.Entity<Registrar>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Registrar>()
                .HasMany(e => e.Record)
                .WithRequired(e => e.Registrar)
                .HasForeignKey(e => e.Registrar_FK)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Spesiality>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Spesiality>()
                .HasMany(e => e.Doctor)
                .WithRequired(e => e.Spesiality)
                .HasForeignKey(e => e.Speciality_FK)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Status>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Status>()
                .HasMany(e => e.Doctor)
                .WithRequired(e => e.Status)
                .HasForeignKey(e => e.Status_FK)
                .WillCascadeOnDelete(false);
        }
    }
}
