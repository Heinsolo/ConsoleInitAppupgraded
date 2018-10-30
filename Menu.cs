using System;
using System.Collections.Generic;

namespace ConsoleInitApp
{
    class Menu
    {
        private string Title;
        private List<string> Options = new List<string>();

        public Menu(string title, string[] options)
        {
            Title = title;
            Options.AddRange(options);
        }

        public void Print()
        {
            Console.WriteLine(Title);
            for(int i = 0; i < Options.Count; ++i)
            {
                Console.WriteLine("{0}. {1}", i+1, Options[i].ToString());
            }
        }

        public int ReadOption()
        {
            string input = Console.ReadLine();
            int option = int.Parse(input);
            return option;
        }
     }
}
