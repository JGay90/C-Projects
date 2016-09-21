using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeilandR_HW7_3
{
   
    class Room
    {
        public int RID { get; set; }
        public string rName { get; set; }
        public string rDesc { get; set; }

        public List<Creature> mobList = new List<Creature>();

        public List<Item> itemList = new List<Item>();

        private int roomID = 0;

        public Room()
        {
            RID = roomID;
            rName = "Bob";
            rDesc = "Instantiate me properly!";
        }

        public void checkDeaths()
        {
            foreach(Creature val in mobList)
            {
                if(val.HP <= 0)
                {
                    val.isdead = true;
                }
            }
            for(int i = 0; i < mobList.Count; i++)
            {
                if (mobList[i].isdead == true)
                {
                    mobList.RemoveAt(i);
                }
            }
        }

    }
}
