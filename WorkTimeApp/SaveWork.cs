using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkTimeApp.DTO;
using WorkTimeApp.Entities;
using WorkTimeApp.Helpers;

namespace WorkTimeApp
{
    public partial class SaveWork : Form
    {
        public WorkTime WorkTime { get; set; }
        public SaveWork()
        {
            InitializeComponent();
        }

        private void SaveWork_Load(object sender, EventArgs e)
        {
            lbl_Amount.Text = $"{WorkTime.Amount} saat";
            lbl_Date.Text = WorkTime.Date.ToString();
            lbl_Name.Text = WorkTime.Person;

            FillDataSource.Fill(DataBaseHelper.GetList<Quest>(), cmb_Quests, "Id", "Name");
            FillDataSource.Fill(DataBaseHelper.GetList<Project>(), cmb_Projects, "Id", "Name");
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            WorkTime.Description = rch_Description.Text;
            WorkTime.QuestId = (int)cmb_Quests.SelectedValue;
            WorkTime.ProjectId = (int)cmb_Projects.SelectedValue;

            DataBaseHelper.Add(WorkTime);

            if (MessageBox.Show("Efor başarıyla kaydedildi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
            {
                this.Dispose();
            }
        }
    }
}
