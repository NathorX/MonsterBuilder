using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageInventory
{
    interface IArmor : IEquipment
    {
        string Skill { get; set; }
        int FireRes { get; set; }
        int WaterRes { get; set; }
        int LightningRes { get; set; }
        int IceRes { get; set; }
        int DragonRes { get; set; }

    }
}
