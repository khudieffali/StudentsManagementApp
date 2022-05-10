using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class StudentDbContext : DbContext
    {
      
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //optionsBuilder.UseSqlServer("Data Source=SQL5104.site4now.net;Initial Catalog=db_a4f2ac_comparstudentform;User Id=db_a4f2ac_comparstudentform_admin;Password=Compar2019");
                optionsBuilder.UseSqlServer("Data Source=HOME-PC;Initial Catalog=ComparDB2;Integrated Security=true");

            }
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<RoleToUser> RoleToUsers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentGroup> StudentGroups { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Speciality> Specialities { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<InformationStudent> InformationStudents { get; set; }
        public DbSet<Cost> Costs { get; set; }


    }
}
