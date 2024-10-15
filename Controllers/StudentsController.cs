using Microsoft.AspNetCore.Mvc;
using private_school.Dto;
using Private_School.Data;

namespace Private_School.Controllers
{
    [ApiController]
    [Route("[controller]")]
    // renamed the controller to represent what it does
    public class StudentsController : ControllerBase
    {
        private readonly ApplicationDbContext _appDbContext;

        public StudentsController(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        // naming convention to follow pascal case
        [HttpPost]
        public IActionResult RegisterStudent([FromBody] StudentDto stu)
        {
            if (stu == null) // Ensure student object is not null
            {
                return BadRequest("Student data is null.");
            }

            try
            {
                var student = new Student()
                {
                    DateOfBirth = stu.DateOfBirth,
                    FirstName = stu.FirstName,
                    _address = stu._address,
                    GradeLevel = stu.GradeLevel,
                    LastName = stu.LastName,
                    PhoneNumber = stu.PhoneNumber
                };
                // Add the student to the database
                _appDbContext.Students.Add(student);
                _appDbContext.SaveChanges();

                return Ok(student.Id);

                //search for CreatedAtAction if you don't know it, instead of OK
            }
            catch (Exception ex)
            {
                // Handle exceptions and log if necessary
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }


    }

}
