using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Filtering
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
        {
            List<int> integers = new List<int>();

            foreach (object item in listOfItems)
            {
                if (item is int)
                {
                    integers.Add((int)item);
                }
            }

            return integers;
        }
    }
}
