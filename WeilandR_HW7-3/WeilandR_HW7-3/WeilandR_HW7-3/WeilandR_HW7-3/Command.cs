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

            cleanupInput = input.Trim().ToLower();//trim the white space off the input

            //Split the line at delimiters, removing the empty entries.
             placeholder = cleanupInput.Split(delim, StringSplitOptions.RemoveEmptyEntries);//split the string into the string array by the delimiter, remove empty entries

            //Take the verb and the 'action' and set them into separate roles. I could do it with just the array, but this will be easier on the eyes.
            verb = placeholder[0];

            if (placeholder.Length == 1)
            {
                Console.WriteLine(verb);

                switch (verb)
                {
                    case "look":
                        post = Look();
                        break;

                    case "i":
                        post = Inventory();
                        break;

                    case "inventory":
                        post = Inventory();
                        break;

                    case "score":
                        post = Score();
                        break;

                    case "quit":
                        post = Quit();
                        break;
                }
            }
            else if (placeholder.Length == 2)
            {
                action = placeholder[1];
                Console.WriteLine(verb);
                Console.WriteLine(action);

                switch (verb)
                {
                    case "go":
                        post = Go(action);
                        Console.WriteLine("I work!");
                        break;

                    case "take":
                        post = Take(action);
                        break;

                    case "get":
                        post = Get(action);
                        break;

                    case "drop":
                        post = Drop(action);
                        break;

                    case "open":
                        //post = Open(action);
                        break;
                }
            }
            else
            {
                post = "Invalid command. Try again?";
            }


            return post;
        }

        public string Go(string direction)
        {
            string go = "";


            if (world.worldList[player.Location].mobList.Count == 0)
            {
                if (direction == "ahead")
                {
                    if (this.world.worldList[player.Location].RID == 9)
                    {
                        MessageBox.Show("You are at the end of the " +
                          "dungeon. You can go no further.");
                    }
                    else
                    {
                        player.Location++;
                         go = Look();
                    }
                }
                else if (direction == "back")
                {
                    if (this.world.worldList[player.Location].RID == 1)
                    {
                        MessageBox.Show("You are at the beginning of the " +
                            "dungeon. You can go no further.");
                    }
                    else
                    {
                        player.Location--;
                        go = Look();
                    }
                    
                }
                else
                {
                    go = "\nThat is not a valid direction.";
                }

            }
            else
            {
                go = "\nThe monster blocks your path.";
            }
            

                return go;
        }
        public string Look()
        {
            string look = "";

            look = "\n" + world.worldList[player.Location].rName +
                "\n" + world.worldList[player.Location].rDesc + 
                "\n";

            foreach(Creature val in world.worldList[player.Location].mobList)
            {
                look += "\nThere is a " + val.Name + " here.";
            }

            foreach(Item val in world.worldList[player.Location].itemList)
            {
                look += "\nThere is a " + val.Name + " here.";
            }

            look += "\nThere are ";

            if(world.worldList[player.Location].exitList.Count != 0)
            {
                foreach(string val in world.worldList[player.Location].exitList)
                {
                    look += val;
                }
            }
            else
            {
                look += " no";
            }

            look += " exits here.";

            return look;
        }
        public string Take(string name)
        {
            string take;

            take = Get(name);

            return take;
        }
        public string Get(string Name)
        {
            string get;
            Item placeHolder = null;

            //for each item in the list, check to see if the selected name matches the item's.
            foreach (Item val in world.worldList[player.Location].itemList)
            {
                if (val.accessName.Contains(Name))
                {
                    placeHolder = val;
                    break;
                }
                else
                {
                    get = "\nPlease select an item to pick up.";

                }
            }
            if (placeHolder != null)//If the placeholder has an item, do this.
            {
                player.Inventory.Add(placeHolder);
                world.worldList[player.Location].itemList.Remove(placeHolder);
                get = "\nYou pick up the " + placeHolder.Name;
            }
            else
            {
                get = "\nPlease select a real item to pick up.";

            }

            return get;
        }
        
        public string Drop(string Name)
        {
            string drop = "";
            Item placeHolder = null;

            //for each item in the list, check to see if the selected name matches the item's.
            foreach (Item val in player.Inventory)
            {
                if (val.accessName.Contains(Name))
                {
                    placeHolder = val;
                    break;
                }
                else
                {
                    drop = "\nPlease select an item in your inventory to drop.";

                }
            }
            if (placeHolder != null)//If the placeholder has an item, do this.
            {
                world.worldList[player.Location].itemList.Add(placeHolder);
                player.Inventory.Remove(placeHolder);
                drop = "\nYou pick up the " + placeHolder.Name;
            }
            else
            {
                drop = "\nPlease select a real item to pick up.";

            }


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

            if(player.Inventory.Count != 0)
            {
                foreach (Item val in player.Inventory)
                {
                    inventory += "\n " + val.Name;
                }
            }
            else
            {
                inventory = "\nYou have nothing in your inventory";
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
