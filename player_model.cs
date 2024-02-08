using DB = Game;

namespace CharacterGeneration {
    
public class CharacterGenerationClass 
{
   public static int[] char1StatModifiers = [0,0,0,0,0,0];
public static void generateStatModifiers(int[] statsArray)
        {   
            for (int i = 0; i < statsArray.Length; i++)
            {   
                DB.Program.char1StatModifiers[i] = (statsArray[i] - 10)/2;
                //Console.WriteLine(char1StatModifiers[i]);
            }
        }
}
}
//genChar

// static void generateCharacterF1 (int[] characterSelection1) 
//     {
//         Console.WriteLine("Please enter a value for Class /(/"Paladin, /"Chivalrier/", /"Necromancer/", /"Wizard/", /"Elf Mage/", /"Orc BattleMaster/") ");
//         string typeClass = Console.ReadLine();
//             if (typeClass != null)
//             {
//                 for (int i = 0; i .)
//                 if (typeClass == )
//             }
//     }
// }

// }