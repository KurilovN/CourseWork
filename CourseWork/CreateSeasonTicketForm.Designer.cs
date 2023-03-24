namespace CourseWork
{
    partial class CreateSeasonTicketForm
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
            this.tBNameSeasonTicket = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tBCountCredit = new System.Windows.Forms.TextBox();
            this.cBTypeCredit = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ReturnBtn
            // 
            this.ReturnBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ReturnBtn.Location = new System.Drawing.Point(12, 156);
            this.ReturnBtn.Name = "ReturnBtn";
            this.ReturnBtn.Size = new System.Drawing.Size(112, 52);
            this.ReturnBtn.TabIndex = 33;
            this.ReturnBtn.Text = "Назад";
            this.ReturnBtn.UseVisualStyleBackColor = true;
            this.ReturnBtn.Click += new System.EventHandler(this.ReturnBtn_Click);
            // 
            // CreateBtn
            // 
            this.CreateBtn.Location = new System.Drawing.Point(227, 156);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(116, 52);
            this.CreateBtn.TabIndex = 32;
            this.CreateBtn.Text = "Добавить";
            this.CreateBtn.UseVisualStyleBackColor = true;
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // tBNameSeasonTicket
            // 
            this.tBNameSeasonTicket.Location = new System.Drawing.Point(194, 19);
            this.tBNameSeasonTicket.Name = "tBNameSeasonTicket";
            this.tBNameSeasonTicket.Size = new System.Drawing.Size(149, 22);
            this.tBNameSeasonTicket.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 17);
            this.label3.TabIndex = 28;
            this.label3.Text = "Тип условной единицы";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "Длительность(в у. е.)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "Наименование";
            // 
            // tBCountCredit
            // 
            this.tBCountCredit.Location = new System.Drawing.Point(194, 63);
            this.tBCountCredit.Name = "tBCountCredit";
            this.tBCountCredit.Size = new System.Drawing.Size(149, 22);
            this.tBCountCredit.TabIndex = 34;
            // 
            // cBTypeCredit
            // 
            this.cBTypeCredit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBTypeCredit.FormattingEnabled = true;
            this.cBTypeCredit.Items.AddRange(new object[] {
            "Год",
            "Месяц",
            "День"});
            this.cBTypeCredit.Location = new System.Drawing.Point(194, 111);
            this.cBTypeCredit.Name = "cBTypeCredit";
            this.cBTypeCredit.Size = new System.Drawing.Size(149, 24);
            this.cBTypeCredit.TabIndex = 35;
            // 
            // CreateSeasonTicketForm
            // 
            this.AcceptButton = this.CreateBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ReturnBtn;
            this.ClientSize = new System.Drawing.Size(356, 213);
            this.Controls.Add(this.cBTypeCredit);
            this.Controls.Add(this.tBCountCredit);
            this.Controls.Add(this.ReturnBtn);
            this.Controls.Add(this.CreateBtn);
            this.Controls.Add(this.tBNameSeasonTicket);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateSeasonTicketForm";
            this.Text = "Абонемент";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ReturnBtn;
        private System.Windows.Forms.Button CreateBtn;
        private System.Windows.Forms.TextBox tBNameSeasonTicket;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBCountCredit;
        private System.Windows.Forms.ComboBox cBTypeCredit;
    }
}