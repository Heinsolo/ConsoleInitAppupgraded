using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleInitApp
{
    class Character
    {
        public string Name { get; set; }
        public int HP { get; set; }
        public int Damage { get; set; }

        public Character()
        {

        }

        public Character(string name, int hp, int damage)
        {
            Name = name;
            HP = hp;
            Damage = damage;
        }


        public override string ToString()
        {
            return String.Format("{0}: {1} HP {2} DMG", Name, HP, Damage);
        }
    }
}
