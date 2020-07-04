using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskWinform.DataServices;
using TaskWinform.Models;

namespace TaskWinform.Forums
{
    
    public partial class InfoCvForum : Form
    {
        private readonly Hr_Context _context;
        SignUp SignUp;
        public InfoCvForum()
        {
            InitializeComponent();
            _context = new Hr_Context();
          
        }

        private void InfoCvForum_Load(object sender, EventArgs e)
        {
          
            var cV = _context.Cv.Select(x => new { Name = x.Name ,Surname=x.Surname,Age=x.Age,Education=x.Education.Name ,City=x.City.Name,Salary=x.Min_Salary,Tel=x.Tel_Number,Cinsi=x.Gender.Gender1});
            dataGridView1.DataSource = cV.ToList(); 
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }
    }
}
