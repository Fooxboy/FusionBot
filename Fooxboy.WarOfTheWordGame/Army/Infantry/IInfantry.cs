using System;
using System.Collections.Generic;
using System.Text;

namespace Fooxboy.WarOfTheWordGame.Army.Infantry
{
    public abstract class IInfantry : IArmy
    {
        public abstract int Id { get; }
        public abstract string Name { get; }
        public int TypeId { get;  } = 1;
        public abstract int Level { get; set; }
        public abstract int Hp { get; set; }
        public abstract int[] Damage { get; set; }
        public abstract int[] Speed { get; set; }
        public abstract int[] Recharge { get; set; }
        public abstract int TypeShoot { get; set; }
    }
}
