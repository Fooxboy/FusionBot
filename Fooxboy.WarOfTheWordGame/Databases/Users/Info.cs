using System;
using System.Collections.Generic;
using System.Text;

namespace Fooxboy.WarOfTheWordGame.Databases.Users
{
    public class Info
    {
        public long VKId { get; set; }
        public long Level { get; set; }
        public long Experience { get; set; }
        public string Name { get; set; }
        public string BirthDate { get; set; }
        public long RegisterDate { get; set; }
        public long BattleId { get; set; }
        public long Money { get; set; }
        public long GoldMoney { get; set; }
    }
}
