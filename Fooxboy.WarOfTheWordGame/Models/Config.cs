using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fooxboy.WarOfTheWordGame.Models
{
    public class Config
    {
        [JsonProperty("version")]
        public string Version { get; set; } 
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }
        [JsonProperty("group_id")]
        public long GroupId { get; set; }
    }
}
