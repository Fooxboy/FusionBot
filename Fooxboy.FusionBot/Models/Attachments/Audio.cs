using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fooxboy.FusionBot.Models.Attachments
{
    public partial class Audio: IAttachment
    {
        [JsonProperty("id")]
        public long Id { get; set; }
        [JsonProperty("owner_id")]
        public long OwnerId { get; set; }
        [JsonProperty("artist")]
        public string Artist { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("duration")]
        public long Duration { get; set; }
        [JsonProperty("url")]
        public string Url { get; set; }
        [JsonProperty("lyrics_id")]
        public long LyricsId { get; set; }
        [JsonProperty("album_id")]
        public long AlbumId { get; set; }
        [JsonProperty("genre_id")]
        public long GenreId { get; set; }
        [JsonProperty("date")]
        public long Date { get; set; }
        [JsonProperty("no_search")]
        public long NoSearch { get; set; }
        [JsonProperty("is_hq")]
        public long IsHq { get; set; }

        public override string ToString()
        {
            return "Аудио";
        }

        public string ToMore() => "Аудио";
        public string ToMoreTwo() => "Аудио";
    }
}
