using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fooxboy.FusionBot.Models
{
    [Serializable]
    public class PayLoadModel
    {
        public PayLoadModelFusion Fusion { get; set; }
    }

    [Serializable]
    public class PayLoadModelFusion 
    {
        [JsonProperty("arguments")]
        public List<object> Arguments { get; set; }
        [JsonProperty("command")]
        public string Command { get; set; }
    }
}
