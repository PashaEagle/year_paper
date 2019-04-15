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

        List<TestQuestion> questions;
        int currentQuestion = 0;
        double result = 0;

        private void TestForm_Load(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            panel4.Visible = false;
            label1.Text = "Введіть ПІБ: ";
            label2.Text = "Введіть групу: ";
            label3.Text = "null";
            button1.Text = "Розпочати тестування";
            button2.Text = "Подивитись результати";
            button3.Text = "Повернутись на головну";
            button4.Text = "Далі";
            button5.Text = "Подивитись результати";
            questions = new List<TestQuestion>();
            questions.Add(new TestQuestion("1. Маринка кідкинула гральний кубик, який має 6 граней, на кожній з яких цифра від 1 до 6. Яка ймовірність того, що число, яке випаде, буде парним?", "0.4", "0.3", "0.5", "0.6", 3));
            questions.Add(new TestQuestion("2. В пакетику знаходиться насіння моркви, огірків та помідор. Моркви — 72 насінини, огірків — 45, помідор — 83. Яка ймовірність того, що з навмання посадженої насінини виросте морква?", "0.36", "0.48", "0.72", "0.81", 1));
            questions.Add(new TestQuestion("3. З повного набору доміно беруть два каменя. Яка ймовірність того, що другий камінь доміно не можна приставити до першого?", "7/18", "11/18", "0.5", "0.1", 2));
            questions.Add(new TestQuestion("4. Формула для обчислення перестановок", "Pn = (1+n)!", "Pn = (n-2)!", "Pn = n!", "Pn = 1*2*...*(1-n)", 2));
            questions.Add(new TestQuestion("5. Розміщення", "m-елементні вибірки з n-елементних множин, які відрізняються елементами або порядком елементів", "вибірки, які відрізняються порядком елементів", "m-елементні вибірки з n-елементних множин, які відрізняються елементами і порядком елементів", "множини, для яких порядок елементів не є істотним", 1));
            questions.Add(new TestQuestion("6. ??? ", "Формула повної ймовірності", "Формула Байєса", "Формула Бернуллі", "Формула Ла-Гранжа", 1));
            questions.Add(new TestQuestion("7. Із натуральних чисел від 1 до 30 учень навмання називає одне. Яка ймовірність того, що це число кратне числу 5?", "1/10", "1/6", "1/5", "1/4", 2));
            questions.Add(new TestQuestion("8. Із літер, написаних на окремих картках, склали слово «математика». Потім ці картки поміняли місцями, перетасували та взяли навмання одну з них. Яка ймовірність того, що це буде картка з літерою А?", "0.1", "0.2", "0.3", "0.4", 3));
            questions.Add(new TestQuestion("9. В автоматі містяться 100 пронумерованих жетонів (від 1 до 100). Знайдіть імовірність того, що номер навмання витягнутого жетона не має цифру 3.", "0.11", "0.38", "0.19", "0.81", 4));
            questions.Add(new TestQuestion("10. Задано цифри 1, 2, 3, 4, 5, 6. Із них утворюють усі можливі шестицифрові числа, використовуючи кожну цифру тільки один раз. Знайдіть імовірність того, що взяте навмання одне з чисел ділитиметься на 5.", "1/720", "1/6", "1/80", "1/5", 2));

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

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0 && textBox2.Text.Length > 0)
            {
                panel1.Visible = false;
                panel2.Visible = false;
                panel4.Visible = true;
                // timer
                if (currentQuestion >= questions.Count)
                {
                    panel2.Visible = true;
                    panel1.Visible = false;
                    panel4.Visible = false;
                    label3.Text = "Ваш результат " + result + " балів";
                    label3.Location = new Point(ActiveForm.Width / 4, ActiveForm.Height / 3);
                    Global.participants.Add(new TestParticipant(textBox1.Text, textBox2.Text, result, DateTime.Now.ToString()));

                    var json = JsonConvert.SerializeObject(Global.participants);
                    File.WriteAllText(Global.pathToDefaultParticipantFile, json);

                }
                else
                {
                    radioButton1.Checked = radioButton2.Checked = radioButton3.Checked = radioButton4.Checked = false;
                    richTextBox1.Text = questions[currentQuestion].question;
                    radioButton1.Text = questions[currentQuestion].answer1;
                    radioButton2.Text = questions[currentQuestion].answer2;
                    radioButton3.Text = questions[currentQuestion].answer3;
                    radioButton4.Text = questions[currentQuestion].answer4;
                }
            }
            else
            {
                MessageBox.Show("Введіть дані");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked || radioButton2.Checked || radioButton3.Checked || radioButton4.Checked)
            {
                if (questions[currentQuestion].correctAnswer == 1 && radioButton1.Checked) result += 0.5;
                else if (questions[currentQuestion].correctAnswer == 2 && radioButton2.Checked) result += 0.5;
                else if (questions[currentQuestion].correctAnswer == 3 && radioButton3.Checked) result += 0.5;
                else if (questions[currentQuestion].correctAnswer == 4 && radioButton4.Checked) result += 0.5;

                currentQuestion++;
                button1_Click(this, e);
            }
            else
            {
                MessageBox.Show("Виберіть правильний варіант");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TestResultsForm testResultsForm = new TestResultsForm();
            testResultsForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TestResultsForm testResultsForm = new TestResultsForm();
            testResultsForm.Show();
        }
    }
}
