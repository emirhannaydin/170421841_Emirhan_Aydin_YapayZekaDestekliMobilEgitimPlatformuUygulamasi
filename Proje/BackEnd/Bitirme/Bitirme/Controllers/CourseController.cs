using Bitirme.BLL.Interfaces;
using Bitirme.DAL.Entities.Courses;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Bitirme.Controllers
{
    [ApiController]
    [Authorize]
    [Route("api/[controller]")]
    public class CourseController : ControllerBase
    {
        private readonly ICourseService _courseService;
        
        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        /// <summary>
        }
        /// T�m courselar� �ek.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_courseService.GetAll());
        }

    }
}