using System;
using System.Data;
using CharacterGeneration;

namespace Game {

    class Program 
    {
            

        static int[] char1StatModifiers = [0,0,0,0,0,0];
        static string[] typesOfClasses = ["Paladin", "Chivalrier", "Necromancer", "Wizard", "Elf Mage", "Orc BattleMaster"];
        static void Main (string[] args) 
        {    
            CharacterGenerationClass characterGenerator = new();
            //Variables
            string[] charStatsNames = ["Strength", "Dexterity", "Constitution", "Intelligence", "Wisdom", "Charisma"];
            int[] char1Stats = [12, 16, 13, 9, 17, 7];
            

            //Functions

            CharacterGenerationClass.generateStatModifiers(char1Stats);
            
            //PrintAnArray(char1StatModifiers);
            PrintStatModifiers(CharacterGenerationClass.char1StatModifiers, charStatsNames);
            PrintStatModifiers(char1StatModifiers, charStatsNames);
            
        }
        
        static void PrintAnArray(int[] array)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine($"Array {i} index value is {array[i]}");
                }
            }
            static void PrintStatModifiers(int[] array, string[] charStatsNames)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine($"{charStatsNames[i]} modifier is {array[i]}");
                }
            }
        
    
    
    }
}