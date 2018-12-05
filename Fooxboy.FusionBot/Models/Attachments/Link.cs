using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fooxboy.FusionBot.Models.Attachments
{
    public partial class Link:IAttachment
    {
        [JsonProperty("url")]
        public string Url { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("caption")]
        public string Caption { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("photo")]
        public Photo Photo { get; set; }
        [JsonProperty("product")]
        public ProductLink Product { get; set; }
        [JsonProperty("button")]
        public ButtonLink Button { get; set; }
        [JsonProperty("preview_page")]
        public string PreviewPage { get; set; }
        [JsonProperty("preview_url")]
        public string PreviewUrl { get; set; }

        public class ProductLink
        {
            [JsonProperty("price")]
            public PriceProduct Price { get; set; }
            public class PriceProduct
            {
                [JsonProperty("amount")]
                public int Amount { get; set; }
                [JsonProperty("text")]
                public string Text { get; set; }
            }
        }

        public class ButtonLink
        {
            [JsonProperty("title")]
            public string Title { get; set; }
            [JsonProperty("action")]
            public ActionButton Action { get; set; }

            public class ActionButton
            {
                [JsonProperty("type")]
                public string Type { get; set; }
                [JsonProperty("url")]
                public string Url { get; set; }
            }
        }

        public override string ToString()
        {
            return "Ссылка";
        }

        public string ToMore() => "Ссылки";
        public string ToMoreTwo() => "Ссылок";
    }
}
