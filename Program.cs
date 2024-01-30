using System;
using System.Data;

namespace Game {

    class Program 
    {
        static int[] char1StatModifiers = [0,0,0,0,0,0];
        static void Main (string[] args) 
        {    
            //Variables
            string[] charStatsNames = ["Strength", "Dexterity", "Constitution", "Intelligence", "Wisdom", "Charisma"];
            int[] char1Stats = [12, 16, 13, 9, 17, 7];
            

            //Functions
            generateStatModifiers(char1Stats);
            //PrintAnArray(char1StatModifiers);
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
        static void generateStatModifiers(int[] statsArray)
        {   

            for (int i = 0; i < statsArray.Length; i++)
            {   
                char1StatModifiers[i] = (statsArray[i] - 10)/2;
                //Console.WriteLine(char1StatModifiers[i]);
            }
            
        }
    }
}