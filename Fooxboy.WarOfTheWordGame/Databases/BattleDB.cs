using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fooxboy.WarOfTheWordGame.Databases
{
    public class BattleDB :DbContext
    {

        DbSet<Battle.Now> Now { get; set; }
        DbSet<Battle.History> History { get; set; }
    }
}
