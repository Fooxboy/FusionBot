using Fooxboy.FusionBot;
using Fooxboy.FusionBot.Models;
using Fooxboy.FusionBot.Models.Response;
using Fooxboy.FusionBot.VkNetSupport;
using Fooxboy.WarOfTheWordGame.Army;
using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using System.Text;
using VkNet.Enums.SafetyEnums;

namespace Fooxboy.WarOfTheWordGame.Commands.Store
{
    public class Buy
    {
        [Argument("buyArmy")]
        public TextAndButtons BuyArmy(MessageVK msg, object data)
        {
            var response = new TextAndButtons();

            var idArmy = Int64.Parse((string)msg.Payload.Arguments[1]);

            IArmy unit = Globals.Infantry.Where(a => a.Id == idArmy).Single();

            string text = $"Информация о выбранном юните:" +
                $"\n Id: {unit.Id}" +
                $"\n Name: {unit.Name}" +
                $"\n Hp: {unit.Hp}" +
                $"\n Damage: {unit.Damage}" +
                $"\n Level: {unit.Level}" +
                $"\n Speed: {unit.Speed[0]}" +
                $"\n Recharge: {unit.Recharge[0]}" +
                $"\n Price: 0000";
            var keyboardBuilder = new KeyboardBuilder();
            keyboardBuilder.AddButton(ButtonConstructor.ButtonBuyUnit(unit.Id));
            keyboardBuilder.AddLine();
            keyboardBuilder.AddButton(ButtonConstructor.ButtonInfoUnit(unit.Id));
            var keyboard = keyboardBuilder.Build();
            response.Text = text;
            response.Keyboard = keyboard;
            
            return response;
        }

        [Argument("buyAccept")]
        public TextAndButtons BuyAccept(MessageVK msg, object data)
        {
            var response = new TextAndButtons();

            var id = Int32.Parse((string)msg.Payload.Arguments[1]);
            object unit = Globals.Infantry.Where(a => a.Id == id).Single();
            string model = JsonConvert.SerializeObject(unit);

            using (var db = new Databases.UsersDB())
            {
                var army = db.Army.Single(u => u.Id == msg.PeerId);
                army.Select = model;
                army.All = model;
                db.SaveChanges();
            }

            return response;
        }
    }
}
