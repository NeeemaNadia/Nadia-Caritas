using System.ComponentModel.DataAnnotations;

namespace ConsoleApp21
{
    public class Student
    {
        [Required(ErrorMessage = "Can't be empty")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Can't be empty")]
        public string Firstname { get; set; }
        [Required(ErrorMessage = "Can't be empty")]
        public string Lastname { get; set; }
        [Required(ErrorMessage = "Can't be empty")]
        public string Phone { get; set; }
    }
}