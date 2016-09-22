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
            //this is the base room in our world.
            Room room1 = new Room();
            Room room2 = new Room();
            Room room3 = new Room();
            Room room4 = new Room();
            Room room5 = new Room();
            Room room6 = new Room();
            Room room7 = new Room();
            Room room8 = new Room();
            Room room9 = new Room();
            Room room10 = new Room();


            //This is the base creature in our world.
            Creature goblin = new Creature();
            Creature skeleton = new Creature();
            Creature wolf = new Creature();

            //These are all the base items in our world.
            Item defpotion = new Item();
            Item atkpotion = new Item();
            Item healpotion = new Item();
            Weapon sword = new Weapon();
            Weapon dagger = new Weapon();
            Weapon staff = new Weapon();

            //Room 1 stuff
            room1.rName = "Entrance";
            goblin.Name = "Goblin";
            room1.mobList.Add(goblin);
            skeleton.Name = "Skeleton";
            room1.mobList.Add(skeleton);
            healpotion.Name = "Potion of Healing";
            healpotion.Effect = "Heal1";
            room1.itemList.Add(healpotion);
            worldList.Add(room1);

            //Room 2 stuff
            room2.rName = "Dark Room";
            wolf.Name = "Wolf";
            room2.mobList.Add(wolf);
            defpotion.Name = "Iron Skin Potion";
            defpotion.Effect = "Def1";
            room2.itemList.Add(defpotion);
            sword.Name = "Sword";
            room2.itemList.Add(sword);
            worldList.Add(room2);

            //Room 3 stuff
            room3.rName = "Dining Hall";
            atkpotion.Name = "Strength Potion";
            atkpotion.Effect = "Atk1";
            room3.itemList.Add(atkpotion);
            worldList.Add(room3);

            //Room 4 stuff
            room4.rName = "Long Hallway";
            staff.Name = "Staff";
            room4.itemList.Add(staff);
            worldList.Add(room4);
            
            //Room 5 stuff
            room5.rName = "Armory";
            dagger.Name = "Dagger";
            room5.itemList.Add(dagger);
            worldList.Add(room5);

            //Room 6 stuff
            room6.rName = "Tallest Tower";
            worldList.Add(room6);

            //Room 7 stuff
            room7.rName = "Dungeon";
            worldList.Add(room7);

            //Room 8 stuff
            room8.rName = "Large Holding Cell";
            worldList.Add(room8);

            //Room 9 stuff
            room9.rName = "Secret Cave";
            worldList.Add(room9);

            //Room 10 stuff
            room10.rName = "Dragon Nest";
            worldList.Add(room10);
        }
        public void RemoveMonster()
        {

        }


    }
}
