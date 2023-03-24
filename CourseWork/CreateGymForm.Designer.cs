namespace CourseWork
{
    partial class CreateGymForm
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
            this.tBNameGym = new System.Windows.Forms.TextBox();
            this.tBAddressGym = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tBPhoneGym = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tBCityGym = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tBWebGym = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CreateBtn = new System.Windows.Forms.Button();
            this.ReturnBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Наименование \r\nтренажерного зала";
            // 
            // tBNameGym
            // 
            this.tBNameGym.Location = new System.Drawing.Point(167, 17);
            this.tBNameGym.Name = "tBNameGym";
            this.tBNameGym.Size = new System.Drawing.Size(149, 22);
            this.tBNameGym.TabIndex = 1;
            // 
            // tBAddressGym
            // 
            this.tBAddressGym.Location = new System.Drawing.Point(167, 64);
            this.tBAddressGym.Name = "tBAddressGym";
            this.tBAddressGym.Size = new System.Drawing.Size(149, 22);
            this.tBAddressGym.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Адрес";
            // 
            // tBPhoneGym
            // 
            this.tBPhoneGym.Location = new System.Drawing.Point(167, 109);
            this.tBPhoneGym.Name = "tBPhoneGym";
            this.tBPhoneGym.Size = new System.Drawing.Size(149, 22);
            this.tBPhoneGym.TabIndex = 5;
            this.tBPhoneGym.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBPhoneGym_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Телефон(null)";
            // 
            // tBCityGym
            // 
            this.tBCityGym.Location = new System.Drawing.Point(167, 155);
            this.tBCityGym.Name = "tBCityGym";
            this.tBCityGym.Size = new System.Drawing.Size(149, 22);
            this.tBCityGym.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Город";
            // 
            // tBWebGym
            // 
            this.tBWebGym.Location = new System.Drawing.Point(167, 199);
            this.tBWebGym.Name = "tBWebGym";
            this.tBWebGym.Size = new System.Drawing.Size(149, 22);
            this.tBWebGym.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Сайт(null)";
            // 
            // CreateBtn
            // 
            this.CreateBtn.Location = new System.Drawing.Point(200, 240);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(116, 52);
            this.CreateBtn.TabIndex = 10;
            this.CreateBtn.Text = "Добавить";
            this.CreateBtn.UseVisualStyleBackColor = true;
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // ReturnBtn
            // 
            this.ReturnBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ReturnBtn.Location = new System.Drawing.Point(10, 240);
            this.ReturnBtn.Name = "ReturnBtn";
            this.ReturnBtn.Size = new System.Drawing.Size(112, 52);
            this.ReturnBtn.TabIndex = 11;
            this.ReturnBtn.Text = "Назад";
            this.ReturnBtn.UseVisualStyleBackColor = true;
            this.ReturnBtn.Click += new System.EventHandler(this.ReturnBtn_Click);
            // 
            // CreateGymForm
            // 
            this.AcceptButton = this.CreateBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ReturnBtn;
            this.ClientSize = new System.Drawing.Size(336, 302);
            this.Controls.Add(this.ReturnBtn);
            this.Controls.Add(this.CreateBtn);
            this.Controls.Add(this.tBWebGym);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tBCityGym);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tBPhoneGym);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tBAddressGym);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tBNameGym);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateGymForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавление зала";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBNameGym;
        private System.Windows.Forms.TextBox tBAddressGym;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBPhoneGym;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBCityGym;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tBWebGym;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button CreateBtn;
        private System.Windows.Forms.Button ReturnBtn;
    }
}