using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;

namespace LansNoMoreVanity
{
    class NoMoreVanityGlobalItem : GlobalItem
    {
        public override bool OnPickup(Item item, Player player)
        {
            if (item.vanity)
            {

                return false;
            }

            return true;
        }
    }
}
