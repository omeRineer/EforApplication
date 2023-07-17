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
    public partial class Quests : Form
    {
        public Quest CurrentQuest { get; set; }
        private BindingList<Quest> QuestList;
        public Quests()
        {
            InitializeComponent();
            var quests = DataBaseHelper.GetList<Quest>();
            QuestList = new BindingList<Quest>(quests);
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            var newQuest = new Quest();
            newQuest.Name = txt_QuestName.Text;
            DataBaseHelper.Add(newQuest);
            QuestList.Add(newQuest);
            MessageBox.Show("Görev bilgisi kaydedildi", "Başarılı");
        }

        private void Quests_Load(object sender, EventArgs e)
        {
            FillDataSource.Fill(QuestList, list_Quests, "Id", "Name");
        }

        private void list_Quests_SelectedValueChanged(object sender, EventArgs e)
        {
            CurrentQuest = (Quest)list_Quests.SelectedItem;
            txt_QuestName.Text = CurrentQuest.Name;
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            DataBaseHelper.Update(CurrentQuest);
            var lastQuest = QuestList.FirstOrDefault(x => x.Id == CurrentQuest.Id);
            lastQuest = CurrentQuest;
            MessageBox.Show("Görev bilgisi güncellendi", "Başarılı");
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            DataBaseHelper.Delete(CurrentQuest);
            QuestList.Remove(CurrentQuest);
            MessageBox.Show("Görev bilgisi silindi", "Başarılı");
        }

        private void Quests_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }
    }
}
