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
    public class BattleLoading
    {
        [Argument("cancelBattle")]
        public TextAndButtons CancelBattle(MessageVK msg, object data)
        {
            var response = new TextAndButtons();

            using (var db = new Databases.UsersDB())
            {
                var userInfo = db.Info.Single(u => u.VKId == msg.PeerId);
                userInfo.WaitBattle = false;
                userInfo.WaitId = 0;
                db.SaveChanges();
            }

            string text = "Вы отменили бой. Противник получил уведомление.";
            var keyboardBuilder = new KeyboardBuilder();
            keyboardBuilder.AddButton(ButtonConstructor.ButtonToHome());
            var keyboard = keyboardBuilder.Build();
            response.Text = text;
            response.Keyboard = keyboard;

            var textEnemy = "Ваш пративник сбежал! И даже не начал бой!";
            var keyboardEnemyBuilder = new KeyboardBuilder();
            keyboardEnemyBuilder.AddButton(ButtonConstructor.ButtonToHome());
            var keyboardEnemy = keyboardEnemyBuilder.Build();
            var enemyId = Int64.Parse((string)msg.Payload.Arguments[1]);
            Notifications.SendNativeMessage(textEnemy, keyboardEnemy, enemyId);
            return response;
        }

        [Argument("acceptEnemy")]
        public TextAndButtons AcceptBattle(MessageVK msg, object data)
        {
            var response = new TextAndButtons();
            return response;
        }


        [Argument("notAcceptEnemy")]
        public TextAndButtons NotAcceptBattle(MessageVK msg, object data)
        {
            var response = new TextAndButtons();
            var text = "Вы не приняли бой от этого пользователя.";
            var keyboard = KeyboardConstructor.ToHome();
            response.Text = text;
            response.Keyboard = keyboard;
            var enemyId = Int64.Parse((string)msg.Payload.Arguments[1]);

            var textEnemy = "Ваш бой не приняли.";
            Notifications.SendNativeMessage(textEnemy, keyboard, enemyId);

            using (var db = new Databases.UsersDB())
            {
                var userInfo = db.Info.Single(u => u.VKId == msg.PeerId);
                userInfo.WaitBattle = false;
                userInfo.WaitId = 0;
                db.SaveChanges();
            }

            return response;
        }
    }
}
