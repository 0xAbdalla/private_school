using System.Security.Cryptography.Xml;

namespace Private_School.Data
{
    public class Teacher
    {
        public int Id { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required int PhoneNumber { get; set; }
        public required int GradeLevel { get; set; }
        public required string _address { get; set; }
        public Reference SubjectID { get; set; }
    }
}
