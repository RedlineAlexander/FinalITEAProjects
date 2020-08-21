using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalITEAProjects.Models.Repositories
{
    public interface IEnrollmentRepository
    {
        public IEnumerable<Enrollment> GetAllEnrollments();
        public Enrollment GetEnrollment(int enrollmentId);
        public void CreateEnrollment(Enrollment enrollment);

        public void ModifyEnrollment(Enrollment enrollment, int enrollmentId);

        public void DeleteEnrollment(int enrollmentId);
    }
}
