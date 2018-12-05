using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fooxboy.FusionBot.Models
{
    public partial class MessageVK
    {
        [JsonProperty("id")]
        public long Id { get; set; }
        [JsonProperty("date")]
        public long Date { get; set; }
        [JsonProperty("peer_id")]
        public long PeerId { get; set; }
        [JsonProperty("ref")]
        public string Ref { get; set; }
        [JsonProperty("ref_source")]
        public string RefSource { get; set }
        [JsonProperty("from_id")]
        public long FromId { get; set; }
        [JsonProperty("text")]
        public string Text { get; set; }
        [JsonProperty("random_id")]
        public long RandomId { get; set; }
        [JsonProperty("attachments")]
        public List<AttachVK> Attachments { get; set; }
        [JsonProperty("important")]
        public bool Important { get; set; }
        //public Geo geo { get; set; }
        [JsonProperty("payload")]
        public string Payload { get; set; }
        [JsonProperty("fwd_messages")]
        public List<MessageVK> ForwardMessages { get; set; }
        [JsonProperty("action")]
        public ActionChatVK Action { get; set; }
    }
}
