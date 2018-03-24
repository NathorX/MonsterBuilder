using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageInventory
{
    interface IEquipment
    {
        string Name { get; set; }
        int Rarity { get; set; }
        int DecorationSlot { get; set; }
        int Defense { get; set; }

    }
}
