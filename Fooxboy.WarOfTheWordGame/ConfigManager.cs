using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Fooxboy.WarOfTheWordGame
{
    public static class ConfigManager
    {
        public static Models.Config Manager => JsonConvert.DeserializeObject<Models.Config>(GetText());

        private static string GetText()
        {
            string text;
            using(var reader = new StreamReader("Config.json"))
            {
                text = reader.ReadToEnd();
            }
            return text;
        }
    }
}
