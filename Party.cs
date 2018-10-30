using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleInitApp
{
    class Party
    {
        public List<Character> Characters = new List<Character>();
        public string Name { get; set; }

        public Party()
        {

        }

        public void AddCharacter(Character character)
        {
            Characters.Add(character);
        }

    }
}
