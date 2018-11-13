using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace ConsoleInitApp
{
    class SaveState
    {
        public List<Character> Characters = new List<Character>();
        public List<Party> Parties = new List<Party>();
        public Encounter Encounter = new Encounter();
        public SaveState() { }
        public SaveState(List<Character> characters, List<Party> parties, Encounter encounter)
        {
            Characters = characters;
            Parties = parties;
            Encounter = encounter;
        }

        public void Save(string fileName)
        {
            File.WriteAllText(fileName, JsonConvert.SerializeObject(this));
        }

        public static SaveState Load(string fileName)
        {
            return JsonConvert.DeserializeObject<SaveState>(File.ReadAllText(fileName));
        }
    }
}
