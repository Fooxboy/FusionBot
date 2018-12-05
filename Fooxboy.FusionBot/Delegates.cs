using System;
using System.Collections.Generic;
using System.Text;

namespace Fooxboy.FusionBot
{
    public class Delegates
    {
        public delegate void NewMessage(Models.MessageVK message);
        public delegate void MessageAllowOrDeny(Models.MessageAllowModel model);
    }
}
