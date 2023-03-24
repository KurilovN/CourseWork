namespace CourseWork
{
    partial class ChangeInformationUserForm
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
            this.tBLoginClient = new System.Windows.Forms.TextBox();
            this.tBNameClient = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tBNewPassw = new System.Windows.Forms.TextBox();
            this.tBCurrentPassw = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tBRetryPassw = new System.Windows.Forms.TextBox();
            this.BackBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tBLoginClient
            // 
            this.tBLoginClient.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBLoginClient.Location = new System.Drawing.Point(335, 76);
            this.tBLoginClient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tBLoginClient.Name = "tBLoginClient";
            this.tBLoginClient.Size = new System.Drawing.Size(297, 34);
            this.tBLoginClient.TabIndex = 10;
            this.tBLoginClient.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBLoginClient_KeyPress);
            // 
            // tBNameClient
            // 
            this.tBNameClient.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBNameClient.Location = new System.Drawing.Point(335, 14);
            this.tBNameClient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tBNameClient.Name = "tBNameClient";
            this.tBNameClient.Size = new System.Drawing.Size(297, 34);
            this.tBNameClient.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(9, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 27);
            this.label3.TabIndex = 8;
            this.label3.Text = "Логин:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(9, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 27);
            this.label2.TabIndex = 7;
            this.label2.Text = "ФИО:";
            // 
            // tBNewPassw
            // 
            this.tBNewPassw.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBNewPassw.Location = new System.Drawing.Point(335, 201);
            this.tBNewPassw.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tBNewPassw.Name = "tBNewPassw";
            this.tBNewPassw.PasswordChar = '*';
            this.tBNewPassw.Size = new System.Drawing.Size(297, 34);
            this.tBNewPassw.TabIndex = 14;
            this.tBNewPassw.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBNewPassw_KeyPress);
            // 
            // tBCurrentPassw
            // 
            this.tBCurrentPassw.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBCurrentPassw.Location = new System.Drawing.Point(335, 138);
            this.tBCurrentPassw.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tBCurrentPassw.Name = "tBCurrentPassw";
            this.tBCurrentPassw.PasswordChar = '*';
            this.tBCurrentPassw.Size = new System.Drawing.Size(297, 34);
            this.tBCurrentPassw.TabIndex = 13;
            this.tBCurrentPassw.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBCurrentPassw_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 27);
            this.label1.TabIndex = 12;
            this.label1.Text = "Новый пароль:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(9, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 27);
            this.label4.TabIndex = 11;
            this.label4.Text = "Текущий пароль:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(9, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(273, 27);
            this.label5.TabIndex = 15;
            this.label5.Text = "Повторите новый пароль:";
            // 
            // tBRetryPassw
            // 
            this.tBRetryPassw.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBRetryPassw.Location = new System.Drawing.Point(335, 265);
            this.tBRetryPassw.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tBRetryPassw.Name = "tBRetryPassw";
            this.tBRetryPassw.PasswordChar = '*';
            this.tBRetryPassw.Size = new System.Drawing.Size(297, 34);
            this.tBRetryPassw.TabIndex = 16;
            this.tBRetryPassw.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBRetryPassw_KeyPress);
            // 
            // BackBtn
            // 
            this.BackBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackBtn.Location = new System.Drawing.Point(15, 331);
            this.BackBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(197, 71);
            this.BackBtn.TabIndex = 17;
            this.BackBtn.Text = "Назад";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditBtn.Location = new System.Drawing.Point(436, 331);
            this.EditBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(197, 71);
            this.EditBtn.TabIndex = 18;
            this.EditBtn.Text = "Принять \r\nизменения";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // ChangeInformationUserForm
            // 
            this.AcceptButton = this.EditBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BackBtn;
            this.ClientSize = new System.Drawing.Size(651, 417);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.tBRetryPassw);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tBNewPassw);
            this.Controls.Add(this.tBCurrentPassw);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tBLoginClient);
            this.Controls.Add(this.tBNameClient);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangeInformationUserForm";
            this.Text = "Редактирование информации";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBLoginClient;
        private System.Windows.Forms.TextBox tBNameClient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBNewPassw;
        private System.Windows.Forms.TextBox tBCurrentPassw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tBRetryPassw;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button EditBtn;
    }
}