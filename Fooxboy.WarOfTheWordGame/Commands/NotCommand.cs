using Fooxboy.FusionBot;
using Fooxboy.FusionBot.Models;
using Fooxboy.FusionBot.Models.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fooxboy.WarOfTheWordGame.Commands
{
    public class NotCommand : IFusionCommand
    {
        public string PrivateName => "Неверная команда";

        public string Command => "nocommand";

        public TypeResponse TypeResponse => TypeResponse.TextAndButtons;

        public object Execute(MessageVK message)
        {
            var response = new TextAndButtons();
            string text = "Такой команды не существует! Перейдите на главную!";
            response.Keyboard = KeyboardConstructor.ToHome();
            response.Text = text;
            return response;
        }
    }
}
