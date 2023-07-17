namespace WorkTimeApp
{
    partial class Quests
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Quests));
            btn_Delete = new System.Windows.Forms.Button();
            btn_Update = new System.Windows.Forms.Button();
            btn_Save = new System.Windows.Forms.Button();
            txt_QuestName = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            list_Quests = new System.Windows.Forms.ListBox();
            SuspendLayout();
            // 
            // btn_Delete
            // 
            btn_Delete.Location = new System.Drawing.Point(252, 196);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new System.Drawing.Size(277, 44);
            btn_Delete.TabIndex = 11;
            btn_Delete.Text = "Sil";
            btn_Delete.UseVisualStyleBackColor = true;
            btn_Delete.Click += btn_Delete_Click;
            // 
            // btn_Update
            // 
            btn_Update.Location = new System.Drawing.Point(252, 146);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new System.Drawing.Size(277, 44);
            btn_Update.TabIndex = 10;
            btn_Update.Text = "Güncelle";
            btn_Update.UseVisualStyleBackColor = true;
            btn_Update.Click += btn_Update_Click;
            // 
            // btn_Save
            // 
            btn_Save.Location = new System.Drawing.Point(252, 96);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new System.Drawing.Size(277, 44);
            btn_Save.TabIndex = 9;
            btn_Save.Text = "Kaydet";
            btn_Save.UseVisualStyleBackColor = true;
            btn_Save.Click += btn_Save_Click;
            // 
            // txt_QuestName
            // 
            txt_QuestName.Location = new System.Drawing.Point(252, 51);
            txt_QuestName.Name = "txt_QuestName";
            txt_QuestName.Size = new System.Drawing.Size(277, 39);
            txt_QuestName.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(252, 25);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(120, 23);
            label1.TabIndex = 7;
            label1.Text = "Görev İsmi";
            // 
            // list_Quests
            // 
            list_Quests.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            list_Quests.FormattingEnabled = true;
            list_Quests.ItemHeight = 23;
            list_Quests.Location = new System.Drawing.Point(12, 12);
            list_Quests.Name = "list_Quests";
            list_Quests.Size = new System.Drawing.Size(234, 441);
            list_Quests.TabIndex = 6;
            list_Quests.SelectedValueChanged += list_Quests_SelectedValueChanged;
            // 
            // Quests
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(15F, 32F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(542, 465);
            Controls.Add(btn_Delete);
            Controls.Add(btn_Update);
            Controls.Add(btn_Save);
            Controls.Add(txt_QuestName);
            Controls.Add(label1);
            Controls.Add(list_Quests);
            Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            MaximizeBox = false;
            Name = "Quests";
            Text = "Görevler";
            FormClosing += Quests_FormClosing;
            Load += Quests_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TextBox txt_QuestName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox list_Quests;
    }
}