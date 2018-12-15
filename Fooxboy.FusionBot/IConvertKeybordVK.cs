using System;
using System.Collections.Generic;
using System.Text;

namespace Fooxboy.FusionBot
{
    public interface IConvertKeybordVK
    {
        T Convert<T>(IMessageKeyboardVK keybord);
    }
}
