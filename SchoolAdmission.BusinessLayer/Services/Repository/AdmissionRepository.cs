using SchoolAdmission.DataLayer;
using SchoolAdmission.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAdmission.BusinessLayer.Services.Repository
{
    public class AdmissionRepository : IAdmissionRepository
    {
        private readonly SchoolDbContext _schoolDbContext;
        public AdmissionRepository(SchoolDbContext schoolDbContext)
        {
            _schoolDbContext = schoolDbContext;
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
