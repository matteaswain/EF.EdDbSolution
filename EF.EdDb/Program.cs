using EF.EdDb.Models;
using System;
using System.Linq;

namespace EF.EdDb
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new EdDbContext();
// Method example // Students who live in KY, sorted by last name ascending 

            //var studentsinKY = context.Students
            //    .Where(s => s.StateCode == "KY")
            //    .OrderBy(s => s.Lastname)
            //    .ToList();


            //foreach(var s in studentsinKY)
            //{

            //    Console.WriteLine($" {s.Firstname} {s.Lastname}");
            //}



// Query Example // Joined Major table fpr Students who live in Ky, calling for name/major columns

            //var studentsWithMajor = from s in context.Students
            //                        join m in context.Majors
            //                        on s.MajorId equals m.Id
            //                        where s.StateCode == "KY"
            //                        orderby s.Lastname
            //                        select new { s.Firstname, s.Lastname, Major = m.Description };

// query syntax is not executed when encountered but when the var is used in a statment
// 
            //foreach( var s in studentsWithMajor) // var studentWithMajor used in a statement
            //{
            //    Console.WriteLine($"{s.Firstname} {s.Lastname} || {s.Major} ");
            //}   

        }
    }
}
