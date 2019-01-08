using System;
using Fooxboy.FusionBot;
using Fooxboy.FusionBot.BotsLongPoll;
using VkNet;
using VkNet.Model;
using VkNet.Model.Keyboard;

namespace Fooxboy.FusionBotTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            IGetUpdates upd = new Updater();
            var fusion = new Fusion(upd, new NotCommand(), new SendMessage());
            fusion.SetCommands( new StartCommand(), new TestCommand());
            fusion.Start("89d513f60f1f26a711a376720a9dba0149ab2a283941b83fc1753c0a9fd54b2350be6ada97a44ee083de1", 161965172);

            Console.ReadLine();
        }
    }

    public class NotCommand : INotCommand
    {
        public void Action(string nameCommand)
        {
            Console.Write("Команды {0} несуществует", nameCommand);
        }
    }

    public class SendMessage : IFusionSendMessage
    {

        public static VkApi vk = new VkApi();

        public SendMessage()
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
                AccessToken = "89d513f60f1f26a711a376720a9dba0149ab2a283941b83fc1753c0a9fd54b2350be6ada97a44ee083de1"
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
