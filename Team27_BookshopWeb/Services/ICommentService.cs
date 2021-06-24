using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Team27_BookshopWeb.Entities;

namespace Team27_BookshopWeb.Services
{
    public interface ICommentService
    {
        public IQueryable<Comment> GetComment();
        public Comment GetDetailComment(int id);
        public IEnumerable<Comment> FindCommentFollowNameBook(string name);
        public IQueryable<Comment> FindComment(string name, IQueryable<Comment> comments);
        public IQueryable<Comment> FindCommentVote(int vote, IQueryable<Comment> comments);
        public IEnumerable<Comment> FindCommentFollowVote(int vote);
        public IQueryable<Comment> FindCommentBought(int bought, IQueryable<Comment> comments);
        public IEnumerable<Comment> FindCommentFollowBought(int bought);
    }
}
