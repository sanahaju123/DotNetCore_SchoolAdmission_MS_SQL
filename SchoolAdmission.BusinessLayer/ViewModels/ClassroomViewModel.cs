using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolAdmission.BusinessLayer.ViewModels
{
    public class ClassroomViewModel
    {
        public int ClassroomId { get; set; }
        public int StudentCapacity { get; set; }
        public string ClassType { get; set; }
        public string Availability { get; set; }
        public int PerClassFee { get; set; }
    }
}
