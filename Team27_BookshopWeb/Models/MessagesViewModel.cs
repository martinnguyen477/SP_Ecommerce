using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Team27_BookshopWeb.Models
{
    public class MessagesViewModel
    {
        public bool IsSuccess { get; set; }
        public ICollection<string> Messages { get; set; }
        public object Data { get; set; }
        public MessagesViewModel()
        {
            this.Messages = new HashSet<string>();
        }

        public MessagesViewModel(bool isSuccess, string message)
        {
            List<string> messages = new List<string>();
            messages.Add(message);
            this.IsSuccess = isSuccess;
            this.Messages = messages;
        }

        public MessagesViewModel(bool isSuccess, string message, object data)
        {
            List<string> messages = new List<string>();
            messages.Add(message);
            this.IsSuccess = isSuccess;
            this.Messages = messages;
            this.Data = data;
        }
    }
}
