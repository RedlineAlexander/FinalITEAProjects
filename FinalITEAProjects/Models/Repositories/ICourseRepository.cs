using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalITEAProjects.Models.Repositories
{
   public interface ICourseRepository
    {
        public IEnumerable<Course> GetAllCourses();
        public Course GetCourse(int courseId);
        public void CreateCourse(Course course);
        public void ModifyCourse(int courseId, Course course);
        public void DeleteCourse(int courseId); 
    }
}
