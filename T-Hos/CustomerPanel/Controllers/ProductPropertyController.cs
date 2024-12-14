using DAL.Operations;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;
using DAL.Entity;
using System.Linq;
using CustomerPanel.Models;

namespace CustomerPanel.Controllers
{
    public class ProductPropertyController : Controller
    {
        public IActionResult Index()
        {
            GenericRepository<ProductProperty> repository = new GenericRepository<ProductProperty>();
            GenericRepository<Product> repositorProduct = new GenericRepository<Product>();
            GenericRepository<Property> repositoryProperty = new GenericRepository<Property>();

            var productProperties = repository.GetList();
            var products = repositorProduct.GetList();
            var properties = repositoryProperty.GetList();

            List<ProductPropertyModel> productPropertiesModel = productProperties.Select(i => new ProductPropertyModel()
            {
                Id = i.Id,
                ProductId = i.ProductId,
                PropertyId = i.PropertyId,
            }
            ).ToList();

            productPropertiesModel.ForEach(delegate (ProductPropertyModel productProperties)
            {
                ProductModel productModel = new ProductModel();
                var category = repositorProduct.GetItemById(productProperties.ProductId);
                productModel.Name = category.Name;
                productModel.CreateDate = category.CreateDate;
                productModel.CreatorUserId = category.CreatorUserId;
                productModel.IsDeleted = category.IsDeleted;

                productProperties.Product = productModel;

            });

            productPropertiesModel.ForEach(delegate (ProductPropertyModel productProperties)
            {
                PropertyModel propertyModel = new PropertyModel();
                var property = repositoryProperty.GetItemById(productProperties.PropertyId);
                propertyModel.Key = property.Key;
                propertyModel.Value = property.Value;

                productProperties.Property = propertyModel;

            });

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

            List<PropertyModel> propertyModel = properties.Select(i => new PropertyModel()
            {
                Id = i.Id,
                Key = i.Key,
                Value = i.Value,
            }
            ).ToList();

            ProductPropertyViewModel productPropertiesViewModel =  new ProductPropertyViewModel()
            {
                ProductProperties = productPropertiesModel,
                Products = productModel,
                Properties = propertyModel,
            };


            return View(productPropertiesViewModel);
        }

        public JsonResult UpdateTable()
        {
            GenericRepository<ProductProperty> repository = new GenericRepository<ProductProperty>();
            GenericRepository<Product> repositorProduct = new GenericRepository<Product>();
            GenericRepository<Property> repositoryProperty = new GenericRepository<Property>();

            var productProperties = repository.GetList();
            var products = repositorProduct.GetList();
            var properties = repositoryProperty.GetList();

            List<ProductPropertyModel> productPropertiesModel = productProperties.Select(i => new ProductPropertyModel()
            {
                Id = i.Id,
                ProductId = i.ProductId,
                PropertyId = i.PropertyId,
            }
            ).ToList();

            productPropertiesModel.ForEach(delegate (ProductPropertyModel productProperties)
            {
                ProductModel productModel = new ProductModel();
                var category = repositorProduct.GetItemById(productProperties.ProductId);
                productModel.Name = category.Name;
                productModel.CreateDate = category.CreateDate;
                productModel.CreatorUserId = category.CreatorUserId;
                productModel.IsDeleted = category.IsDeleted;

                productProperties.Product = productModel;

            });

            productPropertiesModel.ForEach(delegate (ProductPropertyModel productProperties)
            {
                PropertyModel propertyModel = new PropertyModel();
                var property = repositoryProperty.GetItemById(productProperties.PropertyId);
                propertyModel.Key = property.Key;
                propertyModel.Value = property.Value;

                productProperties.Property = propertyModel;

            });

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

            List<PropertyModel> propertyModel = properties.Select(i => new PropertyModel()
            {
                Id = i.Id,
                Key = i.Key,
                Value = i.Value,
            }
            ).ToList();

            ProductPropertyViewModel productPropertiesViewModel = new ProductPropertyViewModel()
            {
                ProductProperties = productPropertiesModel,
                Products = productModel,
                Properties = propertyModel,
            };


            return Json(productPropertiesViewModel);
        }

        public JsonResult GetProductPropertyById(int _id)
        {
            try
            {
                GenericRepository<Property> repository = new GenericRepository<Property>();
                var result = repository.GetItemById(_id);

                return Json(result);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public JsonResult CreateProductProperty(int _productId, int _propertyId)
        {
            try
            {
                var property = new ProductProperty();
                property.ProductId = _productId;
                property.PropertyId = _propertyId;



                GenericRepository<ProductProperty> repository = new GenericRepository<ProductProperty>();
                var result = repository.Create(property);

                var propertyModel = new DAL.Models.ProductPropertyModel()
                {
                    Id = result.Id,
                    ProductId = result.ProductId,
                    PropertyId = result.PropertyId,
                };


                return Json(propertyModel);
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        public JsonResult UpdateProductProperty(int _id, int _productId, int _propertyId)
        {
            try
            {
                GenericRepository<ProductProperty> repository = new GenericRepository<ProductProperty>();

                var property = new ProductProperty();
                property.Id = _id;
                property.ProductId = _productId;
                property.PropertyId = _propertyId;

                var result = repository.Update(property);

                var propertyModel = new DAL.Models.ProductPropertyModel()
                {
                    Id = result.Id,
                    ProductId = result.ProductId,
                    PropertyId = result.PropertyId,
                };


                return Json(propertyModel);
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        public JsonResult DeleteProductProperty(int _id)
        {
            try
            {
                GenericRepository<ProductProperty> repository = new GenericRepository<ProductProperty>();

                bool isDeleted = repository.Delete(_id);

                return Json(isDeleted);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
