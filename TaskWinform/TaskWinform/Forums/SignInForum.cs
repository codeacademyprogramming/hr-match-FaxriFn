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
    public partial class SignInForum : Form
    {
        private readonly Hr_Context _context;
   
        public SignInForum()
        {
            InitializeComponent();
            _context = new Hr_Context();
      
        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void SignInForum_Load(object sender, EventArgs e)
        {

        }

        private void SignInForum_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Check();
        }

        #region Check Username Password

        private void Check()
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();


            var signIn = _context.SignUps.FirstOrDefault(x => x.Username == username);

            if (signIn.Password ==password && signIn.StatusId==2)
            {
                new HomeIseGoturen().Show();
                      this.Hide();
            }
            else if(signIn.Password == password && signIn.StatusId == 1)
            {
                new HomeEmployeesForum().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Isdifadeci Adi ve ya Parolu Sehvdir", "Warning", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
        }
        #endregion
    }


