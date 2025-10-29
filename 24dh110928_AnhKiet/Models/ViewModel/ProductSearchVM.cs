using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _24dh110928_AnhKiet.Models.ViewModel
{
    public class ProductSearchVM
    {
        public int SearchTerm { get; set; }
        public List<Product> Products { get; set; }

    }
}