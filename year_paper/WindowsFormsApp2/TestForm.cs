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
                       
        const int SecondsCount = 120;

        public TestForm()
        {
            InitializeComponent();

            progressBar1.Maximum = SecondsCount;
            progressBar1.Minimum = 0; 
            timer1 = new Timer()
            {
                Interval = 1000
            };
            timer1.Tick += OnTickHandler;
            timer1.Enabled = true;
        }

        private void OnTickHandler(object sender, EventArgs e)
        {
            progressBar1.Value += 1;
            if (progressBar1.Value == SecondsCount)
            {
                timer1.Stop();
                progressBar1.Visible = false;
                richTextBox1.Visible = false;
                panel3.Visible = false;
                button4.Visible = false;
                button3.Visible = false;
                label2.Visible = true;
                label1.Visible = true;
                button1.Visible = true;
                button2.Visible = true;
                label1.Text = "Ваш результат " + Global.finalPoints.ToString() + " балів";
                Global.participants.Add(new TestParticipant(Global.activeParticipantName, Global.activeParticipantGroup, Global.finalPoints, DateTime.Now.ToString()));

                var json = JsonConvert.SerializeObject(Global.participants);
                File.WriteAllText(Global.pathToDefaultParticipantFile, json);
            }
        }

        Random rand = new Random();

        public void RefreshQuestion()
        {
            if (Global.currentQuestionIndex >= Global.random10Questions.Count)
            {
                progressBar1.Visible = false;
                richTextBox1.Visible = false;
                panel3.Visible = false;
                button4.Visible = false;
                button3.Visible = false;
                label1.Visible = true;
                button1.Visible = true;
                button2.Visible = true;
                label1.Text = Global.activeParticipantName.ToString() + ", Ваш результат " + Global.finalPoints.ToString() + " балів";
                Global.participants.Add(new TestParticipant(Global.activeParticipantName, Global.activeParticipantGroup, Global.finalPoints, DateTime.Now.ToString()));

                var json = JsonConvert.SerializeObject(Global.participants);
                File.WriteAllText(Global.pathToDefaultParticipantFile, json);
               
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
            label1.Visible = false;
            label2.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            label2.Text = "Час вийшов!";
            button1.Text = "На головну";
            button2.Text = "Детальніше";
            //button3.Text = "Завершити";
            //button4.Text = "Далі";
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
                Global.correctAnswers[Global.currentQuestionIndex] = true;
                if (Global.random10Questions[Global.currentQuestionIndex].correctAnswer == 1 && radioButton1.Checked) Global.finalPoints += 0.5;
                else if (Global.random10Questions[Global.currentQuestionIndex].correctAnswer == 2 && radioButton2.Checked) Global.finalPoints += 0.5;
                else if (Global.random10Questions[Global.currentQuestionIndex].correctAnswer == 3 && radioButton3.Checked) Global.finalPoints += 0.5;
                else if (Global.random10Questions[Global.currentQuestionIndex].correctAnswer == 4 && radioButton4.Checked) Global.finalPoints += 0.5;
                else
                {
                    Global.correctAnswers[Global.currentQuestionIndex] = false;
                }

                Global.currentQuestionIndex++;
                RefreshQuestion();
            }
            else
            {
                MessageBox.Show("Виберіть правильний варіант");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new AnalyzeTestForm().Show();
        }

         private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Visible = false;
            panel3.Visible = false;
            button4.Visible = false;
            button3.Visible = false;
            progressBar1.Visible = false;
            timer1.Stop();
            label1.Visible = true;
            button1.Visible = true;
            button2.Visible = true;
            label1.Text = "Ваш результат " + Global.finalPoints.ToString() + " балів";
            Global.participants.Add(new TestParticipant(Global.activeParticipantName, Global.activeParticipantGroup, Global.finalPoints, DateTime.Now.ToString()));

            var json = JsonConvert.SerializeObject(Global.participants);
            File.WriteAllText(Global.pathToDefaultParticipantFile, json);
        }
    }
}
