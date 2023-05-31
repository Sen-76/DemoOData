using DemoOData.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using Microsoft.EntityFrameworkCore;

namespace DemoOData.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ODataController
    {
        private readonly DemoODataContext _context;
        public StudentController(DemoODataContext context)
        {
            _context = context;
        }
        [HttpGet]
        [EnableQuery]
        public IActionResult GetAll()
        {
            return Ok(_context.Students.Include("Gender").ToList());
        }
    }
}
