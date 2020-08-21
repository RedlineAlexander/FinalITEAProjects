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
            throw new NotImplementedException();
        }

        public void DeleteCourse(int courseId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Course> GetAllCourses()
        {
            throw new NotImplementedException();
        }

        public Course GetCourse(int courseId)
        {
            throw new NotImplementedException();
        }

        public void ModifyCourse(int courseId, Course course)
        {
            throw new NotImplementedException();
        }
    }
}
