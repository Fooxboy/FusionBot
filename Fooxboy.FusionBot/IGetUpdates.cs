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

        event Delegates.NewMessage MessageNewEvent;
        event Delegates.NewMessage MessageReplyEvent;
        event Delegates.NewMessage MessageEditEvent;
        event Delegates.MessageAllowOrDeny MessageAllowEvent;
        event Delegates.MessageAllowOrDeny MessageDenyEvent;
    }
}
