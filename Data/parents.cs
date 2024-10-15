using System.Security.Cryptography.Xml;

namespace Private_School.Data
{
    public class parents
    {
        public required int ParentID { get; set; }
        public Reference StudentID { get; set; }

        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string PhoneNumber { get; set; }
    }
}
