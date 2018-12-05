using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fooxboy.FusionBot.Models
{
    public class KeyAndServerModel
    {
        public TsAndKeyModel response { get; set; }
     
        public class TsAndKeyModel
        {
            [JsonProperty("key")]
            public string Key { get; set; }
            [JsonProperty("server")]
            public string Server { get; set; }
            [JsonProperty("ts")]
            public long Ts { get; set; }
        }
    }
}
