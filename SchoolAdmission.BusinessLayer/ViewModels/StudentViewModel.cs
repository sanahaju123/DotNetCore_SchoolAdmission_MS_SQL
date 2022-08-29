using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolAdmission.BusinessLayer.ViewModels
{
    public class StudentViewModel
    {
        public int PersonID { get; set; }
        public string PersonName { get; set; }
        public string Password { get; set; }
        public string EmailId { get; set; }
        public string Personcity { get; set; }
    }
}
