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
            var access_token =  ConfigManager.Manager.AccessToken;
            Globals.AccessToken = access_token;
            Console.Title = "Война миров";
            Console.WriteLine($"Война миров vesion: {ConfigManager.Manager.Version}");
            Console.WriteLine("Начало загрузки бота...");
            //Инициализация ядра.
            var fusion = new Fusion(new FusionBot.BotsLongPoll.Updater(),
                new Commands.NotCommand(),
                new FusionBot.VkNetSupport.MessageSend(Globals.AccessToken));
            //Добавление команд.
            fusion.SetCommands(new Commands.StartCommand(), new Commands.HomeCommand());

            //авторизация Во ВКонтакте.
            var vk = new VkApi();
            vk.Authorize(new ApiAuthParams
            {
                AccessToken = Globals.AccessToken
            });
            Globals.VK = vk;
            fusion.Start(Globals.AccessToken, ConfigManager.Manager.GroupId);

            //Для того, чтобы главный поток работал и не закрыл фоновые.
            Console.ReadLine();
        }
    }
}
