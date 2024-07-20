using P01_StudentSystem.Data;

namespace P01_StudentSystem
{
    internal class Program
    { 
        static void Main(string[] args)
        {

            StudentSystemContext context = new StudentSystemContext();
            context.Students.Add(new P01__StudentSystem.Models.Students { Birthday = DateTime.Parse("2024-07-19"), Name = "Ahmed" , PhoneNo = "0111111" , RegisteredOn = DateTime.Parse("2024-08-19") });
            context.Students.Add(new P01__StudentSystem.Models.Students { Birthday = DateTime.Parse("2000-07-19"), Name = "Mohamed" , PhoneNo = "012366555" , RegisteredOn = DateTime.Parse("2024-07-20") });
            context.Students.Add(new P01__StudentSystem.Models.Students { Birthday = DateTime.Parse("2001-07-19"), Name = "Ali" , PhoneNo = "01456667" , RegisteredOn = DateTime.Parse("2024-04-15") });
            context.Students.Add(new P01__StudentSystem.Models.Students { Birthday = DateTime.Parse("2002-01-19"), Name = "Mona" , PhoneNo = "0199898" , RegisteredOn = DateTime.Parse("2024-06-30") });
            context.Students.Add(new P01__StudentSystem.Models.Students { Birthday = DateTime.Parse("1994-08-19"), Name = "Mohsen" , PhoneNo = "01236666" , RegisteredOn = DateTime.Parse("2024-07-19") });
            context.Students.Add(new P01__StudentSystem.Models.Students { Birthday = DateTime.Parse("2000-01-01"), Name = "Amjad" , PhoneNo = "01559999" , RegisteredOn = DateTime.Parse("2023-07-14") });
            context.Students.Add(new P01__StudentSystem.Models.Students { Birthday = DateTime.Parse("1998-07-15"), Name = "Heba" , PhoneNo = "0122333333" , RegisteredOn = DateTime.Parse("2021-08-12") });

            

            context.Courses.Add(new P01__StudentSystem.Models.Courses { Name = "CS", Description = "CS", StartDate = DateTime.Parse("2000-07-10"), EndDate = DateTime.Parse("2024-07-19"), Price = 20 });
            context.Courses.Add(new P01__StudentSystem.Models.Courses { Name = "IS", Description = "IS", StartDate = DateTime.Parse("2000-05-11"), EndDate = DateTime.Parse("2024-07-19"), Price = 30 });
            context.Courses.Add(new P01__StudentSystem.Models.Courses { Name = "PL", Description = "CS", StartDate = DateTime.Parse("2001-01-01"), EndDate = DateTime.Parse("2024-07-19"), Price = 550 });
            context.Courses.Add(new P01__StudentSystem.Models.Courses { Name = "PL2", Description = "IS", StartDate = DateTime.Parse("2020-07-08"), EndDate = DateTime.Parse("2024-07-19"), Price = 50 });
            context.Courses.Add(new P01__StudentSystem.Models.Courses { Name = "Math", Description = "CS", StartDate = DateTime.Parse("2023-07-19"), EndDate = DateTime.Parse("2024-07-19"), Price = 77 });
            context.Courses.Add(new P01__StudentSystem.Models.Courses { Name = "English", Description = "IS", StartDate = DateTime.Parse("2024-07-19"), EndDate = DateTime.Parse("2024-07-19"), Price = 100 });
            context.Courses.Add(new P01__StudentSystem.Models.Courses { Name = "Arabic", Description = "CS", StartDate = DateTime.Parse("2024-07-19"), EndDate = DateTime.Parse("2024-07-19"), Price = 900 });
            context.Courses.Add(new P01__StudentSystem.Models.Courses { Name = "IS", Description = "IS", StartDate = DateTime.Parse("2024-07-19"), EndDate = DateTime.Parse("2024-07-19"), Price = 200 });

            
            
            context.Resources.Add(new P01__StudentSystem.Models.Resources { Name = "Res1", Url = "www.Res1.com",CourseID = 1 });
            context.Resources.Add(new P01__StudentSystem.Models.Resources { Name = "Res2", Url = "www.Res2.com",CourseID = 2 });
            context.Resources.Add(new P01__StudentSystem.Models.Resources { Name = "Res3", Url = "www.Res3.com",CourseID = 3 });
            context.Resources.Add(new P01__StudentSystem.Models.Resources { Name = "Res4", Url = "www.Res4.com",CourseID = 4 });
            context.Resources.Add(new P01__StudentSystem.Models.Resources { Name = "Res5", Url = "www.Res5.com",CourseID = 5 });
            context.Resources.Add(new P01__StudentSystem.Models.Resources { Name = "Res6", Url = "www.Res6.com",CourseID = 6 });
            context.Resources.Add(new P01__StudentSystem.Models.Resources { Name = "Res7", Url = "www.Res7.com",CourseID = 7 });
            context.Resources.Add(new P01__StudentSystem.Models.Resources { Name = "Res8", Url = "www.Res8.com",CourseID = 8 });
            
            
            context.Homework.Add(new P01__StudentSystem.Models.Homework { Contect = "Homework1", SubmissionTime = DateTime.Parse("2024-07-19")  , CourseID = 2 , StudentID = 1});
            context.Homework.Add(new P01__StudentSystem.Models.Homework { Contect = "Homework2", SubmissionTime = DateTime.Parse("2000-11-19")  , CourseID = 4 , StudentID = 4});
            context.Homework.Add(new P01__StudentSystem.Models.Homework { Contect = "Homework3", SubmissionTime = DateTime.Parse("1998-01-01")  , CourseID = 5 , StudentID = 3});
            context.Homework.Add(new P01__StudentSystem.Models.Homework { Contect = "Homework4", SubmissionTime = DateTime.Parse("1997-07-11")  , CourseID = 1 , StudentID = 2});
            context.Homework.Add(new P01__StudentSystem.Models.Homework { Contect = "Homework5", SubmissionTime = DateTime.Parse("2022-07-14")  , CourseID = 2 , StudentID = 5});
            context.Homework.Add(new P01__StudentSystem.Models.Homework { Contect = "Homework6", SubmissionTime = DateTime.Parse("2022-07-20")  , CourseID = 3 , StudentID = 3});
            context.Homework.Add(new P01__StudentSystem.Models.Homework { Contect = "Homework7", SubmissionTime = DateTime.Parse("2000-12-01")  , CourseID = 6 , StudentID = 2});
            context.SaveChanges();
        }
    }
}
