namespace CourseWork
{
    partial class UserForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.bBack = new System.Windows.Forms.Button();
            this.bContinue = new System.Windows.Forms.Button();
            this.bReg = new System.Windows.Forms.Button();
            this.bLogIn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tBPassword = new System.Windows.Forms.TextBox();
            this.tBLogin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Khaki;
            this.panel1.Controls.Add(this.bBack);
            this.panel1.Controls.Add(this.bContinue);
            this.panel1.Controls.Add(this.bReg);
            this.panel1.Controls.Add(this.bLogIn);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tBPassword);
            this.panel1.Controls.Add(this.tBLogin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 98);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(528, 342);
            this.panel1.TabIndex = 7;
            // 
            // bBack
            // 
            this.bBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bBack.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bBack.Location = new System.Drawing.Point(32, 146);
            this.bBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bBack.Name = "bBack";
            this.bBack.Size = new System.Drawing.Size(212, 80);
            this.bBack.TabIndex = 7;
            this.bBack.Text = "Назад";
            this.bBack.UseVisualStyleBackColor = true;
            this.bBack.Click += new System.EventHandler(this.bBack_Click);
            // 
            // bContinue
            // 
            this.bContinue.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bContinue.Location = new System.Drawing.Point(345, 43);
            this.bContinue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bContinue.Name = "bContinue";
            this.bContinue.Size = new System.Drawing.Size(150, 88);
            this.bContinue.TabIndex = 6;
            this.bContinue.Text = "Продолжить без входа";
            this.bContinue.UseVisualStyleBackColor = true;
            this.bContinue.Click += new System.EventHandler(this.bContinue_Click);
            // 
            // bReg
            // 
            this.bReg.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bReg.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bReg.Location = new System.Drawing.Point(32, 245);
            this.bReg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bReg.Name = "bReg";
            this.bReg.Size = new System.Drawing.Size(463, 80);
            this.bReg.TabIndex = 5;
            this.bReg.Text = "Зарегистрироваться";
            this.bReg.UseVisualStyleBackColor = true;
            this.bReg.Click += new System.EventHandler(this.bReg_Click);
            // 
            // bLogIn
            // 
            this.bLogIn.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bLogIn.Location = new System.Drawing.Point(283, 146);
            this.bLogIn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bLogIn.Name = "bLogIn";
            this.bLogIn.Size = new System.Drawing.Size(212, 80);
            this.bLogIn.TabIndex = 4;
            this.bLogIn.Text = "Войти";
            this.bLogIn.UseVisualStyleBackColor = true;
            this.bLogIn.Click += new System.EventHandler(this.bLogIn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(28, 99);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "Пароль";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(28, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Логин";
            // 
            // tBPassword
            // 
            this.tBPassword.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBPassword.Location = new System.Drawing.Point(135, 93);
            this.tBPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tBPassword.Name = "tBPassword";
            this.tBPassword.PasswordChar = '*';
            this.tBPassword.Size = new System.Drawing.Size(194, 35);
            this.tBPassword.TabIndex = 1;
            this.tBPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBPassword_KeyPress);
            // 
            // tBLogin
            // 
            this.tBLogin.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBLogin.Location = new System.Drawing.Point(135, 43);
            this.tBLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tBLogin.Name = "tBLogin";
            this.tBLogin.Size = new System.Drawing.Size(194, 35);
            this.tBLogin.TabIndex = 0;
            this.tBLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBLogin_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 40);
            this.label1.TabIndex = 6;
            this.label1.Text = "Окно пользователя";
            // 
            // UserForm
            // 
            this.AcceptButton = this.bLogIn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bBack;
            this.ClientSize = new System.Drawing.Size(528, 440);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bContinue;
        private System.Windows.Forms.Button bReg;
        private System.Windows.Forms.Button bLogIn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBPassword;
        private System.Windows.Forms.TextBox tBLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bBack;
    }
}