using CustomerPanel.Models;
using DAL.Entity;
using DAL.Operations;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;
using System.Linq;

namespace CustomerPanel.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            GenericRepository<Category> repository = new GenericRepository<Category>();

            var categories = repository.GetList();

            List<CategoryModel> categoryModel = categories.Select(i => new CategoryModel()
            {
                Id = i.Id,
                Name = i.Name,
                CreateDate= i.CreateDate,
                CreatorUserId= i.CreatorUserId,
                IsDeleted = i.IsDeleted,
                ParentCategoryId = i.ParentCategoryId
            }
            ).Where(x => x.IsDeleted == false).ToList();


            return View(categoryModel);
        }

        public JsonResult UpdateTable()
        {
            GenericRepository<Category> repository = new GenericRepository<Category>();

            var categories = repository.GetList();

            List<CategoryModel> categoryModel = categories.Select(i => new CategoryModel()
            {
                Id = i.Id,
                Name = i.Name,
                CreateDate = i.CreateDate,
                CreatorUserId = i.CreatorUserId,
                IsDeleted = i.IsDeleted,
                ParentCategoryId = i.ParentCategoryId
            }
            ).ToList();


            return Json(categoryModel);
        }

        public JsonResult GetCategoryById(int _id)
        {
            try
            {
                GenericRepository<Category> repository = new GenericRepository<Category>();
                var result = repository.GetItemById(_id);

                return Json(result);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public JsonResult CreateCategory(string _categoryName, int _parentCategoryId)
        {
            try
            {
                var category = new Category();
                category.Name = _categoryName;
                category.CreatorUserId = 1;
                category.ParentCategoryId = _parentCategoryId;
                category.CreateDate = DateTime.Now;
                category.IsDeleted = false;


                GenericRepository<Category> repository = new GenericRepository<Category>();
                var result = repository.Create(category);

                var categoryModel = new DAL.Models.CategoryModel()
                {
                    Id = result.Id,
                    Name = result.Name,
                    CreateDate = result.CreateDate,
                    CreatorUserId = result.CreatorUserId,
                    IsDeleted = result.IsDeleted,
                    ParentCategoryId = result.ParentCategoryId

                };


                return Json(categoryModel);
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        public JsonResult UpdateCategory(int _id, string _categoryName, int _creatorUserId, int _parentCategoryId)
        {
            try
            {
                GenericRepository<Category> repository = new GenericRepository<Category>();

                var getCat = repository.GetItemById(_id);

                var category = new Category();
                category.Id = _id;
                category.Name = _categoryName;
                category.CreatorUserId = _creatorUserId;
                category.ParentCategoryId = _parentCategoryId;
                category.CreateDate = getCat.CreateDate;
                category.IsDeleted = false;


                var result = repository.Update(category);

                var categoryModel = new DAL.Models.CategoryModel()
                {
                    Id = result.Id,
                    Name = result.Name,
                    CreateDate = result.CreateDate,
                    CreatorUserId = result.CreatorUserId,
                    IsDeleted = result.IsDeleted,
                    ParentCategoryId = result.ParentCategoryId
                };


                return Json(categoryModel);
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        public JsonResult DeleteCategory(int _id)
        {
            try
            {
                GenericRepository<Category> repository = new GenericRepository<Category>();

                var getCat = repository.GetItemById(_id);

                var category = new Category();
                category.Id = _id;
                category.Name = getCat.Name;
                category.CreatorUserId = getCat.CreatorUserId;
                category.ParentCategoryId = getCat.ParentCategoryId;
                category.CreateDate = getCat.CreateDate;
                category.IsDeleted = true;


                var result = repository.Update(category);

                var categoryModel = new DAL.Models.CategoryModel()
                {
                    Id = result.Id,
                    Name = result.Name,
                    CreateDate = result.CreateDate,
                    CreatorUserId = result.CreatorUserId,
                    IsDeleted = result.IsDeleted,
                    ParentCategoryId = result.ParentCategoryId
                };


                return Json(categoryModel);
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        //public JsonResult DeleteCategory(int _id)
        //{
        //    try
        //    {
        //        var category = new Category();
        //        category.Id = _id;
        //        //category.CreateDate = DateTime.Now;
        //        category.IsDeleted = true;

        //        GenericRepository<Category> repository = new GenericRepository<Category>();
        //        var result = repository.Update(category);

        //        var categoryModel = new DAL.Models.CategoryModel()
        //        {
        //            Id = result.Id,
        //            //Name = result.Name,
        //            //CreateDate = result.CreateDate,
        //            //CreatorUserId = result.CreatorUserId,
        //            IsDeleted = result.IsDeleted,
        //            //ParentCategoryId = result.ParentCategoryId
        //        };


        //        return Json(categoryModel);
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //}
    }
}
