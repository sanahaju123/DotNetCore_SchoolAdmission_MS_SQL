using SchoolAdmission.DataLayer;
using SchoolAdmission.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAdmission.BusinessLayer.Services.Repository
{
    public class ClassroomRepository : IClassroomRepository
    {
        private readonly SchoolDbContext _schoolDbContext;
        public ClassroomRepository(SchoolDbContext schoolDbContext)
        {
            _schoolDbContext = schoolDbContext;
        }

        public async Task<Classroom> AddClassroom(Classroom classroom)
        {
            throw new NotImplementedException();
        }

        public async Task<Classroom> FindClassroomById(int classroomId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Classroom>> GetClassroom()
        {
            throw new NotImplementedException();
        }
    }
}
