namespace CourseWork
{
    partial class SearchGymForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cBNameGym = new System.Windows.Forms.ComboBox();
            this.cBCity = new System.Windows.Forms.ComboBox();
            this.FinishBtn = new System.Windows.Forms.Button();
            this.CheckResultsBtn = new System.Windows.Forms.Button();
            this.ClearNameGymBtn = new System.Windows.Forms.Button();
            this.ClearCityGymBtn = new System.Windows.Forms.Button();
            this.cBEquip = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ClearEquipGymBtn = new System.Windows.Forms.Button();
            this.cBTrain = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ClearTrainBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Город";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 34);
            this.label1.TabIndex = 10;
            this.label1.Text = "Наименование \r\nтренажерного зала";
            // 
            // cBNameGym
            // 
            this.cBNameGym.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBNameGym.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cBNameGym.FormattingEnabled = true;
            this.cBNameGym.Location = new System.Drawing.Point(203, 15);
            this.cBNameGym.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cBNameGym.Name = "cBNameGym";
            this.cBNameGym.Size = new System.Drawing.Size(410, 28);
            this.cBNameGym.TabIndex = 17;
            // 
            // cBCity
            // 
            this.cBCity.AutoCompleteCustomSource.AddRange(new string[] {
            "Кунгур",
            "Пермь",
            "Москва",
            "Санк-Петербург",
            "Санк-Петербург",
            "Санк-Петербург",
            "Санк-Петербург",
            "Санк-Петербург",
            "Санк-Петербург",
            "Санк-Петербург",
            "Ленинград"});
            this.cBCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cBCity.FormattingEnabled = true;
            this.cBCity.Location = new System.Drawing.Point(203, 66);
            this.cBCity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cBCity.Name = "cBCity";
            this.cBCity.Size = new System.Drawing.Size(410, 28);
            this.cBCity.TabIndex = 18;
            // 
            // FinishBtn
            // 
            this.FinishBtn.Location = new System.Drawing.Point(15, 231);
            this.FinishBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FinishBtn.Name = "FinishBtn";
            this.FinishBtn.Size = new System.Drawing.Size(144, 45);
            this.FinishBtn.TabIndex = 19;
            this.FinishBtn.Text = "Закончить поиск";
            this.FinishBtn.UseVisualStyleBackColor = true;
            this.FinishBtn.Click += new System.EventHandler(this.FinishBtn_Click);
            // 
            // CheckResultsBtn
            // 
            this.CheckResultsBtn.Location = new System.Drawing.Point(599, 231);
            this.CheckResultsBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CheckResultsBtn.Name = "CheckResultsBtn";
            this.CheckResultsBtn.Size = new System.Drawing.Size(156, 45);
            this.CheckResultsBtn.TabIndex = 20;
            this.CheckResultsBtn.Text = "Посмотерть  результаты";
            this.CheckResultsBtn.UseVisualStyleBackColor = true;
            this.CheckResultsBtn.Click += new System.EventHandler(this.CheckResultsBtn_Click);
            // 
            // ClearNameGymBtn
            // 
            this.ClearNameGymBtn.Location = new System.Drawing.Point(638, 15);
            this.ClearNameGymBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ClearNameGymBtn.Name = "ClearNameGymBtn";
            this.ClearNameGymBtn.Size = new System.Drawing.Size(117, 34);
            this.ClearNameGymBtn.TabIndex = 21;
            this.ClearNameGymBtn.Text = "Очистить поле";
            this.ClearNameGymBtn.UseVisualStyleBackColor = true;
            this.ClearNameGymBtn.Click += new System.EventHandler(this.ClearNameGymBtn_Click);
            // 
            // ClearCityGymBtn
            // 
            this.ClearCityGymBtn.Location = new System.Drawing.Point(638, 66);
            this.ClearCityGymBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ClearCityGymBtn.Name = "ClearCityGymBtn";
            this.ClearCityGymBtn.Size = new System.Drawing.Size(117, 34);
            this.ClearCityGymBtn.TabIndex = 22;
            this.ClearCityGymBtn.Text = "Очистить поле";
            this.ClearCityGymBtn.UseVisualStyleBackColor = true;
            this.ClearCityGymBtn.Click += new System.EventHandler(this.ClearCityGymBtn_Click);
            // 
            // cBEquip
            // 
            this.cBEquip.AutoCompleteCustomSource.AddRange(new string[] {
            "Кунгур",
            "Пермь",
            "Москва",
            "Санк-Петербург",
            "Санк-Петербург",
            "Санк-Петербург",
            "Санк-Петербург",
            "Санк-Петербург",
            "Санк-Петербург",
            "Санк-Петербург",
            "Ленинград"});
            this.cBEquip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBEquip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cBEquip.FormattingEnabled = true;
            this.cBEquip.Location = new System.Drawing.Point(203, 117);
            this.cBEquip.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cBEquip.Name = "cBEquip";
            this.cBEquip.Size = new System.Drawing.Size(410, 28);
            this.cBEquip.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "Оборудование";
            // 
            // ClearEquipGymBtn
            // 
            this.ClearEquipGymBtn.Location = new System.Drawing.Point(638, 114);
            this.ClearEquipGymBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ClearEquipGymBtn.Name = "ClearEquipGymBtn";
            this.ClearEquipGymBtn.Size = new System.Drawing.Size(117, 34);
            this.ClearEquipGymBtn.TabIndex = 25;
            this.ClearEquipGymBtn.Text = "Очистить поле";
            this.ClearEquipGymBtn.UseVisualStyleBackColor = true;
            this.ClearEquipGymBtn.Click += new System.EventHandler(this.ClearEquipGymBtn_Click);
            // 
            // cBTrain
            // 
            this.cBTrain.AutoCompleteCustomSource.AddRange(new string[] {
            "Кунгур",
            "Пермь",
            "Москва",
            "Санк-Петербург",
            "Санк-Петербург",
            "Санк-Петербург",
            "Санк-Петербург",
            "Санк-Петербург",
            "Санк-Петербург",
            "Санк-Петербург",
            "Ленинград"});
            this.cBTrain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBTrain.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cBTrain.FormattingEnabled = true;
            this.cBTrain.Location = new System.Drawing.Point(203, 169);
            this.cBTrain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cBTrain.Name = "cBTrain";
            this.cBTrain.Size = new System.Drawing.Size(410, 28);
            this.cBTrain.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 27;
            this.label3.Text = "Тренировка";
            // 
            // ClearTrainBtn
            // 
            this.ClearTrainBtn.Location = new System.Drawing.Point(638, 163);
            this.ClearTrainBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ClearTrainBtn.Name = "ClearTrainBtn";
            this.ClearTrainBtn.Size = new System.Drawing.Size(117, 34);
            this.ClearTrainBtn.TabIndex = 28;
            this.ClearTrainBtn.Text = "Очистить поле";
            this.ClearTrainBtn.UseVisualStyleBackColor = true;
            this.ClearTrainBtn.Click += new System.EventHandler(this.ClearTrainBtn_Click);
            // 
            // SearchGymForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 293);
            this.Controls.Add(this.ClearTrainBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cBTrain);
            this.Controls.Add(this.ClearEquipGymBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cBEquip);
            this.Controls.Add(this.ClearCityGymBtn);
            this.Controls.Add(this.ClearNameGymBtn);
            this.Controls.Add(this.CheckResultsBtn);
            this.Controls.Add(this.FinishBtn);
            this.Controls.Add(this.cBCity);
            this.Controls.Add(this.cBNameGym);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchGymForm";
            this.Text = "Поиск тренажерного зала";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBNameGym;
        private System.Windows.Forms.ComboBox cBCity;
        private System.Windows.Forms.Button FinishBtn;
        private System.Windows.Forms.Button CheckResultsBtn;
        private System.Windows.Forms.Button ClearNameGymBtn;
        private System.Windows.Forms.Button ClearCityGymBtn;
        private System.Windows.Forms.ComboBox cBEquip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ClearEquipGymBtn;
        private System.Windows.Forms.ComboBox cBTrain;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ClearTrainBtn;
    }
}