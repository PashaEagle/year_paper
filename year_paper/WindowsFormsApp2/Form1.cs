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
    public partial class Form1 : Form
    {
        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Виберіть експеримент";
            label2.Text = "Виберіть к-сть підкидань";
            button1.Text = "Підкинути";
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false; pictureBox2.Visible = false; pictureBox3.Visible = false;
            label3.Visible = false; label4.Visible = false; label5.Visible = false;

            if (numericUpDown1.Value.Equals(1)) { pictureBox1.Visible = true; }
            if (numericUpDown1.Value.Equals(2)) { pictureBox1.Visible = true; pictureBox2.Visible = true; }
            if (numericUpDown1.Value.Equals(3)) { pictureBox1.Visible = true; pictureBox2.Visible = true; pictureBox3.Visible = true; }

            switch (comboBox1.Text)
            {
                case "Монета":
                    pictureBox1.Image = Properties.Resources.gerb;
                    pictureBox2.Image = Properties.Resources.gerb;
                    pictureBox3.Image = Properties.Resources.gerb;

                    CoinProperties.timeForJuggling = rand.Next(CoinProperties.minAmountOfJuggles, CoinProperties.maxAmountOfJuggles);
                    CoinProperties.timeThatPassed = 0;

                    timer1.Enabled = true;

                    break;

                case "Кубик":
                    label3.Visible = false; label4.Visible = false; label5.Visible = false;
                    pictureBox1.Image = (Image)Properties.Resources.ResourceManager.GetObject("_" + rand.Next(1, DiceProperties.possibleExodusNumber + 1) + "p");
                    pictureBox2.Image = (Image)Properties.Resources.ResourceManager.GetObject("_" + rand.Next(1, DiceProperties.possibleExodusNumber + 1) + "p");
                    pictureBox3.Image = (Image)Properties.Resources.ResourceManager.GetObject("_" + rand.Next(1, DiceProperties.possibleExodusNumber + 1) + "p");

                    DiceProperties.timeForJuggling = rand.Next(DiceProperties.minAmountOfJuggles, DiceProperties.maxAmountOfJuggles);
                    DiceProperties.timeThatPassed = 0;

                    timer2.Enabled = true;

                    break;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Console.WriteLine("Timer ticked !!" + CoinProperties.timeThatPassed + " " + CoinProperties.timeForJuggling);
            if (CoinProperties.coin1Gerb) { pictureBox1.Image = Properties.Resources.reshka; } else { pictureBox1.Image = Properties.Resources.gerb; }
            if (CoinProperties.coin2Gerb) { pictureBox2.Image = Properties.Resources.reshka; } else { pictureBox2.Image = Properties.Resources.gerb; }
            if (CoinProperties.coin3Gerb) { pictureBox3.Image = Properties.Resources.reshka; } else { pictureBox3.Image = Properties.Resources.gerb; }

            CoinProperties.coin1Gerb = !CoinProperties.coin1Gerb;
            CoinProperties.coin2Gerb = !CoinProperties.coin2Gerb;
            CoinProperties.coin3Gerb = !CoinProperties.coin3Gerb;

            if (CoinProperties.timeThatPassed++ < CoinProperties.timeForJuggling) timer1.Enabled = true;
            else
            {
                int coin1Result = rand.Next(0, CoinProperties.possibleExodusNumber); int coin2Result = rand.Next(0, CoinProperties.possibleExodusNumber); int coin3Result = rand.Next(0, CoinProperties.possibleExodusNumber);

                if (coin1Result.Equals(1)) { pictureBox1.Image = Properties.Resources.gerb; label3.Text = "Орел!"; } else { pictureBox1.Image = Properties.Resources.reshka; label3.Text = "Решка!"; }
                if (coin2Result.Equals(1)) { pictureBox2.Image = Properties.Resources.gerb; label4.Text = "Орел!"; } else { pictureBox2.Image = Properties.Resources.reshka; label4.Text = "Решка!"; }
                if (coin3Result.Equals(1)) { pictureBox3.Image = Properties.Resources.gerb; label5.Text = "Орел!"; } else { pictureBox3.Image = Properties.Resources.reshka; label5.Text = "Решка!"; }

                if (numericUpDown1.Value.Equals(1)) { label3.Visible = true; }
                if (numericUpDown1.Value.Equals(2)) { label3.Visible = true; label4.Visible = true; }
                if (numericUpDown1.Value.Equals(3)) { label3.Visible = true; label4.Visible = true; label5.Visible = true; }
                timer1.Enabled = false;
            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Console.WriteLine("Timer 2ticked !!" + DiceProperties.timeThatPassed + " " + DiceProperties.timeForJuggling);
            pictureBox1.Image = (Image)Properties.Resources.ResourceManager.GetObject("_" + rand.Next(1, DiceProperties.possibleExodusNumber + 1).ToString() + "p");
            pictureBox2.Image = (Image)Properties.Resources.ResourceManager.GetObject("_" + rand.Next(1, DiceProperties.possibleExodusNumber + 1).ToString() + "p");
            pictureBox3.Image = (Image)Properties.Resources.ResourceManager.GetObject("_" + rand.Next(1, DiceProperties.possibleExodusNumber + 1).ToString() + "p");

            if (DiceProperties.timeThatPassed++ < DiceProperties.timeForJuggling) timer2.Enabled = true;
            else
            {
                pictureBox1.Image = (Image)Properties.Resources.ResourceManager.GetObject("_" + rand.Next(1, DiceProperties.possibleExodusNumber + 1) + "p");
                pictureBox2.Image = (Image)Properties.Resources.ResourceManager.GetObject("_" + rand.Next(1, DiceProperties.possibleExodusNumber + 1) + "p");
                pictureBox3.Image = (Image)Properties.Resources.ResourceManager.GetObject("_" + rand.Next(1, DiceProperties.possibleExodusNumber + 1) + "p");

                timer2.Enabled = false;
            }
        }
    }
}
