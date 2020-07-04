using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskWinform.Models
{
    public class CV
    {
        public int Id { get; set; }
        [MaxLength(30)]
        public string Name { get; set; }
        [MaxLength(30)]
        public string Surname { get; set; }
        public int GenderId { get; set; }
        public Gender Gender { get; set; }
        public int Age { get; set; }
        public int EducationId { get; set; }
        public Education Education { get; set; }
        public int ExperienceId { get; set; }
        public Experiences Experiences { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int CityId { get; set; }
        public City City { get; set; }

        public decimal Min_Salary { get; set; }
        public string Tel_Number { get; set; }


    }
}
