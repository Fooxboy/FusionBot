
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fooxboy.FusionBot.Models.Attachments
{
    public partial class Wall: IAttachment
    {
        [JsonProperty("id")]
        public long Id { get; set; }
        [JsonProperty("to_id")]
        public long ToId { get; set; }
        [JsonProperty("from_id")]
        public long FromId { get; set; }
        [JsonProperty("created_by")]
        public long CreatedBy { get; set; }
        [JsonProperty("date")]
        public long Date { get; set; }
        [JsonProperty("text")]
        public string Text { get; set; }
        [JsonProperty("reply_owner_id")]
        public long ReplyOwnerId { get; set; }
        [JsonProperty("reply_post_id")]
        public long ReplyPostId { get; set; }
        [JsonProperty("friends_only")]
        public int FriendsOnly { get; set; }
        [JsonProperty("comments")]
        public object Comments { get; set; }
        [JsonProperty("likes")]
        public object Likes { get; set; }
        [JsonProperty("reposts")]
        public object Reposts { get; set; }
        [JsonProperty("views")]
        public object Views { get; set; }
        [JsonProperty("post_type")]
        public string PostType { get; set; }
        [JsonProperty("post_source")]
        public object PostSource { get; set; }
        [JsonProperty("attachments")]
        public List<AttachVK> attachments { get; set; }
        //public Geo geo { get; set; }
        [JsonProperty("signer_id")]
        public long SignerId { get; set; }
        [JsonProperty("copy_history")]
        public List<Wall> CopyHistory { get; set; }
        [JsonProperty("can_pin")]
        public int CanPin { get; set; }
        [JsonProperty("can_delete")]
        public int CanDelete { get; set; }
        [JsonProperty("can_edit")]
        public int CanEdit { get; set; }
        [JsonProperty("is_pinned")]
        public int IsPinned { get; set; }
        [JsonProperty("marked_as_ads")]
        public int MarkedAsAds { get; set; }
        [JsonProperty("can_close")]
        public bool CanClose { get; set; }
        [JsonProperty("can_open")]
        public bool CanOpen { get; set; }

        public override string ToString()
        {
            return "Запись на стене";
        }

        public string ToMore() => "Записи на стене";
        public string ToMoreTwo() => "Записей на стене";
    }
}
