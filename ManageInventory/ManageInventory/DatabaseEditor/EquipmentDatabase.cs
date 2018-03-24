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
        private Dictionary<string, IArmor> armorDictionary;
        private Dictionary<string, IWeapon> weaponDictionary;
        
        /// <summary>
        /// Creating a new Database for armor and weapons.
        /// </summary>
        public EquipmentDatabase()
        {
            armorDictionary = new Dictionary<string, IArmor>();
            weaponDictionary = new Dictionary<string, IWeapon>();
        }

        /// <summary>
        /// Loads a new databaser for armor and weapons from a file to change or edit.
        /// </summary>
        /// <param name="reader"></param>
        public EquipmentDatabase(StreamReader reader)
        {

        }


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

            this.weaponDictionary.Add(weaponToAdd.Name, weaponToAdd);
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
            this.armorDictionary.Add(armorToAdd.Name, armorToAdd);
        }

        /// <summary>
        /// Trys to get the weapon connected to the name, if the weapon exists then it is returned to the caller.
        /// </summary>
        /// <param name="weaponName"></param>
        /// <returns></returns>
        public IWeapon GetWeapon(string weaponName)
        {
            if (weaponName == null)
            {
                return null;
            }

            weaponDictionary.TryGetValue(weaponName, out IWeapon weapon);

            if(weapon == null)
            {
                return null;
            }

            return weapon;
        }

        /// <summary>
        /// Trys to get the armor connected to the name, if the armor exists, returns the armor to the caller.
        /// </summary>
        /// <param name="armorName"></param>
        /// <returns></returns>
        public IArmor GetArmor(string armorName)
        {
            if(armorName == null)
            {
                return null;
            }

            armorDictionary.TryGetValue(armorName, out IArmor armor);

            if (armor == null)
            {
                return null;
            }

            return armor;
        }

        /// <summary>
        /// Removes the weapon connected to the name from the database.
        /// </summary>
        /// <param name="weaponName"></param>
        public void RemoveWeapon(string weaponName)
        {
            if (weaponName == null)
            {
                return;
            }

            weaponDictionary.Remove(weaponName);
        }

        /// <summary>
        /// Removes the armor conntected tot he name from the databse.
        /// </summary>
        /// <param name="weaponName"></param>
        public void RemoveArmor(string armorName)
        {
            if(armorName == null)
            {
                return;
            }

            armorDictionary.Remove(armorName);
        }
    }
}
