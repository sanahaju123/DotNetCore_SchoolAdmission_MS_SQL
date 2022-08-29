using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SchoolAdmission.Entities
{
    public class Admission
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AdmissionId { get; set; }
        public int PersonId { get; set; }
        public int ClassroomId { get; set; }
        public int NumberofStudents { get; set; }
    }
}
