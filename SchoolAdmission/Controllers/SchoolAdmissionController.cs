using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolAdmission.BusinessLayer.Interfaces;
using SchoolAdmission.BusinessLayer.Services;
using SchoolAdmission.BusinessLayer.ViewModels;
using SchoolAdmission.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolAdmission.Controllers
{
    [ApiController]
    public class SchoolAdmissionController : ControllerBase
    {
        private readonly IStudentServices _studentService;
        private readonly IClassroomServices _classroomService;
        private readonly IAdmissionServices _admissionService;

        public SchoolAdmissionController(IStudentServices studentServices, IClassroomServices classroomServices, IAdmissionServices admissionServices)
        {
            _studentService = studentServices;
            _classroomService = classroomServices;
            _admissionService = admissionServices;
        }

        
        [HttpPost]
        [Route("student/register-student")]
        [AllowAnonymous]
        public async Task<IActionResult> Register([FromBody] StudentViewModel model)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        
        [HttpPost]
        [Route("student/login-student")]
        public async Task<IActionResult> Login(string emailid,string password)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        [HttpPost]
        [Route("classroom/add-classroom")]
        public async Task<IActionResult> AddClassroom([FromBody] ClassroomViewModel model)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }


        /// <summary>
        /// List All Suppliers
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("classroom/list-available-classrooms")]
        public async Task<IEnumerable<Classroom>> ListAvailableClassrooms()
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }


        [HttpPost]
        [Route("admission/add-admission")]
        [AllowAnonymous]
        public async Task<IActionResult> AddAdmission([FromBody] AdmissionViewModel model)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }


        /// <summary>
        /// List All Suppliers
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("admission/list-all-admissions")]
        public async Task<IEnumerable<Admission>> ListAllAdmissions()
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }
    }
}