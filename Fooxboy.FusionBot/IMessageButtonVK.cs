using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fooxboy.FusionBot
{
    public interface IMessageButtonVK
    {
        [JsonProperty("action")]
        IMessageActionVK Action { get; set; }
        [JsonProperty("color")]
        string Color { get; set; }
    }
}
