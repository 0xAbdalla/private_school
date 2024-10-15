using System.ComponentModel.DataAnnotations;

namespace Private_School.Data
{
    public class board_of_directories
    {
        [Key]
        public required int BMID { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required int PhoneNumber { get; set; }
        public required string Role { get; set; }
        public required string _address { get; set; }
        public required float Salary { get; set; }

    }
}
