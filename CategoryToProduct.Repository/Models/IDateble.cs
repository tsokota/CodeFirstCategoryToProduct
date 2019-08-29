using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CategoryToProduct.Repository.Models
{
    public interface IDateble
    {
        Nullable<DateTime> DelitingDate { get; set; }
    }
}
