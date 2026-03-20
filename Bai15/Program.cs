using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=======================================");
            Console.WriteLine("NGUYEN LONG NHAT-23115053122126-23T1");
            Console.WriteLine("=======================================\n");

            List<int> numbers = new List<int>() { 1, 2, 2, 3, 4, 4, 5 };

            Console.Write("Danh sach ban dau: ");

            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }

            var uniques = numbers.Distinct();

            Console.Write("\nDanh sach khong trung: ");

            foreach (var number in uniques)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();
        }
    }
}
