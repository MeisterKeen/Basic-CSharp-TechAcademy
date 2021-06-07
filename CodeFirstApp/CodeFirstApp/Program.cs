using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace CodeFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new EnrollmentContext())
            {
                Console.WriteLine("Enter the subject name of your class:");
                var subject = Console.ReadLine();
                Console.WriteLine("Enter the class year:");
                var year = Console.ReadLine();

                var rolls = new Rolls { Subject = subject, Year = year };
                db.Rolls.Add(rolls);
                db.SaveChanges();

                bool addAnother = true;
                
                while (addAnother)
                {
                    Console.WriteLine("Enter student first name:");
                    var fname = Console.ReadLine();
                    Console.WriteLine("Enter student last name:");
                    var lname = Console.ReadLine();
                    Console.WriteLine("Enter student email address:");
                    var email = Console.ReadLine();

                    var student = new Student { firstName = fname, lastName = lname, emailAddress = email };
                    db.Students.Add(student);
                    db.SaveChanges();

                    Console.WriteLine("Would you like to enter another student?");
                    var yesNo = Console.ReadLine().ToLower();

                    if (yesNo != "yes" || yesNo != "y" || yesNo != "ya" || yesNo != "yeah" || yesNo != "yah") 
                    {
                        break;
                    }
                }

                Console.WriteLine("Currently enrolled students:");
                foreach (Student s in db.Students)
                {
                    Console.WriteLine("ID:{0} :: {1}, {2} :: email: {3}", s.StudentId, s.lastName, s.firstName, s.emailAddress);
                }
                Console.WriteLine("\n\nPress any key to exit:");
                Console.ReadKey();

            }
        }

        public class Rolls
        {
            [Key]
            public int RollId { get; set; }
            public string Subject { get; set; }
            public string Year { get; set; }

            public virtual List<Student> students { get; set; }
        }

        public class Student
        {
            [Key]
            public int StudentId { get; set; }
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string emailAddress { get; set; }
            public decimal GPA { get; set; }
            public virtual Rolls Rolls { get; set; }

        }

        public class EnrollmentContext : DbContext
        {
            public DbSet<Rolls> Rolls { get; set; }
            public DbSet<Student> Students { get; set; }
        }

    }
}
