using Fooxboy.FusionBot.Models.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fooxboy.WarOfTheWordGame
{
    public static class Notifications
    {
        public static void SendNativeMessage(string text, object keyboard, long userId)
        {
            FusionBot.VkNetSupport.MessageSend messageSend = new FusionBot.VkNetSupport.MessageSend(Globals.AccessToken);
            messageSend.SendText(text, userId, keyboard);

        }
    }
}
