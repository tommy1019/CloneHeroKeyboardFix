using System;
using BepInEx;
using Rewired;

namespace CloneHeroMod
{
    [BepInPlugin("com.tommysource.plugins.keyboardfix", "Keyboard Fix", "1.0")]
    public class KeyboardFix : BaseUnityPlugin
    {
        private void Start()
        {
            foreach (Player p in ReInput.players.AllPlayers)
            {
                p.controllers.maps.SetAllMapsEnabled(true);
            }
        }
    }
}
