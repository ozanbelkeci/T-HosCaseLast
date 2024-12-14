using DAL.Entity;
using DAL.Operations;
using CustomerPanel.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using System.Globalization;
using System.IO;
using System;

namespace CustomerPanel.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
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
                IsDeleted= i.IsDeleted,
                CreateDate= i.CreateDate,
                ImagePath= i.ImagePath,
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


            return View(productModel);
        }

        public JsonResult UpdateTable()
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

        public JsonResult GetProductById(int _id)
        {
            try
            {
                GenericRepository<Product> repository = new GenericRepository<Product>();
                var result = repository.GetItemById(_id);

                return Json(result);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public JsonResult CreateProduct(string _name, string _price, IFormFile _photo, int _categoryId)
        {
            try
            {
                double priceD = double.Parse(_price, CultureInfo.InvariantCulture);
                var product = new Product();
                if (_photo != null)
                {
                    var extension = Path.GetExtension(_photo.FileName);
                    var newImageName = Guid.NewGuid() + extension;
                    var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/productPhotos/", newImageName);
                    var stream = new FileStream(location, FileMode.Create);
                    _photo.CopyTo(stream);
                    product.ImagePath = newImageName;
                }

                product.Name = _name;
                product.CreateDate = DateTime.Now;
                product.Price = priceD;
                product.IsDeleted = false;
                product.CreatorUserId = 1;
                product.CategoryId = _categoryId;

                GenericRepository<Product> repository = new GenericRepository<Product>();
                var result = repository.Create(product);

                var productModel = new ProductModel()
                {
                    Id = result.Id,
                    Name = result.Name,
                    CreatorUserId = result.CreatorUserId,
                    Price = result.Price,
                    IsDeleted = result.IsDeleted,
                    CreateDate = result.CreateDate,
                    ImagePath = result.ImagePath,
                    CategoryId = result.CategoryId
                };

                return Json(productModel);
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        public JsonResult UpdateProduct(int _id, string _name, string _price, IFormFile _photo, int _categoryId)
        {
            try
            {
                double priceD = double.Parse(_price, CultureInfo.InvariantCulture);
                var product = new Product();
                if (_photo != null)
                {
                    var extension = Path.GetExtension(_photo.FileName);
                    var newImageName = Guid.NewGuid() + extension;
                    var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/productPhotos/", newImageName);
                    var stream = new FileStream(location, FileMode.Create);
                    _photo.CopyTo(stream);
                    product.ImagePath = newImageName;
                }

                product.Id = _id;
                product.Name = _name;
                product.CreateDate = DateTime.Now;
                product.Price = priceD;
                product.IsDeleted = false;
                product.CreatorUserId = 1;
                product.CategoryId = _categoryId;

                GenericRepository<Product> repository = new GenericRepository<Product>();
                var result = repository.Update(product);

                var productModel = new ProductModel()
                {
                    Id = result.Id,
                    Name = result.Name,
                    CreatorUserId = result.CreatorUserId,
                    Price = result.Price,
                    IsDeleted = result.IsDeleted,
                    CreateDate = result.CreateDate,
                    ImagePath = result.ImagePath,
                    CategoryId = result.CategoryId
                };

                return Json(productModel);
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        public JsonResult DeleteProduct(int _id)
        {
            try
            {
                GenericRepository<Product> repository = new GenericRepository<Product>();
                
                var product = new Product();

                var getProd = repository.GetItemById(_id);

                product.Id = _id;
                product.Name = getProd.Name;
                product.CreateDate = getProd.CreateDate;
                product.Price = getProd.Price;
                product.IsDeleted = true;
                product.CreatorUserId = getProd.CreatorUserId;
                product.CategoryId = getProd.CategoryId;

                var result = repository.Update(product);

                var productModel = new ProductModel()
                {
                    Id = result.Id,
                    Name = result.Name,
                    CreatorUserId = result.CreatorUserId,
                    Price = result.Price,
                    IsDeleted = result.IsDeleted,
                    CreateDate = result.CreateDate,
                    ImagePath = result.ImagePath,
                    CategoryId = result.CategoryId
                };

                return Json(productModel);
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        public JsonResult GetCategories()
        {
            try
            {
                GenericRepository<Category> repository = new GenericRepository<Category>();
                var result = repository.GetList();

                return Json(result);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
