using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=======================================");
            Console.WriteLine("NGUYEN LONG NHAT-23115053122126-23T1");
            Console.WriteLine("=======================================\n");

            List<int> numbers = new List<int>() { 1, 1, 2, 3, 4, 4, 7, 4, 9 };

            Console.Write("Danh sach ban dau: ");

            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }

            var so = numbers.GroupBy(n => n)
                            .OrderByDescending(g => g.Count())
                            .First()
                            .Key;

            Console.Write($"\nSo xuat hien nhieu nhat la: {so}");

            Console.WriteLine();
        }
    }
}
