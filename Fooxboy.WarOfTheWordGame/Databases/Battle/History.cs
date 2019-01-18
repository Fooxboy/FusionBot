using System;
using System.Collections.Generic;
using System.Text;

namespace Fooxboy.WarOfTheWordGame.Databases.Battle
{
    public class History
    {
        public long[] Users { get; set; }
        public long Winner { get; set; }
        public long Time { get; set; }
        public long[] Money { get; set; }
    }
}
