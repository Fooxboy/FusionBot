using System;
using System.Collections.Generic;
using System.Text;
using Fooxboy.FusionBot;
using Fooxboy.FusionBot.Models;
using Fooxboy.FusionBot.Models.Response;
using Fooxboy.FusionBot.VkNetSupport;
using VkNet.Enums.SafetyEnums;

namespace Fooxboy.FusionBotTest
{
    public class StartCommand : IFusionCommand
    {
        public string PrivateName  => "Старт";
        public string Command => "start";
        public TypeResponse TypeResponse => TypeResponse.TextAndButtons;

        public object Execute(MessageVK message)
        {
            Console.WriteLine("тестирование команты start");
            var responseObject = new TextAndButtons();
            var builder = new KeyboardBuilder();
            var builderPayLoad = new PayloadBuilder("test");
            builder.AddButton("Начать тест", builderPayLoad.Build(), KeyboardButtonColor.Primary);
            var buttons = builder.Build();
            responseObject.Keyboard = buttons;
            responseObject.Text = "Тестирование ядра Fooxboy.FusionBot";
            return responseObject;
        }
    }
}
