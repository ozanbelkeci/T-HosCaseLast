using CafeMenu.Models;
using DAL.Entity;
using DAL.Operations;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;

namespace CafeMenu.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

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

            var xmlIns = CurrOperations.GetInstance();
            var xml = xmlIns.GetCurr();
            string USD = xml.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerXml.Replace(".",",");
            string EUR = xml.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerXml.Replace(".", ",");
            string GBP = xml.SelectSingleNode("Tarih_Date/Currency[@Kod='GBP']/BanknoteSelling").InnerXml.Replace(".", ",");

            var usdPrice = Convert.ToDouble(USD);

            List<ProductModel> productModel = products.Select(i => new ProductModel()
            {
                Id = i.Id,
                Name = i.Name,
                CreatorUserId = i.CreatorUserId,
                Price = Math.Round(i.Price, 2),
                UsdPrice = Math.Round(i.Price / Convert.ToDouble(USD), 2),
                EurPrice = Math.Round(i.Price / Convert.ToDouble(EUR), 2),
                GbpPrice = Math.Round(i.Price / Convert.ToDouble(GBP), 2),
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

            ProductViewModel productPropertiesViewModel = new ProductViewModel()
            {
                ProductProperties = productPropertiesModel,
                Products = productModel,
                Properties = propertyModel,
            };

            return View(productPropertiesViewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public JsonResult GetCurrencyInfo()
        {
            //string url = "https://www.tcmb.gov.tr/kurlar/today.xml";
            //var xml = new XmlDocument();
            //xml.Load(url);
            var xmlIns = CurrOperations.GetInstance();
            var xml = xmlIns.GetCurr();
            string USD = xml.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerXml;
            string EUR = xml.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerXml;
            string GBP = xml.SelectSingleNode("Tarih_Date/Currency[@Kod='GBP']/BanknoteSelling").InnerXml;
            return Json(new { usd = USD, eur = EUR, gbp = GBP });
        }

        public JsonResult GetProducts()
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
            var xmlIns = CurrOperations.GetInstance();
            var xml = xmlIns.GetCurr();
            string USD = xml.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerXml;
            string EUR = xml.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerXml;
            string GBP = xml.SelectSingleNode("Tarih_Date/Currency[@Kod='GBP']/BanknoteSelling").InnerXml;
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
                UsdPrice = i.Price / Convert.ToDouble(USD),
                EurPrice = i.Price / Convert.ToDouble(EUR),
                GbpPrice = i.Price / Convert.ToDouble(GBP),
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

            ProductViewModel productPropertiesViewModel = new ProductViewModel()
            {
                ProductProperties = productPropertiesModel,
                Products = productModel,
                Properties = propertyModel,
            };

            return Json(productPropertiesViewModel);
        }
    }
}
