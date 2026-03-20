using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=========================================");
            Console.WriteLine("NGUYEN LONG NHAT - 23115053122126-23T1");
            Console.WriteLine("=========================================\n");

            List<int> numbers = new List<int> { 7, 5, 3, 6, 12, 2, 9, 8 };

            Console.Write("Danh sach ban dau: ");

            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }

            var list = numbers.OrderBy(n => n);

            Console.WriteLine("\nDanh sach sau khi sap xep tang dan: ");
            foreach (int number in list)
            {
                Console.Write(number + " ");
            }
        }
    }
}
