using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeilandR_HW7_3
{
    class Look_At
    {
        public bool Try(String arg)
        {
            if (arg == null || arg == "")
            {
                return TryLookAtRoom();
            }
            return TryLookAtObject(arg);
        }
        private bool TryLookAtRoom()
        {

            //world
            //item and player locaion
            //Item name's
            //descripiton

            foreach (Object o in w.Objects)
            {
                if ("//Location" == r.Id)
                {
                    string ItemThere = ("There is a " + "//Item Name" + " here.");
                }
            }
            string Exit = ("Exits lead: ");
            foreach (Exit ex in r.Exits)
            {
                if (ex.Destination != -1)
                {
                    string spare =  (ex.Name + " ");
                }
            }
            string exit = ("");
            return true;
        }

        private bool TryLookAtObject(String noun)
        {
            //world
            //room and player locaion

            bool exists = false;
            foreach (Object o in w.Objects)
            {
                if (noun == "//item Name")
                {
                    exists = true;
                    if ("//item location" == "//player location")
                    {
                        string ISee = ("//Description" + ".");
                        return true;
                    }
                    else
                    {
                        string dontSee = ("I don't see " + noun + " here.");
                        return false;
                    }

                }
            }
            if (!exists)
            {
                string notRecognized = "I don't recognize the noun '" + noun + "'.";
                return false;
            }

            return true;
        }
    }
}
