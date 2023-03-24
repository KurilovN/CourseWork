namespace CourseWork
{
    partial class CreateTrainForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.tBNameTrain = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cBTypeTrain = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ReturnBtn
            // 
            this.ReturnBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ReturnBtn.Location = new System.Drawing.Point(14, 109);
            this.ReturnBtn.Name = "ReturnBtn";
            this.ReturnBtn.Size = new System.Drawing.Size(112, 52);
            this.ReturnBtn.TabIndex = 23;
            this.ReturnBtn.Text = "Назад";
            this.ReturnBtn.UseVisualStyleBackColor = true;
            this.ReturnBtn.Click += new System.EventHandler(this.ReturnBtn_Click);
            // 
            // CreateBtn
            // 
            this.CreateBtn.Location = new System.Drawing.Point(204, 109);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(116, 52);
            this.CreateBtn.TabIndex = 22;
            this.CreateBtn.Text = "Добавить";
            this.CreateBtn.UseVisualStyleBackColor = true;
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Вид тренировки";
            // 
            // tBNameTrain
            // 
            this.tBNameTrain.Location = new System.Drawing.Point(171, 20);
            this.tBNameTrain.Name = "tBNameTrain";
            this.tBNameTrain.Size = new System.Drawing.Size(149, 22);
            this.tBNameTrain.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 34);
            this.label1.TabIndex = 12;
            this.label1.Text = "Наименование \r\nтренировки";
            // 
            // cBTypeTrain
            // 
            this.cBTypeTrain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBTypeTrain.FormattingEnabled = true;
            this.cBTypeTrain.Items.AddRange(new object[] {
            "Одиночная",
            "Групповая"});
            this.cBTypeTrain.Location = new System.Drawing.Point(171, 64);
            this.cBTypeTrain.Name = "cBTypeTrain";
            this.cBTypeTrain.Size = new System.Drawing.Size(149, 24);
            this.cBTypeTrain.TabIndex = 24;
            // 
            // CreateTrainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 170);
            this.Controls.Add(this.cBTypeTrain);
            this.Controls.Add(this.ReturnBtn);
            this.Controls.Add(this.CreateBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tBNameTrain);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateTrainForm";
            this.Text = "Тренировка";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ReturnBtn;
        private System.Windows.Forms.Button CreateBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBNameTrain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBTypeTrain;
    }
}