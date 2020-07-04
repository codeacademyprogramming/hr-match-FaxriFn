using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskWinform.Models
{
   public class SignUpIsveren
    {
        public int Id { get; set; }
        public string Advertisement_Name { get; set; }
        public string Company_Name { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public string Work_Info { get; set; }
        public string City { get; set; }
        public decimal Salary { get; set; }
        public int EducationId { get; set; }
        public Education Education { get; set; }
        public int ExperienceId { get; set; }
        public Experiences Experience { get; set; }
        public string Tel { get; set; }
    }
}
