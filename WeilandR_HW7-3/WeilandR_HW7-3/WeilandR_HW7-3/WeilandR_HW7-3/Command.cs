using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeilandR_HW7_3
{
    class Command
    {
        public World world = new World();
        public Player player = new Player();

        public string Handler(string input)
        {
            string[] placeholder;//this is the array the string segments should be going into.
            string cleanupInput;//this will be the placeholder for cleaning up the input and just taking the input in general.
            string verb;//This will be the placeholder to determine the verb.
            string action;//This will be the placeholder to determine the action.
            string post = "Try again?";//This will be for holding the output.
            char[] delim = { ' ', ',', '.', '!', '?' };//this is here to be a delimiter for when I separate words.

            cleanupInput = input.Trim();//trim the white space off the input

            //Split the line at delimiters, removing the empty entries.
             placeholder = cleanupInput.Split(delim, StringSplitOptions.RemoveEmptyEntries);//split the string into the string array by the delimiter, remove empty entries

            if (placeholder.Length == 2)
            {

                verb = placeholder[0];
                action = placeholder[1];
                Console.WriteLine(verb);
                Console.WriteLine(action);

                switch (input)
                {
                    case "Go":
                        post = Go(action);
                        break;

                    case "Look":
                        post = Look();
                        break;

                    case "Take":
                        post = Take(action);
                        break;

                    case "Get":
                        post = Get(action);
                        break;

                    case "Drop":
                        post = Drop(action);
                        break;

                    case "Open":
                        post = Open(action);
                        break;

                    case "Inventory":
                        post = Inventory();
                        break;

                    case "Score":
                        post = Score();
                        break;

                    case "Quit":
                        post = Quit();
                        break;
                }
            }
            else
            {
                post = "Invalid command. Try again?";
            }


            return post;
        }

        public string Go()
        {
            string go = "";

            if (this.world.worldList[player.Location].RID == 9)
            {
                MessageBox.Show("You are at the end of the " +
                    "dungeon. You can go no further.");
            }
            else
            {
                if (world.worldList[player.Location].mobList.Count == 0)
                {
                    player.Location++;
                    Look();
                }
                else
                {
                    go = "\nThe monster blocks your path.";
                }
            }

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
        public string Get(string Name)
        {
            string get;
            Item placeHolder = null;
            int i = 0;

            foreach (Item val in world.worldList[player.Location].itemList)//for each item in the list, check to see if the selected name matches the item's.
            {
                if (val.Name == Name)
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
