using System;
using System.Collections.Generic;

namespace ConsoleInitApp
{
    class Menu
    {
        //I encapsulated these two members variables because they don't need to be accessed outside of the Menu class. The next method (Menu) does allow for a assignment for Title and options, which can be used outside of the Menu class to instantiate a new Menu.
        private readonly string Title;
        private readonly List<string> Options = new List<string>();

        public Menu(string title, string[] options)
        {
            Title = title;
            Options.AddRange(options); //Allows for strings (menu options) to be added to the List.
        }

        //This method prints the particular menu as it's instantiated in the Main method in the Program class.
        public void Print()
        {
            Console.WriteLine("\n{0}\n----------------------", Title);
            for(int i = 0; i < Options.Count; ++i)
            {
                Console.WriteLine("{0}. {1}", i+1, Options[i].ToString()); //Allows the string to be numbered based on how many items the List contains.
            }
        }

        public int ReadOption()
        {
            Console.Write("\n>: "); //This is a placeholder so it looks a little more professional when the user is prompted for an input.
            string input = Console.ReadLine();
            try
            {
                int option = int.Parse(input); //Parses the string input into an int.

                if (option > 0 && option <= Options.Count)
                {
                    return option;
                }
               else
                {
                    throw new Exception("Invalid Selection"); //Exception so that the application doesn't crash if anything but the numbers offered in the instantiated Menu are chosen. 
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid Selection. Please try again");
                return -1;
            }
        }


     }
}
