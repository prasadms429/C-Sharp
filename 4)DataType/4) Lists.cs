using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> starTechCharacters=new List<string>(); // Storage of Lists takes more memory than Arrays and Lists can be modified after creating it, it is not possible in case of array.

            starTechCharacters.Add("Candy");    //"Candy" added to index 0
            starTechCharacters.Add("Randy");    //"Randy" added to index 1
            starTechCharacters.Add("Mandy");    //"Mandy" added to index 2

            starTechCharacters.Insert(2, "Kaju");   //"Kaju" is added to index 2 and "Mandy" is shifted up to index 3

            starTechCharacters.RemoveAt(2); //"Kaju" is removed and "Mandy" is shifted down to index 2

            starTechCharacters.Remove("Randy"); //"Randy" is removed and "Mandy" is shifted down to index 1

            string firstCharacter = starTechCharacters[0]; // stores the string "Candy" in firstCharacter variable
            starTechCharacters[0] = "Bajji";    // "Candy" is replaced by "Bajji"

            foreach(string starTechCharacter in starTechCharacters)
            {
                Console.WriteLine(starTechCharacter);
            }

            Console.ReadLine();
        }
    }
}
