using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleInitApp
{
    class Encounter
    {
        public List<Party> Parties = new List<Party>();
        public List<Character> InitiativeOrder = new List<Character>();

        public void BuildInitiativeOrder() //This method will allow the user to put the party in an encounter and let the user put an initiative number in so it can order the players correctly.
        {
            foreach (Party p in Parties)
            {
                foreach (Character c in p.Characters)
                {
                    InitiativeOrder.Add(c);
                }
            }

            InitiativeOrder = InitiativeOrder.OrderBy(c => c.Initiative).Reverse().ToList(); //This LINQ sequence actually puts the order of the characters in order from the greatest initiative number to the lowest.
        }
    }
}
