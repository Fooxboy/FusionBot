using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fooxboy.FusionBot.Models.Attachments
{
    public partial class Graffiti : IAttachment
    {
        [JsonProperty("src")]
        public string Src { get; set; }
        [JsonProperty("width")]
        public string Width { get; set; }
        [JsonProperty("height")]
        public string Height { get; set; }

        public override string ToString()
        {
            return "Граффити";
        }

        public string ToMore() => "Граффити";
        public string ToMoreTwo() => "Граффити";
    }
}
