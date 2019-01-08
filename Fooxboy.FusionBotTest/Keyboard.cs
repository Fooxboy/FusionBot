using System;
using System.Collections.Generic;
using System.Text;
using Fooxboy.FusionBot;
using Fooxboy.FusionBot.Models;

namespace Fooxboy.FusionBotTest
{
    public class Keyboard: IMessageKeyboardVK
    {
        public bool OneTime { get; set; }
        public IEnumerable<IEnumerable<IMessageButtonVK>> Buttons { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }

    public class Buttons : IMessageButtonVK
    {
        public IMessageActionVK Action { get; set; }
        public string Color { get; set; }
    }

    public class ActionButton : IMessageActionVK
    {
        public string Type { get; set; }
        public IPayLoadModel Payoad { get; set; }
        public string Label { get; set; }
    }
}
