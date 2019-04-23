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
    public partial class AnalyzeTestForm : Form
    {
        public AnalyzeTestForm()
        {
            InitializeComponent();
        }

        private void AnalyzeTestForm_Load(object sender, EventArgs e)
        {
            button1.Text = "Повернутьись";
            dataGridView1.RowCount = Global.random10Questions.Count;

            for (int i = 0; i < 10; ++i)
            {
                dataGridView1.Rows[i].Cells[0].Value = Global.random10Questions[i].question;
                if (Global.correctAnswers[i])
                    dataGridView1.Rows[i].Cells[1].Value = Properties.Resources.Okay;
                else
                    dataGridView1.Rows[i].Cells[1].Value = Properties.Resources.NotOkay;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }
    }
}
