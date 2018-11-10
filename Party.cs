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

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(string.Format("Party Name: " + Name));
            foreach (Character c in Characters)
            {

                sb.Append(string.Format("\n{0}", c.ToString()));
            }
            return sb.ToString();
        }

    }
}
