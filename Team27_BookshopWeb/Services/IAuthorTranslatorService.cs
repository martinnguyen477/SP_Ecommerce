using System.Collections.Generic;
using System.Linq;
using Team27_BookshopWeb.Areas.admin.Models;
using Team27_BookshopWeb.Entities;
using Team27_BookshopWeb.Models;

namespace Team27_BookshopWeb.Services
{
    public interface IAuthorTranslatorService
    {
        AuthorTranslator GetAuTrans(string type, bool isAuthor, string slugOrId);
        IQueryable<AuthorTranslator> GetNotDeletedAuthorTranslators();
        IEnumerable<AuthorTranslator> GetAuthorTranslatorWithoutBooks();
        IEnumerable<AuthorTranslator> GetAllAvailableAuthorTranslators();
        IQueryable<AuthorTranslator> WhereId(string id, IQueryable<AuthorTranslator> authorTranslators);
        IQueryable<AuthorTranslator> WhereSlug(string slug, IQueryable<AuthorTranslator> authorTranslators);
        string CreateSlug(string source, string id);
        string CreateAuTransId();
        MessagesViewModel AddAuthorTranslator(AuthorTranslatorEditModel authorTranslatorEditModel);
        MessagesViewModel UpdateAuthorTranslator(AuthorTranslatorEditModel authorTranslatorEditModel);
        MessagesViewModel SoftDelete(string Id);
        MessagesViewModel Delete(string Id);
        MessagesViewModel Restore(string Id);

        IQueryable<AuthorTranslator> WhereName(string name, IQueryable<AuthorTranslator> authorTranslators);
        IQueryable<AuthorTranslator> Filter(string type, IQueryable<AuthorTranslator> authorTranslators);
        IEnumerable<AuthorTranslator> GetAuthorsNotDeleted();
        IEnumerable<AuthorTranslator> GetTranslatorsNotDeleted();
    }
}