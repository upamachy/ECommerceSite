using ECommerce.Database.DbContexts;
using ECommerce.Models.EntityModels;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace ECommerce.Repository
{
    public class BrandRepository
    {
        SMEDBContext db;
        public BrandRepository()
        {
            db = new SMEDBContext();
        }

        public Brand GetById(int id)
        {
            return db.Brands.FirstOrDefault(c => c.Id == id);
        }

        public ICollection<Brand> GetAll()
        {
            return db.Brands.Include(c => c.items).ToList();
        }

        public bool Add(Brand brand)
        {
            db.Brands.Add(brand);
            int successCount = db.SaveChanges();
            return successCount > 0;
        }

        public bool Update(Brand brand)
        {
            db.Brands.Update(brand);
            return db.SaveChanges() > 0;
        }

        public bool Remove(Brand brand)
        {
            db.Brands.Remove(brand);
            return db.SaveChanges() > 0;
        }
    }
}
