using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M4H1_WeilandR
{
    class NonPlayerCharacter : MobileObject
    {
        //Fields:The different factions for the NPC.
        public enum FactionType
        {
            Unaffiliated, Skylanders, Immaculates, Wayfarers
        }

        private FactionType _faction;

        //Constructor
        public NonPlayerCharacter(int HP, int AC, int AB, int DMG, bool CanAttack, FactionType faction)
            : base(HP, AC, AB, DMG, CanAttack)
        {
            _faction = faction;
            CanAttack = false;
        }

        //public NonPlayerCharacter()
        //{
        //    NonPlayerCharacter()
        //}

        public FactionType Faction
        {
            get { return _faction; }
            set { _faction = value; }
        }
    }
}
