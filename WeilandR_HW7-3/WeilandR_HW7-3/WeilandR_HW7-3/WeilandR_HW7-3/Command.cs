using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeilandR_HW7_3
{
    class Command : dungeonCrawlForm
    {
        string input;
        public World world = new World();
        public Player player = new Player();

        public string Handler(string input)
        {
            string handler = "";
            switch(handler)
            {
                case "Go":
                     
                    break;

                case "Look":

                    break;

                case Take:

                    break;

                case Get:

                    break;

                case Drop:

                    break;

                case Open:

                    break;

                case Inventory:

                    break;

                case Score:

                    break;

                case Quit:

                    break;
            }


            return handler;
        }

        public string Go()
        {
            string go = "";



            return go;
        }
        public string Look()
        {
            string look = "";



            return look;
        }
        public string Take()
        {
            string take = "";



            return take;
        }
        public string Get()
        {
            string get = "";



            return get;
        }
        
        public string Drop()
        {
            string drop = "";



            return drop;
        }
        public string Open()
        {
            string open = "";



            return open;
        }
        public string Inventory()
        {
            string inventory = "";

            for (int i = 0; i<= List.lenghth; i++)
            {
                inventory += listitem.name() + "\n "
            }


            return inventory;
        }
        public string Score()
        {
            string score = "";

            score += Player.getEXP();

            return score;
        }
        public string Quit()
        {
            string quit = "Have a Nice Day";

           //figure out later!

            return quit;
        }
    }
}
