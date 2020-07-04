using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskWinform.Models
{
  public  class SignUp
    {

        public int Id { get; set; }

        public string Username { get; set; }
        public string Email { get; set; }
        public int StatusId { get; set; }
        public Status Status { get; set; }
        public string Password { get; set; }
        public string RandomCode { get; set; }
    }
}
