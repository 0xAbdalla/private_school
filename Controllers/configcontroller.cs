using Microsoft.AspNetCore.Mvc;
using Private_School.Data;

namespace Private_School.Controllers
{
    [ApiController]
    [Route("[controller]")] 
    public class Private_Schoolcontroller : ControllerBase
    {
        private readonly ApplicationDbContext _AppDbContext;
        public Private_Schoolcontroller(ApplicationDbContext AppDbContext)
        {
            _AppDbContext = AppDbContext;
        }
        [HttpPost]
        [Route("")]
        public ActionResult<int> register_of_student(students stu) 
        {
            stu.StudentID = 0;
            _AppDbContext.Set<students>().Add(stu);
            _AppDbContext.SaveChanges();
            return Ok(stu.StudentID);
        }
    }
}
