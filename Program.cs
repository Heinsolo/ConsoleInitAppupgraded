﻿using System;
using System.Collections.Generic;

namespace ConsoleInitApp
{
    class Program
    {
        static List<Character> Characters = new List<Character>();
        static List<Party> Parties = new List<Party>();
        static Encounter Encounter = new Encounter();

        static void Pause()
        {
            Console.Write("\n Press any key to continue...");
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
                "Start an Encounter",
                "Save Data",
                "Load Data",
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
                        StartEncounter();
                        break;
                    case 5:
                        SaveData();
                        break;
                    case 6:
                        LoadData();
                        break;
                    case 7:
                        Quit();
                        break;
                    default:
                        break;
                }
            }
        }

        static void AddCharacter()
        {
            Character character = new Character(Prompt("Enter Character Name "));
            Characters.Add(character);
        }

        static void AddParty()
        {
            bool goBack = false;
            Menu PartyMenu = new Menu("Party Menu", new string[]
            { "Enter Party Name",
              "Add Characters",
              "Show Party",
              "Go Back"
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
                        Console.WriteLine("\n{0}", newParty.ToString());
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
            List<string> availableCharacters = new List<string>();
            foreach(Character c in Characters)
            {
                availableCharacters.Add(c.ToString());
            }

            availableCharacters.Add("Go Back");

            Menu AddCharacters = new Menu("Add Characters", availableCharacters.ToArray());
            AddCharacters.Print();
            bool goBack = false;
            while (!goBack)
            {
                AddCharacters.Print();
                int option = AddCharacters.ReadOption();

                if (option == availableCharacters.Count)
                {
                    goBack = true;
                }
                else
                {
                    party.Characters.Add(Characters[option - 1]);
                }
            }
        }
        
        static void StartEncounter()
        {
            foreach (Party p in Parties)
            {
                Encounter.Parties.Add(p);
            }
            bool goBack = false;
            Menu EncounterMenu = new Menu("Encounter Menu", new string[] { "Input Initiative", "Show Initiative Order", "Go Back" });

            while (!goBack)
            {
                EncounterMenu.Print();
                int option = EncounterMenu.ReadOption();
                switch (option)
                {
                    case 1:
                        InputInitiative();
                        break;
                    case 2:
                        ShowInitiativeOrder();
                        break;
                    case 3:
                        goBack = true;
                        break;
                    default:
                        break;

                }
            }
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

        public static void LoadData()
        {
            string fileName = Prompt("Enter File Name");
            SaveState LoadedData = SaveState.Load(fileName);
            Characters = LoadedData.Characters;
            Parties = LoadedData.Parties;
            Encounter = LoadedData.Encounter;
        }

        public static void SaveData()
        {
            string fileName = Prompt("Enter File Name");
            SaveState SaveData = new SaveState(Characters, Parties, Encounter);
            SaveData.Save(fileName);
        }

        static void InputInitiative()
        {
            foreach(Party p in Encounter.Parties)
            {
                foreach (Character c in p.Characters)
                {
                    string Number = Prompt(string.Format("Enter Initiative for {0}", c.ToString()));
                    int Roll = int.Parse(Number);
                    c.Initiative = Roll;
                }
            }

            Encounter.BuildInitiativeOrder();
        }

        static void ShowInitiativeOrder()
        {
            foreach(Character c in Encounter.InitiativeOrder)
            {
                Console.WriteLine("{0}: {1}", c.Initiative, c.ToString());
            }
        }
        
        static void Quit()
        {
            Environment.Exit(0);
        }
    }
}