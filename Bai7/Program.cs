using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=======================================");
            Console.WriteLine("NGUYEN LONG NHAT-23115053122126-23T1");
            Console.WriteLine("=======================================\n");

            List<int> numbers = new List<int> { 1, 20, 3, 8, 5 };

            Console.Write("Danh sach ban dau: ");
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }

            if (numbers.Any(n => n > 10))
            {
                Console.WriteLine("\nCo so lon hon 10 trong danh sach.");
            }
            else
            {
                Console.WriteLine("\nKhong co so nao lon hon 10 trong danh sach.");
            }
        }
    }
}
