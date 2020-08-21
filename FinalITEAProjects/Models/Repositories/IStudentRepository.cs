using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalITEAProjects.Models.Repositories
{
    public interface IStudentRepository
    {
        public IEnumerable<Student> GetAllStudents();
        public Student GetStudent(int studentId);
        public void CreateStudent(Student student);
        public void ModifyStudent(int studentId, Student student);

        public void DeleteStudent(int studentId);
    }
}
