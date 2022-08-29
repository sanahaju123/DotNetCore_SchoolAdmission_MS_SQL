using SchoolAdmission.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAdmission.BusinessLayer.Interfaces
{
    public interface IClassroomServices
    {
        Task<Classroom> AddClassroom(Classroom classroom);
        Task<IEnumerable<Classroom>> GetClassroom();
        Task<Classroom> FindClassroomById(int classroomId);
    }
}
