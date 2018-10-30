using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleInitApp
{
    class Round
    {
        public int Number { get; set; }
        public List<String> CombatLog = new List<String>();

        public Round()
        {

        }

        public void LogCombatAction(Action action)
        {
            CombatLog.Add(action.ToString());
        }
    }
}
