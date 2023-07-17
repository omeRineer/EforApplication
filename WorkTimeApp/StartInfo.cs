using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkTimeApp.DataBase;
using WorkTimeApp.Entities;
using WorkTimeApp.Helpers;

namespace WorkTimeApp
{
    public partial class StartInfo : Form
    {
        public StartInfo()
        {
            InitializeComponent();
        }

        private void btn_Enter_Click(object sender, EventArgs e)
        {
            User.Name = txt_Name.Text;

            var panel = new WorkPanel();
            panel.Show();

            this.Hide();
        }

        private void StartInfo_Load(object sender, EventArgs e)
        {
        }
    }
}
