using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeilandR_HW7_3
{
    class Player
    {
        public int HP { get; set; }
        public int AC { get; set; }
        public int ATK { get; set; }
        public int DMG { get; set; }
        public int Lvl { get; set; }
        public int EXP { get; set; }

        List<Item> playerItems = new List<Item>();

        public Player()
        {
            HP = 10;
            AC = 0;
            ATK = 1;
            Lvl = 1;
            DMG = ATK + Lvl;
            EXP = 0;
        }


    }
}
