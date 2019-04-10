using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class TestResultsForm : Form
    {
        public TestResultsForm()
        {
            InitializeComponent();
        }

        private void TestResultsForm_Load(object sender, EventArgs e)
        {
            button1.Text = "Назад";
            dataGridView1.RowCount = Global.participants.Count;
            int i = 0;
            foreach (TestParticipant par in Global.participants)
            {
                dataGridView1.Rows[i].Cells[0].Value = par.name;
                dataGridView1.Rows[i].Cells[1].Value = par.group;
                dataGridView1.Rows[i].Cells[2].Value = par.result;
                dataGridView1.Rows[i++].Cells[3].Value = par.date;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }
    }
}
