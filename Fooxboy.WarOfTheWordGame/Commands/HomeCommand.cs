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
    public class HomeCommand : IFusionCommand
    {
        public string PrivateName => "Домашний экран";

        public string Command => "home";

        public TypeResponse TypeResponse => TypeResponse.TextAndButtons;

        public object Execute(MessageVK message)
        {
            var response = new TextAndButtons();
            var text = "Выберите необходимый раздел";
            var keyboardBuilder = new KeyboardBuilder();
            keyboardBuilder.AddButton("В бой", PayloadBuilder.BuildStatic("battle"), KeyboardButtonColor.Primary);
            keyboardBuilder.AddLine();
            keyboardBuilder.AddButton("Магазин", PayloadBuilder.BuildStatic("store"), KeyboardButtonColor.Default);
            var keyboard = keyboardBuilder.Build();
            response.Keyboard = keyboard;
            response.Text = text;
            return response;
        }
    }
}
