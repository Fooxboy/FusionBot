using Fooxboy.FusionBot;
using Fooxboy.FusionBot.Models;
using Fooxboy.FusionBot.Models.Response;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using Fooxboy.FusionBot.VkNetSupport;


namespace Fooxboy.WarOfTheWordGame
{
    public static class KeyboardConstructor
    {
        public static VkNet.Model.Keyboard.MessageKeyboard ToHome()
        {
            var keyboardBuilder = new KeyboardBuilder();
            keyboardBuilder.AddButton(ButtonConstructor.ButtonToHome());
            var keyboard = keyboardBuilder.Build();
            return keyboard;
        } 
    }
}
