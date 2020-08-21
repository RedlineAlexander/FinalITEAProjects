using FinalITEAProjects.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalITEAProjects.Models.Repositories
{
    public class SqlStudentRepository : IStudentRepository
    {
        private ApplicationDbContext _context { get; set; }

        public SqlStudentRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void CreateStudent(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
            //throw new NotImplementedException();
        }

        public void DeleteStudent(int studentId)
        {
            var DeleteStudent = _context.Students.SingleOrDefault(x => x.ID == studentId);
            try
            {
                _context.Students.Remove(DeleteStudent);
            }
            catch
            {
                throw new ArgumentNullException($"There is no student with Id = {studentId}");
            }
            finally
            {
                _context.SaveChanges();
            }
            //throw new NotImplementedException();
        }

        public IEnumerable<Student> GetAllStudents()
        {
            return _context.Students;
           // throw new NotImplementedException();
        }

        public Student GetStudent(int studentId)
        {
            return _context.Students.SingleOrDefault(x => x.ID == studentId);
           // throw new NotImplementedException();
        }

        public void ModifyStudent(int studentId, Student student)
        {
            var studentToUpdate = _context.Students.SingleOrDefault(x => x.ID == studentId);
            if (studentToUpdate == null)
                return;

            studentToUpdate.FirstMidName = student.FirstMidName;
            studentToUpdate.LastName = student.LastName;
            studentToUpdate.EnrollmentDate = student.EnrollmentDate;
            studentToUpdate.Enrollments = student.Enrollments;
            //throw new NotImplementedException();
            _context.SaveChanges();
        }
    }
}
