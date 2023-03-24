namespace CourseWork
{
    partial class EditTrainForm
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
            this.cBTypeTrain = new System.Windows.Forms.ComboBox();
            this.ReturnBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tBNameTrain = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cBTypeTrain
            // 
            this.cBTypeTrain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBTypeTrain.FormattingEnabled = true;
            this.cBTypeTrain.Items.AddRange(new object[] {
            "Одиночная",
            "Групповая"});
            this.cBTypeTrain.Location = new System.Drawing.Point(167, 62);
            this.cBTypeTrain.Name = "cBTypeTrain";
            this.cBTypeTrain.Size = new System.Drawing.Size(149, 24);
            this.cBTypeTrain.TabIndex = 30;
            // 
            // ReturnBtn
            // 
            this.ReturnBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ReturnBtn.Location = new System.Drawing.Point(10, 107);
            this.ReturnBtn.Name = "ReturnBtn";
            this.ReturnBtn.Size = new System.Drawing.Size(112, 52);
            this.ReturnBtn.TabIndex = 29;
            this.ReturnBtn.Text = "Назад";
            this.ReturnBtn.UseVisualStyleBackColor = true;
            // 
            // EditBtn
            // 
            this.EditBtn.Location = new System.Drawing.Point(200, 107);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(116, 52);
            this.EditBtn.TabIndex = 28;
            this.EditBtn.Text = "Редактировать";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "Вид тренировки";
            // 
            // tBNameTrain
            // 
            this.tBNameTrain.Location = new System.Drawing.Point(167, 18);
            this.tBNameTrain.Name = "tBNameTrain";
            this.tBNameTrain.Size = new System.Drawing.Size(149, 22);
            this.tBNameTrain.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 34);
            this.label1.TabIndex = 25;
            this.label1.Text = "Наименование \r\nтренировки";
            // 
            // EditTrainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 177);
            this.Controls.Add(this.cBTypeTrain);
            this.Controls.Add(this.ReturnBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tBNameTrain);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditTrainForm";
            this.Text = "Тренировка";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cBTypeTrain;
        private System.Windows.Forms.Button ReturnBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBNameTrain;
        private System.Windows.Forms.Label label1;
    }
}