using System;
using System.Collections.Generic;
using System.Text;

namespace Fooxboy.FusionBot
{
    public static class Globals
    {
        public static List<IFusionCommand> Commands { get; set; }
        public static string TokenGroup { get; set; }
        public static INotCommand NotCommand { get; set; }
        public static IFusionSendMessage Message { get; set; }
    }
}
