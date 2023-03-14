using ECommerce.Database.DbContexts;
using ECommerce.Models.EntityModels;
using ECommerce.Repository.Abstraction;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace ECommerce.Repository
{
    public class CategoryRepository:ICategoryRepository
    {
        SMEDBContext db;

        public CategoryRepository()
        {
            db = new SMEDBContext();
        }

        public Catagory GetById(int id)
        {
            return db.Catagories.FirstOrDefault(c => c.Id == id);
        }

        public ICollection<Catagory> GetAll()
        {
            return db.Catagories.Include(c => c.Items).ToList();
        }

        public bool Add(Catagory catagory)
        {
            db.Catagories.Add(catagory);
            int successCount = db.SaveChanges();
            return successCount > 0;
        }

        public bool Update(Catagory catagory)
        {
            db.Catagories.Update(catagory);
            return db.SaveChanges() > 0;
        }

        public bool Remove(Catagory catagory)
        {
            db.Catagories.Remove(catagory);
            return db.SaveChanges() > 0;
        }
    }
}
