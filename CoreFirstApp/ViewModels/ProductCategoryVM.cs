using CoreFirstApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreFirstApp.ViewModels
{
    public class ProductCategoryVM
    {
        public IEnumerable<Product> products;
        public IEnumerable<Category> categories;
    }
}
