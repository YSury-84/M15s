using System;
using System.Collections.Generic;
using System.Linq;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            var classes = new[]
            {
               new Classroom { Students = {"Evgeniy", "Sergey", "Andrew"}, },
               new Classroom { Students = {"Anna", "Viktor", "Vladimir"}, },
               new Classroom { Students = {"Bulat", "Alex", "Galina"}, }
           };
            var allStudents = GetAllStudents(classes);

            Console.WriteLine(string.Join(" ", allStudents));
        }

        static string[] GetAllStudents(Classroom[] classes)
        {
            //Реализация #1
            List<string> linqtdata = new List<string>();
            var res = from students in classes from student in students.Students select student;
            linqtdata.AddRange(res);
            return linqtdata.ToArray();
            //Реализация #1 (не вызывается, но рабочая)
            List<string> listdata = new List<string>();
            foreach (var student in classes) {listdata.AddRange(student.Students);}
            return listdata.ToArray();
        }

        public class Classroom
        {
            public List<string> Students = new List<string>();
        }
    }
}