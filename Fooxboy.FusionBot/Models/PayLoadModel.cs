using System;
using System.Collections.Generic;
using System.Text;

namespace Fooxboy.FusionBot.Models
{
    public class PayLoadModel: IPayLoadModel
    {
        public string Object { get; set; }
        public List<string> Arguments { get; set; }
    }
}
