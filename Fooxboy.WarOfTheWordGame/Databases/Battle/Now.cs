using System;
using System.Collections.Generic;
using System.Text;

namespace Fooxboy.WarOfTheWordGame.Databases.Battle
{
    public class Now  
    {



        public long[] Users { get; set; }
        public long BattleId { get; set; }
        public Coordinates[] Coordinates { get; set; }
        public long TimeStart { get; set; }
        public long TimeEnd { get; set; }
    }

    public class Coordinates
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
}
