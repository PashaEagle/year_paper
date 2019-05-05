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

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Title = "Створення файлу з результатами";
            dialog.FileName = "Результати";
            dialog.DefaultExt = "docx";
            dialog.Filter = "DOCX |*.docx";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var doc = DocX.Create(dialog.FileName);
                string title = "Результати";
                string textParagraph = "";

                Xceed.Words.NET.Formatting titleFormat = new Xceed.Words.NET.Formatting();
                titleFormat.Size = 26;
                titleFormat.Position = 40;
                titleFormat.FontColor = System.Drawing.Color.Navy;
                titleFormat.Italic = true;
                titleFormat.Bold = true;


                Xceed.Words.NET.Formatting textParagraphFormat = new Xceed.Words.NET.Formatting();
                textParagraphFormat.Size = 10;

                foreach (TestParticipant temp in Global.participants)
                {
                    textParagraph += "Імя: " + temp.name + ";\t";
                    textParagraph += "Група: " + temp.group + ";\t";
                    textParagraph += "Дата: " + temp.date + ";\t";
                    textParagraph += "Результат: " + temp.result + Environment.NewLine + Environment.NewLine;
                }

                Paragraph paragraphTitle = doc.InsertParagraph(title, false, titleFormat);
                paragraphTitle.Alignment = Alignment.center;
                doc.InsertParagraph(textParagraph, false, textParagraphFormat);

                doc.Save();

                MessageBox.Show("Файл з результатами збережено");
            }
        }
    }
}
