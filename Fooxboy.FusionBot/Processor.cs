using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Fooxboy.FusionBot.Models;

namespace Fooxboy.FusionBot
{
    public static partial class Processor
    {

        public static IFusionCommand FindCommand(string command)=> Globals.Commands.Find(c => c.Command == command);


        public static void StartProcessor(MessageVK message)
        {
            var actionText = String.Empty;
            if (message.Payload == null) actionText = message.Text.Split(' ')[0];
            var command = FindCommand(actionText);
            ExecuteCommand(command, message);
        }

        public static void ExecuteCommand(IFusionCommand command, MessageVK msg)
        {
            if(command.TypeResponse == TypeResponse.Text)
            {
                var result = (string)command.Execute(msg);
                Globals.Message.SendText(result, msg.PeerId, msg.FromId);
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
