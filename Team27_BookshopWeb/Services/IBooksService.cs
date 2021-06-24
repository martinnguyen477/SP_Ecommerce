using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using Team27_BookshopWeb.Areas.admin.Models;
using Team27_BookshopWeb.Entities;
using Team27_BookshopWeb.Models;

namespace Team27_BookshopWeb.Services
{
    public interface IBooksService
    {
        IQueryable<Book> GetNotDeletedBooks();
        IEnumerable<Book> GetNewlyPublishedBooks(int amountOfBooks);
        IEnumerable<Book> GetTopViewBooks(int days, int amountOfBooks);
        IQueryable<BestSellerBooksViewModel> GetBestSeller(int days);
        IEnumerable<Book> GetBestSellerBooks(int days, int amountOfBooks);
        IEnumerable<Book> GetAvailableBooks();
        Book GetBookBySlugOrId(string slugOrId, string type);
        IEnumerable<Book> GetRelatedBooks([FromServices] ICategoryService _categoryService, Book book, int amountOfBooks);
        IEnumerable<Book> Sort(IEnumerable<Book> books, string type);
        IEnumerable<Book> SearchBooks(string name);

        MessagesViewModel UpdateBookViews(string BookId, string SessionId, string CustomerId);
        string CreateNewBookId();
        string CreateNewId(string prefix, int count, string lastId);
        string GenerateNewSlug(string source);
        string CreateSlug(string source, string id);
        IQueryable<Book> WhereId(string id, IQueryable<Book> books);
        IQueryable<Book> WhereCategory(string categoryId, IQueryable<Book> books);
        IQueryable<Book> WhereName(string name, IQueryable<Book> books);
        IQueryable<Book> WherePublisher(string publisherId, IQueryable<Book> books);
        IQueryable<Book> WhereAuthor(string authorId, IQueryable<Book> books);
        IQueryable<Book> WhereDeleted(IQueryable<Book> books);
        IQueryable<Book> IncludeProperties(IQueryable<Book> books);
        IQueryable<Book> AllBooks();
        IQueryable<Book> Filter(string type, string filter, IQueryable<Book> books);
        MessagesViewModel Create(BookEditModel book, IFormFile PrimaryImage, List<IFormFile> Images);
        BookEditModel ToBookEditModel(Book book);
        MessagesViewModel Edit(BookEditModel editedbook, IFormFile NewPrimaryImage, List<IFormFile> NewOtherImages);
        MessagesViewModel SoftDelete(string id);
        MessagesViewModel Restore(string id);
        MessagesViewModel Delete(string id);
        IQueryable<TopViewModel> TopView(int days, string sort, bool all, IQueryable<Book> books);
        IEnumerable<Book> GetConsideredBooks();
        MessagesViewModel Comment(CommentEditModel commentEditModel);
    }
}