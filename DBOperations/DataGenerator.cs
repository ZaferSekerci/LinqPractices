using System.Linq;

namespace LinqPractices.DBOperations
{
    public class DataGenerator
    {
        public static void Initialize()
        {
            using (var context = new LinqDbContext())
            {
                if (context.Students.Any())
                    return;
                context.AddRange(
                    new Student()
                    {
                        StudentID = 1,
                        Name = "Zafer",
                        Surname = "Yılmaz",
                        ClassID = 2
                    },
                    new Student()
                    {
                        StudentID = 2,
                        Name = "Dilek",
                        Surname = "Palkara",
                        ClassID = 3
                    },
                    new Student()
                    {
                        StudentID = 3,
                        Name = "Ayşe",
                        Surname = "Uygun",
                        ClassID = 3
                    },
                    new Student()
                    {
                        StudentID = 4,
                        Name = "Ali",
                        Surname = "Algın",
                        ClassID = 3
                    }

                );
                context.SaveChanges();



            }
        }
    }
}