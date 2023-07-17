namespace WorkTimeApp
{
    partial class Projects
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Projects));
            list_Projects = new System.Windows.Forms.ListBox();
            label1 = new System.Windows.Forms.Label();
            txt_ProjectName = new System.Windows.Forms.TextBox();
            btn_Save = new System.Windows.Forms.Button();
            btn_Update = new System.Windows.Forms.Button();
            btn_Delete = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // list_Projects
            // 
            list_Projects.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            list_Projects.FormattingEnabled = true;
            list_Projects.ItemHeight = 23;
            list_Projects.Location = new System.Drawing.Point(12, 12);
            list_Projects.Name = "list_Projects";
            list_Projects.Size = new System.Drawing.Size(234, 441);
            list_Projects.TabIndex = 0;
            list_Projects.SelectedIndexChanged += list_Projects_SelectedIndexChanged;
            list_Projects.SelectedValueChanged += list_Projects_SelectedValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(252, 25);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(120, 23);
            label1.TabIndex = 1;
            label1.Text = "Proje İsmi";
            label1.Click += label1_Click;
            // 
            // txt_ProjectName
            // 
            txt_ProjectName.Location = new System.Drawing.Point(252, 51);
            txt_ProjectName.Name = "txt_ProjectName";
            txt_ProjectName.Size = new System.Drawing.Size(277, 39);
            txt_ProjectName.TabIndex = 2;
            txt_ProjectName.TextChanged += txt_ProjectName_TextChanged;
            // 
            // btn_Save
            // 
            btn_Save.Location = new System.Drawing.Point(252, 96);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new System.Drawing.Size(277, 44);
            btn_Save.TabIndex = 3;
            btn_Save.Text = "Kaydet";
            btn_Save.UseVisualStyleBackColor = true;
            btn_Save.Click += btn_Save_Click;
            // 
            // btn_Update
            // 
            btn_Update.Location = new System.Drawing.Point(252, 146);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new System.Drawing.Size(277, 44);
            btn_Update.TabIndex = 4;
            btn_Update.Text = "Güncelle";
            btn_Update.UseVisualStyleBackColor = true;
            btn_Update.Click += btn_Update_Click;
            // 
            // btn_Delete
            // 
            btn_Delete.Location = new System.Drawing.Point(252, 196);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new System.Drawing.Size(277, 44);
            btn_Delete.TabIndex = 5;
            btn_Delete.Text = "Sil";
            btn_Delete.UseVisualStyleBackColor = true;
            btn_Delete.Click += btn_Delete_Click;
            // 
            // Projects
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(15F, 32F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(541, 473);
            Controls.Add(btn_Delete);
            Controls.Add(btn_Update);
            Controls.Add(btn_Save);
            Controls.Add(txt_ProjectName);
            Controls.Add(label1);
            Controls.Add(list_Projects);
            Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            MaximizeBox = false;
            Name = "Projects";
            Text = "Projeler";
            FormClosing += Projects_FormClosing;
            Load += Projects_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListBox list_Projects;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ProjectName;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Delete;
    }
}