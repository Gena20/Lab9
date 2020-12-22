namespace Lab9.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<cars> cars { get; set; }
        public virtual DbSet<objects> objects { get; set; }
        public virtual DbSet<trips> trips { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<cars>()
                .HasMany(e => e.trips)
                .WithRequired(e => e.cars)
                .HasForeignKey(e => e.car_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<objects>()
                .HasMany(e => e.trips)
                .WithRequired(e => e.objects)
                .HasForeignKey(e => e.object_form_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<objects>()
                .HasMany(e => e.trips1)
                .WithRequired(e => e.objects1)
                .HasForeignKey(e => e.object_to_id)
                .WillCascadeOnDelete(false);
        }
    }
}
