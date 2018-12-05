using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fooxboy.FusionBot.Models.Attachments
{
    public partial class WallReply: IAttachment
    {
        [JsonProperty("id")]
        public long Id { get; set; }
        [JsonProperty("from_id")]
        public long FromId { get; set; }
        [JsonProperty("date")]
        public long Date { get; set; }
        [JsonProperty("text")]
        public string Text { get; set; }
        [JsonProperty("reply_to_user")]
        public long ReplyToUser { get; set; }
        [JsonProperty("reply_to_comment")]
        public long ReplyToComment { get; set; }
        [JsonProperty("attachments")]
        public List<AttachVK> attachments { get; set; }
        [JsonProperty("parents_stack")]
        public List<long> ParentsStack { get; set; }
        [JsonProperty("thread")]
        public ThreadObject Thread { get; set; }

        public override string ToString()
        {
            return "Комментарий на стене";
        }

        public string ToMore() => "Комментария на стене";
        public string ToMoreTwo() => "Комментариев на стене";

        public class ThreadObject
        {
            [JsonProperty("count")]
            public long Count { get; set; }
            [JsonProperty("can_post")]
            public bool CanPost { get; set; }
            [JsonProperty("show_reply_button")]
            public bool ShowReplyButton { get; set; }
            [JsonProperty("groups_can_post")]
            public bool GroupsCanPost { get; set; } 
        }
    }
}
