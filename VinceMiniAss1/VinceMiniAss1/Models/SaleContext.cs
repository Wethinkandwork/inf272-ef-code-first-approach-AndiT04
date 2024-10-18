using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity;


namespace VinceMiniAss1.Models
{
    public class SaleContext : DbContext
    {
        public DbSet<Brand> Brands;
        public DbSet<Category> Categories;
        public DbSet<Product> Products;
        public DbSet<Staff> Staffs;
        public DbSet<Stock> Stocks;
        public DbSet<Store> Stores;

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingEntitySetNameConvention>();
        }

        public System.Data.Entity.DbSet<VinceMiniAss1.Models.Brand> Brand { get; set; }

        public System.Data.Entity.DbSet<VinceMiniAss1.Models.Category> Category { get; set; }

        public System.Data.Entity.DbSet<VinceMiniAss1.Models.Product> Product { get; set; }

        public System.Data.Entity.DbSet<VinceMiniAss1.Models.Staff> Staff { get; set; }

        public System.Data.Entity.DbSet<VinceMiniAss1.Models.Store> Store { get; set; }

        public System.Data.Entity.DbSet<VinceMiniAss1.Models.Stock> Stock { get; set; }
    }
}