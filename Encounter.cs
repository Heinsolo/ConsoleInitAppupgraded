﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleInitApp
{
    class Encounter
    {
        public List<Party> Parties = new List<Party>();
        public List<Character> InitiativeOrder = new List<Character>();

        public Encounter()
        {

        }

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
