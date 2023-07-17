using Microsoft.EntityFrameworkCore;
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
    public partial class WorkTimeDetail : Form
    {
        private WorkTime WorkTime;
        public int WorkId { get; set; }
        public WorkTimeDetail()
        {
            InitializeComponent();
        }

        private void WorkTimeDetail_Load(object sender, EventArgs e)
        {
            WorkTime = DataBaseHelper.Get<WorkTime>(x => x.Id == WorkId, includes => includes.Include(x => x.Project).Include(x => x.Quest));
            date_Date.Text = WorkTime.Date;
            txt_Person.Text = WorkTime.Person.ToString();
            txt_Amount.Text = WorkTime.Amount.ToString();
            FillDataSource.Fill(DataBaseHelper.GetList<Project>(), cmb_Project, "Id", "Name");
            FillDataSource.Fill(DataBaseHelper.GetList<Quest>(), cmb_Quest, "Id", "Name");
            cmb_Project.SelectedValue = WorkTime.Project.Id;
            cmb_Quest.SelectedValue = WorkTime.Quest.Id;
            rch_Description.Text = WorkTime.Description;

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            WorkTime.Date = date_Date.Text;
            WorkTime.Person = txt_Person.Text;
            WorkTime.Description = rch_Description.Text;
            WorkTime.QuestId = (int)cmb_Quest.SelectedValue;
            WorkTime.ProjectId = (int)cmb_Project.SelectedValue;
            WorkTime.Amount = Convert.ToDouble(txt_Amount.Text);
            DataBaseHelper.Update(WorkTime);
            MessageBox.Show("Efor bilgisi güncellendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
