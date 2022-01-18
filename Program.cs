using System;
using System.Linq;
using LinqPractices.DBOperations;

namespace LinqPractices
{
    class Program
    {
        static void Main(string[] args)
        {
            DataGenerator.Initialize();
            LinqDbContext _context = new LinqDbContext();
            var students = _context.Students.ToList<Student>();
            //find
            Console.WriteLine("******find******");
            var student = _context.Students.Where(student => student.StudentID == 1).FirstOrDefault();
            student = _context.Students.Find(2);
            Console.WriteLine(student.Name);

            //first or default
            Console.WriteLine("******find\n");
            student = _context.Students.Where(student => student.Surname == "Yılmaz").FirstOrDefault();
            Console.WriteLine(student.Name);
            student = _context.Students.FirstOrDefault(x => x.Surname == "Yılmaz");
            Console.WriteLine(student.Name);


            //single or default
            Console.WriteLine("******single or def\n");
            student = _context.Students.SingleOrDefault(student => student.Name == "Zafer");
            Console.WriteLine(student.Name);

            //tolist
            Console.WriteLine("******tolist\n");
            var studentList = _context.Students.Where(student => student.ClassID == 3).ToList();
            Console.WriteLine(studentList.Count());

            //orderby
            Console.WriteLine("******tolist\n");
            students = _context.Students.OrderBy(x => x.StudentID).ToList();

            foreach (var st in students)
            {
                Console.WriteLine(st.StudentID + " " + st.Name + " " + st.Surname);
            }

            //orderby desc
            Console.WriteLine("******tolist\n");
            students = _context.Students.OrderByDescending(x => x.StudentID).ToList();

            foreach (var st in students)
            {
                Console.WriteLine(st.StudentID + " " + st.Name + " " + st.Surname);
            }


        }
    }
}
