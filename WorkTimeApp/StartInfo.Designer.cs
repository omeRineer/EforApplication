namespace WorkTimeApp
{
    partial class StartInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartInfo));
            txt_Name = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            btn_Enter = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // txt_Name
            // 
            txt_Name.Location = new System.Drawing.Point(28, 55);
            txt_Name.Name = "txt_Name";
            txt_Name.Size = new System.Drawing.Size(368, 39);
            txt_Name.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(28, 29);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(54, 23);
            label1.TabIndex = 1;
            label1.Text = "İsim";
            // 
            // btn_Enter
            // 
            btn_Enter.Location = new System.Drawing.Point(28, 119);
            btn_Enter.Name = "btn_Enter";
            btn_Enter.Size = new System.Drawing.Size(368, 58);
            btn_Enter.TabIndex = 4;
            btn_Enter.Text = "Giriş";
            btn_Enter.UseVisualStyleBackColor = true;
            btn_Enter.Click += btn_Enter_Click;
            // 
            // StartInfo
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(15F, 32F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(423, 202);
            Controls.Add(btn_Enter);
            Controls.Add(label1);
            Controls.Add(txt_Name);
            Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            MaximizeBox = false;
            Name = "StartInfo";
            Text = "Giriş";
            Load += StartInfo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Enter;
    }
}