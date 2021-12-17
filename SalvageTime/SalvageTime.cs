using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Rocket.Core;
using Rocket.API;
using Rocket.Unturned;
using Logger = Rocket.Core.Logging.Logger;
using Rocket.Core.Plugins;
using Rocket.Unturned.Player;

namespace SalvageTime
{
    public class SalvageTime : RocketPlugin<Config>
    {
        protected override void Load()
        {
            Logger.Log("SalvageTime loaded correctly! Haven fun using it, in case of errors contact Arbusto#6794");
            U.Events.OnPlayerConnected += OnPlayerConnect;
        }
        public void OnPlayerConnect(UnturnedPlayer player)
        {
            float salvageTime = Configuration.Instance.SalvageTime;
            player.Player.interact.sendSalvageTimeOverride(salvageTime);
        }
    }
}
