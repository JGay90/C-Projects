using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeilandR_HW7_3
{
    class Item
    {
        public string Name { get; set; }
        public int Value { get; set; }
        public string Effect { get; set; }
        public int durability { get; set; }
        public Item()
        {
            Name = "You didn't give me anything";
            Value = 0;
            Effect = "None";
            durability = 1;
        }
        public string UseEffect(Player player)
        {
            string i = "";
            switch (Effect)
            {
                case "Heal1":
                    Heal(player);
                    i = "you recover 5 HP";
                    break;

                case "Def1":
                    Def(player);
                    i = "your defense goes up by 2";
                    break;

                case "Atk1":
                    Atk(player);
                    i = "your attack goes up by 2";
                    break;

                default:
                    //Add box/
                    break;
            }
            return i;
        }
        public void Heal(Player playerHeal)
        {
            playerHeal.HP = playerHeal.HP + 5;

        }
        public void Def(Player playerDef)
        {
            playerDef.AC = playerDef.AC + 2;
        }
        public void Atk(Player playerAtk)
        {
            playerAtk.ATK = playerAtk.ATK + 2;
        }
    }
}
