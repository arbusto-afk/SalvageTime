using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Rocket.API;

namespace SalvageTime
{
    public class Config : IRocketPluginConfiguration
    {
        public int SalvageTime;
        public string DiscordSupport;
        public void LoadDefaults()
        {
            SalvageTime = 1;
            DiscordSupport = "Arbusto#6794";
        }
    }
}
