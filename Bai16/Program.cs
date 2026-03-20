using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=======================================");
            Console.WriteLine("NGUYEN LONG NHAT-23115053122126-23T1");
            Console.WriteLine("=======================================\n");

            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

            Console.Write("Danh sach ban dau: ");

            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine("\nTong cac so: " + numbers.Sum());

            Console.WriteLine();
        }
    }
}
