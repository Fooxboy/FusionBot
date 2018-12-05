using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fooxboy.FusionBot.Models.Attachments
{
    public partial class Sticker: IAttachment
    {
        [JsonProperty("product_id")]
        public long ProductId { get; set; }
        [JsonProperty("sticker_id")]
        public long StickerId { get; set; }
        [JsonProperty("images")]
        public List<ImageSticker> Images { get; set; }
        [JsonProperty("images_with_background")]
        public List<ImageSticker> ImagesWithBackground { get; set; }

        public class ImageSticker
        {
            [JsonProperty("url")]
            public string Url { get; set; }
            [JsonProperty("width")]
            public int Width { get; set; }
            [JsonProperty("height")]
            public int Height { get; set; }
        }

        public override string ToString()
        {
            return "Стикер";
        }

        public string ToMore() => "Стикера";
        public string ToMoreTwo() => "Стикеров";
    }
}
