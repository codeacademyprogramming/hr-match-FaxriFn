using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskWinform.Models;

namespace TaskWinform.Forums
{
    public partial class HomeEmployeesForum : Form
    
    {
     

        public HomeEmployeesForum()
        {
            InitializeComponent();
          
        }

        private void HomeEmployeesForum_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new LogOutsForum().Show();
        }

        private void btnCv_Click(object sender, EventArgs e)
        {
            new CvForum().Show();
        }

        private void btnData_Click(object sender, EventArgs e)
        {
            new InfoCvForum().Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            new SearchForum().Show();
        }

        private void HomeEmployeesForum_Load(object sender, EventArgs e)
        {

        }
    }
}
