using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CategoryToProduct.Repository.Models
{
    public class Category : IDeletable, IDateble
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual List<Product> Products { get; set; }

        public virtual Category SubCategoryId { get; set; }

        public bool IsDelete { get; set; }

        public Nullable<DateTime> DelitingDate { get; set; }
    }
}
