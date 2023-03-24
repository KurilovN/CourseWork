namespace CourseWork
{
    partial class EditTrainGymForm
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
            this.cBCoachID = new System.Windows.Forms.ComboBox();
            this.cBTrainID = new System.Windows.Forms.ComboBox();
            this.cBWeekDay = new System.Windows.Forms.ComboBox();
            this.ReturnBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.tBEnd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tBBegin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cBCoachID
            // 
            this.cBCoachID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBCoachID.FormattingEnabled = true;
            this.cBCoachID.Location = new System.Drawing.Point(202, 10);
            this.cBCoachID.Name = "cBCoachID";
            this.cBCoachID.Size = new System.Drawing.Size(149, 24);
            this.cBCoachID.TabIndex = 38;
            // 
            // cBTrainID
            // 
            this.cBTrainID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBTrainID.FormattingEnabled = true;
            this.cBTrainID.Location = new System.Drawing.Point(202, 54);
            this.cBTrainID.Name = "cBTrainID";
            this.cBTrainID.Size = new System.Drawing.Size(149, 24);
            this.cBTrainID.TabIndex = 37;
            // 
            // cBWeekDay
            // 
            this.cBWeekDay.FormattingEnabled = true;
            this.cBWeekDay.Items.AddRange(new object[] {
            "Понедельник",
            "Вторник",
            "Среда",
            "Четверг",
            "Пятница",
            "Суббота",
            "Воскресенье"});
            this.cBWeekDay.Location = new System.Drawing.Point(202, 99);
            this.cBWeekDay.Name = "cBWeekDay";
            this.cBWeekDay.Size = new System.Drawing.Size(149, 24);
            this.cBWeekDay.TabIndex = 36;
            // 
            // ReturnBtn
            // 
            this.ReturnBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ReturnBtn.Location = new System.Drawing.Point(13, 233);
            this.ReturnBtn.Name = "ReturnBtn";
            this.ReturnBtn.Size = new System.Drawing.Size(112, 52);
            this.ReturnBtn.TabIndex = 35;
            this.ReturnBtn.Text = "Назад";
            this.ReturnBtn.UseVisualStyleBackColor = true;
            this.ReturnBtn.Click += new System.EventHandler(this.ReturnBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.Location = new System.Drawing.Point(202, 233);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(149, 52);
            this.EditBtn.TabIndex = 34;
            this.EditBtn.Text = "Редактировать";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // tBEnd
            // 
            this.tBEnd.Location = new System.Drawing.Point(202, 192);
            this.tBEnd.Name = "tBEnd";
            this.tBEnd.Size = new System.Drawing.Size(149, 22);
            this.tBEnd.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 17);
            this.label5.TabIndex = 32;
            this.label5.Text = "Время по";
            // 
            // tBBegin
            // 
            this.tBBegin.Location = new System.Drawing.Point(202, 148);
            this.tBBegin.Name = "tBBegin";
            this.tBBegin.Size = new System.Drawing.Size(149, 22);
            this.tBBegin.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 30;
            this.label4.Text = "Время с";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 29;
            this.label3.Text = "День недели";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "Наименование тренировки";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "ФИО тренера";
            // 
            // EditTrainGymForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 298);
            this.Controls.Add(this.cBCoachID);
            this.Controls.Add(this.cBTrainID);
            this.Controls.Add(this.cBWeekDay);
            this.Controls.Add(this.ReturnBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.tBEnd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tBBegin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditTrainGymForm";
            this.Text = "Тренировка тренажерного зала";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cBCoachID;
        private System.Windows.Forms.ComboBox cBTrainID;
        private System.Windows.Forms.ComboBox cBWeekDay;
        private System.Windows.Forms.Button ReturnBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.TextBox tBEnd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tBBegin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}