using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Multiplayer.API;
using Verse;

namespace ArmorRacks
{
    [StaticConstructorOnStartup]
    internal static class Multiplayer
    {
        static Multiplayer()
        {
            if (!MP.enabled)
            {
                return;
            }

            MP.RegisterAll();
        }
    }
}
