using SchoolAdmission.DataLayer;
using SchoolAdmission.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAdmission.BusinessLayer.Services.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private readonly SchoolDbContext _schoolDbContext;
        public StudentRepository(SchoolDbContext schoolDbContext)
        {
            _schoolDbContext = schoolDbContext;
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
