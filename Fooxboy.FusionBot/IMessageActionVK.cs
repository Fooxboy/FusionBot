using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using Fooxboy.FusionBot.Models;

namespace Fooxboy.FusionBot
{
    public interface IMessageActionVK
    {
        [JsonProperty("type")]
        string Type { get; set; }
        [JsonProperty("payload")]
        IPayLoadModel Payoad { get; set; }
        [JsonProperty("label")]
        string Label { get; set; }
    }
}
