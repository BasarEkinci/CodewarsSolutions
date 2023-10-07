using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Opposites_Attract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(loveFunc(2, 3));
            Console.ReadLine();
        }

        static bool loveFunc(int flower1,int flower2)
        {
            int flowers = flower2 + flower1;

            return flowers % 2 == 0 ? false : true;
        }
        //Timmy & Sarah think they are in love, but around where they live, they will only know once they pick a flower each.
        //If one of the flowers has an even number of petals and the other has an odd number of petals it means they are in love.
        //Write a function that will take the number of petals of each flower and return true if they are in love and false if they aren't.
    }
}
