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
Field1 > 70 crashes the client
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mooege.Core.GS.Effects
{
    public static class ActorEffects
    {
        /// <summary>
        /// Actor Effects specifically for Heroes ingame
        /// </summary>
        public enum Hero
        {
            /// <summary>
            /// Gold Pickup (golden Glow)
            /// </summary>
            PickupGold = 5, 
            /// <summary>
            /// Displays a sign in the center of the screen with the "Level gained" message. Level is taken from GameAttribute.Level.
            /// Also displays signs for unlocked skills and slots.
            /// </summary>
            LevelInfo = 6,
            /// <summary>
            /// Health Globe Pickup (red bubbles aborbed by Actor)
            /// </summary>
            PickupHealth = 7, 
            /// <summary>
            /// Arcane Power Gain (Purple glow)
            /// </summary>
            ArcanePower = 8,
            /// <summary>
            /// A Yellow and Black glowing sign appears above the Actor
            /// </summary>
            Sign = 9, 
            /// <summary>
            /// Many small yellow glows go towards Actor (soul steal?)
            /// </summary>
            Gather = 10,
            /// <summary>
            /// White Cloud appears at the Actors Position and stays there
            /// </summary>
            Item = 27,
            /// <summary>
            /// This is a Placeholder for Effects. Field2 should contain the SNO of the effect to show. (ie 85195 for Level Up Swhirl)
            /// </summary>
            GeneralEffect = 32, 
            /// <summary>
            /// Energy / Furty / Mana etc pickup indicator, right globe flashes
            /// </summary>
            FlashEnergyGlobe = 37, 
            /// <summary>
            /// Mana Pickup (blue bubbles absorbed by Actor)
            /// </summary>
            PickupMana = 62,
            /// <summary>
            /// the Actor vanishes under ground (z=z-20f?) - not sure about the use yet
            /// </summary>
            Vanish = 67
        }

        /// <summary>
        /// Sounds that originate at the Actors Location
        /// </summary>
        public enum Sounds
        {
            MetalImpact = 34,
            CrashImpact = 35
        }

        /// <summary>
        /// Death Effects most likely for Heroes, could be for endbosses too
        /// </summary>
        public enum Death
        {
            /// <summary>
            /// Blood splash upwards from Actor
            /// </summary>
            BloodSplash = 24,
            Gore = 40,
            Fire = 41,
            Green = 42,
            Purple = 43,
            /// <summary>
            /// Probably the monks death ?
            /// </summary>
            Symbols = 44, 
            Lightning = 45,
            Ice = 46,
            /// <summary>
            /// Enormous Gore Explosion - possibly for endboss death ?
            /// </summary>
            Huge = 47
        }

        /// <summary>
        /// Actor Textures - when poisoned = green ?
        /// </summary>
        public enum Texture
        {
            Dark = 48,
            BloodVeins = 49,
            Purple = 50,
            Black = 52,
            Blue = 53,
            /// <summary>
            /// Black with a somewhat different texture
            /// </summary>
            Black2 = 55, 
            Green = 56
        }

        /// <summary>
        /// Messages the Game Client can show
        /// </summary>
        public enum Messages
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

        public enum Unknown
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

}
