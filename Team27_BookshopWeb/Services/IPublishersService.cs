using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Linq;
using Team27_BookshopWeb.Areas.admin.Models;
using Team27_BookshopWeb.Entities;
using Team27_BookshopWeb.Models;

namespace Team27_BookshopWeb.Services
{
    public interface IPublishersService
    {
        IEnumerable<Publisher> GetPublishersWithoutBooks();
        IEnumerable<Publisher> GetAllAvailablePublishers();
        Publisher GetPublisher(string type, string slugOrId);
        public IQueryable<Publisher> GetNotDeletedPublishers();
        public IEnumerable<Publisher> FindPublisherName(string name);
        public IQueryable<Publisher> GetDeletePublishers();
        public IEnumerable<Publisher> FindPublisherDeleteName(string name);
        public MessagesViewModel Create(PublisherEditModel publisherEditModel, IFormFile Image);
        public Publisher GetPublisher(string id);
        public IQueryable<Publisher> WhereId(string id, IQueryable<Publisher> publishers);
        public MessagesViewModel EditPublisher(PublisherEditModel publisherEditModel, IFormFile ImageUpLoad);
        public MessagesViewModel DeletePublisherTmp(string id);
        public MessagesViewModel RestorePublisher(string id);
        public MessagesViewModel DeletePublisherForever(string id);
        IQueryable<Publisher> WhereSlug(string slug, IQueryable<Publisher> publishers);
        string CreateSlug(string source, string id);
        public Publisher EditModelToPublisher(PublisherEditModel publisherEditModel, Publisher publisher);
        PublisherEditModel PublisherToEditModel(Publisher publisher);
    }
}