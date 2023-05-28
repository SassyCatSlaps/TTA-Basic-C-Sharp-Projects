using System;

// Create a basic Entity Framework Code-First console application that creates a basic Student database and adds one student

namespace FinalChallengeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Made an instance of the DbContext class and used it to add a new student to the 'Students' DbSet over in the 'StudentContext' file
            // Figured I could make this 2 ways: 1. where I give the input || 2. logic that responds to user input -- I figured if I did user input, errors could start occuring so I went with option 1
            // Was getting an error thrown due to my cosent '.SaveChnges' logic so I threw the code block into a try/catch
            try
            {
                using (var context = new StudentContext())
                {
                    var student = new Student { Name = "Vikko", Age = 9000 };
                    context.Students.Add(student);
                    context.SaveChanges();

                    Console.WriteLine("This student was successfully added to the database");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unsightly error has occurred. GROSS!: {ex.InnerException?.Message}");
            }
            Console.ReadLine();
        }
    }
}
