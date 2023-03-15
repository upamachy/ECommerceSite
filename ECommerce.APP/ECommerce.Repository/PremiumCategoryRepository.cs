using ECommerce.Models.EntityModels;
using ECommerce.Repository.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Repository
{
    public class PremiumCategoryRepository : ICategoryRepository
    {
        public bool Add(Catagory catagory)
        {
            return true;
        }

        public ICollection<Catagory> GetAll()
        {
            return null;
        }

        public Catagory GetById(int id)
        {
            return null;
        }

        public bool Remove(Catagory catagory)
        {
            return true;
        }

        public bool Update(Catagory catagory)
        {
            return true;
        }
    }
}
