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
            //throw new NotImplementedException();
        }

        public void DeleteStudent(int studentId)
        {
            //throw new NotImplementedException();
        }

        public IEnumerable<Student> GetAllStudents()
        {
           // throw new NotImplementedException();
        }

        public Student GetStudent(int studentId)
        {
           // throw new NotImplementedException();
        }

        public void ModifyStudent(int studentId, Student student)
        {
            //throw new NotImplementedException();
        }
    }
}
