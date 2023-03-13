using ECommerce.Models.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.APP.Models.CategoryModel
{
    public class CategoryListVM
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public List<Catagory> CategoryList { get; set; }
    }
}
