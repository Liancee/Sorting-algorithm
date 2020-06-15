using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Selection_Sort.selectSort(new[] { 7, 4, 12, 1, 2 }).ToList().ForEach(x => Console.WriteLine(x));
            Console.ReadKey();
        }
    }
}
