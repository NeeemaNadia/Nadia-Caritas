using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Query;

namespace ConsoleApp21
{
    public interface IStudentRepository
    {
        public Student GetStudentById(int id);
        public Student Create(int id, string firstname, string lastname, string phone);
        public Student Update(Student student);
        public Student Delete(Student student);
        public IEnumerable<Student> GetAllStudents { get; }

    }
}