using Fooxboy.FusionBot;
using Fooxboy.FusionBot.Models;
using Fooxboy.FusionBot.Models.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fooxboy.FusionBotTest
{
    public class TestCommand : IFusionCommand
    {
        public string PrivateName => "Тест";

        public string Command => "test";

        public TypeResponse TypeResponse => TypeResponse.Text;

        public object Execute(MessageVK message)
        {
            return "Тестирование ядра Fooxboy.FusionBot v 0.1 beta Пройдено успешно по следующим модулям:" +
                 "\n 1. Отправка сообщений" +
                 "\n 2. BotLongPoll" +
                 "\n 3. Fusion Command Library (FCL)" +
                 "\n 4. Fusion Message Library (FML)" +
                 "\n 5. Fusion Message Processor (FMP)" +
                 "\n 6. Fusion Message Send Library (FMSL)" +
                 "\n 7. Fusion VkNet Support (FVkSupp)" +
                 "\n 8. Fusion Core Processor (FCP)" +
                 "\n 9. Fusion Get Updates Interface";
        }
    }
}
