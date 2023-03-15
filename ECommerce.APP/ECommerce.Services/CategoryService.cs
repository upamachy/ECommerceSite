using ECommerce.Models.EntityModels;
using ECommerce.Repository;
using ECommerce.Repository.Abstraction;
using ECommerce.Services.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Services
{
    public class CategoryService:ICategoryService
    {
        ICategoryRepository _categoryRepository;
        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public bool Add(Catagory catagory)
        {
            // Logic for adding Category.. Logic can be anything
            if (string.IsNullOrEmpty(catagory.Name))
            {
                return false;
            }

            return _categoryRepository.Add(catagory);
        }

        public ICollection<Catagory> GetAll()
        {
            return _categoryRepository.GetAll();
        }

        public bool Update(Catagory catagory)
        {
            // Logic for updating Category.. Logic can be anything
            return _categoryRepository.Update(catagory);
        }

        public bool Remove(Catagory catagory)
        {
            // Logic for removing Category.. Logic can be anything
            return _categoryRepository.Remove(catagory);
        }

        public Catagory GetById(int id)
        {
            return _categoryRepository.GetById(id);
        }
    }
}
