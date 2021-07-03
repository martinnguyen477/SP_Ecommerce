using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using Team27_BookshopWeb.Entities;
using Team27_BookshopWeb.Extensions;
using Team27_BookshopWeb.Models;
using Team27_BookshopWeb.Services;

namespace Team27_BookshopWeb.Controllers
{
    public class ProductDetailsController : Controller
    {
        private readonly MyDbContext _myDbContext;
        private readonly IBooksService _booksService;

        public ProductDetailsController(MyDbContext myDbContext, IBooksService booksService)
        {
            _myDbContext = myDbContext;
            _booksService = booksService;
        }

        public IActionResult Index(string bookSlug, [FromServices] ICategoryService _categoryService)
        {
            ProductDetailsViewModel mdl = new ProductDetailsViewModel();
            //Hiển thị sách theo slug
            mdl.book = _booksService.GetBookBySlugOrId(bookSlug, "slug");

            //Cập nhật lượt xem
            MessagesViewModel mdlUpdateViews = new MessagesViewModel();
            mdlUpdateViews = UpdateViews(mdl.book.Id);
            if (!mdlUpdateViews.IsSuccess)
            {
                return BadRequest();
            }

            if (mdl.book != null)
            {
                //Lấy comments của sách và sắp xếp theo ngày mới nhất
                mdl.comments = mdl.book.Comments.OrderBy(c => c.CreatedAt);
                //Lấy và Shuffle các sách liên quan
                mdl.relatedBooks = _booksService.GetRelatedBooks(_categoryService, mdl.book, 7).Shuffle();
                return View(mdl);
            }
            else
            {
                return StatusCode(404);
            }
        }

        [HttpPost]
        public IActionResult QuickView([FromForm]string id)
        {
            ProductDetailsViewModel mdl = new ProductDetailsViewModel();
            //Hiển thị sách theo id
            mdl.book = _booksService.GetBookBySlugOrId(id, "id");

            //Cập nhật lượt xem
            MessagesViewModel mdlUpdateViews = new MessagesViewModel();
            mdlUpdateViews = UpdateViews(mdl.book.Id);
            if (!mdlUpdateViews.IsSuccess)
            {
                return BadRequest();
            }

            if (mdl.book != null)
            {
                //Lấy comments của sách và sắp xếp theo ngày mới nhất
                mdl.comments = mdl.book.Comments.OrderBy(c => c.CreatedAt);
                return PartialView("_BookQuickView", mdl);
            }
            else
            {
                return StatusCode(404);
            }
            
        }

        public MessagesViewModel UpdateViews(string bookId)
        {
            string sessionId = HttpContext.Session.Id;
            string customerId = null;
            if (User.Identity.IsAuthenticated)
            {
                customerId = User.FindFirst("Id").Value;
            }
            MessagesViewModel mdl = new MessagesViewModel();
            mdl = _booksService.UpdateBookViews(bookId, sessionId, customerId);
            return mdl;
        }

        [HttpPost]
        public JsonResult Comment([FromForm]CommentEditModel comment)
        {
            if (User.Identity.IsAuthenticated)
            {
                comment.CustomerId = User.FindFirst("Id").Value;
            }

            if (ModelState.IsValid)
            {
                MessagesViewModel mdl = new MessagesViewModel();
                mdl = _booksService.Comment(comment);
                return Json(mdl);
            }
            return Json(new MessagesViewModel(false, "Thông tin không hợp lệ"));
        }
    }
}