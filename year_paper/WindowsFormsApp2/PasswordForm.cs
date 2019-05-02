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
    public partial class PasswordForm : Form
    {
        public PasswordForm()
        {
            InitializeComponent();
        }

        private void PasswordForm_Load(object sender, EventArgs e)
        {
            label1.Text = "Пароль: ";
            button1.Text = "Ввести";
            button2.Text = "Редагувати тест з файлу";
            button3.Text = "Переглянути результати тестів";
            button2.Enabled = false;
            button3.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text.Equals(Global.password))
            {
               // this.Visible = false;
                button2.Enabled = true;
                button3.Enabled = true;
                //new TeacherForm().Show();
            }
            else
            {
                MessageBox.Show("Пароль невірний !");
                button2.Enabled = false;
                button3.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new EditTestForm().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new TestResultsForm().Show();
        }
    }
}
