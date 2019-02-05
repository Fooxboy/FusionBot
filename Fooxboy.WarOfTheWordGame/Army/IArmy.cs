using System;
using System.Collections.Generic;
using System.Text;

namespace Fooxboy.WarOfTheWordGame.Army
{
    public interface IArmy
    {
        int Id { get; }
        string Name { get; }
        int TypeId { get; }
        int Level { get; set; }
        int Hp { get; set; }
        int[] Damage { get; set; }
        int[] Speed { get; set; }
        int[] Recharge { get; set; }
        int TypeShoot { get; set; }
    }
}
