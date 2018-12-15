using System;
using System.Collections.Generic;
using System.Text;

namespace Fooxboy.FusionBot
{
    public interface IMessageKeyboardVK
    {
        bool OneTime { get; set; }
        IEnumerable<IEnumerable<IMessageButtonVK>> Buttons { get; set; }
    }
}
