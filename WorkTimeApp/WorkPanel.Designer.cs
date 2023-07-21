namespace WorkTimeApp
{
    partial class WorkPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkPanel));
            groupBox1 = new System.Windows.Forms.GroupBox();
            btn_Projects = new System.Windows.Forms.Button();
            btn_Quests = new System.Windows.Forms.Button();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            btn_AllWorks = new System.Windows.Forms.Button();
            btn_CurrWeek = new System.Windows.Forms.Button();
            btn_Excel = new System.Windows.Forms.Button();
            btn_WorkRec = new System.Windows.Forms.Button();
            lbl_Hour = new System.Windows.Forms.Label();
            timer_WorkTime = new System.Windows.Forms.Timer(components);
            label2 = new System.Windows.Forms.Label();
            lbl_Minute = new System.Windows.Forms.Label();
            lbl_Second = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            pic_Rec = new System.Windows.Forms.PictureBox();
            panel1 = new System.Windows.Forms.Panel();
            label7 = new System.Windows.Forms.Label();
            lbl_TotalWork = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            panel3 = new System.Windows.Forms.Panel();
            btn_End = new System.Windows.Forms.Button();
            btn_Remove = new System.Windows.Forms.Button();
            notify = new System.Windows.Forms.NotifyIcon(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_Rec).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_Projects);
            groupBox1.Controls.Add(btn_Quests);
            groupBox1.Location = new System.Drawing.Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(344, 193);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "İşlemler";
            // 
            // btn_Projects
            // 
            btn_Projects.Location = new System.Drawing.Point(6, 114);
            btn_Projects.Name = "btn_Projects";
            btn_Projects.Size = new System.Drawing.Size(332, 53);
            btn_Projects.TabIndex = 1;
            btn_Projects.Text = "Projeler";
            btn_Projects.UseVisualStyleBackColor = true;
            btn_Projects.Click += btn_Projects_Click;
            // 
            // btn_Quests
            // 
            btn_Quests.Location = new System.Drawing.Point(6, 55);
            btn_Quests.Name = "btn_Quests";
            btn_Quests.Size = new System.Drawing.Size(332, 53);
            btn_Quests.TabIndex = 0;
            btn_Quests.Text = "Görevler";
            btn_Quests.UseVisualStyleBackColor = true;
            btn_Quests.Click += btn_Quests_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Location = new System.Drawing.Point(371, 67);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new System.Drawing.Size(1230, 594);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellMouseClick += dataGridView1_CellMouseClick;
            dataGridView1.CellMouseDoubleClick += dataGridView1_CellMouseDoubleClick;
            // 
            // btn_AllWorks
            // 
            btn_AllWorks.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btn_AllWorks.Location = new System.Drawing.Point(371, 12);
            btn_AllWorks.Name = "btn_AllWorks";
            btn_AllWorks.Size = new System.Drawing.Size(172, 49);
            btn_AllWorks.TabIndex = 2;
            btn_AllWorks.Text = "Tüm Eforlar";
            btn_AllWorks.UseVisualStyleBackColor = true;
            btn_AllWorks.Click += btn_AllWorks_Click;
            // 
            // btn_CurrWeek
            // 
            btn_CurrWeek.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btn_CurrWeek.Location = new System.Drawing.Point(549, 12);
            btn_CurrWeek.Name = "btn_CurrWeek";
            btn_CurrWeek.Size = new System.Drawing.Size(172, 49);
            btn_CurrWeek.TabIndex = 3;
            btn_CurrWeek.Text = "Bu Hafta";
            btn_CurrWeek.UseVisualStyleBackColor = true;
            btn_CurrWeek.Click += btn_CurrWeek_Click;
            // 
            // btn_Excel
            // 
            btn_Excel.BackgroundImage = (System.Drawing.Image)resources.GetObject("btn_Excel.BackgroundImage");
            btn_Excel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btn_Excel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btn_Excel.Location = new System.Drawing.Point(1532, 12);
            btn_Excel.Name = "btn_Excel";
            btn_Excel.Size = new System.Drawing.Size(69, 49);
            btn_Excel.TabIndex = 4;
            btn_Excel.UseVisualStyleBackColor = true;
            btn_Excel.Click += btn_Excel_Click;
            // 
            // btn_WorkRec
            // 
            btn_WorkRec.Location = new System.Drawing.Point(6, 135);
            btn_WorkRec.Name = "btn_WorkRec";
            btn_WorkRec.Size = new System.Drawing.Size(157, 52);
            btn_WorkRec.TabIndex = 5;
            btn_WorkRec.Text = "Başlat";
            btn_WorkRec.UseVisualStyleBackColor = true;
            btn_WorkRec.Click += btn_WorkRec_Click;
            // 
            // lbl_Hour
            // 
            lbl_Hour.AutoSize = true;
            lbl_Hour.Font = new System.Drawing.Font("Bahnschrift Condensed", 25.8000011F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_Hour.Location = new System.Drawing.Point(12, 44);
            lbl_Hour.Name = "lbl_Hour";
            lbl_Hour.Size = new System.Drawing.Size(58, 53);
            lbl_Hour.TabIndex = 6;
            lbl_Hour.Text = "00";
            // 
            // timer_WorkTime
            // 
            timer_WorkTime.Interval = 1000;
            timer_WorkTime.Tick += timer_WorkTime_Tick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Consolas", 25.8000011F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.Blue;
            label2.Location = new System.Drawing.Point(81, 47);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(46, 51);
            label2.TabIndex = 7;
            label2.Text = ":";
            // 
            // lbl_Minute
            // 
            lbl_Minute.AutoSize = true;
            lbl_Minute.Font = new System.Drawing.Font("Bahnschrift Condensed", 25.8000011F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_Minute.Location = new System.Drawing.Point(149, 44);
            lbl_Minute.Name = "lbl_Minute";
            lbl_Minute.Size = new System.Drawing.Size(58, 53);
            lbl_Minute.TabIndex = 8;
            lbl_Minute.Text = "00";
            // 
            // lbl_Second
            // 
            lbl_Second.AutoSize = true;
            lbl_Second.Font = new System.Drawing.Font("Bahnschrift Condensed", 25.8000011F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_Second.Location = new System.Drawing.Point(284, 44);
            lbl_Second.Name = "lbl_Second";
            lbl_Second.Size = new System.Drawing.Size(58, 53);
            lbl_Second.TabIndex = 9;
            lbl_Second.Text = "00";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Consolas", 25.8000011F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.ForeColor = System.Drawing.Color.Blue;
            label5.Location = new System.Drawing.Point(227, 47);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(46, 51);
            label5.TabIndex = 10;
            label5.Text = ":";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.Red;
            label1.Location = new System.Drawing.Point(146, 103);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(63, 20);
            label1.TabIndex = 11;
            label1.Text = "Dakika";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.ForeColor = System.Drawing.Color.Red;
            label3.Location = new System.Drawing.Point(280, 103);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(63, 20);
            label3.TabIndex = 12;
            label3.Text = "Saniye";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.ForeColor = System.Drawing.Color.Red;
            label4.Location = new System.Drawing.Point(19, 102);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(45, 20);
            label4.TabIndex = 13;
            label4.Text = "Saat";
            // 
            // pic_Rec
            // 
            pic_Rec.BackColor = System.Drawing.Color.Transparent;
            pic_Rec.Image = (System.Drawing.Image)resources.GetObject("pic_Rec.Image");
            pic_Rec.Location = new System.Drawing.Point(-1, 4);
            pic_Rec.Name = "pic_Rec";
            pic_Rec.Size = new System.Drawing.Size(65, 50);
            pic_Rec.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pic_Rec.TabIndex = 14;
            pic_Rec.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.Black;
            panel1.Location = new System.Drawing.Point(12, 461);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(340, 4);
            panel1.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label7.Location = new System.Drawing.Point(12, 21);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(98, 23);
            label7.TabIndex = 17;
            label7.Text = "Toplam :";
            // 
            // lbl_TotalWork
            // 
            lbl_TotalWork.AutoSize = true;
            lbl_TotalWork.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_TotalWork.ForeColor = System.Drawing.Color.Red;
            lbl_TotalWork.Location = new System.Drawing.Point(116, 21);
            lbl_TotalWork.Name = "lbl_TotalWork";
            lbl_TotalWork.Size = new System.Drawing.Size(32, 23);
            lbl_TotalWork.TabIndex = 19;
            lbl_TotalWork.Text = "00";
            // 
            // panel2
            // 
            panel2.Controls.Add(label7);
            panel2.Controls.Add(lbl_TotalWork);
            panel2.Location = new System.Drawing.Point(12, 211);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(344, 156);
            panel2.TabIndex = 20;
            // 
            // panel3
            // 
            panel3.Controls.Add(btn_End);
            panel3.Controls.Add(btn_WorkRec);
            panel3.Controls.Add(lbl_Hour);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(pic_Rec);
            panel3.Controls.Add(lbl_Minute);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(lbl_Second);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label1);
            panel3.Location = new System.Drawing.Point(12, 471);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(353, 190);
            panel3.TabIndex = 21;
            // 
            // btn_End
            // 
            btn_End.Location = new System.Drawing.Point(187, 135);
            btn_End.Name = "btn_End";
            btn_End.Size = new System.Drawing.Size(157, 52);
            btn_End.TabIndex = 15;
            btn_End.Text = "Bitir";
            btn_End.UseVisualStyleBackColor = true;
            btn_End.Click += btn_End_Click;
            // 
            // btn_Remove
            // 
            btn_Remove.BackgroundImage = (System.Drawing.Image)resources.GetObject("btn_Remove.BackgroundImage");
            btn_Remove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btn_Remove.Location = new System.Drawing.Point(1457, 12);
            btn_Remove.Name = "btn_Remove";
            btn_Remove.Size = new System.Drawing.Size(69, 49);
            btn_Remove.TabIndex = 22;
            btn_Remove.UseVisualStyleBackColor = true;
            btn_Remove.Click += btn_Remove_Click;
            // 
            // notify
            // 
            notify.Icon = (System.Drawing.Icon)resources.GetObject("notify.Icon");
            notify.Visible = true;
            // 
            // WorkPanel
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(15F, 32F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1613, 673);
            Controls.Add(btn_Remove);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btn_Excel);
            Controls.Add(btn_CurrWeek);
            Controls.Add(btn_AllWorks);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            MaximizeBox = false;
            Name = "WorkPanel";
            Text = "Panel";
            FormClosing += WorkPanel_FormClosing;
            FormClosed += WorkPanel_FormClosed;
            Load += WorkPanel_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_Rec).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_AllWorks;
        private System.Windows.Forms.Button btn_CurrWeek;
        private System.Windows.Forms.Button btn_Excel;
        private System.Windows.Forms.Button btn_WorkRec;
        private System.Windows.Forms.Label lbl_Hour;
        private System.Windows.Forms.Timer timer_WorkTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_Minute;
        private System.Windows.Forms.Label lbl_Second;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pic_Rec;
        private System.Windows.Forms.Button btn_Quests;
        private System.Windows.Forms.Button btn_Projects;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_TotalWork;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.Button btn_End;
        private System.Windows.Forms.NotifyIcon notify;
    }
}