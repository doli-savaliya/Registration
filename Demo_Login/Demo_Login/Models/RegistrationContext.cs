namespace Demo_Login.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class RegistrationContext : DbContext
    {
        public RegistrationContext()
            : base("name=RegistrationContext")
        {
        }

        public virtual DbSet<Registration_Master> Registration_Master { get; set; }
        public virtual DbSet<Role_Master> Role_Master { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
