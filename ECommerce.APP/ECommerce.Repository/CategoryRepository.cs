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
        SMEDBContext _db;

        public CategoryRepository(SMEDBContext db)
        {
            _db = db;
        }

        public Catagory GetById(int id)
        {
            return _db.Catagories.FirstOrDefault(c => c.Id == id);
        }

        public ICollection<Catagory> GetAll()
        {
            return _db.Catagories.Include(c => c.Items).ToList();
        }

        public bool Add(Catagory catagory)
        {
            _db.Catagories.Add(catagory);
            int successCount = _db.SaveChanges();
            return successCount > 0;
        }

        public bool Update(Catagory catagory)
        {
            _db.Catagories.Update(catagory);
            return _db.SaveChanges() > 0;
        }

        public bool Remove(Catagory catagory)
        {
            _db.Catagories.Remove(catagory);
            return _db.SaveChanges() > 0;
        }
    }
}
