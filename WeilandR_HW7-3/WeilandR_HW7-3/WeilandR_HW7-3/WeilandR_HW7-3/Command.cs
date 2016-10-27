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
