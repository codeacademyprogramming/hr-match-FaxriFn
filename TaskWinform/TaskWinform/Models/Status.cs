using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskWinform.Models
{
   public class Status
    {

        public int Id { get; set; }
        public string StatusName { get; set; }
        public ICollection<SignUp> SignUp { get; set; }
    }
}
