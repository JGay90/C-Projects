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
        //public will be fine for now.
        public Player player = new Player();
        public World world = new World();

        public string Handler(string input)
        {
            string handler = "";
            switch(handler)
            {
                case Go:
                     
                    break;

                case Look:

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
            string get;
            Item placeHolder = null;
            int i = 0;

            foreach (Item val in world.worldList[player.Location].itemList)//for each item in the list, check to see if the selected name matches the item's.
            {
                if (val.Name == world.worldList[player.Location].itemList[i].Name)
                {
                    placeHolder = val;
                }
                else
                {
                    get = "\nPlease select an item to pick up.";
                    
                }
            }
            if (placeHolder != null)//If the placeholder has an item, do this.
            {
                world.worldList[player.Location].itemList.Remove(placeHolder);
                get = "\nYou pick up the " + placeHolder.Name;
                player.Inventory.Add(placeHolder);
            }
            else
            {
                get = "\nPlease select a real item to pick up.";

            }


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
