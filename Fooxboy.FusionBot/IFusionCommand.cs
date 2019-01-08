using System;
using System.Collections.Generic;
using System.Text;
using Fooxboy.FusionBot.Models;

namespace Fooxboy.FusionBot
{
    public interface IFusionCommand
    {
        string PrivateName { get; }
        string Command { get; }
        TypeResponse TypeResponse { get; }

        object Execute(MessageVK message);
    }
}
