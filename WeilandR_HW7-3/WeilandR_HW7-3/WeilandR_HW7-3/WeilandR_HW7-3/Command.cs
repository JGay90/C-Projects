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
            
            switch(input)
            {
                case "Go":
                    input = Go();
                    break;

                case "Look":
                    input = Look();
                    break;

                case "Take":
                    input = Take();
                    break;

                case "Get":
                    input = Get();
                    break;

                case "Drop":
                    input = Drop();
                    break;

                case "Open":
                    input = Open();
                    break;

                case "Inventory":
                    input = Inventory();
                    break;

                case "Score":
                    input = Score();
                    break;

                case "Quit":
                    input = Quit();
                    break;
            }


            return input;
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

            for (int i = 0; i<= player.Inventory.Count; i++)
            {
                inventory += player.Inventory[i].Name + "\n ";
            }


            return inventory;
        }
        public string Score()
        {
            string score = "";

            score += player.EXP;

            return score;
        }
        public string Quit()
        {
            string quit = "Game Over\n" +
                          "Your score was: " + Score() + "\n" +
                          "Have a Nice Day";
            return quit;
        }
    }
}
