using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Data.Entities
{
    public partial class ProductModel : DbContext
    {
        public ProductModel()
            : base("name=ProductModel1")
        {
        }

        public virtual DbSet<abc> abcs { get; set; }
        public virtual DbSet<Cart> Carts { get; set; }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<OrderH> OrderHs { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Store> Stores { get; set; }
        public virtual DbSet<Login> Logins { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<abc>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<Cart>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<Company>()
                .Property(e => e.C_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Company>()
                .Property(e => e.M_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.F_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.L_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Dob)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Mobile)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Locations)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.Logins)
                .WithOptional(e => e.Customer)
                .HasForeignKey(e => e.C_Id);

            modelBuilder.Entity<OrderH>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.Color)
                .IsUnicode(false);

            modelBuilder.Entity<Store>()
                .Property(e => e.Locations)
                .IsUnicode(false);

            modelBuilder.Entity<Store>()
                .Property(e => e.S_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Login>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<Login>()
                .Property(e => e.Password)
                .IsUnicode(false);
        }
    }
}
