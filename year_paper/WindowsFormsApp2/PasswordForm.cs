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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text.Equals(Global.password))
            {
                this.Visible = false;
                new TeacherForm().Show();
            }
            else
            {
                MessageBox.Show("Пароль невірний !");
            }
        }
    }
}
