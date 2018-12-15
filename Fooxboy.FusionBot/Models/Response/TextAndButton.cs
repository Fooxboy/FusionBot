using System;
using System.Collections.Generic;
using System.Text;

namespace Fooxboy.FusionBot.Models.Response
{
    public class TextAndButtons
    {
        public string Text { get; set; }
        public IMessageKeyboardVK Keyboard { get; set; }
    }
}
