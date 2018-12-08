using System;
using System.Collections.Generic;
using System.Text;

namespace Fooxboy.FusionBot
{
    public interface IFusionSendMessage
    {
        bool SendText(string text, object to, object from = null);
        bool SendImage(object image, object to, object from, object key = null);
        bool SendImageAndText(object image, string text, object to, object from = null);
    }
}
