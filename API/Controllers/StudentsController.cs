using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly DataContext _context;

        public StudentsController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        //[Route("list")]
        public async Task<ActionResult<IEnumerable<Student>>> List()
        {
            var students = await _context.Students.Include(student => student.Room).ToListAsync();
            return Ok(students);
        }

        [HttpGet("{id}")]
        //[Route("getone/{id}")]
        public async Task<ActionResult<Student>> Get(int id)
        {
            var student = await _context.Students.FindAsync(id);
            return Ok(student);
        }
    }
}