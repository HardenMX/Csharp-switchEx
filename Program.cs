using System;
using System.Data;

namespace Game {

    class Program 
    {
        static void Main (string[] args) 
        {    
            string[] charStatsNames = ["Strength", "Dexterity", "Constitution", "Intelligence", "Wisdom", "Charisma"];
            int[] charStats = [12, 16, 13, 10, 16, 8];

            int[] char1StatModifiers = [];
            
            //Console.WriteLine();

            PrintAnArray([1, 2, 3]);
        }
        
         static void PrintAnArray(int[] array)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine($"Array {i} index value is {array[i]}");
                }
            }
    }
}