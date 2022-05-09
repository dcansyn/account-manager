using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManager.Core.Models
{
    public class MailModel
    {
        [JsonProperty("hydra:member")]
        public MailItemModel[] Items { get; set; }

        public string Text { get; set; }
    }

    public class MailItemModel
    {
        public string Id { get; set; }
        public string Subject { get; set; }
    }
}
