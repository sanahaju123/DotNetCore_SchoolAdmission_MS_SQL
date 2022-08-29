using SchoolAdmission.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAdmission.BusinessLayer.Services.Repository
{
    public interface IAdmissionRepository
    {
        Task<Admission> AddAdmission(Admission admission);
        Task<IEnumerable<Admission>> GetAdmission();
        Task<Admission> FindAdmissionById(int AdmissionId);
    }
}
