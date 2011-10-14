/*
 * Copyright (C) 2011 mooege project
 *
 * This program is free software; you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation; either version 2 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program; if not, write to the Free Software
 * Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA
 */

/*
 * 
 * 
field1 = 0 -> char goes -> 0 again crashes client
(field2 = 7 ??)

field1 = 1 -> char goes dark -> does not work again

2 ??
3 ??
4 ??

field1 = 5 -> gold pickup? (gold glow)
field1 = 6 -> levelup
field1 = 7 -> hp pickup? (red bubbles glow)
field1 = 8 -> violette glow
field1 = 9 -> yellow/black glow above the char
field1 = 10 -> lots of small yellow glows that go toward the char

11 ??
12 ??

field1 = 13 -> small violette square in middle of actor (keeps fading in/out) that stays where the char went
field1 = 17 -> that item cannot be picked up
18 -> you have no place to put that item
19 -> you are not allowed to have more than one of this item
20 -> that item belongs to someone else and cannot be picked up

23 ??

27 -> white cloud, stays at pos
28 -> blue cloud
29 -> blue flash / big glow
32 -> level up effect (gold flash) (needs field2 fe 85195)

33 ??

37 -> energy globe flashes

40 -> death ? big gore flesh explosion
41 -> death ? big fire flesh explosion
42 -> death ? big green flesh explo
43 -> death ? big biolette flesh explo
44 -> death ? big explo with symbols
45 -> death ? lightning explo
46 -> death ? icey explo
47 -> death ? HUGE flesh blood explo

48 -> char goes dark
49 -> char gets blood veins over the body ?
50 -> char goes violette
52 -> char goes black
53 -> char goes blue
55 -> char goes black diff texture
56 -> char goes green

61 ??

62 -> mana pickup ? (blue bubbles glow)

67 -> char vanishes completely! -> 50 does not make it come back -> char possibly under ground ...

68 -> crashes client

70 -> checkpoint reached message

71 -> crashes client
72 -> crashes client
73 -> crashes client
74 -> crashes client
+ -> crashes client
 * 
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mooege.Core.GS.Effects
{
    public static class ActorEffects
    {
        public static enum Hero
        {
            PickupGold = 5, // gold pickup? (gold glow)
            LevelUpMessage = 6,
            PickupHealth = 7, // hp pickup? (red bubbles glow)
            GlowViolette = 8, // violette glow ?
            Sign = 9, // yellow/black glow above the char
            Gather = 10, // lots of small yellow glows that go toward the char
            LevelUp = 32, // huge golden shwirl effect, needs field2 to be an int, f.e. 85195
            FlashEnergyGlobe = 37, // flashes the right globe in the game, possible after mana pickup or use of mana flask
            PickupMana = 62 // mana pickup? (blue bubbles glow)
        }

        public static enum Death
        {
            Gore = 40,
            Fire = 41,
            Green = 42,
            Purple = 43,
            Symbols = 44, // probably for monk's death ?
            Lightning = 45,
            Ice = 46,
            Huge = 47
        }

        public static enum Texture
        {
            Dark = 48,
            BloodVeins = 49,
            Purple = 50,
            Black = 52,
            Blue = 53,
            Black2 = 55, // black with a somewhat different texture
            Green = 56
        }

        public static enum Messages
        {
            /// <summary>red message: that item cannot be picked up</summary>
            ItemNoPickup = 17,
            /// <summary>red message: you have no place to put that item</summary>
            ItemNoPlace = 18,
            /// <summary>red message: you are not allowed to have more than one of this item</summary>
            ItemNoMore = 19,
            /// <summary>red message: that item belongs to someone else and cannot be picked up</summary>
            ItemOwner = 20,
            /// <summary>Checkpoint Reached popup and Message in Chat Window</summary>
            CheckpointReached = 70 
        }

        /// <summary>
        ///  these are to be found in packet captures but are unknown of what they do, everything seems to work without these just as well
        /// </summary>

        public static enum Unknown
        {
            Unknown1 = 1,
            Unknown2 = 2,
            Unknown3 = 3,
            Unknown4 = 4,
            Unknown11 = 11,
            Unknown12 = 12,
            Unknown23 = 23,
            Unknown33 = 33,
            Unknown61 = 61
        }
    }

    public static class ActorEffectsAttributes
    {
        public static class Hero 
        {
            public static int[] LevelUpEffects =
            {
                85186, 85186, 85186, 85186, 85186, 85190, 85190, 85190, 85190, 85190, /* Level 1-10 */
                85187, 85187, 85187, 85187, 85187, 85187, 85187, 85187, 85187, 85187, /* Level 11-20 */
                85192, 85192, 85192, 85192, 85192, 85192, 85192, 85192, 85192, 85192, /* Level 21-30 */
                85192, 85192, 85192, 85192, 85192, 85192, 85192, 85192, 85192, 85192, /* Level 31-40 */
                85192, 85192, 85192, 85192, 85192, 85192, 85192, 85192, 85192, 85192, /* Level 41-50 */
                85194, 85194, 85194, 85194, 85194, 85194, 85194, 85194, 85194, 85194, /* Level 51-60 */
                85194, 85194, 85194, 85194, 85194, 85194, 85194, 85194, 85194, 85194, /* Level 61-70 */
                85194, 85194, 85194, 85194, 85194, 85194, 85194, 85194, 85194, 85194, /* Level 71-80 */
                85195, 85195, 85195, 85195, 85195, 85195, 85195, 85195, 85195, 85195, /* Level 81-90 */
                85195, 85195, 85195, 85195, 85195, 85195, 85195, 85195, 85195, 85195 /* Level 91-99 */
            };
        }
    }
}
