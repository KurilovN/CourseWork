namespace CourseWork
{
    partial class EditGymEquipForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.tBCount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cBIDGym = new System.Windows.Forms.ComboBox();
            this.cBIDEquipment = new System.Windows.Forms.ComboBox();
            this.ReturnBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 42;
            this.label1.Text = "Количество";
            // 
            // tBCount
            // 
            this.tBCount.Location = new System.Drawing.Point(169, 105);
            this.tBCount.Name = "tBCount";
            this.tBCount.Size = new System.Drawing.Size(149, 22);
            this.tBCount.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 34);
            this.label3.TabIndex = 40;
            this.label3.Text = "Наименование\r\nтренажерного зала";
            // 
            // cBIDGym
            // 
            this.cBIDGym.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBIDGym.FormattingEnabled = true;
            this.cBIDGym.Location = new System.Drawing.Point(169, 8);
            this.cBIDGym.Name = "cBIDGym";
            this.cBIDGym.Size = new System.Drawing.Size(149, 24);
            this.cBIDGym.TabIndex = 39;
            // 
            // cBIDEquipment
            // 
            this.cBIDEquipment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBIDEquipment.FormattingEnabled = true;
            this.cBIDEquipment.Location = new System.Drawing.Point(169, 57);
            this.cBIDEquipment.Name = "cBIDEquipment";
            this.cBIDEquipment.Size = new System.Drawing.Size(149, 24);
            this.cBIDEquipment.TabIndex = 38;
            // 
            // ReturnBtn
            // 
            this.ReturnBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ReturnBtn.Location = new System.Drawing.Point(11, 142);
            this.ReturnBtn.Name = "ReturnBtn";
            this.ReturnBtn.Size = new System.Drawing.Size(112, 52);
            this.ReturnBtn.TabIndex = 37;
            this.ReturnBtn.Text = "Назад";
            this.ReturnBtn.UseVisualStyleBackColor = true;
            this.ReturnBtn.Click += new System.EventHandler(this.ReturnBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.Location = new System.Drawing.Point(188, 142);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(130, 52);
            this.EditBtn.TabIndex = 36;
            this.EditBtn.Text = "Редактировать";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 34);
            this.label2.TabIndex = 35;
            this.label2.Text = "Наименование\r\nоборудования";
            // 
            // EditGymEquipForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 197);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cBIDGym);
            this.Controls.Add(this.cBIDEquipment);
            this.Controls.Add(this.ReturnBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditGymEquipForm";
            this.Text = "Оборудование в зале";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cBIDGym;
        private System.Windows.Forms.ComboBox cBIDEquipment;
        private System.Windows.Forms.Button ReturnBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Label label2;
    }
}