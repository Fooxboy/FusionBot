using Fooxboy.FusionBot;
using Fooxboy.FusionBot.Models;
using Fooxboy.FusionBot.Models.Response;
using Fooxboy.FusionBot.VkNetSupport;
using System;
using System.Collections.Generic;
using System.Text;
using VkNet.Enums.SafetyEnums;

namespace Fooxboy.WarOfTheWordGame.Commands.Store
{
    public class Categories
    {
        public TextAndButtons Infantry(MessageVK msg, object data)
        {
            var response = new TextAndButtons();

            var keyboardBuilder = new KeyboardBuilder();

            var types = new Dictionary<int, string>();
            types.Add(1, "addfg");
            types.Add(2, "ofjigsd");
            types.Add(3, "2e23346");
            keyboardBuilder.AddButton("ебать смешно", new PayloadBuilder("store", new List<object>() { "infantry" }), KeyboardButtonColor.Primary);

            //TODO: дописать логику.
            return response; 
        }
    }
}
