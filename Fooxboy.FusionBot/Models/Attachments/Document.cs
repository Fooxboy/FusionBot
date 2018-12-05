using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fooxboy.FusionBot.Models.Attachments
{
    public partial class Document: IAttachment
    {
        [JsonProperty("id")]
        public long Id { get; set; }
        [JsonProperty("owner_id")]
        public long OwnerId { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("size")]
        public long Size { get; set; }
        [JsonProperty("ext")]
        public string Ext { get; set; }
        [JsonProperty("url")]
        public string Url { get; set; }
        [JsonProperty("date")]
        public long Date { get; set; }
        [JsonProperty("type")]
        public int Type { get; set; }
        [JsonProperty("preview")]
        public PreviewDoc Preview { get; set; }

        public class PreviewDoc
        {
            [JsonProperty("photo")]
            public PhotoPreview Photo { get; set; }
            [JsonProperty("graffiti")]
            public Graffiti Graffiti { get; set; }
            [JsonProperty("audio_msg")]
            public AudioMessage AudioMsgPrev { get; set; }

            public class PhotoPreview
            {
                [JsonProperty("sizes")]
                public List<object> Sizes { get; set; }
            }
        }

        public override string ToString()
        {
            return "Документ";
        }

        public string ToMore() => "Документа";
        public string ToMoreTwo() => "Документов";
    }
}
