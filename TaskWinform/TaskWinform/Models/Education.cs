using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskWinform.Models
{
   public class Education
    {
        public int Id { get; set; }
        public string Name { get; set; }
    public  List<SignUpIsveren> signUpIsverens { get; set; }
    public  List<CV> CVs { get; set; }
    }
}
