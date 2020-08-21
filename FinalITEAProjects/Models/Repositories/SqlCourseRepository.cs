using FinalITEAProjects.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalITEAProjects.Models.Repositories
{
    public class SqlCourseRepository : ICourseRepository
    {
        private ApplicationDbContext _context { get; set; }

        public SqlCourseRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void CreateCourse(Course course)
        {
            _context.Courses.Add(course);
            _context.SaveChanges();
            //throw new NotImplementedException();
        }

        public void DeleteCourse(int courseId)
        {
            var DeleteCourse = _context.Courses.SingleOrDefault(x => x.CourseID == courseId);
            try
            {
                _context.Courses.Remove(DeleteCourse);
            }
            catch
            {
                throw new ArgumentNullException($"There is no course {courseId}");
            }
            finally
            {
                _context.SaveChanges();
            }
            //throw new NotImplementedException();
        }

        public IEnumerable<Course> GetAllCourses()
        {
           return _context.Courses;
            //throw new NotImplementedException();
        }

        public Course GetCourse(int courseId)
        {
            return _context.Courses.SingleOrDefault(x => x.CourseID == courseId);
            //throw new NotImplementedException();
        }

        public void ModifyCourse(int courseId, Course course)
        {
            var CourseUpdate = _context.Courses.SingleOrDefault(x => x.CourseID == courseId);
            if (CourseUpdate == null)
                return;
            // throw new NotImplementedException();
            CourseUpdate.Title = course.Title;
            CourseUpdate.Credits = course.Credits;
            CourseUpdate.Enrollments = course.Enrollments;
            _context.SaveChanges();
        }
    }
}
