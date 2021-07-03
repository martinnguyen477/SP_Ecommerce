using System;
using System.Collections.Generic;
using System.Linq;
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
    public class PublisherController : Controller
    {

        private readonly MyDbContext _context;
        private readonly IPublishersService _publishersService;

        public PublisherController(MyDbContext context, IPublishersService publishersService)
        {
            _context = context;
            _publishersService = publishersService;
        }
        public IActionResult Index(string name, int page=1)
        {
            PublisherViewModel mdl = new PublisherViewModel();
            if (name != null)
            {
                mdl.timKiem = name;
                mdl.thongBao = "Tìm kiếm trên danh sách NXB";
                mdl.publishers = _publishersService.FindPublisherName(name);
            }
            else
            {
                mdl.thongBao = "Danh sách NXB";
                mdl.publishers = _publishersService.GetNotDeletedPublishers();
            }
            mdl = PaginationInfo(mdl, page);
            mdl.publishers = Paging(mdl.publishers, page);
            //Nhận thông báo
            if (TempData.Get<MessagesViewModel>("MessagesView") != null)
            {
                mdl.MessagesView = TempData.Get<MessagesViewModel>("MessagesView");
            }
            return View(mdl);
        }

        public IActionResult ShowTmp(string name, int page=1)
        {
            PublisherViewModel mdl = new PublisherViewModel();
            if (name != null)
            {
                mdl.publishers = _publishersService.FindPublisherDeleteName(name);
                mdl.timKiem = name;
                mdl.thongBao = "Tìm kiếm trên danh sách NXB đã bị tạm xóa";              
            }
            else
            {
                mdl.thongBao = "Danh sách NXB đã tạm xóa";
                mdl.publishers = _publishersService.GetDeletePublishers();
            }

            mdl = PaginationInfo(mdl, page);
            mdl.publishers = Paging(mdl.publishers, page);

            //Nhận thông báo
            if (TempData.Get<MessagesViewModel>("MessagesView") != null)
            {
                mdl.MessagesView = TempData.Get<MessagesViewModel>("MessagesView");
            }
            return View("Index", mdl);
        }


        public IActionResult Create()
        {
            PublisherEditModel publisherEditModel = new PublisherEditModel();
            //Nhận thông báo
            if (TempData.Get<MessagesViewModel>("MessagesView") != null)
            {
                publisherEditModel.MessagesView = TempData.Get<MessagesViewModel>("MessagesView");
            }
            return View(publisherEditModel);         

        }
        [HttpPost]
        public IActionResult Create(PublisherEditModel publisherEditModel, IFormFile Image)
        {
            if (ModelState.IsValid)
            {
                MessagesViewModel res = _publishersService.Create(publisherEditModel, Image);
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
            PublisherEditModel publisherEditModel = _publishersService.PublisherToEditModel(_publishersService.GetPublisher(id));
            //Nhận thông báo
            if (TempData.Get<MessagesViewModel>("MessagesView") != null)
            {
                publisherEditModel.MessagesView = TempData.Get<MessagesViewModel>("MessagesView");
            }
            return View(publisherEditModel);
        }

        [HttpPost]
        public IActionResult Edit(PublisherEditModel publisherEditModel, IFormFile ImageUpLoad)
        {
            if (ModelState.IsValid)
            {
                MessagesViewModel res = _publishersService.EditPublisher(publisherEditModel, ImageUpLoad);
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

            MessagesViewModel res = _publishersService.DeletePublisherTmp(id);
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

        public IActionResult Restore(string id)
        {
            MessagesViewModel res = _publishersService.RestorePublisher(id);
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

            MessagesViewModel res = _publishersService.DeletePublisherForever(id);
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
            return _publishersService.CreateSlug(source, id);
        }

        const int PAGE_SIZE = 10;
        public IEnumerable<Publisher> Paging(IEnumerable<Publisher> publishers, int page = 1)
        {
            int skipN = (page - 1) * PAGE_SIZE;
            publishers = publishers.Skip(skipN).Take(PAGE_SIZE);
            return publishers;
        }

        public PublisherViewModel PaginationInfo(PublisherViewModel mdl, int page)
        {
            mdl.AllPages = (int)Math.Ceiling((double)mdl.publishers.Count() / PAGE_SIZE);
            mdl.CurrentPage = page;

            return mdl;
        }
    }
}
