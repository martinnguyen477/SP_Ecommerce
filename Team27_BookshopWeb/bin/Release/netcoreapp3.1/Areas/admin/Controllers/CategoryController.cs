using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Team27_BookshopWeb.Areas.admin.Models;
using Team27_BookshopWeb.Entities;
using Team27_BookshopWeb.Extensions;
using Team27_BookshopWeb.Models;
using Team27_BookshopWeb.Services;

namespace Team27_BookshopWeb.Areas.admin.Controllers
{
    [Area("admin")]
    [Authorize(AuthenticationSchemes = "admin")]
    public class CategoryController : Controller
    {
        private readonly MyDbContext _context;
        private readonly ICategoryService _categoryService;

        public CategoryController(MyDbContext context, ICategoryService categoryService)
        {
            _context = context;
            _categoryService = categoryService;
        }
        public IActionResult Index(string name, int page=1)
        {
            CategoryViewModel mdl = new CategoryViewModel();
            if (name != null)
            {
                mdl.timKiem = name;
                mdl.thongBao = "Tìm kiếm trên danh sách loại sách";
                mdl.categories = _categoryService.FindCategoryName(name);         
            }
            else
            {
                mdl.thongBao = "Danh sách loại sách";
                mdl.categories = _categoryService.GetNotDeleteCategories();           
            }
            mdl = PaginationInfo(mdl, page);
            mdl.categories = Paging(mdl.categories, page);
            //Nhận thông báo
            if (TempData.Get<MessagesViewModel>("MessagesView") != null)
            {
                mdl.MessagesView = TempData.Get<MessagesViewModel>("MessagesView");
            }
            return View(mdl);
        }
        public IActionResult ShowTmp(string name, int page=1)
        {
            CategoryViewModel mdl = new CategoryViewModel();
            if (name != null)
            {
                mdl.categories = _categoryService.FindCategoryDeleteName(name);
                mdl.timKiem = name;
                mdl.thongBao = "Tìm kiếm trên danh sách loại sách đã bị tạm xóa";
            }
            else
            {
                mdl.thongBao = "Danh sách loại sách đã tạm xóa";
                mdl.categories = _categoryService.GetDeleteCategories();             
            }
            mdl = PaginationInfo(mdl, page);
            mdl.categories = Paging(mdl.categories, page);
            //Nhận thông báo
            if (TempData.Get<MessagesViewModel>("MessagesView") != null)
            {
                mdl.MessagesView = TempData.Get<MessagesViewModel>("MessagesView");
            }
            return View("Index", mdl);
        }

        public IActionResult Create()
        {
            CategoryEditModel categoryEditModel = new CategoryEditModel();
            //Nhận thông báo
            if (TempData.Get<MessagesViewModel>("MessagesView") != null)
            {
                categoryEditModel.MessagesView = TempData.Get<MessagesViewModel>("MessagesView");
            }
            return View(categoryEditModel);
        }

        [HttpPost]
        public IActionResult Create(CategoryEditModel categoryEditModel, IFormFile VerticalImage, IFormFile HorizontalImage)
        {
            if (ModelState.IsValid)
            {
                MessagesViewModel res = _categoryService.Create(categoryEditModel, VerticalImage, HorizontalImage);
                //Gửi thông báo
                TempData.Put("MessagesView", res);
                if (res.IsSuccess)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return RedirectToAction("Create");
                }

            }
            //Gửi thông báo
            TempData.Put("MessagesView", new MessagesViewModel(false, "Thông tin không hợp lệ"));
            return RedirectToAction("Create");
        }

        public IActionResult Edit(string id)
        {
            CategoryEditModel editModel = _categoryService.CategoryToEditModel(_categoryService.GetCategory(id));
            //Nhận thông báo
            if (TempData.Get<MessagesViewModel>("MessagesView") != null)
            {
                editModel.MessagesView = TempData.Get<MessagesViewModel>("MessagesView");
            }
            return View(editModel); 
        }

        [HttpPost]
        public IActionResult Edit(CategoryEditModel categoryEditModel, IFormFile VerticalImageUpLoad, IFormFile HorizontalImageUpLoad)
        {
            if (ModelState.IsValid)
            {
                MessagesViewModel res = _categoryService.EditCategory(categoryEditModel, VerticalImageUpLoad, HorizontalImageUpLoad);
                //Gửi thông báo
                TempData.Put("MessagesView", res);
                if (res.IsSuccess)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return RedirectToAction("Edit");
                }
            }
            //Gửi thông báo
            TempData.Put("MessagesView", new MessagesViewModel(false, "Thông tin không hợp lệ"));
            return RedirectToAction("Edit");
        }


        public IActionResult Delete(string id)
        {

            MessagesViewModel res = _categoryService.DeleteCategoryTmp(id);
            TempData.Put("MessagesView", res);
            if (res.IsSuccess)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Create");
            }

        }

        public IActionResult Restore (string id)
        {
            MessagesViewModel res = _categoryService.RestoreCategory(id);
            TempData.Put("MessagesView", res);
            if (res.IsSuccess)
            {
                return RedirectToAction("ShowTmp");
            }
            else
            {
                return RedirectToAction("Create");
            }
        }

        public IActionResult DeleteForever(string id)
        {

            MessagesViewModel res = _categoryService.DeleteCategoryForever(id);
            TempData.Put("MessagesView", res);
            if (res.IsSuccess)
            {
                return RedirectToAction("ShowTmp");
            }
            else
            {
                return RedirectToAction("Create");
            }

        }

        public string CheckSlug(string source, string id)
        {
            return _categoryService.CreateSlug(source, id);
        }

        const int PAGE_SIZE = 10;
        public IEnumerable<Category> Paging(IEnumerable<Category> categories, int page = 1)
        {
            int skipN = (page - 1) * PAGE_SIZE;
            categories = categories.Skip(skipN).Take(PAGE_SIZE);
            return categories;
        }

        public CategoryViewModel PaginationInfo(CategoryViewModel mdl, int page)
        {
            mdl.AllPages = (int)Math.Ceiling((double)mdl.categories.Count() / PAGE_SIZE);
            mdl.CurrentPage = page;

            return mdl;
        }


    }
}
