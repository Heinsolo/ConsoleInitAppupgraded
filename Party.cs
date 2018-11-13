using System.Collections.Generic;
using System.Text;

namespace ConsoleInitApp
{
    //The Party class is just a List of Characters that are generated in the Character menu. 
    class Party
    {
        public List<Character> Characters = new List<Character>();
        public string Name { get; set; }

        //I had to override this method because it's also used in the Character class.
        public override string ToString()
        {
            //I'm using the StringBuilder class from System.Text because it allows for the characters to be placed within a group of characters called a party. This way, you can name the party whatever you want and the StringBuilder will automatically adjust to account for the string input from the user and then add the names of the characters the user chose.
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
