using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskWinform.DataServices;
using TaskWinform.Models;

namespace TaskWinform.Forums
{
    public partial class SignUpForum : Form
    {
        private readonly Hr_Context _context;
        public SignUpForum()
        {
            InitializeComponent();
            _context = new Hr_Context();
        }

        private void SignUpForum_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void SignUpForum_Load(object sender, EventArgs e)
        {

            #region Form Load Random Code
            txtRandomCode.Text = RandomCode();
            #endregion
            #region Form Load Status 
            FillStatus();
            #endregion
        }

        #region Random Code
        private string RandomCode()
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[4];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            var finalString = new String(stringChars);
            return finalString;
        }

        #endregion

        #region Check and Add Database

        private void Check()
        {
            if (string.IsNullOrEmpty(txtEmail.Text) && string.IsNullOrEmpty(txtPassword.Text) && string.IsNullOrEmpty(txtConfirmPassword.Text) && string.IsNullOrEmpty(txtRandom.Text) && string.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("Inputlari Bos Saxlamayin", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                string email = txtEmail.Text.Trim();
                MailAddress mailAddress = new MailAddress(email);
             
            }
            catch (Exception)
            {

                MessageBox.Show("Email Duz Yazin", "Warning", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
           
        
           

            int cast = 0;
            string password = txtPassword.Text.Trim();
            string confirmPassword = txtConfirmPassword.Text.Trim();
            if (password.Length > 15 || int.TryParse(password, out cast))
            {
                MessageBox.Show("Password Duz Yazin (15 simvoldan artiq olmaz ve minimum bir herf olmalidir)");
                return;
            }
          
            if (password != confirmPassword)
            {
                MessageBox.Show("Her Iki Password Eyni Olmalidir");
                return;
            }
            if (txtRandom.Text!=txtRandomCode.Text)
            {

                MessageBox.Show("Zehmet Olmasa Kodu Duz Yazin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            AddData();


        }
        #endregion

        #region Status
        private void FillStatus()
        {

            var status = _context.Statuses.ToList();
            foreach (var item in status)
            {
                cmbStatus.Items.Add(item.StatusName);
            }
            
        }
        #endregion



      



        private void btnSend_Click(object sender, EventArgs e)
        {


            Check();
         
   }

        private void AddData()
        {
          
            string username = txtUsername.Text.Trim();
            string emailTxt = txtEmail.Text.Trim();
            string pass = txtPassword.Text.Trim();
            string randompass = txtRandomCode.Text;
            SignUp signUp = new SignUp()
            {
                Username = txtUsername.Text.Trim(),
                Email = emailTxt,
                Password = pass,
                RandomCode = randompass,


            };

            if (_context.Statuses.FirstOrDefault(x => x.StatusName == cmbStatus.Text) != null)
            {
                signUp.StatusId = _context.Statuses.FirstOrDefault(x => x.StatusName == cmbStatus.Text).Id;
            }
            else
            {
                MessageBox.Show("Status Secin Zehmet Olmasa");
                return;
            }

            _context.SignUps.Add(signUp);
            _context.SaveChanges();
            //
            MessageBox.Show("Ugurlu Qeydiyyat", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //
            new SignInForum().Show();
            this.Hide();
        }
    }
}
