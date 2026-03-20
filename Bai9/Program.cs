using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai9
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Score { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=======================================");
            Console.WriteLine("NGUYEN LONG NHAT-23115053122126-23T1");
            Console.WriteLine("=======================================\n");

            List<Student> students = new List<Student>() {
                new Student { Id = 1, Name = "An", Score = 8 },
                new Student { Id = 2, Name = "Binh", Score = 6 },
                new Student { Id = 3, Name = "Chi", Score = 9 },
                new Student { Id = 4, Name = "Dung", Score = 7 }
            };

            var sv = students.Select(s => s.Name);

            Console.Write("Danh sach ten sinh vien: ");

            foreach (var name in sv)
            {
                Console.Write(name + " ");
            }

            Console.WriteLine();    
        }
    }
}
