using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fooxboy.FusionBot.Models
{
    public class MessageAllowModel
    {
        [JsonProperty("user_id")]
        public long UserId { get; set; }
        [JsonProperty("key")]
        public string Key { get; set; }
    }
}
