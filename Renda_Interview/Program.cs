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
           // var values = new int[] { 1, 2, 2, 3, 3, 4, 5, 5 };
            var input = new int[10];
            for (int i = 0; i < input.Length; i++)
            {
                input[i] = Convert.ToInt32(Console.ReadLine());
            }
            RemoveDuplicateFromArray(input);
            Console.WriteLine();
            Console.ReadLine();
        }

        static void RemoveDuplicateFromArray(int[] duplicateArray)
        {
            var responseHashSet = new HashSet<int>();
            if (duplicateArray != null && duplicateArray.Any())
            {
                for (int i = 0; i < duplicateArray.Length; i++)
                {
                    var item = duplicateArray[i];
                    responseHashSet.Add(item);

                }
            }
            var result = responseHashSet.ToArray();
            for(int item = 1; item < result.Length; item++)
            {
                //resultArray = resultArray[item];
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
    }
}
