using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace EF_CODEFIRST.Models
{
    public class CompanyDBContext:DbContext
    {

        public CompanyDBContext() : base("MyConnection")
        {
        }
        public DbSet<Brand> Brands { set; get; }
        public DbSet<Category> Categories { set; get; }
        public DbSet<Product> Products { set; get; }

    }
}