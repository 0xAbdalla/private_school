namespace Private_School.Data
{
    // SHould be Student
    public class Student
    {
        // removed required. because it's set from db not from us, so we couldn't pass from our side. 
        public  int Id { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string PhoneNumber { get; set; }
        public required DateTime DateOfBirth { get; set; }
        public required string _address { get; set; }
        public required int GradeLevel { get; set; }
    }
}
