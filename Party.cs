using System;
using System.Collections.Generic;

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
