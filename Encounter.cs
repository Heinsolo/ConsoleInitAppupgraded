using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleInitApp
{
    class Encounter
    {
        public List<Party> Parties = new List<Party>();
        public List<Character> InitiativeOrder = new List<Character>();

        public void BuildInitiativeOrder()
        {
            foreach (Party p in Parties)
            {
                foreach (Character c in p.Characters)
                {
                    InitiativeOrder.Add(c);
                }
            }

            InitiativeOrder = InitiativeOrder.OrderBy(c => c.Initiative).Reverse().ToList();
        }
    }
}
