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
    public class Find
    {
        [Argument("find")]
        public TextAndButtons FindStart(MessageVK msg, object data)
        {
            var response = new TextAndButtons();
            long userLevel;
            long userExp;
            using (var db = new Databases.UsersDB())
            {

                var userInfo = db.Info.Single(u => u.VKId == msg.PeerId);
                userLevel = userInfo.Level;
                userExp = userInfo.Experience;
            }

            List<Databases.Users.Info> users = null;
            //начало поиска по уровню.
            for (int i = 0; i > 4; i++)
            {
                users = FindUsers(i, userLevel);
                if (users != null) break;
                
            }

            if (users == null) ; //возвращаем инфу, что мы не нашли вам противника

            //Если мы нашли..

            var user = users.FirstOrDefault();
            var text = $"Система нашла Вам противника: " +
                $"\n Имя: {user.Name}" +
                $"\n Уровень: {user.Level}" +
                $"\n Последнее раз был в сети: {user.LastSeen}" +
                $"\n Нажмите \"В бой\", чтобы начать игру.";

            var keyboardBuilder = new KeyboardBuilder();
            keyboardBuilder.AddButton(ButtonConstructor.ButtonToBattle(user.VKId));
            keyboardBuilder.AddLine();
            keyboardBuilder.AddButton(ButtonConstructor.ButtonToHome());
            var keyboard = keyboardBuilder.Build();
            response.Keyboard = keyboard;
            response.Text = text;

            return response;
        }


        private List<Databases.Users.Info> FindUsers(int i, long userLevel)
        {
            List<Databases.Users.Info> users;
            using (var db = new Databases.UsersDB())
            {
                var dateTimeNowUTC = DateTimeOffset.Now.ToUnixTimeSeconds();
                
                if(i < 3)
                {
                    users = db.Info.Where(u => u.Level == userLevel + i && !(u.LastSeen < (dateTimeNowUTC - 1800))).ToList();
                }if( i > 2)
                {
                    i = i-1;
                    users = db.Info.Where(u => u.Level == userLevel + i && !(u.LastSeen < (dateTimeNowUTC - 1800))).ToList();
                }else
                {
                    return null;
                }

                if (users.Count == 0) return null;

                return users;
            }
        }
    }
}
