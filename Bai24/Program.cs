using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai24
{
    class Student
    {
        public int Id { get; set; }
        public int tuoi { get; set; }
        public double diem { get; set; }
        public string khoa { get; set; }
        public int nam { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=========================================");
            Console.WriteLine("NGUYEN LONG NHAT-23115053122126-23T1");
            Console.WriteLine("========================================\n");

            var students = taoSV(15);

            foreach (var sv in students)
            {
                Console.WriteLine(
                    $"Id: {sv.Id} | Tuoi: {sv.tuoi} | Diem: {sv.diem} | Khoa: {sv.khoa} | Khoa hoc: K{sv.nam}"
                );
            }

            var dssv = students.Where(s => s.nam != 22);

            Console.WriteLine("\nDanh sach sinh vien ko co nam cuoi (khoa 22):");

            foreach (var sv in dssv)
            {
                Console.WriteLine(
                    $"Id: {sv.Id} | Tuoi: {sv.tuoi} | Diem: {sv.diem} | Khoa: {sv.khoa} | Khoa hoc: K{sv.nam}"
                );
            }

            Console.WriteLine();
        }

        static List<Student> taoSV(int n)
        {
            Random rd = new Random();
            List<Student> list = new List<Student>();

            string[] faculties = { "CNS", "CNTT", "QTKD", "KT", "DL" };
            int[] courses = { 22, 23, 24, 25 };

            for (int i = 0; i < n; i++)
            {
                Student sv = new Student
                {
                    Id = i + 1,
                    tuoi = rd.Next(18, 25),                        // 18 - 24 tuổi
                    diem = Math.Round(rd.NextDouble() * 10, 2), // 0 - 10 điểm
                    khoa = faculties[rd.Next(faculties.Length)],
                    nam = courses[rd.Next(courses.Length)]
                };

                list.Add(sv);
            }

            return list;
        }
    }
}
