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
            Item Shield = new Item();
            room1.itemList.Add(Shield);
            room1.itemList[0].Name = "Potion of Healing";
            room1.itemList[0].Effect = "Heal1";
            worldList.Add(room1);
            Room room2 = new Room();
            room2.rName = "Dark Room";
            Creature Wolf = new Creature();
            room2.mobList.Add(Wolf);
            room2.mobList[0].Name = "Wolf";
            Item Sword = new Item();
            room2.itemList.Add(Sword);
            room2.itemList[0].Name = "Sword";
            worldList.Add(room2);
            Room room3 = new Room();
            room3.rName = "Dining Hall";
            worldList.Add(room3);
            Room room4 = new Room();
            room4.rName = "Long Hallway";
            worldList.Add(room4);
            Room room5 = new Room();
            room5.rName = "Armory";
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
