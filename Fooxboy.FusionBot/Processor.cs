using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Fooxboy.FusionBot.Models;
using Fooxboy.FusionBot.Models.Response;
using Newtonsoft.Json;

namespace Fooxboy.FusionBot
{
    public static partial class Processor
    {
        public static IFusionCommand FindCommand(string command)=> Globals.Commands.Find(c => c.Command.ToLower() == command.ToLower());


        public static void StartProcessor(MessageVK message)
        {
            var actionText = String.Empty;
            if (message.PayloadString == null) actionText = message.Text.Split(' ')[0];
            else
            {
                message.Payload = JsonConvert.DeserializeObject<PayLoadModelFusion>(message.PayloadString);
                actionText = message.Payload.Command;
            }

            var command = FindCommand(actionText);
            if (command is null) command = Globals.NotCommand;
            ExecuteCommand(command, message);
        }

        public static void ExecuteCommand(IFusionCommand command, MessageVK msg)
        {
            if (command.TypeResponse == TypeResponse.Text)
            {
                var result = command.Execute(msg) as String;
                Globals.Message.SendText(result, msg.PeerId);
            }else if(command.TypeResponse == TypeResponse.TextAndButtons)
            {
                var result = command.Execute(msg) as TextAndButtons;
                Globals.Message.SendText(result.Text, msg.FromId, result.Keyboard);
            }else if(command.TypeResponse == TypeResponse.PhotoAndButtons)
            {
                var result = command.Execute(msg) as PhotoAndButtons;
                Globals.Message.SendImage(result.Photo, msg.PeerId, result.Keyboard);

            }else if(command.TypeResponse == TypeResponse.TextAndPhotoAndButtions)
            {
                var result = command.Execute(msg) as TextAndPhotoAndButtons;
                Globals.Message.SendImageAndText(result.Photo, result.Text, msg.PeerId, result.Keyboard);
            }else if(command.TypeResponse == TypeResponse.Photo)
            {
                //TODO: отправка фотографии
            }else if(command.TypeResponse == TypeResponse.TextAndPhoto) 
            {
                //TODO: отправка фотографии с текстом.
            }
        }
    }
}
