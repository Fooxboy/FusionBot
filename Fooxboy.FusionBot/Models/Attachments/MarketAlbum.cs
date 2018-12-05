using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fooxboy.FusionBot.Models.Attachments
{
    public partial class MarketAlbum: IAttachment
    {
        [JsonProperty("id")]
        public long Id { get; set; }
        [JsonProperty("owner_id")]
        public long OwnerId { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("photo")]
        public Photo Photo { get; set; }
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("updated_time")]
        public long UpdatedTime { get; set; }

        public override string ToString()
        {
            return "Подборка товаров";
        }

        public string ToMore() => "Подборки товаров";
        public string ToMoreTwo() => "Подборок товаров";
    }
}
