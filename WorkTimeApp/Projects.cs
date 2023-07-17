using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkTimeApp.Entities;
using WorkTimeApp.Helpers;

namespace WorkTimeApp
{
    public partial class Projects : Form
    {
        public Project CurrentProject { get; set; }
        private BindingList<Project> ProjectList;
        public Projects()
        {
            InitializeComponent();
            var projects = DataBaseHelper.GetList<Project>();
            ProjectList = new BindingList<Project>(projects);
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            var newProject = new Project();
            newProject.Name = txt_ProjectName.Text;
            DataBaseHelper.Add(newProject);
            ProjectList.Add(newProject);
            MessageBox.Show("Proje bilgisi kaydedildi", "Başarılı");

        }

        private void Projects_Load(object sender, EventArgs e)
        {
            FillDataSource.Fill(ProjectList, list_Projects, "Id", "Name");
        }

        private void list_Projects_SelectedValueChanged(object sender, EventArgs e)
        {
            CurrentProject = (Project)list_Projects.SelectedItem;
            txt_ProjectName.Text = CurrentProject.Name;
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            DataBaseHelper.Update(CurrentProject);
            var lastProject = ProjectList.FirstOrDefault(x => x.Id == CurrentProject.Id);
            lastProject = CurrentProject;
            MessageBox.Show("Proje bilgisi güncellendi", "Başarılı");
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            DataBaseHelper.Delete(CurrentProject);
            ProjectList.Remove(CurrentProject);
            MessageBox.Show("Proje bilgisi silindi", "Başarılı");
        }

        private void txt_ProjectName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void list_Projects_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Projects_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}
