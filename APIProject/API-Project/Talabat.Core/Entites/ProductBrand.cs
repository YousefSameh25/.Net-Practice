using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Talabat.Core.Entites
{
    public class ProductBrand : BaseEntity
    {
        public string Name { get; set; }


        // I do not need the collection of products so we will not write it and we must configure the relationship using fluent API.

    }
}
