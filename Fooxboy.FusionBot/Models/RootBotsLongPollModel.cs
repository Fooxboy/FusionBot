using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fooxboy.FusionBot.Models
{
    public class RootBotsLongPollModel
    {
        [JsonProperty("ts")]
        public long Ts { get; set; }
        [JsonProperty("updates")]
        public List<Update> Updates { get; set; }

        public class Update
        {
            [JsonProperty("type")]
            public string Type { get; set; }
            [JsonProperty("object")]
            public object @Object { get; set; }
            [JsonProperty("group_id")]
            public long GroupId { get; set; }
        }
    }
}
