using System;
using Newtonsoft.Json;

namespace ConsoleInitApp
{
    class Program
    {
       static bool shouldQuit = false;
       static bool shouldGoBack = false;

        static void Main(string[] args)
        {
            //Main menu to begin app. Simple choose option.

            Menu start = new Menu("Choose an option", new string[] {"Add a character", "Add an encounter", "Start an Encounter", "Quit" });

            while (!shouldQuit)
            {
                start.Print();
                int option = start.ReadOption();

                switch (option)
                {
                    case 1:
                        AddCharacter();
                        break;
                    case 2:
                        AddEncounter();
                        break;
                    case 3:
                        StartEncounter();
                        break;
                    case 4:
                        Quit();
                        break;
                    default:
                        break;
                }
            }
          
        }


        static void AddCharacter()
        {
            Menu characterMenu = new Menu("Choose an Option", new string[] { "Enter Name", "Enter HP", "Enter Damage", "Go Back" });

            while (!shouldGoBack) 
            {

                characterMenu.Print();
                int option = characterMenu.ReadOption();

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
                        GoBack();
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
        static void EnterName() { }
        static void EnterXP() { }
        static void EnterDamage() { }
        static void Quit() { Environment.Exit(0); }
        static void GoBack() { Environment.Exit(0); }
    }
}
