using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SchoolAdmission.Entities
{
    public class Classroom
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ClassroomId { get; set; }
        public int StudentCapacity { get; set; }
        public string ClassType { get; set; }
        public string Availability { get; set; }
        public int PerClassFee { get; set; }
    }
}
