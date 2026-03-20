using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai10
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

            var sv = students.OrderByDescending(s => s.Score);

            Console.WriteLine("Danh sach sinh vien diem giam dan:");

            foreach (var student in sv)
            {
                Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Score: {student.Score}");
            }

            Console.WriteLine();
        }
    }
}
