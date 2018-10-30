using System;
using Newtonsoft.Json;

namespace ConsoleInitApp
{
    class Program
    {
       static bool shouldQuit = false;
        static bool goBack = false;

        static void Main(string[] args)
        {
            //Main menu to begin app. Simple choose option.

            Menu start = new Menu("Choose an option", new string[] {"Add a character", "Add a party", "Add an encounter", "Start an Encounter", "Quit" });

            while (!shouldQuit)
            {
                start.Print();
                int option = start.ReadOption();

                switch (option)
                {
                    case 1:
                        AddCharacter(;
                        break;
                    case 2:
                        AddParty();
                        break;
                    case 3:
                        AddEncounter();
                        break;
                    case 4:
                        StartEncounter();
                        break;
                    case 5:
                        Quit();
                        break;
                    case 6:
                        break;

                    default:
                        break;
                }
            }
          
        }


        static void AddCharacter()
        {
            Menu CharacterMenu = new Menu("Choose an Option", new string[] { "Enter Name", "Enter HP", "Enter Damage" });
            while (!goBack) 
            {

                CharacterMenu.Print();
                int option = CharacterMenu.ReadOption();

                switch (option)
                {
                    case 1:
                        EnterName();
                        break;
                    case 2:
                        EnterXP();
                        break;
                    case 3:
                        EnterDamage();
                        break;
                    case 4:
                        goBack = true;
                        break;
                    case 5:
                        shouldQuit = true;
                        break;

                    default:
                        break;
                }

            }
        }


        static void AddParty()
        {
            Menu PartyMenu = new Menu("Choose an Option", new string[] { "Enter Party" });
            PartyMenu.Print();
            int option = PartyMenu.ReadOption();

        }
        static void AddEncounter()
        {
            Menu EncounterMenu = new Menu("Choose an Option", new string[] { "Enter Encounter" });
            EncounterMenu.Print();
            int option = EncounterMenu.ReadOption();
        }
        static void StartEncounter() { }
        static void Quit() { Environment.Exit(0); }
    }
}
