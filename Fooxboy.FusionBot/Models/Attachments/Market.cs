using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fooxboy.FusionBot.Models.Attachments
{
    public partial class Market : IAttachment
    {
        [JsonProperty("id")]
        public long Id { get; set; }
        [JsonProperty("owner_id")]
        public long OwnerId { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("price")]
        public PriceMarket Price { get; set; }
        [JsonProperty("category")]
        public CategoryMarket Category { get; set; }
        [JsonProperty("thumb_photo")]
        public string ThumbPhoto { get; set; }
        [JsonProperty("date")]
        public long Date { get; set; }
        [JsonProperty("availability")]
        public int Availability { get; set; }

        public class PriceMarket
        {
            [JsonProperty("amount")]
            public int Amount { get; set; }
            [JsonProperty("text")]
            public string Text { get; set; }
        }

        public class CategoryMarket
        {
            [JsonProperty("id")]
            public int Id { get; set; }
            [JsonProperty("name")]
            public string Name { get; set; }
        }

        public override string ToString()
        {
            return "Товар";
        }

        public string ToMore() => "Товара";
        public string ToMoreTwo() => "Товаров";
    }
}
