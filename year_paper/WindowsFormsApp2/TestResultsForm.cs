using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

         private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (File.Exists(Global.pathToDefaultParticipantFile)) File.Delete(Global.pathToDefaultParticipantFile);
            Global.participants = new List<TestParticipant>();
            MessageBox.Show("Всі результати видалено", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGridView1.RowCount = 0;
        }
    }
}
