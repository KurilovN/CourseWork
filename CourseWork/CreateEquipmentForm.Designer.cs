namespace CourseWork
{
    partial class CreateEquipmentForm
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
            this.tBNameEquip = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cBIDFuncEquip = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ReturnBtn
            // 
            this.ReturnBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ReturnBtn.Location = new System.Drawing.Point(12, 108);
            this.ReturnBtn.Name = "ReturnBtn";
            this.ReturnBtn.Size = new System.Drawing.Size(112, 52);
            this.ReturnBtn.TabIndex = 23;
            this.ReturnBtn.Text = "Назад";
            this.ReturnBtn.UseVisualStyleBackColor = true;
            this.ReturnBtn.Click += new System.EventHandler(this.ReturnBtn_Click);
            // 
            // CreateBtn
            // 
            this.CreateBtn.Location = new System.Drawing.Point(202, 109);
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
            this.label2.Location = new System.Drawing.Point(9, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 34);
            this.label2.TabIndex = 14;
            this.label2.Text = "Назначение\r\nоборудования";
            // 
            // tBNameEquip
            // 
            this.tBNameEquip.Location = new System.Drawing.Point(169, 19);
            this.tBNameEquip.Name = "tBNameEquip";
            this.tBNameEquip.Size = new System.Drawing.Size(149, 22);
            this.tBNameEquip.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 34);
            this.label1.TabIndex = 12;
            this.label1.Text = "Наименование \r\nоборудования";
            // 
            // cBIDFuncEquip
            // 
            this.cBIDFuncEquip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBIDFuncEquip.FormattingEnabled = true;
            this.cBIDFuncEquip.Location = new System.Drawing.Point(169, 64);
            this.cBIDFuncEquip.Name = "cBIDFuncEquip";
            this.cBIDFuncEquip.Size = new System.Drawing.Size(149, 24);
            this.cBIDFuncEquip.TabIndex = 24;
            // 
            // CreateEquipmentForm
            // 
            this.AcceptButton = this.CreateBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ReturnBtn;
            this.ClientSize = new System.Drawing.Size(326, 172);
            this.Controls.Add(this.cBIDFuncEquip);
            this.Controls.Add(this.ReturnBtn);
            this.Controls.Add(this.CreateBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tBNameEquip);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateEquipmentForm";
            this.Text = "Оборудование";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ReturnBtn;
        private System.Windows.Forms.Button CreateBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBNameEquip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBIDFuncEquip;
    }
}