using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nkman_todo_dbDataSet.check_assignment_of_works' table. You can move, or remove it, as needed.
            this.check_assignment_of_worksTableAdapter.Fill(this.nkman_todo_dbDataSet.check_assignment_of_works);
            // TODO: This line of code loads data into the 'toDoListDataSet.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.toDoListDataSet.Table);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            Form2 newf2 = new Form2();
            newf2.ShowDialog();
        }
    }
}
