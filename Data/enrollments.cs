using System.Security.Cryptography.Xml;

namespace Private_School.Data
{
    public class enrollments
    {
        public required int Enrollment_ID { get; set; }
        public Reference StudentID { get; set; }
        public Reference SubjectID { get; set; }
        public required string Semester { get; set; }



    }
}
