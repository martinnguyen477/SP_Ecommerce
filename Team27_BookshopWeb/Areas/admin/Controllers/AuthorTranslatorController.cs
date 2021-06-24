using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Team27_BookshopWeb.Areas.admin.Models;
using Team27_BookshopWeb.Entities;
using Team27_BookshopWeb.Models;
using Team27_BookshopWeb.Services;

namespace Team27_BookshopWeb.Areas.admin.Controllers
{
    [Area("admin")]
    [Authorize(AuthenticationSchemes = "admin")]
    public class AuthorTranslatorController : Controller
    {
        private readonly MyDbContext _myDbContext;
        private readonly IAuthorTranslatorService _authorTranslatorService;

        public AuthorTranslatorController(MyDbContext myDbContext, IAuthorTranslatorService authorTranslatorService)
        {
            _myDbContext = myDbContext;
            _authorTranslatorService = authorTranslatorService;
        }

        public IActionResult Index(string Search, string Filter, int page=1)
        {
            AuthorTranslatorViewModel mdl = new AuthorTranslatorViewModel();
            IQueryable<AuthorTranslator> res;
            //Search
            if (Search != "")
            {
                res = _authorTranslatorService.WhereName(Search, _myDbContext.AuthorTranslators);
            }
            else
            {
                res = _authorTranslatorService.Filter("All", _myDbContext.AuthorTranslators);
            }
            //Filter
            res = _authorTranslatorService.Filter(Filter, res);
            
            mdl.AuthorTranslators = res.ToList();
            mdl = PaginationInfo(mdl, page);
            if (page == 0)
            {
                IEnumerable<AuthorTranslator> list;
                List<AuthorTranslator> tmpList = new List<AuthorTranslator>();
                tmpList.Add(mdl.AuthorTranslators.Last());
                mdl.AuthorTranslators = tmpList;
            }
            else
            {
                mdl.AuthorTranslators = Paging(mdl.AuthorTranslators, page);
            }
            mdl.Search = Search;
            mdl.Filter = Filter;

            if (page == 1) return View(mdl);
            else return PartialView("_AuTransView", mdl);
        }

        public string CheckSlug(string source, string id)
        {
            //Tạo và kiểm tra slug
            return _authorTranslatorService.CreateSlug(source, id);
        }

        [HttpPost]
        public JsonResult Create([FromBody] AuthorTranslatorEditModel authorTranslatorEditModel)
        {
            MessagesViewModel mdl = new MessagesViewModel();
            if (ModelState.IsValid)
            {
                mdl = _authorTranslatorService.AddAuthorTranslator(authorTranslatorEditModel);
                return Json(mdl);
            }
            mdl.IsSuccess = false;
            mdl.Messages.Add("Thêm thất bại");
            return Json(mdl);
        }

        [HttpPut]
        public JsonResult Edit([FromBody] AuthorTranslatorEditModel authorTranslatorEditModel)
        {
            MessagesViewModel mdl = new MessagesViewModel();
            if (ModelState.IsValid)
            {
                mdl = _authorTranslatorService.UpdateAuthorTranslator(authorTranslatorEditModel);
                return Json(mdl);
            }
            mdl.IsSuccess = false;
            mdl.Messages.Add("Cập nhật thất bại");
            return Json(mdl);
        }

        [HttpGet]
        public JsonResult Detail(string Id)
        {
            if (!string.IsNullOrEmpty(Id))
            {
                return Json(new MessagesViewModel(true,
                                        "Load tác giả",
                                        _authorTranslatorService.WhereId(Id, _authorTranslatorService.GetNotDeletedAuthorTranslators())
                                        .FirstOrDefault()));
            }
            return Json(new MessagesViewModel(false, "Lỗi khi load tác giả"));
        }

        [HttpDelete]
        public JsonResult SoftDelete([FromForm]string Id)
        {
            MessagesViewModel mdl = new MessagesViewModel();
            mdl = _authorTranslatorService.SoftDelete(Id);
            return Json(mdl);
        }

        [HttpGet]
        public JsonResult Restore(string Id)
        {
            MessagesViewModel mdl = new MessagesViewModel();
            mdl = _authorTranslatorService.Restore(Id);
            return Json(mdl);
        }

        [HttpGet]
        public JsonResult Delete(string Id)
        {
            MessagesViewModel mdl = new MessagesViewModel();
            mdl = _authorTranslatorService.Delete(Id);
            return Json(mdl);
        }

        const int PAGE_SIZE = 10;
        public IEnumerable<AuthorTranslator> Paging(IEnumerable<AuthorTranslator> authorTranslators, int page = 1)
        {
            int skipN = (page - 1) * PAGE_SIZE;
            authorTranslators = authorTranslators.Skip(skipN).Take(PAGE_SIZE);
            return authorTranslators;
        }

        public AuthorTranslatorViewModel PaginationInfo(AuthorTranslatorViewModel mdl, int page)
        {
            mdl.AllPages = (int)Math.Ceiling((double)mdl.AuthorTranslators.Count() / PAGE_SIZE);
            mdl.CurrentPage = page;

            return mdl;
        }
    }
}