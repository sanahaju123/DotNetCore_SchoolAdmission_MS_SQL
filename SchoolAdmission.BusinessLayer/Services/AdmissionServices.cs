using SchoolAdmission.BusinessLayer.Interfaces;
using SchoolAdmission.BusinessLayer.Services.Repository;
using SchoolAdmission.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAdmission.BusinessLayer.Services
{
    public class AdmissionServices : IAdmissionServices
    {
        private readonly IAdmissionRepository _admissionRepository;

        public AdmissionServices(IAdmissionRepository admissionRepository)
        {
            _admissionRepository = admissionRepository;
        }

        public async Task<Admission> AddAdmission(Admission admission)
        {
            throw new NotImplementedException();
        }

        public async Task<Admission> FindAdmissionById(int AdmissionId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Admission>> GetAdmission()
        {
            throw new NotImplementedException();
        }
    }
}
