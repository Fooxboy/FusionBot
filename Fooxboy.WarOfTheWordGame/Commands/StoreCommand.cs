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
    public class StoreCommand : IFusionCommand
    {
        public string PrivateName => "Магазин";

        public string Command => "store";

        public TypeResponse TypeResponse => TypeResponse.TextAndButtons;

        public object Execute(MessageVK message)
        { 
            TextAndButtons response = new TextAndButtons();
            //поддержка аргументов
            var responseArguments = ArgumentsSupport.FindMethod(message.Payload.Arguments, "Fooxboy.WarOfTheWordGame.Commands.Store", message, null);
            if (responseArguments != null) return responseArguments;

            var keyboardBuilder = new KeyboardBuilder();
            keyboardBuilder.AddButton("Пехота", new PayloadBuilder("store", new List<object>() { "infantry" }), KeyboardButtonColor.Primary);
            keyboardBuilder.AddLine();
            keyboardBuilder.AddButton("Танки", new PayloadBuilder("store", new List<object>() { "tanks" }), KeyboardButtonColor.Default);
            keyboardBuilder.AddLine();
            keyboardBuilder.AddButton("Корабли", new PayloadBuilder("store", new List<object>() { "ships" }), KeyboardButtonColor.Default);
            keyboardBuilder.AddLine();
            keyboardBuilder.AddButton("Самолеты", new PayloadBuilder("store", new List<object>() { "aircraft" }), KeyboardButtonColor.Default);
            keyboardBuilder.AddLine();
            keyboardBuilder.AddButton("Скины", new PayloadBuilder("store", new List<object>() { "skins" }), KeyboardButtonColor.Default);
            keyboardBuilder.AddLine();
            keyboardBuilder.AddButton("ДЕНЬГИ", new PayloadBuilder("store", new List<object>() { "donate" }), KeyboardButtonColor.Default);
            var keyboard = keyboardBuilder.Build();
            response.Text = "Выбери необходимый раздел";
            response.Keyboard = keyboard;

            return response;
        }
    }
}
