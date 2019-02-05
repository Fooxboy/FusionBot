using System;
using System.Collections.Generic;
using System.Text;

namespace Fooxboy.WarOfTheWordGame.Army.Infantry
{
    public class Cyborgs : IInfantry
    {
        public override int Id => 7;

        public override string Name => "Киборги";

        public override int Level { get; set; } = 1;
        public override int Hp { get; set; } = 0;
        public override int[] Damage { get; set; } = { 0 };
        public override int[] Speed { get; set; } = { 3 };
        public override int[] Recharge { get; set; } = { 3 };
        public override int TypeShoot { get; set; } = 7;
    }
}
