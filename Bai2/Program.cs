using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=========================================");
            Console.WriteLine("NGUYEN LONG NHAT - 23115053122126-23T1");
            Console.WriteLine("=========================================\n");

            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };

            var list = numbers.Where(x => x > 5).ToList();

            Console.Write("Cac so > 5 la: ");

            foreach (var item in list)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("\n");
        }
    }
}
