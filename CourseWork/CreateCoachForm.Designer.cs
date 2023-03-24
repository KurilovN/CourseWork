namespace CourseWork
{
    partial class CreateCoachForm
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
            this.ReturnBtn = new System.Windows.Forms.Button();
            this.CreateBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tBWorkExperience = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tBName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cBCategoryID = new System.Windows.Forms.ComboBox();
            this.cBGymID = new System.Windows.Forms.ComboBox();
            this.tBEducation = new System.Windows.Forms.TextBox();
            this.cBGender = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ReturnBtn
            // 
            this.ReturnBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ReturnBtn.Location = new System.Drawing.Point(202, 303);
            this.ReturnBtn.Name = "ReturnBtn";
            this.ReturnBtn.Size = new System.Drawing.Size(112, 52);
            this.ReturnBtn.TabIndex = 23;
            this.ReturnBtn.Text = "Назад";
            this.ReturnBtn.UseVisualStyleBackColor = true;
            // 
            // CreateBtn
            // 
            this.CreateBtn.Location = new System.Drawing.Point(8, 303);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(110, 52);
            this.CreateBtn.TabIndex = 22;
            this.CreateBtn.Text = "Добавить";
            this.CreateBtn.UseVisualStyleBackColor = true;
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Образование";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 34);
            this.label4.TabIndex = 18;
            this.label4.Text = "Наименование\r\nквалификации";
            // 
            // tBWorkExperience
            // 
            this.tBWorkExperience.Location = new System.Drawing.Point(165, 103);
            this.tBWorkExperience.Name = "tBWorkExperience";
            this.tBWorkExperience.Size = new System.Drawing.Size(149, 22);
            this.tBWorkExperience.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Стаж";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Пол";
            // 
            // tBName
            // 
            this.tBName.Location = new System.Drawing.Point(165, 11);
            this.tBName.Name = "tBName";
            this.tBName.Size = new System.Drawing.Size(149, 22);
            this.tBName.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "ФИО";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 34);
            this.label6.TabIndex = 24;
            this.label6.Text = "Наименование\r\nтренажерного зала";
            // 
            // cBCategoryID
            // 
            this.cBCategoryID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBCategoryID.FormattingEnabled = true;
            this.cBCategoryID.Location = new System.Drawing.Point(165, 193);
            this.cBCategoryID.Name = "cBCategoryID";
            this.cBCategoryID.Size = new System.Drawing.Size(149, 24);
            this.cBCategoryID.TabIndex = 25;
            // 
            // cBGymID
            // 
            this.cBGymID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBGymID.FormattingEnabled = true;
            this.cBGymID.Location = new System.Drawing.Point(165, 249);
            this.cBGymID.Name = "cBGymID";
            this.cBGymID.Size = new System.Drawing.Size(149, 24);
            this.cBGymID.TabIndex = 27;
            // 
            // tBEducation
            // 
            this.tBEducation.Location = new System.Drawing.Point(165, 144);
            this.tBEducation.Name = "tBEducation";
            this.tBEducation.Size = new System.Drawing.Size(149, 22);
            this.tBEducation.TabIndex = 28;
            // 
            // cBGender
            // 
            this.cBGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBGender.FormattingEnabled = true;
            this.cBGender.Items.AddRange(new object[] {
            "Мужской",
            "Женский"});
            this.cBGender.Location = new System.Drawing.Point(165, 55);
            this.cBGender.Name = "cBGender";
            this.cBGender.Size = new System.Drawing.Size(149, 24);
            this.cBGender.TabIndex = 29;
            // 
            // CreateCoachForm
            // 
            this.AcceptButton = this.CreateBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ReturnBtn;
            this.ClientSize = new System.Drawing.Size(326, 367);
            this.Controls.Add(this.cBGender);
            this.Controls.Add(this.tBEducation);
            this.Controls.Add(this.cBGymID);
            this.Controls.Add(this.cBCategoryID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ReturnBtn);
            this.Controls.Add(this.CreateBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tBWorkExperience);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tBName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateCoachForm";
            this.Text = "Тренер";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ReturnBtn;
        private System.Windows.Forms.Button CreateBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tBWorkExperience;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cBCategoryID;
        private System.Windows.Forms.ComboBox cBGymID;
        private System.Windows.Forms.TextBox tBEducation;
        private System.Windows.Forms.ComboBox cBGender;
    }
}