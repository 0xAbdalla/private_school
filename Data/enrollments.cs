using System.Security.Cryptography.Xml;

namespace Private_School.Data
{
    public class Enrollment
    {
        public  int Id { get; set; }
        public Reference StudentID { get; set; }
        public Reference SubjectID { get; set; }
        public required string Semester { get; set; }



    }
}
