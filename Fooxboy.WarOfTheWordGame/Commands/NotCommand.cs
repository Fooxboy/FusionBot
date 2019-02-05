using Fooxboy.FusionBot;
using Fooxboy.FusionBot.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fooxboy.WarOfTheWordGame.Commands
{
    public class NotCommand : IFusionCommand
    {
        public string PrivateName => "Неверная команда";

        public string Command => "nocommand";

        public TypeResponse TypeResponse => TypeResponse.TextAndButtons;

        public object Execute(MessageVK message)
        {
            throw new NotImplementedException();
        }
    }
}
