namespace CourseWork
{
    partial class EditCoachForm
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
            this.tBEducation = new System.Windows.Forms.TextBox();
            this.cBGymID = new System.Windows.Forms.ComboBox();
            this.cBCategoryID = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ReturnBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tBWorkExperience = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tBGender = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tBName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tBEducation
            // 
            this.tBEducation.Location = new System.Drawing.Point(172, 145);
            this.tBEducation.Name = "tBEducation";
            this.tBEducation.Size = new System.Drawing.Size(149, 22);
            this.tBEducation.TabIndex = 42;
            // 
            // cBGymID
            // 
            this.cBGymID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBGymID.FormattingEnabled = true;
            this.cBGymID.Location = new System.Drawing.Point(172, 237);
            this.cBGymID.Name = "cBGymID";
            this.cBGymID.Size = new System.Drawing.Size(149, 24);
            this.cBGymID.TabIndex = 41;
            // 
            // cBCategoryID
            // 
            this.cBCategoryID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBCategoryID.FormattingEnabled = true;
            this.cBCategoryID.Location = new System.Drawing.Point(172, 191);
            this.cBCategoryID.Name = "cBCategoryID";
            this.cBCategoryID.Size = new System.Drawing.Size(149, 24);
            this.cBCategoryID.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 34);
            this.label6.TabIndex = 39;
            this.label6.Text = "Наименование \r\nтренажерного зала";
            // 
            // ReturnBtn
            // 
            this.ReturnBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ReturnBtn.Location = new System.Drawing.Point(13, 289);
            this.ReturnBtn.Name = "ReturnBtn";
            this.ReturnBtn.Size = new System.Drawing.Size(112, 52);
            this.ReturnBtn.TabIndex = 38;
            this.ReturnBtn.Text = "Назад";
            this.ReturnBtn.UseVisualStyleBackColor = true;
            this.ReturnBtn.Click += new System.EventHandler(this.ReturnBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.Location = new System.Drawing.Point(193, 289);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(128, 52);
            this.EditBtn.TabIndex = 37;
            this.EditBtn.Text = "Редактировать";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 17);
            this.label5.TabIndex = 36;
            this.label5.Text = "Образование";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 34);
            this.label4.TabIndex = 35;
            this.label4.Text = "Наименование\r\nквалификации";
            // 
            // tBWorkExperience
            // 
            this.tBWorkExperience.Location = new System.Drawing.Point(172, 104);
            this.tBWorkExperience.Name = "tBWorkExperience";
            this.tBWorkExperience.Size = new System.Drawing.Size(149, 22);
            this.tBWorkExperience.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 33;
            this.label3.Text = "Стаж";
            // 
            // tBGender
            // 
            this.tBGender.Location = new System.Drawing.Point(172, 59);
            this.tBGender.Name = "tBGender";
            this.tBGender.Size = new System.Drawing.Size(149, 22);
            this.tBGender.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 31;
            this.label2.Text = "Пол";
            // 
            // tBName
            // 
            this.tBName.Location = new System.Drawing.Point(172, 12);
            this.tBName.Name = "tBName";
            this.tBName.Size = new System.Drawing.Size(149, 22);
            this.tBName.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 29;
            this.label1.Text = "ФИО";
            // 
            // EditCoachForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 347);
            this.Controls.Add(this.tBEducation);
            this.Controls.Add(this.cBGymID);
            this.Controls.Add(this.cBCategoryID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ReturnBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tBWorkExperience);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tBGender);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tBName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditCoachForm";
            this.Text = "Тренер";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBEducation;
        private System.Windows.Forms.ComboBox cBGymID;
        private System.Windows.Forms.ComboBox cBCategoryID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ReturnBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tBWorkExperience;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBGender;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBName;
        private System.Windows.Forms.Label label1;
    }
}