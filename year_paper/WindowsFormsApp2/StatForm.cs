using System;
using Newtonsoft.Json;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;
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
            dataGridView1.RowCount = Global.experiments.Count;
            int i = 0;
            foreach(Experiment exp in Global.experiments)
            {
                dataGridView1.Rows[i].Cells[0].Value = (i + 1);
                dataGridView1.Rows[i].Cells[1].Value = exp.experimentType;

                Image temp;
                switch (exp.result)
                {
                    case "Gerb":
                        temp = Global.coinPictures[0];
                        break;

                    case "Reshka":
                        temp = Global.coinPictures[1];
                        break;

                    case "1":
                        temp = Global.dicePictures[0];
                        break;

                    case "2":
                        temp = Global.dicePictures[1];
                        break;

                    case "3":
                        temp = Global.dicePictures[2];
                        break;

                    case "4":
                        temp = Global.dicePictures[3];
                        break;

                    case "5":
                        temp = Global.dicePictures[4];
                        break;

                    default:
                        temp = Global.dicePictures[5];
                        break;
                }
                dataGridView1.Rows[i].Cells[2].Value = temp;
                dataGridView1.Rows[i++].Cells[3].Value = exp.date;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

            private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (File.Exists(Global.pathToDefaultStatisticFile)) File.Delete(Global.pathToDefaultStatisticFile);
            Global.experiments = new List<Experiment>();
            MessageBox.Show("Статистика очищена", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGridView1.RowCount = 0;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "JSON|*.JSON";
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            if (openFileDialog1.FileName == null) return;

            Global.pathToDefaultStatisticFile = openFileDialog1.FileName;

            try
            {
               DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(List<Experiment>));

                using (FileStream fs = new FileStream(Global.pathToDefaultStatisticFile, FileMode.OpenOrCreate))
                {
                   Global.experiments = (List<Experiment>)jsonFormatter.ReadObject(fs);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Неможливо завнтажити, превірте формат", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Завантажено", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);


            if (Global.experiments.Count == 0)
            {
                return;
            }

            dataGridView1.Rows.Clear();
            int i = 0;
            foreach (Experiment exp in Global.experiments)
            {
                //dataGridView1.Rows[i].Cells[0].Value = (i + 1);
                dataGridView1.Rows[i].Cells[1].Value = exp.experimentType;

                Image temp;
                switch (exp.result)
                {
                    case "Gerb":
                        temp = Global.coinPictures[0];
                        break;

                    case "Reshka":
                        temp = Global.coinPictures[1];
                        break;

                    case "1":
                        temp = Global.dicePictures[0];
                        break;

                    case "2":
                        temp = Global.dicePictures[1];
                        break;

                    case "3":
                        temp = Global.dicePictures[2];
                        break;

                    case "4":
                        temp = Global.dicePictures[3];
                        break;

                    case "5":
                        temp = Global.dicePictures[4];
                        break;

                    default:
                        temp = Global.dicePictures[5];
                        break;
                }
                dataGridView1.Rows[i].Cells[2].Value = temp;
                dataGridView1.Rows[i++].Cells[3].Value = exp.date;
            }

        }

        private void зберегтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Global.pathToDefaultStatisticFile.Equals("null"))
            {
                MessageBox.Show("Неможливо зберегти", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (File.Exists(Global.pathToDefaultStatisticFile)) File.Delete(Global.pathToDefaultStatisticFile);
            try
            {
                DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(List<Experiment>));

                using (FileStream fs = new FileStream(Global.pathToDefaultStatisticFile, FileMode.OpenOrCreate))
                {
                    jsonFormatter.WriteObject(fs, Global.experiments);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Неможливо зберегти", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Збережено", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void зберегтиЯкToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Global.experiments.Count == 0)
            {
                MessageBox.Show("Ви ще не проводили експерименти!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                saveFileDialog1.Filter = "JSON|*.JSON";
                if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                    return;

                Global.pathToDefaultStatisticFile = saveFileDialog1.FileName;
                if (File.Exists(Global.pathToDefaultStatisticFile)) File.Delete(Global.pathToDefaultStatisticFile);
                try
                {
                    DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(List<Experiment>));

                    using (FileStream fs = new FileStream(Global.pathToDefaultStatisticFile, FileMode.OpenOrCreate))
                    {
                        jsonFormatter.WriteObject(fs, Global.experiments);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Неможливо зберегти в файл", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show("Збережено", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

    }
}

