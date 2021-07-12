using System;
using System.Collections.Generic;
using System.Linq;
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
    public class CommentController : Controller
    {

        private readonly MyDbContext _context;
        private readonly ICommentService _commentService;
        public CommentController(MyDbContext context, ICommentService commentService)
        {
            _context = context;
            _commentService = commentService;
        }
        public IActionResult Index(string name, int page=1)
        {
            CommentViewModel mdl = new CommentViewModel();
            if (!string.IsNullOrEmpty(name))
            {
                mdl.timKiem = name;
                mdl.thongBao = "Tìm kiếm comment theo tên sách";
                mdl.comments = _commentService.FindCommentFollowNameBook(name);
                return View( mdl);
            }
            mdl.thongBao = "Danh sách Comment";
            mdl.comments = _commentService.GetComment();
            mdl = PaginationInfo(mdl, page);
            mdl.comments = Paging(mdl.comments, page);
            return View(mdl);
        }

        public IActionResult FilterVote(string vote, int page=1)
        {
            CommentViewModel mdl = new CommentViewModel();
            if (vote != null)
            {
                int a = int.Parse(vote);
                mdl.thongBao = "Tìm kiếm comment có "+ a +" sao";
                mdl.vote = vote;
                mdl.comments = _commentService.FindCommentFollowVote(a);
                return View("Index",mdl);
            }
            mdl.thongBao = "Danh sách Comment";
            mdl.comments = _commentService.GetComment();
            mdl = PaginationInfo(mdl, page);
            mdl.comments = Paging(mdl.comments, page);
            return View("Index",mdl);
        }

        public IActionResult FilterBought(string bought, int page=1)
        {
            CommentViewModel mdl = new CommentViewModel();
            if (bought != null)
            {
                int a = int.Parse(bought);
                if (a == 0)
                {
                    mdl.thongBao = "Tìm kiếm comment của khách hàng chưa mua sách";
                }
                else
                {
                    mdl.thongBao = "Tìm kiếm comment của khách hàng đã mua sách";
                }
                mdl.bought = bought;
                mdl.comments = _commentService.FindCommentFollowBought(a);
                mdl = PaginationInfo(mdl, page);
                mdl.comments = Paging(mdl.comments, page);
                return View("Index", mdl);
            }
            mdl.thongBao = "Danh sách Comment";
            mdl.comments = _commentService.GetComment();
            return View("Index", mdl);
        }
        public IActionResult ViewComment(int id)
        {
            Comment cm = _commentService.GetDetailComment(id);
            return View(cm);
        }

        const int PAGE_SIZE = 10;
        public IEnumerable<Comment> Paging(IEnumerable<Comment> comments, int page = 1)
        {
            int skipN = (page - 1) * PAGE_SIZE;
            comments = comments.Skip(skipN).Take(PAGE_SIZE);
            return comments;
        }

        public CommentViewModel PaginationInfo(CommentViewModel mdl, int page)
        {
            mdl.AllPages = (int)Math.Ceiling((double)mdl.comments.Count() / PAGE_SIZE);
            mdl.CurrentPage = page;

            return mdl;
        }

    }
}
