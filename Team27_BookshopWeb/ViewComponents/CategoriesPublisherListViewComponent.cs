using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using Team27_BookshopWeb.Entities;
using Team27_BookshopWeb.Services;

namespace Team27_BookshopWeb.ViewComponents
{
    public class CategoriesPublisherListViewComponent : ViewComponent
    {
        private readonly MyDbContext myDbContext;
        private readonly ICategoryService _categoryService;
        private readonly IPublishersService _publishersService;

        public CategoriesPublisherListViewComponent(MyDbContext myDbContext, ICategoryService categoryService, IPublishersService publishersService)
        {
            this.myDbContext = myDbContext;
            this._categoryService = categoryService;
            this._publishersService = publishersService;
        }

        public Task<IViewComponentResult> InvokeAsync(string type)
        {
            //Tạo dynamic model
            dynamic selectedModel = new ExpandoObject();
            //Thêm thuộc tính cho dynamic model
            selectedModel.categories = this._categoryService.GetAvailableCategories(0);
            selectedModel.publishers = this._publishersService.GetAllAvailablePublishers();
            //Lưu biến type vào TempData sử dụng ở view
            this.TempData["type"] = type;
            return Task.FromResult<IViewComponentResult>(View("CategoriesPublisherList", selectedModel));
        }
    }
}
