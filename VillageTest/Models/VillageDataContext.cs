using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace VillageTest.Models
{
    public partial class VillageDataContext : DbContext
    {
        public VillageDataContext()
            : base("name=VillageDataContext")
        {
        }

        public DbSet<Resident> residents { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
