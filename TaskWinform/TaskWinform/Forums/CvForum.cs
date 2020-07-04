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
    public partial class CvForum : Form
    {
        private readonly Hr_Context _context;
  
        public CvForum()
        {
            InitializeComponent();
            _context = new Hr_Context();
          
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void CvForum_FormClosed(object sender, FormClosedEventArgs e)
        {
         
        }

        private void CvForum_Load(object sender, EventArgs e)
        {
            Fill();
        }

        #region Combobox Fill

        private void Fill()
        {
            var gender = _context.Genders.ToList();
            foreach (var item in gender)
            {
                cmbGender.Items.Add(item.Gender1);
            }

            var experiens = _context.Experiences.ToList();
            foreach (var item in experiens)
            {
                cmbTecrube.Items.Add(item.Experience1);
            }
            var category = _context.Categories.ToList();
            foreach (var item in category)
            {
                cmbCategory.Items.Add(item.Name);
            }
            var city = _context.Cities.ToList();
            foreach (var item in city)
            {
                cmbCity.Items.Add(item.Name);
            }
            var educations = _context.Educations.ToList();
            foreach (var item in educations)
            {
                cmbEdu.Items.Add(item.Name);

            }
        }
        #endregion

        #region Chech Input Empty
        private void CheckInput()
        {
            if (string.IsNullOrEmpty(txtAge.Text)&& string.IsNullOrEmpty(txtName.Text) && string.IsNullOrEmpty(TxtMebleg.Text) && string.IsNullOrEmpty(TxtSurname.Text))
            {
                MessageBox.Show("Inputlari Bos Qoymayin", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            CV cV = new CV()
            {
                Name = txtName.Text.Trim(),
                Surname = TxtSurname.Text.Trim(),
                Age = int.Parse(txtAge.Text),
                Tel_Number=txtNumber.Text,
                Min_Salary=Decimal.Parse( TxtMebleg.Text)

            };
            if (_context.Categories.FirstOrDefault(x => x.Name == cmbCategory.Text) != null)
            {
                cV.CategoryId = _context.Categories.FirstOrDefault(x => x.Name == cmbCategory.Text).Id;
            }
          
            if (_context.Genders.FirstOrDefault(x => x.Gender1 == cmbGender.Text) != null)
            {
                cV.GenderId = _context.Genders.FirstOrDefault(x => x.Gender1 == cmbGender.Text).Id;
            }
            if (_context.Educations.FirstOrDefault(x => x.Name == cmbEdu.Text) != null)
            {
                cV.EducationId = _context.Educations.FirstOrDefault(x => x.Name == cmbEdu.Text).Id;
            }
            if (_context.Cities.FirstOrDefault(x => x.Name == cmbCity.Text) != null)
            {
                cV.CityId = _context.Cities.FirstOrDefault(x => x.Name == cmbCity.Text).Id;
            }

            if (_context.Experiences.FirstOrDefault(x => x.Experience1== cmbTecrube.Text) != null)
            {
                cV.ExperienceId = _context.Experiences.FirstOrDefault(x => x.Experience1== cmbTecrube.Text).Id;
            }
            _context.Cv.Add(cV);
            _context.SaveChanges();
        }
        #endregion



        private void btnSend_Click_1(object sender, EventArgs e)
        {

            CheckInput();
            MessageBox.Show("Cv-niz elave olundu");
            this.Hide();
        }
    }
}
