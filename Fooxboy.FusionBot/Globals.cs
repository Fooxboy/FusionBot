using System;
using System.Collections.Generic;
using System.Text;

namespace Fooxboy.FusionBot
{
    public static class Globals
    {
        public static List<IFusionCommand> Commands { get; set; }
        public static string TokenGroup { get; set; }
        public static IFusionCommand NotCommand { get; set; }
        public static IFusionSendMessage Message { get; set; }
        public static IConvertKeybordVK ConvertKeyboard { get; set; }
    }
}
