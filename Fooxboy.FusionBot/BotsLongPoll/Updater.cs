using System;
using System.IO;
using System.Net;
using Fooxboy.FusionBot.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Fooxboy.FusionBot.BotsLongPoll
{
    /// <summary>
    /// Главный класс Bots LongPoll
    /// </summary>
    public class Updater : IGetUpdates
    {

        public event Delegates.NewMessage MessageNewEvent;
        public event Delegates.NewMessage MessageReplyEvent;
        public event Delegates.NewMessage MessageEditEvent;
        public event Delegates.MessageAllowOrDeny MessageAllowEvent;
        public event Delegates.MessageAllowOrDeny MessageDenyEvent;

        string _server = String.Empty;
        string _key = String.Empty;
        long _ts = 0;
        bool _isStarted = false; 
        long _currentGroupId = 0;
        public long CurrentTs
        {
            get => _ts;
        }

        string _token = String.Empty;

        /// <summary>
        /// Начать получение обновлений с сервера VK
        /// </summary>
        /// <param name="token">Токен сообщества</param>
        /// <param name="groupId">Индетификатор сообщества</param>
        public void Start(object token, long groupId)
        {
            if (groupId == 0) throw new ArgumentNullException("Невозможно начать получение обновлений. GroupId не может быть 0");
            if (!(token is string)) throw new ArgumentException("Невозможно начать получение обновлений. Token должен быть System.String");
            if (token is null) throw new ArgumentNullException("Невозможно начать получение обновений. Укажите токен сообщества.");
            if (_isStarted) throw new ArgumentException("Невозможно начать получение обновлений. Bots LongPoll уже запущен. Остановите его, вывзвав метод Stop()");

            _currentGroupId = groupId;
            _isStarted = true;
            _token = token as string;

            if (_server != string.Empty || _key != string.Empty) ResetTsAndServer();

            var keyAndTsObject = GetKeyAndTs();

            _server = keyAndTsObject.response.Server;
            _key = keyAndTsObject.response.Key;
            _ts = keyAndTsObject.response.Ts;

            StartedLongPoll();
        }

        /// <summary>
        /// Остановить получение обновлений с сервера VK
        /// </summary>
        public void Stop()
        {
            _isStarted = false;
            ResetTsAndServer();
        }

        void ResetTsAndServer()
        {
            _currentGroupId = 0;
            _server = string.Empty;
            _key = string.Empty;
            _ts = 0;
        }


        private void StartedLongPoll()
        {
            while(_isStarted)
            {
                try
                {

                    var json = Request();
                    if(json != null)
                    {
                        RootBotsLongPollModel responseLongPoll;
                        try
                        {
                            responseLongPoll = JsonConvert.DeserializeObject<RootBotsLongPollModel>(json);
                            _ts = responseLongPoll.Ts;
                        }catch
                        {
                            ResetTsAndServer();
                            var value = GetKeyAndTs();
                            _ts = value.response.Ts;
                            _key = value.response.Key;
                            _server = value.response.Server;
                            responseLongPoll = JsonConvert.DeserializeObject<RootBotsLongPollModel>(json);
                            _ts = responseLongPoll.Ts;
                        }

                        foreach (var update in responseLongPoll.Updates)
                        {
                            var type = update.Type;

                            if (type == "message_new")
                            {
                                var jobj = (JObject)update.Object;
                                var model = jobj.ToObject<MessageVK>();
                                MessageNewEvent?.Invoke(model);
                            }else if(type == "message_reply")
                            {
                                var jobj = (JObject)update.Object;
                                var model = jobj.ToObject<MessageVK>();
                                MessageReplyEvent?.Invoke(model);
                            }else if(type == "message_edit")
                            {
                                var jobj = (JObject)update.Object;
                                var model = jobj.ToObject<MessageVK>();
                                MessageEditEvent?.Invoke(model);
                            }else if(type == "message_allow")
                            {
                                var jobj = (JObject)update.Object;
                                var model = jobj.ToObject<MessageAllowModel>();
                                MessageAllowEvent?.Invoke(model);
                            }else if(type == "message_deny")
                            {
                                var jobj = (JObject)update.Object;
                                var model = jobj.ToObject<MessageAllowModel>();
                                MessageDenyEvent?.Invoke(model);
                            }else
                            {
                                throw new ArgumentException("Другие события, кроме раздела Message ещё не реализованы.");
                            }
                        }
                    }

                }catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        private KeyAndServerModel GetKeyAndTs()
        {
            var json = string.Empty;

            using(var client = new WebClient())
            {
                json = client.DownloadString($"https://api.vk.com/method/groups.getLongPollServer?group_id={_currentGroupId}&access_token={_token}&v=5.92");
            }
            return JsonConvert.DeserializeObject<KeyAndServerModel>(json);
        }

        private string Request()
        {
            var url = $"{_server}?act=a_check&key={_key}&ts={_ts}&wait=20";
            var json = String.Empty;
            var request = HttpWebRequest.Create(url);
            request.Timeout = 30000;
            var response = request.GetResponse();
            using (var stream = response.GetResponseStream())
            {
                using (var reader = new StreamReader(stream))
                {
                    json = reader.ReadToEnd();
                }
            }
            return json;
        }
    }
}
