using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerce.Models.EntityModels
{
    // This attribute is used for give another name to the table of the dataset instead of using the model name of the EFCore
    [Table("Products")]
    public class Item
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ManufactureDate { get; set; }
        public double price { get; set; }
        public Catagory catagory { get; set; }
        public int? CatagoryId { get; set; }
        public Brand brand { get; set; }
        public int? BrandId { get; set; }
    }

    // if we don't want to use any of prop of item class in the main table of the database named probuct. 
    //we can use [Not Mapped ] property before the property.
}
