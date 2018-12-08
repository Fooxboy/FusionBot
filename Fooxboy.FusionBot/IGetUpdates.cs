using System;
using System.Collections.Generic;
using System.Text;

namespace Fooxboy.FusionBot
{
    public interface IGetUpdates
    {
        /// <summary>
        /// Начало получение обновлений
        /// </summary>
        /// <param name="token">Токен от сообщества ВКонтакте</param>
        /// <param name="GroupId">Индентификатор сообщества ВКонтакте</param>
        void Start(object token, long GroupId);
        /// <summary>
        /// Остановить получение обновлений
        /// </summary>
        void Stop();

        public event Delegates.NewMessage MessageNewEvent;
        public event Delegates.NewMessage MessageReplyEvent;
        public event Delegates.NewMessage MessageEditEvent;
        public event Delegates.MessageAllowOrDeny MessageAllowEvent;
        public event Delegates.MessageAllowOrDeny MessageDenyEvent;
    }
}
