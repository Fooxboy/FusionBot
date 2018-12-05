using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fooxboy.FusionBot.Models.Attachments
{
    public partial class AudioMessage : IAttachment
    {
        [JsonProperty("duration")]
        public int Duration { get; set; }
        [JsonProperty("waveform")]
        public List<int> Waveform { get; set; }
        [JsonProperty("link_ogg")]
        public string LinkOgg { get; set; }
        [JsonProperty("link_mp3")]
        public string LinkMp3 { get; set; }

        public override string ToString()
        {
            return "Голосовое сообщение";
        }

        public string ToMore() => "Голосовых сообщения";
        public string ToMoreTwo() => "Голосовых сообщений";
    }
}
