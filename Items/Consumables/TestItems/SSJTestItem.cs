﻿﻿using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace DBZMOD.Items.Consumables.TestItems
{
    public class SSJTestItem : ModItem
    {
        public override void SetDefaults()
        {
            item.width = 40;
            item.height = 40;
            item.consumable = true;
            item.maxStack = 1;
            item.UseSound = SoundID.Item3;
            item.useStyle = 2;
            item.useTurn = true;
            item.useAnimation = 17;
            item.useTime = 17;
            item.value = 0;
            item.expert = true;
            item.potion = false;
        }

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("SSJ Test Item");
            Tooltip.SetDefault("Manually activates the ssj transformation cutscene and unlocks it.");
        }


        public override bool UseItem(Player player)
        {
            MyPlayer.ModPlayer(player).SSJTransformation();
            UI.TransMenu.MenuSelection = 1;
            MyPlayer.ModPlayer(player).SSJ1Achieved = true;
            MyPlayer.ModPlayer(player).IsTransformingSSJ1 = true;
            return true;

        }
    }
}
