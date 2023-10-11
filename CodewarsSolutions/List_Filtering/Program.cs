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
            return listOfItems.Where(item => item is int).Cast<int>();
        }
    }
}
