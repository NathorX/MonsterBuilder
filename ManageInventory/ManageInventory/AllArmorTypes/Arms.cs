using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageInventory.AllArmorTypes
{
    class Arms : IArmor
    {
        public string Skill { get => Skill; set => Skill = value; }
        public int FireRes { get => FireRes; set => FireRes = value; }
        public int WaterRes { get => WaterRes; set => WaterRes = value; }
        public int LightningRes { get => LightningRes; set => LightningRes = value; }
        public int IceRes { get => IceRes; set => IceRes = value; }
        public int DragonRes { get => DragonRes; set => DragonRes = value; }
        public string Name { get => Name; set => Name = value; }
        public int Rarity { get => Rarity; set => Rarity = value; }
        public int DecorationSlot { get => DecorationSlot; set => DecorationSlot = value; }
        public int Defense { get => Defense; set => Defense = value; }
        public string armorPlacement { get => armorPlacement; set => armorPlacement = value; }

        public Arms()
        {
            armorPlacement = "Arms";
        }
    }
}
