using System.Security.Cryptography.Xml;

namespace Private_School.Data
{
    public class payments
    {
        public required int Payment_ID { get; set; }
        public Reference StudentID { get; set; }
        public Reference SubjectID { get; set; }
        public required DateTime Payment_Date { get; set; }
        public required float total {  get; set; }
        public required string Payment_Method { get; set; }

    }
}
