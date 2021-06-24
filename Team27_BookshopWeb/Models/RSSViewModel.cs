using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Team27_BookshopWeb.Models
{
    public class RSSImage
    {
        public string ImageUrl { get; set; }
        public string Title { get; set; }
        public string Link { get; set; }
    }

    public class RSSItem
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string PublicationDate { get; set; }
        public string Link { get; set; }
    }

    public class RSSViewModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public RSSImage Image { get; set; }
        public ICollection<RSSItem> Items { get; set; }

        public RSSViewModel()
        {
            this.Items = new HashSet<RSSItem>();
        }
    }
}
