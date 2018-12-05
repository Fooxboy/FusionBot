using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fooxboy.FusionBot.Models.Attachments
{
    public partial class Video : IAttachment
    {
        [JsonProperty("id")]
        public long Id { get; set; }
        [JsonProperty("owner_id")]
        public long OwnerId { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("duration")]
        public int Duration { get; set; }
        [JsonProperty("photo_130")]
        public string Photo130 { get; set; }
        [JsonProperty("photo_320")]
        public string Photo320 { get; set; }
        [JsonProperty("photo_640")]
        public string Photo640 { get; set; }
        [JsonProperty("photo_800")]
        public string Photo800 { get; set; }
        [JsonProperty("date")]
        public long Date { get; set; }
        [JsonProperty("adding_date")]
        public long AddingDate { get; set; }
        [JsonProperty("views")]
        public int Views { get; set; }
        [JsonProperty("comments")]
        public int Comments { get; set; }
        [JsonProperty("player")]
        public string Player { get; set; }
        [JsonProperty("platform")]
        public string Platform { get; set; }
        [JsonProperty("can_edit")]
        public int CanEdit { get; set; }
        [JsonProperty("can_add")]
        public int CanAdd { get; set; }
        [JsonProperty("is_private")]
        public int IsPrivate { get; set; }
        [JsonProperty("access_key")]
        public string AccessKey { get; set; }
        [JsonProperty("processing")]
        public int Processing { get; set; }
        [JsonProperty("live")]
        public int Live { get; set; }
        [JsonProperty("upcoming")]
        public int UpComing { get; set; }

        public override string ToString()
        {
            return "Видеозапись";
        }

        public string ToMore() => "Видеозаписи";
        public string ToMoreTwo() => "Видеозаписей";
    }
}
