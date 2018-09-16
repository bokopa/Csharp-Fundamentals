using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Average_Grades
{
    class Program
    {
        static void Main(string[] args)

        {
            int studentCount = int.Parse(Console.ReadLine());

            List<Student> students = new List<Student>();

            while (studentCount-- > 0)
            {
                Student student = new Student();
               string[] studentsInfo = Console.ReadLine().Split();

                string studentName = studentsInfo[0];

                student.Name = studentName;
                
                student.Grades = studentsInfo.Skip(1).Select(double.Parse).ToList();
                students.Add(student);
            }
            students
                .Where(s => s.AverageGrade >= 5)
                .OrderBy(s => s.Name)
                .ThenByDescending(s => s.AverageGrade)
                .ToList()
                .ForEach(s =>
                {
                    Console.WriteLine($"{s.Name} -> {s.AverageGrade:F2}");
                });
        }
    }

    class Student
    {
        public string Name { get; set; }
        public List<double> Grades { get; set; }
        public double AverageGrade { get { return Grades.Average(); } }

        

    }
}
