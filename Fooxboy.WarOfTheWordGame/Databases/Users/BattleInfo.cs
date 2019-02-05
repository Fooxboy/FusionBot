using System;
using System.Collections.Generic;
using System.Text;

namespace Fooxboy.WarOfTheWordGame.Databases.Users
{
    public class BattleInfo
    {
        public long UserId { get; set; }
        public long CoordinateX { get; set; }
        public long CoordinateY { get; set; }
        public long TypeArmy { get; set; }
    }
}
