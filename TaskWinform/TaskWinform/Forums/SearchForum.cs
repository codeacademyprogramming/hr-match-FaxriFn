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
    public partial class SearchForum : Form
    {
        private readonly Hr_Context _context;
        public SearchForum()
        {
            InitializeComponent();
            _context = new Hr_Context();
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
      
         
        }

     

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
         
            if (comboBox1.Text == "Kateqoriya")
            {
                comboBox2.Visible = true;
                comboBox3.Visible = false;

              
            }
            if (comboBox1.Text== "Tehsil")
            {
                comboBox2.Visible = false;
                comboBox3.Visible = true;
              
            }
        }

        private void SearchForum_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
           
            if (_context.Categories.FirstOrDefault(x => x.Name == comboBox2.Text) != null)
            {
                var id = _context.Categories.FirstOrDefault(x => x.Name == comboBox2.Text).Id;

                var search = _context.Cv.Where(x => x.CategoryId == id);

                var data = search.Select(x => new {Ad=x.Name,Soyad=x.Surname,Yas=x.Age,Category=x.Category.Name,Seher = x.City.Name,Tehsil=x.Education.Name,Tecrube=x.Experiences.Experience1 });
                dataGridView1.Rows.Clear();
                foreach (var item in data)
                {
                    
                    dataGridView1.Rows.Add(item.Ad,item.Soyad,item.Yas,item.Category, item.Seher,item.Tehsil,item.Tecrube);
                }
            

            }
            return;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
         
            if (_context.Educations.FirstOrDefault(x => x.Name == comboBox3.Text) != null)
            {
                var id = _context.Educations.FirstOrDefault(x => x.Name == comboBox2.Text).Id;

                var search = _context.Cv.Where(x => x.EducationId == id);

                var data = search.Select(x => new { Ad = x.Name, Soyad = x.Surname, Yas = x.Age, Category = x.Category.Name, Seher = x.City.Name, Tehsil = x.Education.Name, Tecrube = x.Experiences.Experience1 });
                dataGridView1.Rows.Clear();
                foreach (var item in data)
                {
                 

                    dataGridView1.Rows.Add(item.Ad, item.Soyad, item.Yas, item.Category, item.Seher, item.Tehsil, item.Tecrube);
                }


            }
            return;
        }
    }
}
