using Fooxboy.FusionBot;
using Fooxboy.FusionBot.Models;
using Fooxboy.FusionBot.VkNetSupport;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fooxboy.WarOfTheWordGame.Commands
{
    public class HomeCommand : IFusionCommand
    {
        public string PrivateName => "Домашний экран";

        public string Command => "home";

        public TypeResponse TypeResponse => TypeResponse.TextAndButtons;

        public object Execute(MessageVK message)
        {
            var text = "Выберите необходимый раздел";
            var keyboardBuilder = new KeyboardBuilder();
            throw new NotImplementedException();
        }
    }
}
