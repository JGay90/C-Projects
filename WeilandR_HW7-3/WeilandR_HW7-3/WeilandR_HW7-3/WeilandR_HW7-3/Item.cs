﻿using System;
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

        public Item()
        {
            Name = "You didn't give me anything";
            Value = 0;
            Effect = "None";
        }
    }
}
