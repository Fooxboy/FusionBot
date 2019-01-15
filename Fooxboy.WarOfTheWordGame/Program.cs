using Fooxboy.FusionBot;
using System;
using System.Text;
using VkNet;
using VkNet.Model;

namespace Fooxboy.WarOfTheWordGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.Title = "Война миров";
            Console.WriteLine("Начало загрузки бота...");
            //Инициализация ядра.
            var fusion = new Fusion(new FusionBot.BotsLongPoll.Updater(),
                new Commands.NotCommand(),
                new FusionBot.VkNetSupport.MessageSend(Globals.AccessToken));
            //Добавление команд.
            fusion.SetCommands(new Commands.Start());

            //авторизация Во ВКонтакте.
            var vk = new VkApi();
            vk.Authorize(new ApiAuthParams
            {
                AccessToken = Fooxboy.FusionBot.Globals.TokenGroup
            });
            Globals.VK = vk;


            //Для того, чтобы главный поток работал и не закрыл фоновые.
            Console.ReadLine();
        }
    }
}
