using DAL.Entity;
using DAL.Operations;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;
using CustomerPanel.Models;
using System.Linq;

namespace CustomerPanel.Controllers
{
    public class PropertyController : Controller
    {
        public IActionResult Index()
        {
            GenericRepository<Property> repository = new GenericRepository<Property>();

            var properties = repository.GetList();

            List<PropertyModel> propertyModel = properties.Select(i => new PropertyModel()
            {
                Id = i.Id,
                Key = i.Key,
                Value= i.Value,
            }
            ).ToList();


            return View(propertyModel);
        }

        public JsonResult UpdateTable()
        {
            GenericRepository<Property> repository = new GenericRepository<Property>();

            var properties = repository.GetList();

            List<PropertyModel> propertyModel = properties.Select(i => new PropertyModel()
            {
                Id = i.Id,
                Key = i.Key,
                Value = i.Value,
            }
            ).ToList();


            return Json(propertyModel);
        }

        public JsonResult GetPropertyById(int _id)
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

        public JsonResult CreateProperty(string _key, string _value)
        {
            try
            {
                var property = new Property();
                property.Key = _key;
                property.Value = _value;
                


                GenericRepository<Property> repository = new GenericRepository<Property>();
                var result = repository.Create(property);

                var propertyModel = new DAL.Models.PropertyModel()
                {
                    Id = result.Id,
                    Key = result.Key,
                    Value= result.Value,
                };


                return Json(propertyModel);
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        public JsonResult UpdateProperty(int _id, string _key, string _value)
        {
            try
            {
                GenericRepository<Property> repository = new GenericRepository<Property>();

                var property = new Property();
                property.Id = _id;
                property.Key= _key;
                property.Value = _value;

                var result = repository.Update(property);

                var propertyModel = new DAL.Models.PropertyModel()
                {
                    Id = result.Id,
                    Key= result.Key,
                    Value= result.Value,
                };


                return Json(propertyModel);
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        public JsonResult DeleteProperty(int _id)
        {
            try
            {
                GenericRepository<Property> repository = new GenericRepository<Property>();

                bool isDeleted = repository.Delete(_id);

                return Json(isDeleted);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        //public JsonResult DeleteCategory(int _id)
        //{
        //    try
        //    {
        //        GenericRepository<Category> repository = new GenericRepository<Category>();

        //        var getCat = repository.GetItemById(_id);

        //        var category = new Category();
        //        category.Id = _id;
        //        category.Name = getCat.Name;
        //        category.CreatorUserId = getCat.CreatorUserId;
        //        category.ParentCategoryId = getCat.ParentCategoryId;
        //        category.CreateDate = getCat.CreateDate;
        //        category.IsDeleted = true;


        //        var result = repository.Update(category);

        //        var categoryModel = new DAL.Models.CategoryModel()
        //        {
        //            Id = result.Id,
        //            Name = result.Name,
        //            CreateDate = result.CreateDate,
        //            CreatorUserId = result.CreatorUserId,
        //            IsDeleted = result.IsDeleted,
        //            ParentCategoryId = result.ParentCategoryId
        //        };


        //        return Json(categoryModel);
        //    }
        //    catch (Exception exc)
        //    {
        //        throw exc;
        //    }
        //}
    }
}
