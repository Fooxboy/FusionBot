using Fooxboy.FusionBot;
using Fooxboy.FusionBot.Models;
using Fooxboy.FusionBot.Models.Response;
using System;
using System.Collections.Generic;
using System.Text;
using VkNet.Enums.Filters;
using Fooxboy.FusionBot.VkNetSupport;
using VkNet.Enums.SafetyEnums;
using System.Linq;

namespace Fooxboy.WarOfTheWordGame.Commands
{
    public class StartCommand : IFusionCommand
    {
        public string PrivateName => "Старт";

        public string Command => "start";

        public TypeResponse TypeResponse => TypeResponse.TextAndButtons;


        public object Execute(MessageVK message)
        {
            var response = new TextAndButtons();

            //старая версия
            //поддержка аргументов
            var payload = message.Payload;
            if (payload.Arguments != null || payload.Arguments.Count != 0)
            {
                var arguments = payload.Arguments;
                if ((string)arguments[0] == "description")
                {
                    return GetDescription((string)arguments[1], message);
                }
            }

            //регистрация пользователя.
            var user = Globals.VK.Users.Get(new List<long>() { message.PeerId }, (ProfileFields.FirstName | ProfileFields.BirthDate));
            using (var db = new Databases.UsersDB())
            {
               
                db.Info.Add(new Databases.Users.Info() { VKId = message.PeerId, BirthDate = user[0].BirthDate, Name = user[0].FirstName, RegisterDate = DateTime.Now.ToFileTimeUtc(), BattleId = 0 });
                db.Now.Add(new Databases.Users.Now() {UserId = message.PeerId, Arguments= "null", Command = "null" });
                db.Army.Add(new Databases.Users.Army() { Id = message.PeerId, All = "a", Select = "a" });
                db.SaveChanges();
            }

            string text = "Поздравляю! Вы прошли регестрацию в игре! Хотите ли узнать подробнее о игре и её принципах?";
            var keyboardBuilder = new KeyboardBuilder().AddButton("Хочу узнать!", new PayloadBuilder("start", new List<object>() { "description", "1" }).Build(), KeyboardButtonColor.Positive);
            keyboardBuilder.AddLine();
            keyboardBuilder.AddButton("Я все знаю :)", new PayloadBuilder("home", new List<object>() {"new_user"}).Build(), KeyboardButtonColor.Negative);
            var keyboard = keyboardBuilder.Build();
            response.Keyboard = keyboard;
            response.Text = text;
            return response;
        }

        public TextAndButtons GetDescription(string page, MessageVK msg)
        {
            var response = new TextAndButtons();

            string text;
            //получение значения с максимальным значением страниц.
            int maxPage = 10;
            VkNet.Model.Keyboard.MessageKeyboard keyboard;
            if(Int32.Parse(page) < maxPage)
            {
                //получение текста
                text = "";
                var keyboardBuilder = new KeyboardBuilder().AddButton("Дальше!", new PayloadBuilder("start", new List<object>() { "description", (Int32.Parse(page) +1).ToString() }).Build(), KeyboardButtonColor.Primary);
                keyboard = keyboardBuilder.Build();
            }else
            {
                text = "Ну вот и все! Давай теперь пойдем на главный экран.";
                var keyboardBuilder = new KeyboardBuilder().AddButton("Пошли!", new PayloadBuilder("home", new List<object>() { "new_user"}).Build(), KeyboardButtonColor.Primary);
                keyboard = keyboardBuilder.Build();
            }

            response.Text = text;
            response.Keyboard = keyboard;
            return response;
        }
    }
}
