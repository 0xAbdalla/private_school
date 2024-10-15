﻿namespace private_school.Dto
{
    public class StudentDto
    {
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string PhoneNumber { get; set; }
        public required DateTime DateOfBirth { get; set; }
        public required string _address { get; set; }
        public required int GradeLevel { get; set; }
    }
}