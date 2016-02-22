namespace MVCAngularFiltering.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ContextDB : DbContext
    {
        public ContextDB()
            : base("name=ContextDB")
        {
        }

        public virtual DbSet<EmployeeInfo_> EmployeeInfo_ { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EmployeeInfo_>()
                .Property(e => e.CustomerName)
                .IsUnicode(false);

            modelBuilder.Entity<EmployeeInfo_>()
                .Property(e => e.CustomerMobile)
                .IsUnicode(false);

            modelBuilder.Entity<EmployeeInfo_>()
                .Property(e => e.OrderedItem)
                .IsUnicode(false);

            modelBuilder.Entity<EmployeeInfo_>()
                .Property(e => e.SalesAgentName)
                .IsUnicode(false);
        }
    }
}
