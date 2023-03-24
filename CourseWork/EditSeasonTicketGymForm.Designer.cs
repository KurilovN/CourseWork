namespace CourseWork
{
    partial class EditSeasonTicketGymForm
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
            this.tBCost = new System.Windows.Forms.TextBox();
            this.cBSeasonTicketD = new System.Windows.Forms.ComboBox();
            this.cBGymID = new System.Windows.Forms.ComboBox();
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
            // tBCost
            // 
            this.tBCost.Location = new System.Drawing.Point(203, 99);
            this.tBCost.Name = "tBCost";
            this.tBCost.Size = new System.Drawing.Size(149, 22);
            this.tBCost.TabIndex = 51;
            // 
            // cBSeasonTicketD
            // 
            this.cBSeasonTicketD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBSeasonTicketD.FormattingEnabled = true;
            this.cBSeasonTicketD.Location = new System.Drawing.Point(203, 7);
            this.cBSeasonTicketD.Name = "cBSeasonTicketD";
            this.cBSeasonTicketD.Size = new System.Drawing.Size(149, 24);
            this.cBSeasonTicketD.TabIndex = 50;
            // 
            // cBGymID
            // 
            this.cBGymID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBGymID.FormattingEnabled = true;
            this.cBGymID.Location = new System.Drawing.Point(203, 51);
            this.cBGymID.Name = "cBGymID";
            this.cBGymID.Size = new System.Drawing.Size(149, 24);
            this.cBGymID.TabIndex = 49;
            // 
            // ReturnBtn
            // 
            this.ReturnBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ReturnBtn.Location = new System.Drawing.Point(14, 230);
            this.ReturnBtn.Name = "ReturnBtn";
            this.ReturnBtn.Size = new System.Drawing.Size(112, 52);
            this.ReturnBtn.TabIndex = 48;
            this.ReturnBtn.Text = "Назад";
            this.ReturnBtn.UseVisualStyleBackColor = true;
            this.ReturnBtn.Click += new System.EventHandler(this.ReturnBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.Location = new System.Drawing.Point(203, 230);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(149, 52);
            this.EditBtn.TabIndex = 47;
            this.EditBtn.Text = "Редактировать";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // tBEnd
            // 
            this.tBEnd.Location = new System.Drawing.Point(203, 189);
            this.tBEnd.Name = "tBEnd";
            this.tBEnd.Size = new System.Drawing.Size(149, 22);
            this.tBEnd.TabIndex = 46;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 45;
            this.label5.Text = "Дата по";
            // 
            // tBBegin
            // 
            this.tBBegin.Location = new System.Drawing.Point(203, 145);
            this.tBBegin.Name = "tBBegin";
            this.tBBegin.Size = new System.Drawing.Size(149, 22);
            this.tBBegin.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 43;
            this.label4.Text = "Дата с";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 17);
            this.label3.TabIndex = 42;
            this.label3.Text = "Стоимость(в рублях)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 34);
            this.label2.TabIndex = 41;
            this.label2.Text = "Наименование\r\nтренажерного зала";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 34);
            this.label1.TabIndex = 40;
            this.label1.Text = "Наименование\r\nабонемента";
            // 
            // EditSeasonTicketGymForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 289);
            this.Controls.Add(this.tBCost);
            this.Controls.Add(this.cBSeasonTicketD);
            this.Controls.Add(this.cBGymID);
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
            this.Name = "EditSeasonTicketGymForm";
            this.Text = "Абонемент тренажерного зала";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBCost;
        private System.Windows.Forms.ComboBox cBSeasonTicketD;
        private System.Windows.Forms.ComboBox cBGymID;
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