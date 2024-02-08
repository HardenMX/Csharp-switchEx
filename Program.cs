using System;
using System.Data;
using CharG = CharacterGeneration;


namespace Game 
{
    class Program 
    {
            
        public static int[] char1StatModifiers = [0,0,0,0,0,0];
        static string[] typesOfClasses = ["Paladin", "Chivalrier", "Necromancer", "Wizard", "Elf Mage", "Orc BattleMaster"];


        static void Main (string[] args) 
        {    
            // CharG.CharacterGenerationClass characterGenerator = new();
            //Variables
            string[] charStatsNames = ["Strength", "Dexterity", "Constitution", "Intelligence", "Wisdom", "Charisma"];
            int[] char1Stats = [12, 16, 13, 9, 17, 7];
            

            //Functions

            CharG.CharacterGenerationClass.generateStatModifiers(char1Stats);
            
            //PrintAnArray(char1StatModifiers);
            PrintStatModifiers(CharG.CharacterGenerationClass.char1StatModifiers, charStatsNames);
            PrintStatModifiers(char1StatModifiers, charStatsNames);
        }
        

    class Utils 
    { 
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
}