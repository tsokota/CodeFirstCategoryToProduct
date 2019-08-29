using CategoryToProduct.Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CategoryToProduct.Repository.Repositories
{
    public interface IProductCategoriesRepository
    {
        List<ProductCategories> GetList();
    }
    public class ProductCategoriesRepository : IProductCategoriesRepository
    {
        public List<ProductCategories> GetList()
        {
            List<ProductCategories> productCategories = new List<ProductCategories>();

            using (var ctx = new CatprodEntity())
            {
                var dt = ctx.Products.ToList();

                dt.ForEach((x) =>
                {
                    productCategories.Add(new ProductCategories {
                        Id = x.Id,
                        ProductName = x.Name,
                        CategoryNames = string.Join(", ", x.Categories.Select((y) => y.Name))});
                });
            }

            return productCategories;
        }

    }
}
