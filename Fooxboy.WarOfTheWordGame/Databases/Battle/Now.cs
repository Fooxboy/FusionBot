using System;
using System.Collections.Generic;
using System.Text;

namespace Fooxboy.WarOfTheWordGame.Databases.Battle
{
    public class Now  
    {

        public long UserOne { get; set; }
        public long UserTwo { get; set; }
        public long BattleId { get; set; }
        public long TimeStart { get; set; }
        public long TimeEnd { get; set; }
    }

    public class Coordinates
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
}
