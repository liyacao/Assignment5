namespace Assignment5
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DBModel : DbContext
    {
        public DBModel()
            : base("name=DBModel")
        {
        }

        public virtual DbSet<orders> orders { get; set; }
        public virtual DbSet<products> products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<products>()
                .Property(e => e.cost)
                .HasPrecision(19, 4);
        }
    }
}
