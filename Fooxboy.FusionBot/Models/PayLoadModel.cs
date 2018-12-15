using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fooxboy.FusionBot.Models
{
    public class PayLoadModel: IPayLoadModel
    {
        [JsonProperty("arguments")]
        public List<string> Arguments { get; set; }
        [JsonProperty("command")]
        public string Command { get; set; }
    }
}
