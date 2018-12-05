using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fooxboy.FusionBot.Models.Attachments
{
    public partial class Gift : IAttachment
    {
        [JsonProperty("id")]
        public long Id { get; set; }
        [JsonProperty("thumb_256")]
        public string Thumb256 { get; set; }
        [JsonProperty("thumb_96")]
        public string Thumb96 { get; set; }
        [JsonProperty("thumb_48")]
        public string Thumb48 { get; set; }

        public override string ToString()
        {
            return "Подарок";
        }

        public string ToMore() => "Подарка";
        public string ToMoreTwo() => "Подарков";
    }
}
