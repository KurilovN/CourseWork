namespace CourseWork
{
    partial class CreateTrainGymForm
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
            this.tBEnd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tBBegin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cBWeekDay = new System.Windows.Forms.ComboBox();
            this.cBTrainID = new System.Windows.Forms.ComboBox();
            this.cBCoachID = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ReturnBtn
            // 
            this.ReturnBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ReturnBtn.Location = new System.Drawing.Point(27, 246);
            this.ReturnBtn.Name = "ReturnBtn";
            this.ReturnBtn.Size = new System.Drawing.Size(112, 52);
            this.ReturnBtn.TabIndex = 23;
            this.ReturnBtn.Text = "Назад";
            this.ReturnBtn.UseVisualStyleBackColor = true;
            this.ReturnBtn.Click += new System.EventHandler(this.ReturnBtn_Click);
            // 
            // CreateBtn
            // 
            this.CreateBtn.Location = new System.Drawing.Point(249, 246);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(116, 52);
            this.CreateBtn.TabIndex = 22;
            this.CreateBtn.Text = "Добавить";
            this.CreateBtn.UseVisualStyleBackColor = true;
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // tBEnd
            // 
            this.tBEnd.Location = new System.Drawing.Point(216, 205);
            this.tBEnd.Name = "tBEnd";
            this.tBEnd.Size = new System.Drawing.Size(149, 22);
            this.tBEnd.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Время по";
            // 
            // tBBegin
            // 
            this.tBBegin.Location = new System.Drawing.Point(216, 161);
            this.tBBegin.Name = "tBBegin";
            this.tBBegin.Size = new System.Drawing.Size(149, 22);
            this.tBBegin.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Время с";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "День недели";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 34);
            this.label2.TabIndex = 14;
            this.label2.Text = "Наименование\r\nтренировки";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "ФИО тренера";
            // 
            // cBWeekDay
            // 
            this.cBWeekDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBWeekDay.FormattingEnabled = true;
            this.cBWeekDay.Items.AddRange(new object[] {
            "Понедельник",
            "Вторник",
            "Среда",
            "Четверг",
            "Пятница",
            "Суббота",
            "Воскресенье"});
            this.cBWeekDay.Location = new System.Drawing.Point(216, 112);
            this.cBWeekDay.Name = "cBWeekDay";
            this.cBWeekDay.Size = new System.Drawing.Size(149, 24);
            this.cBWeekDay.TabIndex = 24;
            // 
            // cBTrainID
            // 
            this.cBTrainID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBTrainID.FormattingEnabled = true;
            this.cBTrainID.Location = new System.Drawing.Point(216, 67);
            this.cBTrainID.Name = "cBTrainID";
            this.cBTrainID.Size = new System.Drawing.Size(149, 24);
            this.cBTrainID.TabIndex = 25;
            // 
            // cBCoachID
            // 
            this.cBCoachID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBCoachID.FormattingEnabled = true;
            this.cBCoachID.Location = new System.Drawing.Point(216, 23);
            this.cBCoachID.Name = "cBCoachID";
            this.cBCoachID.Size = new System.Drawing.Size(149, 24);
            this.cBCoachID.TabIndex = 26;
            // 
            // CreateTrainGymForm
            // 
            this.AcceptButton = this.CreateBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ReturnBtn;
            this.ClientSize = new System.Drawing.Size(401, 317);
            this.Controls.Add(this.cBCoachID);
            this.Controls.Add(this.cBTrainID);
            this.Controls.Add(this.cBWeekDay);
            this.Controls.Add(this.ReturnBtn);
            this.Controls.Add(this.CreateBtn);
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
            this.Name = "CreateTrainGymForm";
            this.Text = "Тренировка в тренажерном зале";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ReturnBtn;
        private System.Windows.Forms.Button CreateBtn;
        private System.Windows.Forms.TextBox tBEnd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tBBegin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBWeekDay;
        private System.Windows.Forms.ComboBox cBTrainID;
        private System.Windows.Forms.ComboBox cBCoachID;
    }
}