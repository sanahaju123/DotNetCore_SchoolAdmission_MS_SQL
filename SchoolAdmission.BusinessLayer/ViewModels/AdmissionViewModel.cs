using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolAdmission.BusinessLayer.ViewModels
{
    public class AdmissionViewModel
    {
        public int AdmissionId { get; set; }
        public int PersonId { get; set; }
        public int ClassroomId { get; set; }
        public int NumberofStudents { get; set; }
    }
}
