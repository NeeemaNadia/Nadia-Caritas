using System.ComponentModel.DataAnnotations;

namespace ConsoleApp5
{
    public class Players
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Team { get; set; }
        public int Phone { get; set; }
        public string Address { get; set; }
    }
}