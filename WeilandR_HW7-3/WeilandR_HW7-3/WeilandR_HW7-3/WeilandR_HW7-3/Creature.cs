using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WeilandR_HW7_3
{
    public class Creature
    {
        public string Name { get; set; }
        public string Desc { get; set; }
        public int HP { get; set; }
        public int AC { get; set; }
        public int ATK { get; set; }
        public int DMG { get; set; }
        public int Lvl { get; set; }
        //public Image i { get; set; }

        /**
         * I turned the stats that should have been numeric into ints so that we could
         * use them for math and various other functions that they would have had to be ints for anyways!
         * Get it to take the objects created in the main form into the moblist in room. I couldn't remember exactly how to do that unless i need to make moblist
         * in main form and pass it as a room constructor requirement??
         * 
         * Remove here down before turn-in!
         * Jeff you have my Cell number if you need to bounce ideas off me this weekend I will be at Funeral Friday but
         * you can text me and ill get back to you when i am able....
         * I will be in touch on Skype when able to just might not be able to do a full call will be in a full house this weekend until sunday i do believe.
         * I WILL BE KEPT INFORMED THIS TIME!
         * 
         * :P just spent like 40+ minutes fixing it so we could do math with the stats is all ttys
         */


        public Creature()
        {
            Name = "You didn't populate the bestiary";
            Desc = "You should go do that now.";
            HP = 0;
            AC = 0;
            ATK = 0;
            Lvl = 1;
            DMG = ATK+Lvl;
            //i = Image.FromFile("Bestiary.png");
        }
    }
}
