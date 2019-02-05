using Fooxboy.FusionBot;
using Fooxboy.FusionBot.Models;
using Fooxboy.FusionBot.Models.Response;
using Fooxboy.FusionBot.VkNetSupport;
using System;
using System.Collections.Generic;
using System.Text;
using VkNet.Enums.SafetyEnums;

namespace Fooxboy.WarOfTheWordGame.Commands
{
    public class BattleCommand : IFusionCommand
    {
        public string PrivateName => "Бои";

        public string Command => "battle";

        public TypeResponse TypeResponse => TypeResponse.TextAndButtons;

        public object Execute(MessageVK message)
        {
            TextAndButtons response = new TextAndButtons();
            //поддержка аргументов
            var responseArguments = ArgumentsSupport.FindMethod(message.Payload.Arguments, "Fooxboy.WarOfTheWordGame.Commands.Battle", message, null);
            if (responseArguments != null) return responseArguments;

            //весь остальной код

            var text = "Давай пойдем в бой? Цена боя: ";
            var keyboardBuilder = new KeyboardBuilder();
            keyboardBuilder.AddButton("В бой!", new PayloadBuilder("battle", new List<object>() { "find" }), KeyboardButtonColor.Primary);
            keyboardBuilder.AddLine();
            keyboardBuilder.AddButton("В бой!", new PayloadBuilder("home"), KeyboardButtonColor.Primary);
            var keyboard = keyboardBuilder.Build();
            response.Keyboard = keyboard;
            response.Text = text;
            return response;
        }
    }
}
