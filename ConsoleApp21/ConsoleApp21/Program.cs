using System;
using  System.Linq;
namespace ConsoleApp21
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new StudentContext())
            {
                context.Database.EnsureCreated();
                var repo = new StudentRepository(context);
                
                /*Create new student*/
                Console.WriteLine("enter student information");
                Console.WriteLine("Enter Id");
                var id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter firstname");
                var firstname = Console.ReadLine();
                Console.WriteLine("enter lastname");
                var lastname = Console.ReadLine();
                Console.WriteLine("enter phone");
                var phone = Console.ReadLine();
                var student = repo.Create(id, firstname, lastname, phone);
                
                /*Retrieve all students*/
                Console.WriteLine("All Students!!");
                var students = repo.GetAllStudents.ToList();
                Console.WriteLine("++++++++++++++++++++++++++++++++++");

                foreach (var stu in students)
                {
                    Console.WriteLine($"{stu.Id}    {stu.Firstname}    {stu.Lastname}    {stu.Phone}");
                }
                /*retrieve sinle record*/
                Console.WriteLine("Enter id of a record to retrieve");
                var idToretrieve = Convert.ToInt32(Console.ReadLine());
                var getStudent = repo.GetStudentById(idToretrieve);
                Console.WriteLine($"INORMATION ON {idToretrieve} are Firstname: {getStudent.Firstname} ,Last name: {getStudent.Lastname} and Phone: {getStudent.Phone}");
                
                /*Update a record*/
                Console.WriteLine("Enter id to Update");
                var idToupdate = Convert.ToInt32(Console.ReadLine());
                var updateStudent = repo.GetStudentById(idToupdate);
                if (updateStudent != null)
                {
                    Console.WriteLine("ENTER NEW INFORMATION");
                    Console.WriteLine("ENTER NEW FIRSTNAME");
                    var newFname = Console.ReadLine();
                    updateStudent.Firstname = newFname;
                    Console.WriteLine("ENTER NEW LASTNAME");
                    var newLname = Console.ReadLine();
                    updateStudent.Lastname = newLname;
                    Console.WriteLine("ENTER NEW PHONE");
                    var Phoneu = Console.ReadLine();
                    updateStudent.Phone = Phoneu;
                    repo.Update(updateStudent);
                }
                /*DELETE A REORD IN A DATABASE*/
                Console.Write("Enter Id to deelete a record");
                var idTodelete = Convert.ToInt32(Console.ReadLine());
                var deleteStudent = repo.GetStudentById(idTodelete);
                repo.Delete(deleteStudent);
            }
        }
    }
}