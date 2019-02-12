using Fooxboy.FusionBot;
using Fooxboy.FusionBot.Models;
using Fooxboy.FusionBot.Models.Response;
using Fooxboy.FusionBot.VkNetSupport;
using Fooxboy.WarOfTheWordGame.Army.Infantry;
using System;
using System.Collections.Generic;
using System.Text;
using VkNet.Enums.SafetyEnums;

namespace Fooxboy.WarOfTheWordGame.Commands.Store
{
    public class Categories
    {
        [Argument("infantry")]
        public TextAndButtons Infantry(MessageVK msg, object data)
        {
            var response = new TextAndButtons();

            var infantry = Globals.Infantry;
            

            var keyboardBuilder = new KeyboardBuilder();

            int buffer = 0;
            foreach(var inf in infantry)
            {
                if(buffer == 2)
                {
                    keyboardBuilder.AddLine();
                    buffer = 0;
                }
                keyboardBuilder.AddButton(inf.Name, PayloadBuilder.BuildStatic("store", new List<object>() { "buyArmy", inf.Id.ToString()}), KeyboardButtonColor.Default);
                buffer++;
            }

            response.Keyboard = keyboardBuilder.Build();
            response.Text = "Выбери необходимого бойца!";

            return response; 
        }
    }
}
