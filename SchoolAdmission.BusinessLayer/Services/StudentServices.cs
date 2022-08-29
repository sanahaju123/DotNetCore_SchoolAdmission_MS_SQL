using SchoolAdmission.BusinessLayer.Interfaces;
using SchoolAdmission.BusinessLayer.Services.Repository;
using SchoolAdmission.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAdmission.BusinessLayer.Services
{
    public class StudentServices : IStudentServices
    {
        private readonly IStudentRepository _studentRepository;

        public StudentServices(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public async Task<Person> FindPersonById(int personId)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Login(string emailId, string password)
        {
            throw new NotImplementedException();
        }

        public async Task<Person> Register(Person person)
        {
            throw new NotImplementedException();
        }
    }
}
