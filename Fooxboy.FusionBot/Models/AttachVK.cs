using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fooxboy.FusionBot.Models
{
    public partial class AttachVK
    {
        [JsonIgnore]
        public Type TypeAttach { get; set; }

        [JsonIgnore]
        public object Instanse { get; set; }

        [JsonIgnore]
        private string _type;

        [JsonProperty(propertyName: "type")]
        public string Type
        {
            get => _type;
            set
            {
                _type = value;
                switch (_type)
                {
                    case "photo":
                        TypeAttach = typeof(Attachments.Photo);
                        break;
                    case "video":
                        TypeAttach = typeof(Attachments.Video);
                        break;
                    case "audio":
                        TypeAttach = typeof(Attachments.Audio);
                        break;
                    case "doc":
                        TypeAttach = typeof(Attachments.Document);
                        break;
                    case "link":
                        TypeAttach = typeof(Attachments.Link);
                        break;
                    case "market":
                        TypeAttach = typeof(Attachments.Market);
                        break;
                    case "market_album":
                        TypeAttach = typeof(Attachments.MarketAlbum);
                        break;
                    case "wall":
                        TypeAttach = typeof(Attachments.Wall);
                        break;
                    case "wall_reply":
                        TypeAttach = typeof(Attachments.WallReply);
                        break;
                    case "sticker":
                        TypeAttach = typeof(Attachments.Sticker);
                        break;
                    case "gift":
                        TypeAttach = typeof(Attachments.Gift);
                        break;
                    case "graffiti":
                        TypeAttach = typeof(Attachments.Graffiti);
                        break;
                    case "audio_message":
                        TypeAttach = typeof(Attachments.AudioMessage);
                        break;
                    default:
                        TypeAttach = typeof(Attachments.Undefined);
                        Instanse = new Attachments.Undefined();
                        break;
                }
            }
        }

        [JsonIgnore]
        private Attachments.Photo _photo;

        [JsonProperty("photo")]
        public Attachments.Photo Photo
        {
            get => _photo;
            set
            {
                if (value == _photo) return;

                _photo = value;
                Instanse = value;
            }
        }
        [JsonIgnore]
        private Attachments.Video _video;

        [JsonProperty(propertyName: "video")]
        public Attachments.Video Video
        {
            get => _video;
            set
            {
                if (value == _video) return;

                _video = value;
                Instanse = value;
            }
        }

        [JsonIgnore]
        private Attachments.Audio _audio;

        [JsonProperty(propertyName: "audio")]
        public Attachments.Audio Audio
        {
            get => _audio;
            set
            {
                if (value == _audio) return;

                _audio = value;
                Instanse = value;
            }
        }
        [JsonIgnore]
        private Attachments.Document _doc;

        [JsonProperty(propertyName: "doc")]
        public Attachments.Document Doc
        {
            get => _doc;
            set
            {
                if (value == _doc) return;

                _doc = value;
                Instanse = value;
            }
        }

        [JsonIgnore]
        private Attachments.Link _link;

        [JsonProperty(propertyName: "link")]
        public Attachments.Link Link
        {
            get => _link;
            set
            {
                if (value == _link) return;

                _link = value;
                Instanse = value;
            }
        }

        [JsonIgnore]
        private Attachments.Market _market;

        [JsonProperty(propertyName: "market")]
        public Attachments.Market Market
        {
            get => _market;
            set
            {
                if (value == _market) return;

                _market = value;
                Instanse = value;
            }
        }

        [JsonIgnore]
        private Attachments.MarketAlbum _market_album;

        [JsonProperty(propertyName: "market_album")]
        public Attachments.MarketAlbum MarketAlbum
        {
            get => _market_album;
            set
            {
                if (_market_album == value) return;

                _market_album = value;

                Instanse = value;
            }
        }

        [JsonIgnore]
        private Attachments.Wall _wall;

        [JsonProperty(propertyName: "wall")]
        public Attachments.Wall Wall
        {
            get => _wall;
            set
            {
                if (value == _wall) return;

                _wall = value;
                Instanse = value;
            }
        }

        [JsonIgnore]
        private Attachments.WallReply _wall_reply;

        [JsonProperty(propertyName: "wall_reply")]
        public Attachments.WallReply WallReply
        {
            get => _wall_reply;
            set
            {
                if (value == _wall_reply) return;

                _wall_reply = value;
                Instanse = value;
            }
        }

        [JsonIgnore]
        private Attachments.Sticker _sticker;

        [JsonProperty(propertyName: "sticker")]
        public Attachments.Sticker Sticker
        {
            get => _sticker;
            set
            {
                if (value == _sticker) return;

                _sticker = value;
                Instanse = value;
            }
        }

        [JsonIgnore]
        private Attachments.Gift _gift;

        [JsonProperty(propertyName: "gift")]
        public Attachments.Gift Gift
        {
            get => _gift;
            set
            {
                if (value == _gift) return;

                _gift = value;
                Instanse = value;
            }
        }

        [JsonIgnore]
        private Attachments.Graffiti _graffiti;

        [JsonProperty(propertyName: "graffiti")]
        public Attachments.Graffiti Graffiti
        {
            get => _graffiti;
            set
            {
                if (value == _graffiti) return;

                _graffiti = value;
                Instanse = value;
            }
        }

        [JsonIgnore]
        private Attachments.AudioMessage _audioMessage;

        [JsonProperty(propertyName: "audio_message")]
        public Attachments.AudioMessage AudioMessage
        {
            get => _audioMessage;
            set
            {
                if (value == _audioMessage) return;

                _audioMessage = value;
                Instanse = value;
            }
        }
    }
}
