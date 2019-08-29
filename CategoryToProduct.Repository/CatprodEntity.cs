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

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker
                .Entries<IDeletable>()
                .Where(e => e.State == System.Data.Entity.EntityState.Deleted))
            {
                entry.Entity.IsDelete = true;
                entry.State = System.Data.Entity.EntityState.Modified;
            }

            return base.SaveChanges();
        }

    }



}