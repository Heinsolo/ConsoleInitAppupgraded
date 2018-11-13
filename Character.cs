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

        //I had to override this method because it's also used in the Party class. 
        public override string ToString()
        {
            return Name;
        }
    }
}
