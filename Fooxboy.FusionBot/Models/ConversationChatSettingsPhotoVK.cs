using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fooxboy.FusionBot.Models
{
    public partial class ConversationChatSettingsPhotoVK
    {
        [JsonProperty("photo_50")]
        public string Photo50 { get; set; }
        [JsonProperty("photo_100")]
        public string Photo100 { get; set; }
        [JsonProperty("photo_200")]
        public string Photo200 { get; set; }
    }
}
