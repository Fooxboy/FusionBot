using System;
using System.Collections.Generic;
using System.Text;

namespace Fooxboy.WarOfTheWordGame.Army.Infantry
{
    public class Slavs : IInfantry
    {
        public override int Id => 3;

        public override string Name => "Славяни";

        public override int Level { get; set; } = 1;
        public override int Hp { get; set; } = 0;
        public override int[] Damage { get; set; } = { 0 };
        public override int[] Speed { get; set; } = { 7 };
        public override int[] Recharge { get; set; } = { 6 };
        public override int TypeShoot { get; set; } = 2;
    }
}
