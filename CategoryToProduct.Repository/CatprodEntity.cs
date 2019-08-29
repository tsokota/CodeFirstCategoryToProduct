namespace CategoryToProduct.Repository
{
    using CategoryToProduct.Repository.Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class CatprodEntity : DbContext
    {
        public CatprodEntity()
            : base("name=CatprodEntity")
        {
        }


        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Product> Products { get; set; }

        //public virtual DbSet<CategoryProduct>  CategoryProducts { get; set; }

    }
}