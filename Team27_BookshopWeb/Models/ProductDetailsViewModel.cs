using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Team27_BookshopWeb.Entities;

namespace Team27_BookshopWeb.Models
{
    public class ProductDetailsViewModel
    {
        private int _numberOfComments;
        private double _averageRating;
        public Book book { get; set; }
        public IEnumerable<Comment> comments { get; set; }
        public int numberOfComments
        {
            get
            {
                return this.comments.Count();
            }
            set
            {
                this._numberOfComments = value;
            }
        }

        public double averageRating
        {
            get
            {
                return (this.numberOfComments > 0) ? this.comments.Average(c => c.Vote) : 0;
            }
            set
            {
                this._averageRating = value;
            }
        }

        public IEnumerable<Book> relatedBooks { get; set; }
        public MessagesViewModel MessagesView { get; set; }
    }
}
