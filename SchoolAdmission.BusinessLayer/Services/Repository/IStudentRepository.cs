using SchoolAdmission.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAdmission.BusinessLayer.Services.Repository
{
    public interface IStudentRepository
    {
        Task<Person> Register(Person person);
        Task<bool> Login(string emailId, string password);
        Task<Person> FindPersonById(int personId);
    }
}
