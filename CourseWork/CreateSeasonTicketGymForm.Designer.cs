namespace CourseWork
{
    partial class CreateSeasonTicketGymForm
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
            this.cBSeasonTicketD = new System.Windows.Forms.ComboBox();
            this.cBGymID = new System.Windows.Forms.ComboBox();
            this.ReturnBtn = new System.Windows.Forms.Button();
            this.CreateBtn = new System.Windows.Forms.Button();
            this.tBEnd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tBBegin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tBCost = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cBSeasonTicketD
            // 
            this.cBSeasonTicketD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBSeasonTicketD.FormattingEnabled = true;
            this.cBSeasonTicketD.Location = new System.Drawing.Point(205, 8);
            this.cBSeasonTicketD.Name = "cBSeasonTicketD";
            this.cBSeasonTicketD.Size = new System.Drawing.Size(149, 24);
            this.cBSeasonTicketD.TabIndex = 38;
            // 
            // cBGymID
            // 
            this.cBGymID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBGymID.FormattingEnabled = true;
            this.cBGymID.Location = new System.Drawing.Point(205, 52);
            this.cBGymID.Name = "cBGymID";
            this.cBGymID.Size = new System.Drawing.Size(149, 24);
            this.cBGymID.TabIndex = 37;
            // 
            // ReturnBtn
            // 
            this.ReturnBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ReturnBtn.Location = new System.Drawing.Point(16, 231);
            this.ReturnBtn.Name = "ReturnBtn";
            this.ReturnBtn.Size = new System.Drawing.Size(112, 52);
            this.ReturnBtn.TabIndex = 35;
            this.ReturnBtn.Text = "Назад";
            this.ReturnBtn.UseVisualStyleBackColor = true;
            this.ReturnBtn.Click += new System.EventHandler(this.ReturnBtn_Click);
            // 
            // CreateBtn
            // 
            this.CreateBtn.Location = new System.Drawing.Point(238, 231);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(116, 52);
            this.CreateBtn.TabIndex = 34;
            this.CreateBtn.Text = "Добавить";
            this.CreateBtn.UseVisualStyleBackColor = true;
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // tBEnd
            // 
            this.tBEnd.Location = new System.Drawing.Point(205, 190);
            this.tBEnd.Name = "tBEnd";
            this.tBEnd.Size = new System.Drawing.Size(149, 22);
            this.tBEnd.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 32;
            this.label5.Text = "Дата по";
            // 
            // tBBegin
            // 
            this.tBBegin.Location = new System.Drawing.Point(205, 146);
            this.tBBegin.Name = "tBBegin";
            this.tBBegin.Size = new System.Drawing.Size(149, 22);
            this.tBBegin.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 30;
            this.label4.Text = "Дата с";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 29;
            this.label3.Text = "Стоимость";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 34);
            this.label2.TabIndex = 28;
            this.label2.Text = "Наименование \r\nтренажерного зала";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 34);
            this.label1.TabIndex = 27;
            this.label1.Text = "Наименование \r\nабонемента";
            // 
            // tBCost
            // 
            this.tBCost.Location = new System.Drawing.Point(205, 100);
            this.tBCost.Name = "tBCost";
            this.tBCost.Size = new System.Drawing.Size(149, 22);
            this.tBCost.TabIndex = 39;
            // 
            // CreateSeasonTicketGymForm
            // 
            this.AcceptButton = this.CreateBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ReturnBtn;
            this.ClientSize = new System.Drawing.Size(363, 295);
            this.Controls.Add(this.tBCost);
            this.Controls.Add(this.cBSeasonTicketD);
            this.Controls.Add(this.cBGymID);
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
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateSeasonTicketGymForm";
            this.Text = "Абонемент тренажерного зала";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cBSeasonTicketD;
        private System.Windows.Forms.ComboBox cBGymID;
        private System.Windows.Forms.Button ReturnBtn;
        private System.Windows.Forms.Button CreateBtn;
        private System.Windows.Forms.TextBox tBEnd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tBBegin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBCost;
    }
}