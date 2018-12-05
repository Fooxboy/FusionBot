using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fooxboy.FusionBot.Models
{
    public partial class ActionChatVK
    {
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("member_id")]
        public long MemberId { get; set; }
        [JsonProperty("text")]
        public string Text { get; set; }
        [JsonProperty("email")]
        public string Email { get; set; }
        [JsonProperty("photo")]
        public ConversationChatSettingsPhotoVK photo { get; set; }
    }
}
