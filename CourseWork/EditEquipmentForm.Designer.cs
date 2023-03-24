namespace CourseWork
{
    partial class EditEquipmentForm
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
            this.cBIDFuncEquip = new System.Windows.Forms.ComboBox();
            this.ReturnBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tBNameEquip = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cBIDFuncEquip
            // 
            this.cBIDFuncEquip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBIDFuncEquip.FormattingEnabled = true;
            this.cBIDFuncEquip.Location = new System.Drawing.Point(168, 63);
            this.cBIDFuncEquip.Name = "cBIDFuncEquip";
            this.cBIDFuncEquip.Size = new System.Drawing.Size(149, 24);
            this.cBIDFuncEquip.TabIndex = 30;
            // 
            // ReturnBtn
            // 
            this.ReturnBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ReturnBtn.Location = new System.Drawing.Point(11, 108);
            this.ReturnBtn.Name = "ReturnBtn";
            this.ReturnBtn.Size = new System.Drawing.Size(112, 52);
            this.ReturnBtn.TabIndex = 29;
            this.ReturnBtn.Text = "Назад";
            this.ReturnBtn.UseVisualStyleBackColor = true;
            this.ReturnBtn.Click += new System.EventHandler(this.ReturnBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.Location = new System.Drawing.Point(184, 108);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(133, 52);
            this.EditBtn.TabIndex = 28;
            this.EditBtn.Text = "Редактировать";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 34);
            this.label2.TabIndex = 27;
            this.label2.Text = "Назначение\r\nоборудования";
            // 
            // tBNameEquip
            // 
            this.tBNameEquip.Location = new System.Drawing.Point(168, 18);
            this.tBNameEquip.Name = "tBNameEquip";
            this.tBNameEquip.Size = new System.Drawing.Size(149, 22);
            this.tBNameEquip.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 34);
            this.label1.TabIndex = 25;
            this.label1.Text = "Наименование \r\nоборудования";
            // 
            // EditEquipmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 174);
            this.Controls.Add(this.cBIDFuncEquip);
            this.Controls.Add(this.ReturnBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tBNameEquip);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditEquipmentForm";
            this.Text = "Оборудование";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cBIDFuncEquip;
        private System.Windows.Forms.Button ReturnBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBNameEquip;
        private System.Windows.Forms.Label label1;
    }
}