using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageInventory.AllWeaponTypes
{
    class HeavyBowGun : IWeapon
    {
        public string Name { get => Name; set => Name = value; }
        public int Rarity { get => Rarity; set => Rarity = value; }
        public int DecorationSlot { get => DecorationSlot; set => DecorationSlot = value; }
        public int Defense { get => Defense; set => Defense = value; }
    }
}
