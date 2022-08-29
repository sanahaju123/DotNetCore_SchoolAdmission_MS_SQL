using SchoolAdmission.BusinessLayer.Interfaces;
using SchoolAdmission.BusinessLayer.Services.Repository;
using SchoolAdmission.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAdmission.BusinessLayer.Services
{
    public class ClassroomServices : IClassroomServices
    {
        private readonly IClassroomRepository _classroomRepository;

        public ClassroomServices(IClassroomRepository classroomRepository)
        {
            _classroomRepository = classroomRepository;
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
