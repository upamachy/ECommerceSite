using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.APP.Models.CategoryModel
{
    public class CategoryEditVM
    {
        public int Id { get; set; }

        [Required]
        public String Name { get; set; }
        public string Code { get; set; }
    }
}
