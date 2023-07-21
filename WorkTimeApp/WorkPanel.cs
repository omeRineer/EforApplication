using Microsoft.EntityFrameworkCore;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.IO.Packaging;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkTimeApp.DataBase;
using WorkTimeApp.DTO;
using WorkTimeApp.Entities;
using WorkTimeApp.Extensions;
using WorkTimeApp.Helpers;

namespace WorkTimeApp
{
    public partial class WorkPanel : Form
    {
        private BindingList<WorkTimeDto> WorkTimes;
        public WorkPanel()
        {
            InitializeComponent();
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
        }

        private void WorkPanel_Load(object sender, EventArgs e)
        {
            btn_Remove.Visible = false;
            pic_Rec.Visible = false;
            btn_End.Enabled = false;
            FillWorks(false);
        }

        private void btn_AllWorks_Click(object sender, EventArgs e)
        {
            FillWorks(false);
        }

        private void btn_Excel_Click(object sender, EventArgs e)
        {
            ExportExcel(dataGridView1);
        }

        private void AddWork(WorkTime workTime)
        {
            var saveWork = new SaveWork();
            saveWork.WorkTime = workTime;
            saveWork.Show();
        }


        private void btn_CurrWeek_Click(object sender, EventArgs e)
        {
            FillWorks(true);
        }

        #region Rec
        int second = 0;
        int minute = 0;
        int hour = 0;
        private void btn_WorkRec_Click(object sender, EventArgs e)
        {
            if (!timer_WorkTime.Enabled)
            {
                timer_WorkTime.Start();
                pic_Rec.Visible = true;
                btn_WorkRec.Text = "Durdur";
            }
            else
            {
                timer_WorkTime.Stop();
                btn_WorkRec.Text = "Devam Et";
                pic_Rec.Visible = false;

            }
            btn_End.Enabled = true;
        }
        private void btn_End_Click(object sender, EventArgs e)
        {
            timer_WorkTime.Stop();
            AddWork(new WorkTime
            {
                Date = DateTime.Now.CustomToShortDateString(),
                Person = User.Name,
                Amount = Math.Round((TimeSpan.FromHours(hour) + TimeSpan.FromMinutes(minute)).TotalHours, 1)
            });
            ClearTime();
            btn_WorkRec.Text = "Başlat";
            pic_Rec.Visible = false;
            btn_End.Enabled = false;
        }
        private void timer_WorkTime_Tick(object sender, EventArgs e)
        {
            second++;

            if (second == 60)
            {
                minute++;
                second = 0;
            }

            if (minute == 60)
            {
                hour++;
                ToastService.ShowToast("Hatırlatma", $"{hour} saati geride bıraktın.", ToolTipIcon.Info, 5000);
                minute = 0;
            }

            lbl_Second.Text = second >= 10 ? second.ToString() : $"0{second}";
            lbl_Minute.Text = minute >= 10 ? minute.ToString() : $"0{minute}";
            lbl_Hour.Text = hour >= 10 ? hour.ToString() : $"0{hour}";
        }
        private void ClearTime()
        {
            second = 0;
            minute = 0;
            hour = 0;

            lbl_Second.Text = second.ToString();
            lbl_Minute.Text = minute.ToString();
            lbl_Hour.Text = hour.ToString();
        }

        #endregion

        private void btn_Projects_Click(object sender, EventArgs e)
        {
            var projectsScreen = new Projects();
            projectsScreen.Show();
        }

        private void btn_Quests_Click(object sender, EventArgs e)
        {
            var questsScreen = new Quests();
            questsScreen.Show();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var workId = ((WorkTimeDto)dataGridView1.Rows[e.RowIndex].DataBoundItem).Id;

            var detail = new WorkTimeDetail();
            detail.WorkId = workId;
            detail.Show();
        }


        WorkTimeDto? WorkTimeDeleteModel = null;
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            WorkTimeDeleteModel = ((WorkTimeDto)dataGridView1.Rows[e.RowIndex].DataBoundItem);

            if (WorkTimeDeleteModel != null) btn_Remove.Visible = true;
            else btn_Remove.Visible = false;
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            if (WorkTimeDeleteModel != null)
            {
                var entity = DataBaseHelper.Get<WorkTime>(x => x.Id == WorkTimeDeleteModel.Id);
                if (MessageBox.Show("Silmek istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    DataBaseHelper.Delete(entity);
                    WorkTimes.Remove(WorkTimeDeleteModel);
                    MessageBox.Show("Efor kaydı silindi", "Başarılı", MessageBoxButtons.OK);
                    WorkTimeDeleteModel = null;
                    btn_Remove.Visible = false;
                }
            }
        }

        private void ExportExcel(DataGridView dataGridView)
        {
            using (ExcelPackage package = new ExcelPackage())
            {
                ExcelWorkbook workbook = package.Workbook;
                ExcelWorksheet worksheet = workbook.Worksheets.Add("Efor");

                for (int col = 0; col < dataGridView.Columns.Count; col++)
                {
                    worksheet.Cells[1, col + 1].Value = dataGridView.Columns[col].HeaderText;
                    worksheet.Cells[1, col + 1].Style.Font.Bold = true;
                }

                for (int row = 0; row < dataGridView.Rows.Count; row++)
                {
                    for (int col = 0; col < dataGridView.Columns.Count; col++)
                    {
                        worksheet.Cells[row + 2, col + 1].Value = dataGridView.Rows[row].Cells[col].Value.ToString();
                    }
                }

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx|All Files (*.*)|*.*";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    FileInfo excelFile = new FileInfo(saveFileDialog.FileName);
                    package.SaveAs(excelFile);
                    ToastService.ShowToast("Bilgilendirme", $"Dışa aktarma başarılı", ToolTipIcon.Info, 2000);
                }
            }
        }
        private void FillWorks(bool isLastWeek)
        {
            var workList = DataBaseHelper.GetList<WorkTime>(includes: x => x.Include(s => s.Project).Include(s => s.Quest))
                    .Select(x => new WorkTimeDto
                    {
                        Id = x.Id,
                        Date = x.Date,
                        Person = x.Person,
                        Description = x.Description,
                        ProjectId = x.Project.Id,
                        ProjectName = x.Project.Name,
                        QuestId = x.Quest.Id,
                        QuestName = x.Quest.Name,
                        Amount = x.Amount
                    }).ToList();

            if (!isLastWeek)
                WorkTimes = new BindingList<WorkTimeDto>(workList);
            else
            {
                WorkTimes = new BindingList<WorkTimeDto>(workList.Where(x =>
                {
                    var dateTime = DateTime.ParseExact(x.Date, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    var lastMonday = DateTime.Now.Date.AddDays((int)DateTime.Today.DayOfWeek != 0 ? (-(int)DateTime.Today.DayOfWeek + 1) : ((int)DateTime.Today.DayOfWeek - 6));
                    return dateTime >= lastMonday && dateTime <= DateTime.Today;
                }).ToList());
            }

            dataGridView1.DataSource = WorkTimes;

            lbl_TotalWork.Text = $"{Math.Round(WorkTimes.Sum(x => x.Amount), 1)} saat";

            dataGridView1.Columns.Remove("Id");
            dataGridView1.Columns.Remove("ProjectId");
            dataGridView1.Columns.Remove("QuestId");

            dataGridView1.Columns["Date"].HeaderText = "Tarih";
            dataGridView1.Columns["Person"].HeaderText = "Personel";
            dataGridView1.Columns["Description"].HeaderText = "Açıklama";
            dataGridView1.Columns["ProjectName"].HeaderText = "Proje";
            dataGridView1.Columns["QuestName"].HeaderText = "Görev";
            dataGridView1.Columns["Amount"].HeaderText = "Miktar";

        }

        private void WorkPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Çıkış yapmak istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void WorkPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
