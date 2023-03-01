using System.Collections.Generic;

namespace ECommerce.Models.EntityModels
{
    public class Brand
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Item> items { get; set; }
    }
}
