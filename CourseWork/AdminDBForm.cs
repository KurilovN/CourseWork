using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class AdminDBForm : Form
    {
        public AdminDBForm()
        {
            InitializeComponent();
        }



        private void добавитьТренажерныйЗалToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateGymForm crtGmForm = new CreateGymForm();
            crtGmForm.ShowDialog();
        }

        private void просмотретьТаблицуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TableForm tblForm = new TableForm();
            tblForm.NameTable = тренажерныйЗалToolStripMenuItem.Text;
            tblForm.MdiParent = this;
            tblForm.Show();
        }

        private void просмотретьТаблицуToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TableForm tblForm = new TableForm();
            tblForm.NameTable = тренерToolStripMenuItem.Text;
            tblForm.MdiParent = this;
            tblForm.Show();
        }

        private void просмотретьТаблицуToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            TableForm tblForm = new TableForm();
            tblForm.NameTable = расписаниеДняРаботыToolStripMenuItem.Text;
            tblForm.MdiParent = this;
            tblForm.Show();
        }

        private void просмотретьТаблицуToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            TableForm tblForm = new TableForm();
            tblForm.NameTable = абонементToolStripMenuItem.Text;
            tblForm.MdiParent = this;
            tblForm.Show();
        }

        private void просмотретьТаблицуToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            TableForm tblForm = new TableForm();
            tblForm.NameTable = оборудованиеВТренажерномЗалеToolStripMenuItem.Text;
            tblForm.MdiParent = this;
            tblForm.Show();
        }

        private void посмотретьТаблицуToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TableForm tblForm = new TableForm();
            tblForm.NameTable = тренировкаToolStripMenuItem.Text;
            tblForm.MdiParent = this;
            tblForm.Show();
        }

        private void посмотертьТаблицуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TableForm tblForm = new TableForm();
            tblForm.NameTable = тренировкаВТренажерномЗалеToolStripMenuItem.Text;
            tblForm.MdiParent = this;
            tblForm.Show();
        }

        private void просмотретьТаблицуToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            TableForm tblForm = new TableForm();
            tblForm.NameTable = абонToolStripMenuItem.Text;
            tblForm.MdiParent = this;
            tblForm.Show();
        }

        private void посмотретьТаблицуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TableForm tblForm = new TableForm();
            tblForm.NameTable = категорииToolStripMenuItem.Text;
            tblForm.MdiParent = this;
            tblForm.Show();
        }

        private void просмотретьТаблицуToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            TableForm tblForm = new TableForm();
            tblForm.NameTable = назначениеОборудованияToolStripMenuItem.Text;
            tblForm.MdiParent = this;
            tblForm.Show();
        }

        private void просмотретьТаблицуToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            TableForm tblForm = new TableForm();
            tblForm.NameTable = оборудованиеToolStripMenuItem.Text;
            tblForm.MdiParent = this;
            tblForm.Show();
        }

        private void посмотретьТопToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TopGymsAdminForm topGymsAdminForm = new TopGymsAdminForm();
            topGymsAdminForm.ShowDialog();
        }

        private void категорииToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
