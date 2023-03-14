using ECommerce.APP.Models.CategoryModel;
using ECommerce.Models.EntityModels;
using ECommerce.Repository;
using ECommerce.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.APP.Controllers
{
    public class CategoryController : Controller
    {
        CategoryService _categoryService;
        public CategoryController()
        {
            _categoryService = new CategoryService();
        }
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
            
            if (model.Name!=null)
            {
                var category = new Catagory()
                { 
                    Name=model.Name,
                    Code=model.Code
                };

                var isAdded=_categoryService.Add(category);

                if (isAdded)
                {
                    return RedirectToAction("List");
                }
            }
           
            return View();
        }

        public IActionResult List()
        {
            var categoryList=_categoryService.GetAll();

            //loosely tied approach
            //ViewBag.CategoryList = categoryList;

            //ViewData["CategoryList"] = categoryList;

            //after creating CategoryListVM . we don't need viewData because now we have a precise model for display category list
            CategoryListVM categoryListVM = new CategoryListVM()
            {
                Title = "Category Overview",
                Description = "You can manage Category From this page.you can create, update and delete categories....",
                CategoryList = categoryList.ToList()
            };

            return View(categoryListVM);
        }

        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("List");
            }
            var category = _categoryService.GetById((int)id);
            if (category == null)
            {
                return RedirectToAction("List");
            }
            var categoryEditVM = new CategoryEditVM()
            {
                Id = category.Id,
                Name = category.Name,
                Code = category.Code
            };
            return View(categoryEditVM);
        }

        [HttpPost]
        public IActionResult Edit(CategoryEditVM categoryEditVM)
        {
            if (ModelState.IsValid)
            {
                var category = new Catagory()
                {
                    Id = categoryEditVM.Id,
                    Name = categoryEditVM.Name,
                    Code = categoryEditVM.Code
                };

                bool isUpdated = _categoryService.Update(category);
                if (isUpdated)
                {
                    return RedirectToAction("List");
                }
            }
            return View();
        }
        
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("List");
            }
            var category = _categoryService.GetById((int)id);
            if (category == null)
            {
                return RedirectToAction("List");
            }

            bool isRemoved= _categoryService.Remove(category);

            if (isRemoved)
            {
                return RedirectToAction("List");
            }

            return RedirectToAction("List");

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
