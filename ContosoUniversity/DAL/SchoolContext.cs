﻿using ContosoUniversity.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ContosoUniversity.DAL
{
    public class SchoolContext:DbContext
    {
        public SchoolContext():base("SchoolContext")
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Course> Course { get; set; }

        protected override void OnModelCreating(DbModelBuilder modleBuilder)
        {
            modleBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}