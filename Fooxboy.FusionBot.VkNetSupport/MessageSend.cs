using System;
using System.Collections.Generic;
using System.Text;
using VkNet;
using VkNet.Model;
using VkNet.Model.Keyboard;

namespace Fooxboy.FusionBot.VkNetSupport
{
    public class MessageSend : IFusionSendMessage
    {
        public static VkApi vk = new VkApi();

        public MessageSend(string token)
        {
        }

        public bool SendImage(object image, object to, object keyboard = null, object from = null, object key = null)
        {
            throw new NotImplementedException();
        }

        public bool SendImageAndText(object image, string text, object to, object keyboard = null, object from = null)
        {
            throw new NotImplementedException();
        }

        public bool SendText(string text, object to, object keyboard = null, object from = null)
        {
            vk.Authorize(new ApiAuthParams
            {
                AccessToken = Fooxboy.FusionBot.Globals.TokenGroup
            });

            vk.Messages.Send(new VkNet.Model.RequestParams.MessagesSendParams
            {
                PeerId = Convert.ToInt64(to),
                Message = text,
                Keyboard = (MessageKeyboard)keyboard
            });

            return true;
        }
    }
}
