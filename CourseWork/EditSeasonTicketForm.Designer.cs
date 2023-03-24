namespace CourseWork
{
    partial class EditSeasonTicketForm
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
            this.cBTypeCredit = new System.Windows.Forms.ComboBox();
            this.tBCountCredit = new System.Windows.Forms.TextBox();
            this.ReturnBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.tBNameSeasonTicket = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cBTypeCredit
            // 
            this.cBTypeCredit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBTypeCredit.FormattingEnabled = true;
            this.cBTypeCredit.Items.AddRange(new object[] {
            "Год",
            "Месяц",
            "День"});
            this.cBTypeCredit.Location = new System.Drawing.Point(192, 102);
            this.cBTypeCredit.Name = "cBTypeCredit";
            this.cBTypeCredit.Size = new System.Drawing.Size(149, 24);
            this.cBTypeCredit.TabIndex = 43;
            // 
            // tBCountCredit
            // 
            this.tBCountCredit.Location = new System.Drawing.Point(192, 54);
            this.tBCountCredit.Name = "tBCountCredit";
            this.tBCountCredit.Size = new System.Drawing.Size(149, 22);
            this.tBCountCredit.TabIndex = 42;
            // 
            // ReturnBtn
            // 
            this.ReturnBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ReturnBtn.Location = new System.Drawing.Point(10, 147);
            this.ReturnBtn.Name = "ReturnBtn";
            this.ReturnBtn.Size = new System.Drawing.Size(112, 52);
            this.ReturnBtn.TabIndex = 41;
            this.ReturnBtn.Text = "Назад";
            this.ReturnBtn.UseVisualStyleBackColor = true;
            this.ReturnBtn.Click += new System.EventHandler(this.ReturnBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.Location = new System.Drawing.Point(222, 147);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(119, 52);
            this.EditBtn.TabIndex = 40;
            this.EditBtn.Text = "Редактировать";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // tBNameSeasonTicket
            // 
            this.tBNameSeasonTicket.Location = new System.Drawing.Point(192, 10);
            this.tBNameSeasonTicket.Name = "tBNameSeasonTicket";
            this.tBNameSeasonTicket.Size = new System.Drawing.Size(149, 22);
            this.tBNameSeasonTicket.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 17);
            this.label3.TabIndex = 38;
            this.label3.Text = "Тип условной единицы";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 17);
            this.label2.TabIndex = 37;
            this.label2.Text = "Длительность(в у. е.)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 36;
            this.label1.Text = "Наименование";
            // 
            // EditSeasonTicketForm
            // 
            this.AcceptButton = this.EditBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ReturnBtn;
            this.ClientSize = new System.Drawing.Size(349, 216);
            this.Controls.Add(this.cBTypeCredit);
            this.Controls.Add(this.tBCountCredit);
            this.Controls.Add(this.ReturnBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.tBNameSeasonTicket);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditSeasonTicketForm";
            this.Text = "Абонемент";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cBTypeCredit;
        private System.Windows.Forms.TextBox tBCountCredit;
        private System.Windows.Forms.Button ReturnBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.TextBox tBNameSeasonTicket;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}