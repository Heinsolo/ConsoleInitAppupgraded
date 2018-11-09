using System;
using System.Collections.Generic;
using Newtonsoft.Json; 

namespace ConsoleInitApp
{
    class Program
    {
        static List<Character> Characters = new List<Character>();
        static List<Party> Parties = new List<Party>();
        static List<Encounter> Encounters = new List<Encounter>();

        static void Pause()
        {
            Console.Write("\nPress any key to continue...");
            Console.ReadKey();
        }

        static string Prompt(string message)
        {
            Console.WriteLine("\n{0}:", message);
            Console.Write(">: ");
            return Console.ReadLine();
        }

        // Main menu to begin app. Simple choose option.
        static void Main(string[] args)
        {
            bool shouldQuit = false;
            Menu start = new Menu("Main menu", new string[] {
                "Add a character",
                "Show characters",
                "Add a party",
                "Add an encounter",
                "Start an Encounter",
                "Quit"
            });

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
                        ShowCharacters();
                        break;
                    case 3:
                        AddParty();
                        break;
                    case 4:
                        AddEncounter();
                        break;
                    case 5:
                        StartEncounter();
                        break;
                    case 6:
                        Quit();
                        break;
                    default:
                        break;
                }
            }
        }

        static void AddCharacter()
        {
            bool goBack = false;
            Menu CharacterMenu = new Menu("Add a character", new string[] {
                "Enter Name",
                "Enter HP",
                "Enter Damage",
                "Show Character",
                "Go Back"
            });

            Character newCharacter = new Character();
            Characters.Add(newCharacter);

            while (!goBack)
            {
                CharacterMenu.Print();
                int option = CharacterMenu.ReadOption();

                switch (option)
                {
                    case 1:
                        EnterName(newCharacter);
                        break;
                    case 2:
                        EnterXP(newCharacter);
                        break;
                    case 3:
                        EnterDamage(newCharacter);
                        break;
                    case 4:
                        Console.WriteLine("\n{0}", newCharacter.ToString());
                        Pause();
                        break;
                    case 5:
                        goBack = true;
                        break;
                    default:
                        break;
                }

            }
        }

        static void EnterName(Character character)
        {
            character.Name = Prompt("Enter the character's name");
        }

        static void EnterXP(Character character)
        {
            character.HP = int.Parse(Prompt("Enter the character's HP"));
        }

        static void EnterDamage(Character character)
        {
            character.Damage = int.Parse(Prompt("Enter the character's damage"));
        }

        static void AddParty()
        {
            bool goBack = false;
            Menu PartyMenu = new Menu("Choose an Option", new string[]
            { "Enter Party Name",
              "Add Characters"
            });

            Party newParty = new Party();
            Parties.Add(newParty);

            while (!goBack)
            {
                PartyMenu.Print();
                int option = PartyMenu.ReadOption();

                switch (option)
                {
                    case 1:
                        PartyName(newParty);
                        break;
                    case 2:
                        AddNames(newParty);
                        break;
                    case 3:
                        Console.WriteLine("\n{0}", newParty);
                        Pause();
                        break;
                    case 4:
                        goBack = true;
                        break;
                    default:
                        break;
                }

            }
        }

        static void PartyName(Party party)
        {
            party.Name = Prompt("Enter your party's name");
        }

        static void AddNames(Party party)
        {
            
        }

        static void ShowParty(Party party)
        {

        }
        

        static void AddEncounter()
        {
            Menu EncounterMenu = new Menu("Choose an Option", new string[] { "Enter Encounter" });
            EncounterMenu.Print();
            int option = EncounterMenu.ReadOption();
        }

        static void ShowCharacters()
        {
            Console.WriteLine("\nCharacters\n------------------------------");
            foreach (Character c in Characters)
            {
                Console.WriteLine(c.ToString());
            }
            Pause();
        }

        static void StartEncounter() { }
        static void Quit() { Environment.Exit(0); }
    }
}