﻿using System;
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
    public partial class StatForm : Form
    {
        public StatForm()
        {
            InitializeComponent();
        }

        private void StatForm_Load(object sender, EventArgs e)
        {
            label1.Text = "Статистика підкидань";
            button1.Text = "Зберегти у файл";
            button2.Text = "Завантажити з файлу";
            button3.Text = "Очистити";

            dataGridView1.RowCount = Global.experiments.Count;
            int i = 0;
            foreach(Experiment exp in Global.experiments)
            {
                dataGridView1.Rows[i].Cells[0].Value = (i + 1);
                dataGridView1.Rows[i].Cells[1].Value = exp.experimentType;
                dataGridView1.Rows[i].Cells[2].Value = exp.result;
                dataGridView1.Rows[i++].Cells[3].Value = exp.date;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (File.Exists(Global.pathToDefaultStatsFile)) File.Delete(Global.pathToDefaultStatsFile);
            Global.experiments = new List<Experiment>();
            MessageBox.Show("All stats were deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGridView1.RowCount = 0;
        }
    }
}