using Microsoft.EntityFrameworkCore;
using SchoolAdmission.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolAdmission.DataLayer
{
    public class SchoolDbContext : DbContext
    {
        public SchoolDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Person> People { get; set; }
        public DbSet<Admission> Admissions { get; set; }
        public DbSet<Classroom> Classrooms { get; set; }

    }
}
