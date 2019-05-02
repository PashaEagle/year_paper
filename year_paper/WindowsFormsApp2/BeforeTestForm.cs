using Newtonsoft.Json;
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
    public partial class BeforeTestForm : Form
    {
        public BeforeTestForm()
        {
            InitializeComponent();
        }

        String pathToFile = "";

        private void BeforeTestForm_Load(object sender, EventArgs e)
        {
            label1.Text = "Введіть ПІБ: ";
            label2.Text = "Введіть групу: ";
            label3.Text = "Файл з питаннями не вибрано";
            label3.ForeColor = Color.Red;
            button1.Text = "Вибрати файл";
            button3.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Вибір файлу з питаннями";
            dialog.FileName = "";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Global.currentTestFilePath = dialog.FileName;
                try
                {
                    string json = File.ReadAllText(Global.currentTestFilePath);
                    Global.currentTestQuestions = JsonConvert.DeserializeObject<List<TestQuestion>>(json);

                    if (Global.currentTestQuestions.Count < 10)
                    {
                        MessageBox.Show("В цьому файлі менше 10 питань, виберіть інший");
                        return;
                    }
                }
                catch(Exception ee)
                {
                    MessageBox.Show("Помилка при завантаженні. Можливо файл пошкоджено");
                    return;
                }

                label3.Text = Global.currentTestFilePath;
                label3.ForeColor = Color.Green;
                button3.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0 && textBox2.Text.Length > 0)
            {
                Global.activeParticipantName = textBox1.Text;
                Global.activeParticipantGroup = textBox2.Text;
                Global.correctAnswers = new bool[10];

                ActiveForm.Visible = false;

                new TestForm().Show();
            }
            else
            {
                MessageBox.Show("Заповніть всі поля");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
