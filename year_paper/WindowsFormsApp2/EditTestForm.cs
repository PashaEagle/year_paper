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
using Xceed.Words.NET;

namespace WindowsFormsApp2
{
    public partial class EditTestForm : Form
    {
        void ClearAllFields()
        {
            richTextBox1.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            rb1.Checked = false;
            rb2.Checked = false;
            rb3.Checked = false;
            rb4.Checked = false;
        }

        void RefreshQBox()
        {
            qbox.Items.Clear();
            for (int i = 0; i < Global.currentTestQuestions.Count; ++i)
            {
                String question = Global.currentTestQuestions[i].question;
                qbox.Items.Add("#" + (i + 1) + " - " + question);
            }
        }

        int indexOfQuestionToSave;

        public EditTestForm()
        {
            InitializeComponent();
        }

        private void EditTestForm_Load(object sender, EventArgs e)
        {
            panel1.Enabled = false;

            bDelete.Enabled = false;
            bEdit.Enabled = false;

            rb1.Text = "Відповідь #1";
            rb2.Text = "Відповідь #2";
            rb3.Text = "Відповідь #3";
            rb4.Text = "Відповідь #4";
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            int index = qbox.SelectedIndex;
            if (index < 0)
            {
                MessageBox.Show("Виберіть питання");
                return;
            }
            indexOfQuestionToSave = qbox.SelectedIndex;
            panel3.Enabled = false;
            panel2.Enabled = true;
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            int index = qbox.SelectedIndex;
            if (index < 0)
            {
                MessageBox.Show("Виберіть питання");
                return;
            }
            if (MessageBox.Show("Ви дійсно хочете безвозвратно видалити це питання?", "Видалення", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                Global.currentTestQuestions.RemoveAt(index);
                RefreshQBox();
            }
        }

        private void bSaveQuestion_Click(object sender, EventArgs e)
        {
            if ((rb1.Checked || rb2.Checked || rb3.Checked || rb4.Checked) && richTextBox1.TextLength > 5 && textBox1.TextLength > 0 && textBox2.TextLength > 0 && textBox3.TextLength > 0 && textBox4.TextLength > 0)
            {
                String question = richTextBox1.Text;
                String ans1 = textBox1.Text;
                String ans2 = textBox2.Text;
                String ans3 = textBox3.Text;
                String ans4 = textBox4.Text;
                int correctAnswer = 0;
                if (rb1.Checked) correctAnswer = 1;
                if (rb2.Checked) correctAnswer = 2;
                if (rb3.Checked) correctAnswer = 3;
                if (rb4.Checked) correctAnswer = 4;
                TestQuestion editedQuestion = new TestQuestion(question, ans1, ans2, ans3, ans4, correctAnswer);

                Global.currentTestQuestions[indexOfQuestionToSave] = editedQuestion;

                RefreshQBox();

                MessageBox.Show("Питання успішно збережено");
                panel2.Enabled = false;
                panel3.Enabled = true;
            }
            else
            {
                MessageBox.Show("Будь ласка заповніть всі поля і відмітьте правиьну відповідь");
            }
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            if (Global.currentTestQuestions.Count < 10)
            {
                if (MessageBox.Show("Ви збираєетсь зберегти файл в якому менше 10 питань. Зауважте що пройти тест по ньому буде неможливо. Всеодно зберегти ?", "Збереження", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
                    return;
            }

            var json = JsonConvert.SerializeObject(Global.currentTestQuestions);
            File.WriteAllText(Global.currentTestFilePath, json);

            MessageBox.Show("Файл з питаннями збережено");
            назадToolStripMenuItem.Enabled = true;
            редагуватиНаявнийToolStripMenuItem.Enabled = true;
            створитиНовийToolStripMenuItem.Enabled = true;
        }

        private void bSaveAs_Click(object sender, EventArgs e)
        {
            if (Global.currentTestQuestions.Count < 10)
            {
                if (MessageBox.Show("Ви збираєетсь зберегти файл в якому менше 10 питань. Зауважте що пройти тест по ньому буде неможливо. Всеодно зберегти ?", "Збереження", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
                    return;
            }

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Title = "Створення файлу з питаннями";
            dialog.FileName = "file";
            dialog.DefaultExt = "json";
            dialog.Filter = "JSON |*.json";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Global.currentTestFilePath = dialog.FileName;
               // File.Create(Global.currentTestFilePath);

                var json = JsonConvert.SerializeObject(Global.currentTestQuestions);
                File.WriteAllText(Global.currentTestFilePath, json);

                MessageBox.Show("Файл з питаннями збережено");
            }
            назадToolStripMenuItem.Enabled = true;
            редагуватиНаявнийToolStripMenuItem.Enabled = true;
            створитиНовийToolStripMenuItem.Enabled = true;
        }

        private void bAddNew_Click(object sender, EventArgs e)
        {
            
            if (Global.currentTestQuestions.Count < Global.maxQuestionsLimit)
            {
                ClearAllFields();
                indexOfQuestionToSave = Global.currentTestQuestions.Count;
                Global.currentTestQuestions.Add(new TestQuestion("it's an aggregate", "null", "null", "null", "null", 0));
                panel3.Enabled = false;
                panel2.Enabled = true;
            }
            else
            {
                MessageBox.Show("Максимальна кількість питань - 30");
            }
           
        }

        private void qbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            bDelete.Enabled = true;
            bEdit.Enabled = true;
            TestQuestion temp = Global.currentTestQuestions[qbox.SelectedIndex];
            richTextBox1.Text = temp.question;
            textBox1.Text = temp.answer1;
            textBox2.Text = temp.answer2;
            textBox3.Text = temp.answer3;
            textBox4.Text = temp.answer4;
            if (temp.correctAnswer == 1) rb1.Checked = true;
            else if (temp.correctAnswer == 2) rb2.Checked = true;
            else if (temp.correctAnswer == 3) rb3.Checked = true;
            else if (temp.correctAnswer == 4) rb3.Checked = true;
        }

        private void bExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Title = "Створення файлу з питаннями";
            dialog.FileName = "Питання";
            dialog.DefaultExt = "docx";
            dialog.Filter = "DOCX |*.docx";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var doc = DocX.Create(dialog.FileName);
                string title = "Питання";
                string textParagraph = "";

                Xceed.Words.NET.Formatting titleFormat = new Xceed.Words.NET.Formatting();
                titleFormat.Size = 26;
                titleFormat.Position = 40;
                titleFormat.FontColor = System.Drawing.Color.Navy;
                titleFormat.Italic = true;
                titleFormat.Bold = true;


                Xceed.Words.NET.Formatting textParagraphFormat = new Xceed.Words.NET.Formatting();
                textParagraphFormat.Size = 10;

                foreach (TestQuestion temp in Global.currentTestQuestions)
                {
                    textParagraph += temp.question + Environment.NewLine + Environment.NewLine;
                }

                Paragraph paragraphTitle = doc.InsertParagraph(title, false, titleFormat);
                paragraphTitle.Alignment = Alignment.center;
                doc.InsertParagraph(textParagraph, false, textParagraphFormat);
                
                doc.Save();

                MessageBox.Show("Файл з питаннями збережено");
            }
            назадToolStripMenuItem.Enabled = true;
            редагуватиНаявнийToolStripMenuItem.Enabled = true;
            створитиНовийToolStripMenuItem.Enabled = true;
        }

        private void редагуватиНаявнийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Вибір файлу з питаннями";
            dialog.FileName = "";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Global.currentTestFilePath = dialog.FileName;
                Global.currentTestQuestions = new List<TestQuestion>();
                try
                {
                    string json = File.ReadAllText(Global.currentTestFilePath);
                    Global.currentTestQuestions = JsonConvert.DeserializeObject<List<TestQuestion>>(json);
                    Console.WriteLine(json);
                }
                catch (Exception ee)
                {
                    MessageBox.Show("Помилка при завантаженні. Можливо файл пошкоджено");
                    return;
                }

                if (Global.currentTestQuestions == null)
                {
                    MessageBox.Show("Відбулась помилка при завантаженні. Файл пустий ?");
                    return;
                }

                panel1.Enabled = true;
                редагуватиНаявнийToolStripMenuItem.Enabled = false;
                створитиНовийToolStripMenuItem.Enabled = false;
                назадToolStripMenuItem.Enabled = false;
                panel2.Enabled = false;

                RefreshQBox();

            }
        }

        private void створитиНовийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Title = "Створення файлу з питаннями";
            dialog.FileName = "file";
            dialog.DefaultExt = "json";
            dialog.Filter = "JSON |*.json";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Global.currentTestFilePath = dialog.FileName;
                Global.currentTestQuestions = new List<TestQuestion>();

                File.Create(Global.currentTestFilePath);

                panel1.Visible = true;
                редагуватиНаявнийToolStripMenuItem.Enabled = false;
                створитиНовийToolStripMenuItem.Enabled = false;
                назадToolStripMenuItem.Enabled = false;
                panel2.Enabled = false;

            }
        }

        private void назадToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }
    }
}
