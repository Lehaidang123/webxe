using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DCXEMAY.Models
{
    public partial class Model1 : DbContext
    {

        public Model1()
            : base("name=Model1")
        {
        }
        public DbSet<sanpham> sanphams { get; set; }
        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
       

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<sanpham>()
                .Property(e => e.id)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
