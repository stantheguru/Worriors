using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Worriors.Enum;

namespace Worriors.Equipment
{
    class Armor
    {
        private int armorPoints;
        private const int GOOD_GUY_ARMOR = 5;
        private const int BAD_GUY_ARMOR = 5;

        public int ArmorPoints
        {
            get
            {
                return armorPoints;
            }
        }
        public Armor(Faction faction)
        {
            switch (faction)
            {
                case Faction.GoodGuy:
                    armorPoints = GOOD_GUY_ARMOR;
                    break;
                case Faction.BadGuy:
                    armorPoints = BAD_GUY_ARMOR;
                    break;
                default:
                    break;
            }
        }
    }
}
