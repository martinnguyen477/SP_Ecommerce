using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml.Linq;
using Team27_BookshopWeb.Models;

namespace Team27_BookshopWeb.ViewComponents
{
    public class RssFeedViewComponent : ViewComponent
    {
        public RssFeedViewComponent()
        {}

        public Task<IViewComponentResult> InvokeAsync()
        {
            var url = "https://vnexpress.net/rss/tin-moi-nhat.rss";
            var httpClient = new HttpClient();
            try
            {
                var result = httpClient.GetAsync(url).Result;
                var stream = result.Content.ReadAsStreamAsync().Result;

                XDocument itemXml = XDocument.Load(stream);
                RSSViewModel Rss = new RSSViewModel();
                var channel = itemXml.Root.Element("channel");
                //Rss Info
                Rss.Title = channel.Element("title").Value;
                Rss.Description = channel.Element("description").Value;
                //Rss Image Info
                RSSImage image = new RSSImage();
                image.Link = channel.Element("image").Element("link").Value;
                image.ImageUrl = channel.Element("image").Element("url").Value;
                image.Title = channel.Element("image").Element("title").Value;
                Rss.Image = image;
                var count = 1;
                //Rss item
                foreach (XElement item in channel.Descendants("item"))
                {
                    if (count <= 10)
                    {
                        RSSItem RssItem = new RSSItem();

                        RssItem.Title = item.Element("title").Value;
                        RssItem.Description = item.Element("description").Value;
                        RssItem.PublicationDate = DateTime.Parse(item.Element("pubDate").Value).ToString("ddd, d MMM, yyyy HH:mm:ss");
                        RssItem.Link = item.Element("link").Value;

                        Rss.Items.Add(RssItem);
                        count++;
                    }
                }
                return Task.FromResult<IViewComponentResult>(View("RssFeed", Rss));
            }
            catch (Exception)
            {
                return null;
            }
            
        }
    }
}
