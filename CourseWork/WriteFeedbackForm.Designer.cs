namespace CourseWork
{
    partial class WriteFeedbackForm
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
            this.richTBFeedback = new System.Windows.Forms.RichTextBox();
            this.cBGradeGym = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BackBtn = new System.Windows.Forms.Button();
            this.SendBtn = new System.Windows.Forms.Button();
            this.cBNameGym = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTBFeedback
            // 
            this.richTBFeedback.Location = new System.Drawing.Point(15, 134);
            this.richTBFeedback.Name = "richTBFeedback";
            this.richTBFeedback.Size = new System.Drawing.Size(411, 242);
            this.richTBFeedback.TabIndex = 0;
            this.richTBFeedback.Text = "";
            // 
            // cBGradeGym
            // 
            this.cBGradeGym.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBGradeGym.FormattingEnabled = true;
            this.cBGradeGym.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cBGradeGym.Location = new System.Drawing.Point(363, 58);
            this.cBGradeGym.Name = "cBGradeGym";
            this.cBGradeGym.Size = new System.Drawing.Size(63, 24);
            this.cBGradeGym.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Оценка тренажерного зала по 10 бальной шкале";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Текст отзыва(может отсутствовать):";
            // 
            // BackBtn
            // 
            this.BackBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BackBtn.Location = new System.Drawing.Point(15, 395);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(164, 52);
            this.BackBtn.TabIndex = 4;
            this.BackBtn.Text = "Назад";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // SendBtn
            // 
            this.SendBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.SendBtn.Location = new System.Drawing.Point(273, 395);
            this.SendBtn.Name = "SendBtn";
            this.SendBtn.Size = new System.Drawing.Size(153, 52);
            this.SendBtn.TabIndex = 5;
            this.SendBtn.Text = "Отправить отзыв";
            this.SendBtn.UseVisualStyleBackColor = true;
            this.SendBtn.Click += new System.EventHandler(this.SendBtn_Click);
            // 
            // cBNameGym
            // 
            this.cBNameGym.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBNameGym.FormattingEnabled = true;
            this.cBNameGym.Location = new System.Drawing.Point(184, 25);
            this.cBNameGym.Name = "cBNameGym";
            this.cBNameGym.Size = new System.Drawing.Size(242, 24);
            this.cBNameGym.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Тренажерный зал";
            // 
            // WriteFeedbackForm
            // 
            this.AcceptButton = this.SendBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BackBtn;
            this.ClientSize = new System.Drawing.Size(442, 463);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cBNameGym);
            this.Controls.Add(this.SendBtn);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cBGradeGym);
            this.Controls.Add(this.richTBFeedback);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WriteFeedbackForm";
            this.Text = "Отзыв о тренажерном зале";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTBFeedback;
        private System.Windows.Forms.ComboBox cBGradeGym;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button SendBtn;
        private System.Windows.Forms.ComboBox cBNameGym;
        private System.Windows.Forms.Label label3;
    }
}