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
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        Random rand = new Random();

        public void RefreshQuestion()
        {
            if (Global.currentQuestionIndex >= Global.random10Questions.Count)
            {
                ActiveForm.Visible = false;
                new AfterTestForm().Show();
            }
            else
            {
                radioButton1.Checked = radioButton2.Checked = radioButton3.Checked = radioButton4.Checked = false;
                richTextBox1.Text = Global.random10Questions[Global.currentQuestionIndex].question;
                radioButton1.Text = Global.random10Questions[Global.currentQuestionIndex].answer1;
                radioButton2.Text = Global.random10Questions[Global.currentQuestionIndex].answer2;
                radioButton3.Text = Global.random10Questions[Global.currentQuestionIndex].answer3;
                radioButton4.Text = Global.random10Questions[Global.currentQuestionIndex].answer4;
            }
        }

        private void TestForm_Load(object sender, EventArgs e)
        {
            Global.random10Questions = new List<TestQuestion>();
            for (int i = 0; i < 10; ++i)
            {
                int droppedIndex = rand.Next(0, Global.currentTestQuestions.Count);
                Global.random10Questions.Add(Global.currentTestQuestions[droppedIndex]);
                Global.currentTestQuestions.RemoveAt(droppedIndex);
            }

            Global.currentQuestionIndex = 0;

            radioButton1.Checked = radioButton2.Checked = radioButton3.Checked = radioButton4.Checked = false;
            richTextBox1.Text = Global.random10Questions[Global.currentQuestionIndex].question;
            radioButton1.Text = Global.random10Questions[Global.currentQuestionIndex].answer1;
            radioButton2.Text = Global.random10Questions[Global.currentQuestionIndex].answer2;
            radioButton3.Text = Global.random10Questions[Global.currentQuestionIndex].answer3;
            radioButton4.Text = Global.random10Questions[Global.currentQuestionIndex].answer4;
            

            button4.Text = "Далі";

            if (!File.Exists(Global.pathToDefaultParticipantFile))
            {
                Global.participants = new List<TestParticipant>();
            }
            else
            {
                string json = File.ReadAllText(Global.pathToDefaultParticipantFile);
                Global.participants = JsonConvert.DeserializeObject<List<TestParticipant>>(json);
                Console.WriteLine(json);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked || radioButton2.Checked || radioButton3.Checked || radioButton4.Checked)
            {
                if (Global.random10Questions[Global.currentQuestionIndex].correctAnswer == 1 && radioButton1.Checked) Global.finalPoints += 0.5;
                else if (Global.random10Questions[Global.currentQuestionIndex].correctAnswer == 2 && radioButton2.Checked) Global.finalPoints += 0.5;
                else if (Global.random10Questions[Global.currentQuestionIndex].correctAnswer == 3 && radioButton3.Checked) Global.finalPoints += 0.5;
                else if (Global.random10Questions[Global.currentQuestionIndex].correctAnswer == 4 && radioButton4.Checked) Global.finalPoints += 0.5;

                Global.currentQuestionIndex++;
                RefreshQuestion();
            }
            else
            {
                MessageBox.Show("Виберіть правильний варіант");
            }
        }

    }
}
