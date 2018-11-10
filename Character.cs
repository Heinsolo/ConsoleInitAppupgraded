using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleInitApp
{
    class Character
    {
        public int Initiative { get; set; }
        public string Name { get; set; }
        
        public Character(string name)
        {
            Name = name;
        }

        public Character()
        {
        }

        public override string ToString()
        {
            return Name;
        }


    }
}
