using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Team27_BookshopWeb.Entities;

namespace Team27_BookshopWeb.Services
{
    public class CommentService: ICommentService
    {
        private readonly MyDbContext myDbContext;
        private readonly IBooksService _booksService;
        private readonly ICustomerService _customerService;
        public CommentService(MyDbContext myDbContext, IBooksService booksService, ICustomerService customerService)
        {
            this.myDbContext = myDbContext;
            _booksService = booksService;
            _customerService = customerService;
        }

        public IQueryable<Comment> GetComment()
        {
            return myDbContext.Comments.Include(c => c.Book)
                        .OrderBy(p => p.Id);
        }
        public Comment GetDetailComment(int id)
        {
            return myDbContext.Comments
                        .Where(p=> p.Id == id)
                        .Include(c => c.Book)
                        .OrderBy(p => p.Id).FirstOrDefault();
        }
        public IEnumerable<Comment> FindCommentFollowNameBook(string name)
        {
            IEnumerable<Comment> list = FindComment(name, GetComment()).ToList();
            return list;
        }
        public IQueryable<Comment> FindComment(string name, IQueryable<Comment> comments)
        {
            return comments.Include(c => c.Book).Where(p => EF.Functions.Like(p.Book.Name, "%" + name + "%")).AsQueryable();
        }

        public IEnumerable<Comment> FindCommentFollowVote(int vote)
        {
            IEnumerable<Comment> list = FindCommentVote(vote, GetComment()).ToList();
            return list;
        }

        public IQueryable<Comment> FindCommentVote(int vote, IQueryable<Comment> comments)
        {
            
            return comments.Where(p => p.Vote == vote).AsQueryable();
        }

        public IEnumerable<Comment> FindCommentFollowBought(int bought)
        {
            IEnumerable<Comment> list = FindCommentBought(bought, GetComment()).ToList();
            return list;
        }

        public IQueryable<Comment> FindCommentBought(int bought, IQueryable<Comment> comments)
        {

            return comments.Where(p => p.Bought == bought).AsQueryable();
        }
    }
}
