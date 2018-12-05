using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fooxboy.FusionBot.Models.Attachments
{
    public partial class Photo: IAttachment
    {
        [JsonProperty("id")]
        public long Id { get; set; }
        [JsonProperty("album_id")]
        public long AlbumId { get; set; }
        [JsonProperty("owner_id")]
        public long OwnerId { get; set; }
        [JsonProperty("user_id")]
        public long UserId { get; set; }
        [JsonProperty("text")]
        public string Text { get; set; }
        [JsonProperty("date")]
        public long Date { get; set; }
        [JsonProperty("sizes")]
        public List<object> Sizes { get; set; }
        [JsonProperty("photo_75")]
        public string Photo75 { get; set; }
        [JsonProperty("photo_130")]
        public string Photo130 { get; set; }
        [JsonProperty("photo_604")]
        public string Photo604 { get; set; }
        [JsonProperty("photo_807")]
        public string Photo807 { get; set; }
        [JsonProperty("photo_1280")]
        public string Photo1280 { get; set; }
        [JsonProperty("photo_2560")]
        public string Photo2560 { get; set; }
        [JsonProperty("width")]
        public int Width { get; set; }
        [JsonProperty("height")]
        public int Height { get; set; }

        public override string ToString()
        {
            return "Фотография";
        }

        public string ToMore() => "Фотографии";
        public string ToMoreTwo() => "Фотографий";
    }
}
