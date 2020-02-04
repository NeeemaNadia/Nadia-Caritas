using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp21
{
    public class StudentRepository: IStudentRepository
    {
        private readonly StudentContext _studentContext;
        public StudentRepository(StudentContext studentContext)
        {
            _studentContext = studentContext;
        }

        public Student GetStudentById(int id)
        {
            /*throw new System.NotImplementedException();*/
            return _studentContext.Students.FirstOrDefault(e=> e.Id == id);
        }

        public Student Create(int id, string firstname, string lastname, string phone)
        {
            var result= _studentContext.Add(new Student
            {
                Firstname=firstname,
                Lastname=lastname,
                Phone=phone
            });
            _studentContext.SaveChanges();
            return result.Entity;
        }

        public Student Update(Student student)
        {
            /*throw new System.NotImplementedException();*/
            var result = _studentContext.Update(student);
            _studentContext.SaveChanges();
            return result.Entity;
        }

        public Student Delete(Student student)
        {
            /*throw new System.NotImplementedException();*/
            var result = _studentContext.Remove(student);
            _studentContext.SaveChanges();
            return result.Entity;
        }

        public IEnumerable<Student> GetAllStudents
        {
            get { return _studentContext.Students; }
        }
    }
}