using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskWinform.Models
{
  public  class Experiences
    {
        public int Id { get; set; }
        public string Experience1 { get; set; }

        public List<CV> CVs { get; set; }
    }
}
