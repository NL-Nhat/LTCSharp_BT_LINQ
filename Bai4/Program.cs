using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=========================================");
            Console.WriteLine("NGUYEN LONG NHAT - 23115053122126-23T1");
            Console.WriteLine("=========================================\n");

            List<int> numbers = new List<int> { 1, 5, 3, 8, 12, 6, 4, 2, 23, 10 };

            Console.Write("Danh sach ban dau: ");

            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }

            var list = numbers.OrderByDescending(n => n);

            Console.Write("\nDanh sach sau khi sap xep giam dan: ");
            foreach (int number in list)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();
        }
    }
}
