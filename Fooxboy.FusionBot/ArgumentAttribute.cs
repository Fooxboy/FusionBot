using System;
using System.Collections.Generic;
using System.Text;

namespace Fooxboy.FusionBot
{
    public class ArgumentAttribute: Attribute
    {

        public string Argument { get; }

        public ArgumentAttribute(string argument)
        {
            this.Argument = argument;
        }
    }
}
