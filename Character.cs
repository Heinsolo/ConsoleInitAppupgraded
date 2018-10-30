using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleInitApp
{
    class Character
    {
        public string CharacterName { get; set; }
        //public Action ActionTaken { get; set; }
        public int HPValue { get; set; }
        public int DamageValue { get; set; }

        public Character(string characterName, int hpValue, int damageValue)
        {
            CharacterName = characterName;
            //ActionTaken = actionTaken;
            HPValue = hpValue;
            DamageValue = damageValue;
    }
}
