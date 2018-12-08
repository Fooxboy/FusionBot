using System;
using System.Collections.Generic;
using System.Text;
using Fooxboy.FusionBot.Models;

namespace Fooxboy.FusionBot
{
    public interface IFusionCommand
    {
        string PrivateName { get; set; }
        string Command { get; set; }
        TypeResponse TypeResponse { get; set; }

        object Execute(MessageVK message);
    }
}
