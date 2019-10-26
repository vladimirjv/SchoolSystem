using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SchoolSystem.Models;
using SchoolSystem.DB;

namespace SchoolSystem.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class UsersController : ControllerBase
  {
    private readonly SchoolSystemContext _context;
    public UsersController(SchoolSystemContext context)
    {
      this._context = context;
    }
    // GET api/users
    [HttpGet]
    public ActionResult<IEnumerable<User>> Get()
    {
      return _context.Users.ToList();
    }

    // [HttpGet("{id}")]
    // public ActionResult<School> Get(int id)
    // {
    //   return _context.Schools.Where(sc => sc.Id == id).First();
    // }

    // [HttpPost]
    // public ActionResult<School> Post(School school)
    // {
    //   _context.Schools.Add(school);
    //   _context.SaveChanges();
    //   return school;
    // }

    // [HttpPut("{id}")]
    // public ActionResult<School> Put(int id, School school)
    // {
    //   Console.WriteLine(school.Id);
    //   this._context.Schools.Update(school);
    //   this._context.SaveChanges();
    //   return school;
    //   // return school;
    // }

    // [HttpDelete("{id}")]
    // public ActionResult<School> Delete(int id)
    // {
    //   var school = this._context.Schools.Where(sc => sc.Id == id).First();
    //   this._context.Schools.Remove(school);
    //   this._context.SaveChanges();
    //   return school;
    // }
  }
}
