using Fooxboy.FusionBot;
using Fooxboy.FusionBot.Models;
using Fooxboy.FusionBot.Models.Response;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using Fooxboy.FusionBot.VkNetSupport;

namespace Fooxboy.WarOfTheWordGame.Commands.Battle
{
    public class ToBattle
    {
        [Argument("toBattle")]
        public TextAndButtons WaitBattle(MessageVK msg, object data)
        {
            var response = new TextAndButtons();
            var enemyId = Int64.Parse((string)msg.Payload.Arguments[1]);
            using (var db = new Databases.UsersDB())
            {
                var userInfo = db.Info.Single(u => u.VKId == msg.PeerId);
                userInfo.WaitBattle = true;
                userInfo.WaitId = enemyId; 
                db.SaveChanges();
            }

           
            string textEnemy = "Привет! Тебя вызывает противник на бой!";
            var keyboardEnemyBuilder = new KeyboardBuilder();
            keyboardEnemyBuilder.AddButton(ButtonConstructor.ButtonEmenyAcceptBattle(msg.PeerId));
            keyboardEnemyBuilder.AddLine();
            keyboardEnemyBuilder.AddButton(ButtonConstructor.ButtonEmenyNotAcceptBattle(msg.PeerId));
            var keyboardEnemy = keyboardEnemyBuilder.Build();
            Notifications.SendNativeMessage(textEnemy, keyboardEnemy, enemyId);


            var keyboardBuilder = new KeyboardBuilder();
            keyboardBuilder.AddButton(ButtonConstructor.ButtonCancelBattle(enemyId));
            var keyboard = keyboardBuilder.Build();

            var text = "Мы ждем противника. Противнику уже отправлен запрос о бое." +
                "\n Вы можете отменить бой, если устали ждать.";
            response.Keyboard = keyboard;
            response.Text = text;
            return response;
        }

    }
}
