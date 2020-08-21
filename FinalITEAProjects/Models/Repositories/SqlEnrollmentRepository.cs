using FinalITEAProjects.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalITEAProjects.Models.Repositories
{
    public class SqlEnrollmentRepository : IEnrollmentRepository
    {
        private ApplicationDbContext _context { get; set; }

        public SqlEnrollmentRepository(ApplicationDbContext context)
        {
            _context = context;
        }


        public void CreateEnrollment(Enrollment enrollment)
        {
            _context.Enrollments.Add(enrollment);
            _context.SaveChanges();
           // throw new NotImplementedException();
        }

        public void DeleteEnrollment(int enrollmentId)
        {
            var DeleteEnrollment = _context.Enrollments.SingleOrDefault(x => x.EnrollmentID == enrollmentId);
            try
            {
                _context.Enrollments.Remove(DeleteEnrollment);


            }
            catch
            {
                throw new ArgumentNullException($"There is no enrollment with Id = {enrollmentId}");
            }
            finally
            {
                _context.SaveChanges();
            }
           
            //throw new NotImplementedException();
        }

        public IEnumerable<Enrollment> GetAllEnrollments()
        {
          return  _context.Enrollments;
          //  throw new NotImplementedException();
        }

        public Enrollment GetEnrollment(int enrollmentId)
        {
            return _context.Enrollments.SingleOrDefault(x => x.EnrollmentID == enrollmentId);
           // throw new NotImplementedException();
        }

        public void ModifyEnrollment(Enrollment enrollment, int enrollmentId)
        {
            var EnrollmentUpdate = _context.Enrollments.SingleOrDefault(x => x.EnrollmentID == enrollmentId);
            if (EnrollmentUpdate == null)
                return;
            EnrollmentUpdate.Course = enrollment.Course;
            EnrollmentUpdate.Grade = enrollment.Grade;
            EnrollmentUpdate.Student = enrollment.Student;
            EnrollmentUpdate.StudentID = enrollment.StudentID;
            EnrollmentUpdate.CourseID = enrollment.CourseID;
            // throw new NotImplementedException();
            _context.SaveChanges();
        }
    }
}
