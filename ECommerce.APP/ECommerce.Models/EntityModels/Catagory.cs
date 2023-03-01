using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ECommerce.Models.EntityModels
{
    public class Catagory
    {
        public int Id { get; set; }

        [StringLength(250)]
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Item> Items { get; set; }
        public string Code { get; set; }
    }
}
