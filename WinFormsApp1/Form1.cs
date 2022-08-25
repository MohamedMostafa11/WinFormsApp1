using Microsoft.EntityFrameworkCore;
using WinFormsApp1.Models;
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        ITIDBTESTContext DB;
        public Form1()
        {
            InitializeComponent();
            DB = new ITIDBTESTContext();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        data_GV.DataSource = DB.Students.Include(a => a.Dept)
                                        .Select(a => new {Name = a.Name ,Address =a.Address,Age =a.Age ,DeptName =a.Dept.Name})
                                        .ToList();
            comb_dept.DataSource = DB.Departments.ToList();
            comb_dept.DisplayMember = "Name";
            comb_dept.ValueMember = "Id";
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            data_GV.DataSource = DB.Students.Where(s => s.Name.Contains(txt_search.Text)).ToList();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            data_GV.DataSource=DB.Students.ToList();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Student s = new Student
            {
                Id = int.Parse(txt_Id.Text),
                Name = txt_Name.Text,
                Age = int.Parse(txt_age.Text),
                Address = txt_address.Text,
                DeptId = (int)comb_dept.SelectedValue
            };

            DB.Students.Add(s);
            DB.SaveChanges();
            txt_address.Text = "";
            txt_age.Text ="";
            txt_Id.Text = "";
            txt_Name.Text = "";
            lbl_add.Text = "ADDED";
            data_GV.DataSource = DB.Students.ToList();
        }

        private void data_GV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}