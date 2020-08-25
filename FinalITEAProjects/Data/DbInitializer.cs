using FinalITEAProjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalITEAProjects.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            if (context.Students.Any())
            {
                return;
            }

            var students = new Student[]
            {
                new Student {FirstMidName = "Carson", LastName="Alexander", EnrollmentDate = DateTime.Parse("2016-09-01")}

            };
            context.Students.AddRange(students);
            context.SaveChanges();

            var instructors = new Instructor[]
            {
                new Instructor {FirstMidName="Kim", LastName="Abercrombie", HireDate=DateTime.Parse("1995-03-11")}
            };
            context.Instructors.AddRange(instructors);
            context.SaveChanges();

            var departments = new Department[]
            {
                new Department {Name = "Alexxander",Budget =10000, StartDate = DateTime.Parse("2020-08-25"), InstructorId = instructors.Single(i=>i.LastName =="Redline").ID }
            };
            context.Departments.AddRange(departments);
            context.SaveChanges();

            var courses = new Course[]
            {
                new Course {CourseID = 1050, Title="Chemistry", Credits=3, DepartmentID=departments.Single(s => s.Name == "Engineering").DepartmentID}
            };
            context.Courses.AddRange(courses);
            context.SaveChanges();

            var OfficeAssignments = new OfficeAssignment[]
            {
                new OfficeAssignment {InstructorID = instructors.Single(i => i.LastName == "Fakhouri").ID , Location = "Smith 17"}
            };
            context.OfficeAssignments.AddRange(OfficeAssignments);
            context.SaveChanges();
            var courseInstructors = new CourseAssignment[]
            {
                new CourseAssignment{CourseID = courses.Single(c => c.Title == "Chemistry" ).CourseID, InstructorID = instructors.Single(i => i.LastName == "Kapoor").ID}

            };

            context.CourseAssignments.AddRange(courseInstructors);
            context.SaveChanges();

            var enrollments = new Enrollment[]
            {
                new Enrollment{StudentID = students.Single(s => s.LastName == "Alexander").ID, CourseID = courses.Single(c => c.Title == "Chemistry").CourseID, Grade = Grade.A},

            };
            foreach(Enrollment e in enrollments)
            {
                var enrollmentInDatabase = context.Enrollments.Where(s => s.StudentID == e.StudentID && s.Course.CourseID == e.CourseID).SingleOrDefault();
                if(enrollmentInDatabase == null)
                {
                    context.Enrollments.Add(e);
                }
            }
            context.SaveChanges();
        }
      
           

    }
}
