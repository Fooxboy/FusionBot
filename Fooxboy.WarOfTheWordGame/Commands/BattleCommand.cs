using Fooxboy.FusionBot;
using Fooxboy.FusionBot.Models;
using Fooxboy.FusionBot.Models.Response;
using Fooxboy.FusionBot.VkNetSupport;
using System;
using System.Collections.Generic;
using System.Linq;
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

            bool userWaitGame;
            using (var db = new Databases.UsersDB())
            {

                var userInfo = db.Info.Single(u => u.VKId == message.PeerId);
                userWaitGame = userInfo.WaitBattle;
            }

            if(userWaitGame)
            {
                var textWait = "Вы уже ждете бой. Вы не можете идти в бой. Можете отменить его.";
                long enemyId;
                using (var db = new Databases.UsersDB())
                {
                    var userInfo = db.Info.Single(u => u.VKId == message.PeerId);
                    enemyId = userInfo.WaitId;
                }
                var keyboardBuilderWait = new KeyboardBuilder();
                keyboardBuilderWait.AddButton(ButtonConstructor.ButtonCancelBattle(enemyId));
                var keyboardWait = keyboardBuilderWait.Build();
                response.Text = textWait;
                response.Keyboard = keyboardWait;
                return response;
            }

            //весь остальной код

            var text = "Давай пойдем в бой? Цена боя: ";
            var keyboardBuilder = new KeyboardBuilder();
            keyboardBuilder.AddButton("В бой!", new PayloadBuilder("battle", new List<object>() { "find" }), KeyboardButtonColor.Primary);
            keyboardBuilder.AddLine();
            keyboardBuilder.AddButton("Домой", new PayloadBuilder("home"), KeyboardButtonColor.Default);
            var keyboard = keyboardBuilder.Build();
            response.Keyboard = keyboard;
            response.Text = text;
            return response;
        }
    }
}
