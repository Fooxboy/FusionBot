using System;
using System.Collections.Generic;
using System.Text;
using VkNet;
using Fooxboy.WarOfTheWordGame.Army.Infantry;

namespace Fooxboy.WarOfTheWordGame
{
    public static class Globals
    {
        public static VkApi VK { get; set; }
        public static string AccessToken { get; set; }

        public static List<IInfantry> Infantry
        {
            get
            {
                return new List<IInfantry>()
                {
                    new Aborigines(),
                    new Androids(),
                    new Archers(),
                    new Cyborgs(),
                    new Indians(),
                    new Knights(),
                    new Samurai(),
                    new Slavs(),
                    new Soldiers()
                };
            }
        }
    }
}
