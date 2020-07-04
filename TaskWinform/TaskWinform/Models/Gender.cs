using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskWinform.Models
{
   public class Gender
    {
        public int Id { get; set; }
        public string  Gender1 { get; set; }
        public List<CV> CVs { get; set; }
    }
}
