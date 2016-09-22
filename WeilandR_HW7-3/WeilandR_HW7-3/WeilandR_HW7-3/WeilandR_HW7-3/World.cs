using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeilandR_HW7_3
{
    class World
    {

        public List<Room> worldList = new List<Room>();


        public World()
        {
            Room room1 = new Room();
            room1.rName = "Entrance";
            Creature Goblin = new Creature();
            room1.mobList.Add(Goblin);
            room1.mobList[0].Name = "Goblin";
            Creature Skeleton = new Creature();
            room1.mobList.Add(Skeleton);
            room1.mobList[1].Name = "Skeleton";
            Item HealingPotion = new Item();
            room1.itemList.Add(HealingPotion);
            room1.itemList[0].Name = "Potion of Healing";
            room1.itemList[0].Effect = "Heal1";
            worldList.Add(room1);
            Room room2 = new Room();
            room2.rName = "Dark Room";
            Creature Wolf = new Creature();
            room2.mobList.Add(Wolf);
            room2.mobList[0].Name = "Wolf";
            Item DefensePotion = new Item();
            room2.itemList.Add(DefensePotion);
            room2.itemList[0].Name = "Iron Skin Potion";
            room2.itemList[0].Effect = "Def1";
            Item Sword = new Item();
            room2.itemList.Add(Sword);
            room2.itemList[1].Name = "Sword";
            worldList.Add(room2);
            Room room3 = new Room();
            room3.rName = "Dining Hall";
            Item AttackPotion = new Item();
            room3.itemList.Add(AttackPotion);
            room3.itemList[0].Name = "Strength Potion";
            room3.itemList[0].Effect = "Atk1";
            worldList.Add(room3);
            Room room4 = new Room();
            room4.rName = "Long Hallway";
            Item Staff = new Item();
            room4.itemList.Add(Staff);
            room4.itemList[0].Name = "Staff";
            worldList.Add(room4);
            Room room5 = new Room();
            room5.rName = "Armory";
            Item Longsword = new Item();
            room2.itemList.Add(Longsword);
            room2.itemList[0].Name = "Longsword";
            worldList.Add(room5);
            Room room6 = new Room();
            room6.rName = "Tallest Tower";
            worldList.Add(room6);
            Room room7 = new Room();
            room7.rName = "Dungeon";
            worldList.Add(room7);
            Room room8 = new Room();
            room8.rName = "Large Holding Cell";
            worldList.Add(room8);
            Room room9 = new Room();
            room9.rName = "Secret Cave";
            worldList.Add(room9);
            Room room10 = new Room();
            room10.rName = "Dragon Nest";
            worldList.Add(room10);
        }
        public void RemoveMonster()
        {

        }


    }
}
