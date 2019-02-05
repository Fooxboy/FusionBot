using System;
using System.Collections.Generic;
using System.Text;

namespace Fooxboy.WarOfTheWordGame.Army.Infantry
{
    public class Aborigines : IInfantry
    {
        public override int Id => 1;
        public override string Name => "Аборигены";
        public override int Level { get; set; } = 1;
        public override int Hp { get; set; } = 0;
        public override int[] Damage { get; set; } = { 1 };
        public override int[] Speed { get; set; } = { 8 };
        public override int[] Recharge { get; set; } = { 10 };
        public override int TypeShoot { get; set; } = 1;
    }
}
