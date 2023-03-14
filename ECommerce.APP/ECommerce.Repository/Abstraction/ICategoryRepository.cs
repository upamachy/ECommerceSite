using ECommerce.Models.EntityModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Repository.Abstraction
{
     public interface ICategoryRepository
    {
        public bool Add(Catagory catagory);
        public ICollection<Catagory> GetAll();
        public bool Update(Catagory catagory);
        public bool Remove(Catagory catagory);
        public Catagory GetById(int id);
    }
}
