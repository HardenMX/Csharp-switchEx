using System;
using System.Data;

namespace Game {

    class Program 
    {   
        public static int[] char1StatModifiers = [];
        static void Main (string[] args) 
        {    
            //Variables
            string[] charStatsNames = ["Strength", "Dexterity", "Constitution", "Intelligence", "Wisdom", "Charisma"];
            int[] char1Stats = [12, 16, 13, 10, 16, 8];
            

            //Functions
            generateStatModifiers(char1Stats);
            //PrintAnArray(char1StatModifiers);
            //PrintAnArray(char1Stats);
            
        }
        
        static void PrintAnArray(int[] array)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine($"Array {i} index value is {array[i]}");
                }
            }
        static void generateStatModifiers(int[] statsArray)
        {   int valueHolder;
    
            for (int i = 0; i >= statsArray.Length; i++)
            {
                valueHolder = statsArray[i];
                char1StatModifiers[i] = (valueHolder - 10)/2;
                Console.WriteLine(char1StatModifiers[i]);
            }
            
        }
    }
}