using System;
using System.Collections.Generic;
using System.Text;

namespace Fooxboy.FusionBot.Models
{
    public interface IPayLoadModel
    {
        string Command { get; set; }
        List<string> Arguments { get; set; }
    }
}
