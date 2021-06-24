using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Team27_BookshopWeb.Areas.admin.Models;
using Team27_BookshopWeb.Entities;
using Team27_BookshopWeb.Models;

namespace Team27_BookshopWeb.Services
{
    public interface ICategoryService
    {
        IQueryable<Category> GetNotDeleteCategories();
        IQueryable<Category> GetDeleteCategories();
        public MessagesViewModel Create(CategoryEditModel categoryEditModel, IFormFile VerticalImage, IFormFile HorizontalImage);
        IEnumerable<Category> GetAvailableCategories(int amountOfCategories);
        Category GetCategory(string type, string slugOrId);
        IEnumerable<Category> GetCategoriesWithoutBooks();
        public Category GetCategory(string id);
        public IEnumerable<Category> FindCategoryName(string name);
        public IEnumerable<Category> FindCategoryDeleteName(string name);
        public IQueryable<Category> FindCategory(string name, IQueryable<Category> categories);
        public IQueryable<Category> WhereId(string id, IQueryable<Category> categories);
        public MessagesViewModel DeleteCategoryTmp(string id);
        public MessagesViewModel RestoreCategory(string id);
        public MessagesViewModel DeleteCategoryForever(string id);
        public MessagesViewModel EditCategory(CategoryEditModel categoryEditModel, IFormFile VerticalImage, IFormFile HorizontalImage);

        IQueryable<Category> WhereSlug(string slug, IQueryable<Category> categories);
        string CreateSlug(string source, string id);
        CategoryEditModel CategoryToEditModel(Category category);
        Category EditModelToCategory(CategoryEditModel categoryEditModel, Category category);
    }
}