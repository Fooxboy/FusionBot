using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fooxboy.WarOfTheWordGame.Databases
{
    public class UsersDB :DbContext
    {
        public DbSet<Users.Info> Info { get; set; }
        public DbSet<Users.Now> Now { get; set; }
        public DbSet<Users.BattleInfo> BattleInfo { get; set; }
        public DbSet<Users.Army> Army { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=users.db");
        }
    }
}
