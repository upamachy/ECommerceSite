using ECommerce.APP.Models.CategoryModel;
using ECommerce.Models.EntityModels;
using ECommerce.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.APP.Controllers
{
    public class CategoryController : Controller
    {
        public string Index()
        {
            return "This is the default method";
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CategoryCreate model)
        {
            CategoryRepository categoryRepository = new CategoryRepository();
            if (model.Name!=null)
            {
                var category = new Catagory()
                { 
                    Name=model.Name,
                    Code=model.Code
                };

                var isAdded=categoryRepository.Add(category);

                if (isAdded)
                {
                    return View("Success");
                }
            }
           
            return View();
        }

        public string CategoryListCreated(CategoryCreate[] categories)
        {
            string data = "Category list created" + Environment.NewLine;
            if(categories!=null && categories.Any())
            {
                foreach (var category in categories)
                {
                    data += $"Category Created : {category.Name} Code : {category.Code}";
                }
            }
            return data;
        }
    }
}
