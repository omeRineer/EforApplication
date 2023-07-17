namespace WorkTimeApp
{
    partial class WorkTimeDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkTimeDetail));
            label1 = new System.Windows.Forms.Label();
            txt_Person = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            cmb_Project = new System.Windows.Forms.ComboBox();
            cmb_Quest = new System.Windows.Forms.ComboBox();
            label4 = new System.Windows.Forms.Label();
            txt_Amount = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            rch_Description = new System.Windows.Forms.RichTextBox();
            label6 = new System.Windows.Forms.Label();
            btn_Save = new System.Windows.Forms.Button();
            date_Date = new System.Windows.Forms.DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(67, 26);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(65, 23);
            label1.TabIndex = 3;
            label1.Text = "Tarih";
            // 
            // txt_Person
            // 
            txt_Person.Location = new System.Drawing.Point(175, 61);
            txt_Person.Name = "txt_Person";
            txt_Person.Size = new System.Drawing.Size(562, 39);
            txt_Person.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(34, 71);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(98, 23);
            label2.TabIndex = 5;
            label2.Text = "Personel";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(67, 116);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(65, 23);
            label3.TabIndex = 7;
            label3.Text = "Proje";
            // 
            // cmb_Project
            // 
            cmb_Project.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmb_Project.FormattingEnabled = true;
            cmb_Project.Location = new System.Drawing.Point(175, 106);
            cmb_Project.Name = "cmb_Project";
            cmb_Project.Size = new System.Drawing.Size(562, 40);
            cmb_Project.TabIndex = 8;
            // 
            // cmb_Quest
            // 
            cmb_Quest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmb_Quest.FormattingEnabled = true;
            cmb_Quest.Location = new System.Drawing.Point(175, 152);
            cmb_Quest.Name = "cmb_Quest";
            cmb_Quest.Size = new System.Drawing.Size(562, 40);
            cmb_Quest.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(67, 162);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(65, 23);
            label4.TabIndex = 9;
            label4.Text = "Görev";
            // 
            // txt_Amount
            // 
            txt_Amount.Location = new System.Drawing.Point(175, 198);
            txt_Amount.Name = "txt_Amount";
            txt_Amount.Size = new System.Drawing.Size(562, 39);
            txt_Amount.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(56, 208);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(76, 23);
            label5.TabIndex = 11;
            label5.Text = "Miktar";
            // 
            // rch_Description
            // 
            rch_Description.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            rch_Description.Location = new System.Drawing.Point(175, 243);
            rch_Description.Name = "rch_Description";
            rch_Description.Size = new System.Drawing.Size(562, 315);
            rch_Description.TabIndex = 13;
            rch_Description.Text = "";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label6.Location = new System.Drawing.Point(34, 253);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(98, 23);
            label6.TabIndex = 14;
            label6.Text = "Açıklama";
            // 
            // btn_Save
            // 
            btn_Save.Location = new System.Drawing.Point(175, 564);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new System.Drawing.Size(562, 40);
            btn_Save.TabIndex = 15;
            btn_Save.Text = "Kaydet";
            btn_Save.UseVisualStyleBackColor = true;
            btn_Save.Click += btn_Save_Click;
            // 
            // date_Date
            // 
            date_Date.CustomFormat = "dd/MM/yyyy";
            date_Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            date_Date.Location = new System.Drawing.Point(175, 16);
            date_Date.Name = "date_Date";
            date_Date.Size = new System.Drawing.Size(562, 39);
            date_Date.TabIndex = 16;
            // 
            // WorkTimeDetail
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(15F, 32F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(749, 611);
            Controls.Add(date_Date);
            Controls.Add(btn_Save);
            Controls.Add(label6);
            Controls.Add(rch_Description);
            Controls.Add(txt_Amount);
            Controls.Add(label5);
            Controls.Add(cmb_Quest);
            Controls.Add(label4);
            Controls.Add(cmb_Project);
            Controls.Add(label3);
            Controls.Add(txt_Person);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            MaximizeBox = false;
            Name = "WorkTimeDetail";
            Text = "Efor Detayı";
            Load += WorkTimeDetail_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Person;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_Project;
        private System.Windows.Forms.ComboBox cmb_Quest;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Amount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox rch_Description;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.DateTimePicker date_Date;
    }
}