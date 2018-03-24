using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageInventory.DatabaseEditor
{
    class EquipmentDatabase
    {
        /// <summary>
        /// Backing dictionaries for armor and weapons.
        /// </summary>
        private Dictionary<string, IEquipment> equipmentDictionary;
        /// <summary>
        /// Creating a new Database for armor and weapons.
        /// </summary>
        public EquipmentDatabase()
        {
            equipmentDictionary = new Dictionary<string, IEquipment>();
        }

        /// <summary>
        /// Loads a new databaser for armor and weapons from a file to change or edit.
        /// </summary>
        /// <param name="reader"></param>
        public EquipmentDatabase(StreamReader reader)
        {

        }

        /// <summary>
        /// Saves the database to a file.
        /// </summary>
        public void SaveDatabase()
        {

        }


        public void LoadDatabase()
        {

        }

        /// <summary>
        /// Adds the weapon to the database. 
        /// </summary>
        /// <param name="weaponToAdd"></param>
        public void SetWeapon(IWeapon weaponToAdd)
        {
            if(weaponToAdd == null)
            {
                return;
            }

            this.equipmentDictionary.Add(weaponToAdd.Name, weaponToAdd);
        }

        /// <summary>
        /// Adds the armor to the database.
        /// </summary>
        /// <param name="armorToAdd"></param>
        public void SetArmor(IArmor armorToAdd)
        {
            if(armorToAdd == null)
            {
                return;
            }
            this.equipmentDictionary.Add(armorToAdd.Name, armorToAdd);
        }

        /// <summary>
        /// Trys to get the equipment connected to the name, if the equipment exists it is returned to the caller.
        /// otherwise a null value is returned to the caller.
        /// </summary>
        /// <param name="equipmentName"></param>
        /// <returns></returns>
        public IEquipment GetEquipment(string equipmentName)
        {
            if(equipmentName == null)
            {
                return null;
            }

            equipmentDictionary.TryGetValue(equipmentName, out IEquipment equipment);

            if (equipment == null)
            {
                return null;
            }

            return equipment;
        }

        /// <summary>
        /// Removes the weapon connected to the name from the database.
        /// </summary>
        /// <param name="equipmentName"></param>
        public void RemoveEquipment(string equipmentName)
        {
            if (equipmentName == null)
            {
                return;
            }

            equipmentDictionary.Remove(equipmentName);
        }
    }
}
