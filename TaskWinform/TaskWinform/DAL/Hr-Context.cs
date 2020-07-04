using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskWinform.Models;

namespace TaskWinform.DataServices
{
    class Hr_Context:DbContext
    {


        public Hr_Context():base("default")
        {

        }


        public DbSet<Category> Categories { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<SignUp> SignUps { get; set; }
        public DbSet<Experiences> Experiences { get; set; }
        public DbSet<SignUpIsveren> SignUpIsverens { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<CV> Cv { get; set; }
    }
}
