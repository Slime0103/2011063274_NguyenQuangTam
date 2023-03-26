using _2011063274_NguyenQuangTam.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _2011063274_NguyenQuangTam.Controllers.api
{
    public class CoursesController : ApiController
    {
        public ApplicationDbContext _dbContext { get; set; }
        public CoursesController()
        {
            _dbContext = new ApplicationDbContext();
        }
        [HttpDelete]
        public IHttpActionResult Cancel(int id)
        {
            var userId = User.Identity.GetUserId();
            var course  = _dbContext.Courses.Single(c => c.Id == id && c.LecturerId == userId) ;
            if(course.IsCanceled)           
                return NotFound();
            course.IsCanceled = true;
            _dbContext.SaveChanges();
            return Ok();

        }
    }
}
