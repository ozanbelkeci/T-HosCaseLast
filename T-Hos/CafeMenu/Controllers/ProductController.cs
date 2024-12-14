using CafeMenu.Models;
using DAL.Entity;
using DAL.Operations;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CafeMenu.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            GenericRepository<Product> repository = new GenericRepository<Product>();

            return View();
        }
        public JsonResult GetProducts()
        {
            try
            {
                GenericRepository<Product> repository = new GenericRepository<Product>();
                GenericRepository<Category> categoryRepo = new GenericRepository<Category>();

                var products = repository.GetList();

                List<ProductModel> productModel = products.Select(i => new ProductModel()
                {
                    Id = i.Id,
                    Name = i.Name,
                    CreatorUserId = i.CreatorUserId,
                    Price = i.Price,
                    IsDeleted = i.IsDeleted,
                    CreateDate = i.CreateDate,
                    ImagePath = i.ImagePath,
                    CategoryId = i.CategoryId
                }).ToList();

                productModel.ForEach(delegate (ProductModel product)
                {
                    CategoryModel categoryModel = new CategoryModel();
                    var category = categoryRepo.GetItemById(product.CategoryId);
                    categoryModel.Name = category.Name;
                    categoryModel.CreateDate = category.CreateDate;
                    categoryModel.ParentCategoryId = category.ParentCategoryId;
                    categoryModel.CreatorUserId = category.CreatorUserId;
                    categoryModel.IsDeleted = category.IsDeleted;

                    product.Category = categoryModel;

                });


                return Json(productModel);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
