namespace CourseWork
{
    partial class TopGymsUserForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BackBtn = new System.Windows.Forms.Button();
            this.cBChoiceOfCity = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.InsertFilterBtn = new System.Windows.Forms.Button();
            this.ClearFilterBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridView1.Location = new System.Drawing.Point(297, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(776, 456);
            this.dataGridView1.TabIndex = 0;
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(164, 130);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(108, 49);
            this.BackBtn.TabIndex = 1;
            this.BackBtn.Text = "Назад";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // cBChoiceOfCity
            // 
            this.cBChoiceOfCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBChoiceOfCity.FormattingEnabled = true;
            this.cBChoiceOfCity.Location = new System.Drawing.Point(127, 22);
            this.cBChoiceOfCity.Name = "cBChoiceOfCity";
            this.cBChoiceOfCity.Size = new System.Drawing.Size(145, 24);
            this.cBChoiceOfCity.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Выбор города";
            // 
            // InsertFilterBtn
            // 
            this.InsertFilterBtn.Location = new System.Drawing.Point(164, 64);
            this.InsertFilterBtn.Name = "InsertFilterBtn";
            this.InsertFilterBtn.Size = new System.Drawing.Size(108, 49);
            this.InsertFilterBtn.TabIndex = 4;
            this.InsertFilterBtn.Text = "Применить фильтр";
            this.InsertFilterBtn.UseVisualStyleBackColor = true;
            this.InsertFilterBtn.Click += new System.EventHandler(this.InsertFilterBtn_Click);
            // 
            // ClearFilterBtn
            // 
            this.ClearFilterBtn.Location = new System.Drawing.Point(24, 64);
            this.ClearFilterBtn.Name = "ClearFilterBtn";
            this.ClearFilterBtn.Size = new System.Drawing.Size(108, 49);
            this.ClearFilterBtn.TabIndex = 5;
            this.ClearFilterBtn.Text = "Очистить фильтр";
            this.ClearFilterBtn.UseVisualStyleBackColor = true;
            this.ClearFilterBtn.Click += new System.EventHandler(this.ClearFilterBtn_Click);
            // 
            // TopGymsUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1073, 456);
            this.Controls.Add(this.ClearFilterBtn);
            this.Controls.Add(this.InsertFilterBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cBChoiceOfCity);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "TopGymsUserForm";
            this.Text = "Список самых популярных залов";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.ComboBox cBChoiceOfCity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button InsertFilterBtn;
        private System.Windows.Forms.Button ClearFilterBtn;
    }
}