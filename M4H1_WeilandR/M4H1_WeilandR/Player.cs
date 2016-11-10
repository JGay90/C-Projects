using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M4H1_WeilandR
{
    class Player : MobileObject
    {
        public Player(int HP, int AC, int AB, int DMG, bool CanAttack)
            : base(HP, AC, AB, DMG, CanAttack)
        {
            CanAttack = false;
        }

        //Getter and setter for the Reputation system.
        private void GetFaction()
        {
            
        }
        //private int UpdateFaction()
        //{
            
        //}
    }
}
