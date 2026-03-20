using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=========================================");
            Console.WriteLine("NGUYEN LONG NHAT - 23115053122126-23T1");
            Console.WriteLine("=========================================\n");

            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("Danh sach ban dau: " + string.Join(", ", numbers));

            var list = numbers.Where(n => n % 2 == 0);

            Console.Write("Cac so chan trong sanh sach: ");

            foreach (var number in list)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();
        }
    }
}
