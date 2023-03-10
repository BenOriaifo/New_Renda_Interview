using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renda_Interview
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var values = new int[] { 1, 2, 2, 3, 3, 4, 5, 5 };
            Console.WriteLine(RemoveDuplicateFromArray(values));
            Console.ReadLine();
        }

        static int[] RemoveDuplicateFromArray(int[] duplicateArray)
        {
            var responseHashSet = new HashSet<int>();
            if(duplicateArray != null && duplicateArray.Any())
            {
                for(int i = 0; i < duplicateArray.Length; i++)
                {
                    var item = duplicateArray[i];
                    responseHashSet.Add(item);
                    Console.WriteLine(item);
                }
            }
            return responseHashSet.ToArray();
        }

        static int ReturnElementWithHightestNumberOfOccurence(int[] values)
        {

        }
    }
}
