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
           // throw new NotImplementedException();
        }

        public void DeleteEnrollment(int enrollmentId)
        {
            //throw new NotImplementedException();
        }

        public IEnumerable<Enrollment> GetAllEnrollments()
        {
          //  throw new NotImplementedException();
        }

        public Enrollment GetEnrollment(int enrollmentId)
        {
           // throw new NotImplementedException();
        }

        public void ModifyEnrollment(Enrollment enrollment, int enrollmentId)
        {
           // throw new NotImplementedException();
        }
    }
}
