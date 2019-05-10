using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using static WindowsFormsApp2.Enums;

namespace WindowsFormsApp2
{
    public partial class MainForm : Form
    {
        Random rand = new Random();

        public MainForm()
        {
            InitializeComponent();
        }

        PictureBox []images = new PictureBox[10];

        void InitializeCoordsArray()
        {
            Global.coordX[1, 1] = 225; Global.coordY[1, 1] = 75; Global.height[1, 1] = 300;  Global.width[1, 1] = 300;

            Global.coordX[2, 1] = 150; Global.coordY[2, 1] = 100; Global.height[2, 1] = 200; Global.width[2, 1] = 200;
            Global.coordX[2, 2] = 400; Global.coordY[2, 2] = 100; Global.height[2, 2] = 200; Global.width[2, 2] = 200;

            Global.coordX[3, 1] = 50;  Global.coordY[3, 1] = 100; Global.height[3, 1] = 200; Global.width[3, 1] = 200;
            Global.coordX[3, 2] = 300; Global.coordY[3, 2] = 100; Global.height[3, 2] = 200; Global.width[3, 2] = 200;
            Global.coordX[3, 3] = 550; Global.coordY[3, 3] = 100; Global.height[3, 3] = 200; Global.width[3, 3] = 200;

            Global.coordX[4, 1] = 200; Global.coordY[4, 1] = 50 ; Global.height[4, 1] = 150; Global.width[4, 1] = 150;
            Global.coordX[4, 2] = 400; Global.coordY[4, 2] = 50 ; Global.height[4, 2] = 150; Global.width[4, 2] = 150;
            Global.coordX[4, 3] = 200; Global.coordY[4, 3] = 250; Global.height[4, 3] = 150; Global.width[4, 3] = 150;
            Global.coordX[4, 4] = 400; Global.coordY[4, 4] = 250; Global.height[4, 4] = 150; Global.width[4, 4] = 150;
             
            Global.coordX[5, 1] = 100; Global.coordY[5, 1] = 50;  Global.height[5, 1] = 150; Global.width[5, 1] = 150;
            Global.coordX[5, 2] = 300; Global.coordY[5, 2] = 50;  Global.height[5, 2] = 150; Global.width[5, 2] = 150;
            Global.coordX[5, 3] = 100; Global.coordY[5, 3] = 250; Global.height[5, 3] = 150; Global.width[5, 3] = 150;
            Global.coordX[5, 4] = 300; Global.coordY[5, 4] = 250; Global.height[5, 4] = 150; Global.width[5, 4] = 150;
            Global.coordX[5, 5] = 500; Global.coordY[5, 5] = 150; Global.height[5, 5] = 150; Global.width[5, 5] = 150;

            Global.coordX[6, 1] = 100; Global.coordY[6, 1] = 50;  Global.height[6, 1] = 150; Global.width[6, 1] = 150;
            Global.coordX[6, 2] = 300; Global.coordY[6, 2] = 50;  Global.height[6, 2] = 150; Global.width[6, 2] = 150;
            Global.coordX[6, 3] = 100; Global.coordY[6, 3] = 250; Global.height[6, 3] = 150; Global.width[6, 3] = 150;
            Global.coordX[6, 4] = 300; Global.coordY[6, 4] = 250; Global.height[6, 4] = 150; Global.width[6, 4] = 150;
            Global.coordX[6, 5] = 500; Global.coordY[6, 5] = 50;  Global.height[6, 5] = 150; Global.width[6, 5] = 150;
            Global.coordX[6, 6] = 500; Global.coordY[6, 6] = 250; Global.height[6, 6] = 150; Global.width[6, 6] = 150;

            Global.coordX[7, 1] = 200; Global.coordY[7, 1] = 20;  Global.height[7, 1] = 100; Global.width[7, 1] = 100;
            Global.coordX[7, 2] = 350; Global.coordY[7, 2] = 20;  Global.height[7, 2] = 100; Global.width[7, 2] = 100;
            Global.coordX[7, 3] = 500; Global.coordY[7, 3] = 20;  Global.height[7, 3] = 100; Global.width[7, 3] = 100;
            Global.coordX[7, 4] = 200; Global.coordY[7, 4] = 150; Global.height[7, 4] = 100; Global.width[7, 4] = 100;
            Global.coordX[7, 5] = 350; Global.coordY[7, 5] = 150; Global.height[7, 5] = 100; Global.width[7, 5] = 100;
            Global.coordX[7, 6] = 500; Global.coordY[7, 6] = 150; Global.height[7, 6] = 100; Global.width[7, 6] = 100;
            Global.coordX[7, 7] = 350; Global.coordY[7, 7] = 270; Global.height[7, 7] = 100; Global.width[7, 7] = 100;

            Global.coordX[8, 1] = 200; Global.coordY[8, 1] = 20;  Global.height[8, 1] = 100; Global.width[8, 1] = 100;
            Global.coordX[8, 2] = 350; Global.coordY[8, 2] = 20;  Global.height[8, 2] = 100; Global.width[8, 2] = 100;
            Global.coordX[8, 3] = 500; Global.coordY[8, 3] = 20;  Global.height[8, 3] = 100; Global.width[8, 3] = 100;
            Global.coordX[8, 4] = 200; Global.coordY[8, 4] = 150; Global.height[8, 4] = 100; Global.width[8, 4] = 100;
            Global.coordX[8, 5] = 350; Global.coordY[8, 5] = 150; Global.height[8, 5] = 100; Global.width[8, 5] = 100;
            Global.coordX[8, 6] = 500; Global.coordY[8, 6] = 150; Global.height[8, 6] = 100; Global.width[8, 6] = 100;
            Global.coordX[8, 7] = 275; Global.coordY[8, 7] = 270; Global.height[8, 7] = 100; Global.width[8, 7] = 100;
            Global.coordX[8, 8] = 425; Global.coordY[8, 8] = 270; Global.height[8, 8] = 100; Global.width[8, 8] = 100;

            Global.coordX[9, 1] = 200; Global.coordY[9, 1] = 20;  Global.height[9, 1] = 100; Global.width[9, 1] = 100;
            Global.coordX[9, 2] = 350; Global.coordY[9, 2] = 20;  Global.height[9, 2] = 100; Global.width[9, 2] = 100;
            Global.coordX[9, 3] = 500; Global.coordY[9, 3] = 20;  Global.height[9, 3] = 100; Global.width[9, 3] = 100;
            Global.coordX[9, 4] = 200; Global.coordY[9, 4] = 150; Global.height[9, 4] = 100; Global.width[9, 4] = 100;
            Global.coordX[9, 5] = 350; Global.coordY[9, 5] = 150; Global.height[9, 5] = 100; Global.width[9, 5] = 100;
            Global.coordX[9, 6] = 500; Global.coordY[9, 6] = 150; Global.height[9, 6] = 100; Global.width[9, 6] = 100;
            Global.coordX[9, 7] = 200; Global.coordY[9, 7] = 270; Global.height[9, 7] = 100; Global.width[9, 7] = 100;
            Global.coordX[9, 8] = 350; Global.coordY[9, 8] = 270; Global.height[9, 8] = 100; Global.width[9, 8] = 100;
            Global.coordX[9, 9] = 500; Global.coordY[9, 9] = 270; Global.height[9, 9] = 100; Global.width[9, 9] = 100;

        }

        void InitializePicturesArray()
        {
            Global.coinPictures[0] = Properties.Resources.gerb;
            Global.coinPictures[1] = Properties.Resources.reshka;

            Global.dicePictures[0] = Properties.Resources._1p;
            Global.dicePictures[1] = Properties.Resources._2p;
            Global.dicePictures[2] = Properties.Resources._3p;
            Global.dicePictures[3] = Properties.Resources._4p;
            Global.dicePictures[4] = Properties.Resources._5p;
            Global.dicePictures[5] = Properties.Resources._6p;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeCoordsArray();
            InitializePicturesArray();
            numericUpDown1_ValueChanged_1(this, e);

            label1.Text = "Виберіть експеримент";
            label2.Text = "Виберіть к-сть підкидань";
            button1.Text = "Підкинути";
            label4.Visible = false;
            label3.Visible = false;

            toolStripStatusLabel1.Text = DateTime.Now.Day.ToString() + "/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString() + "   " + DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString();

            if (!File.Exists(Global.pathToDefaultStatsFile))
            {
                Global.experiments = new List<Experiment>();
            }
            else
            {
                string json = File.ReadAllText(Global.pathToDefaultStatsFile);
                Global.experiments = JsonConvert.DeserializeObject<List<Experiment>>(json);
                Console.WriteLine(json);
            }

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

        private void timer1_Tick(object sender, EventArgs e)
        {
            Console.WriteLine("Timer ticked !! " + CoinProperties.timeThatPassed + " of " + CoinProperties.timeForJuggling);
            int amount; 

            for (int i = 1; i < 10; ++i)
            {
                if (images[i] != null) images[i].Image = Global.coinPictures[rand.Next(0, CoinProperties.possibleExodusNumber)];
            }

            if (CoinProperties.timeThatPassed++ < CoinProperties.timeForJuggling) timer1.Enabled = true;
            else
            {
                amount = 0;
                for (int i = 1; i < 10; ++i)
                {
                    if (images[i] != null)
                    {
                        string result = images[i].Image == Global.coinPictures[0] ? "Gerb" : "Reshka";
                        Experiment thisExperiment = new Experiment(ExperimentType.Coin, result, DateTime.Now.ToString());
                        Global.experiments.Add(thisExperiment);
                        amount++;
                    }
                }

                var json = JsonConvert.SerializeObject(Global.experiments);
                File.WriteAllText(Global.pathToDefaultStatsFile, json);

                label4.Text = "P = 1/(k^n) * 100%, де k- к-сть можливих наслідків, n- число елементів";
                label4.Visible = true;
                label3.Text = "Ймовірність випадання такої комбінації = " + Math.Round((((double)1.0 / Math.Pow(2, amount)) * 100),6) + " %";
                label3.Visible = true;
                timer1.Enabled = false;
            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Console.WriteLine("Timer 2ticked !!" + DiceProperties.timeThatPassed + " " + DiceProperties.timeForJuggling);
            int amount;
            for (int i = 1; i < 10; ++i)
            {
                if (images[i] != null) images[i].Image = Global.dicePictures[rand.Next(0, DiceProperties.possibleExodusNumber)];
            }

            if (DiceProperties.timeThatPassed++ < DiceProperties.timeForJuggling) timer2.Enabled = true;
            else
            {
                amount = 0;
                for (int i = 1; i < 10; ++i)
                {
                    if (images[i] != null)
                    {
                        string result;
                        if (images[i].Image == Global.dicePictures[0]) result = "1";
                        else if (images[i].Image == Global.dicePictures[1]) result = "2";
                        else if (images[i].Image == Global.dicePictures[2]) result = "3";
                        else if (images[i].Image == Global.dicePictures[3]) result = "4";
                        else if (images[i].Image == Global.dicePictures[4]) result = "5";
                        else result = "6";
                        amount++;

                        Experiment thisExperiment = new Experiment(ExperimentType.Dice, result, DateTime.Now.ToString());
                        Global.experiments.Add(thisExperiment);
                    }
                }


                var json = JsonConvert.SerializeObject(Global.experiments);
                File.WriteAllText(Global.pathToDefaultStatsFile, json);
                label4.Text = "P = 1/(k^n) * 100%, де k- к-сть можливих наслідків, n- число елементів";
                label4.Visible = true;
                label3.Text = "Ймовірність випадання такої комбінації = " + Math.Round((((double)1.0 / Math.Pow(6, amount)) * 100),6) + " %";
                label3.Visible = true;
                timer2.Enabled = false;
            }
        }


      

        private void button1_Click_1(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "Монета":

                    CoinProperties.timeForJuggling = rand.Next(CoinProperties.minAmountOfJuggles, CoinProperties.maxAmountOfJuggles);
                    CoinProperties.timeThatPassed = 0;

                    timer1.Enabled = true;

                    break;

                case "Кубик":

                    DiceProperties.timeForJuggling = rand.Next(DiceProperties.minAmountOfJuggles, DiceProperties.maxAmountOfJuggles);
                    DiceProperties.timeThatPassed = 0;

                    timer2.Enabled = true;

                    break;
                    default:  { MessageBox.Show("Виберіть тип експерименту!"); break; }
             }

        }

        private void numericUpDown1_ValueChanged_1(object sender, EventArgs e)
        {
            int amount = (int)numericUpDown1.Value;
            for (int i = 0; i < 10; ++i)
            {
                if (images[i] != null)
                {
                    images[i].Dispose();
                    images[i] = null;
                }

            }


            for (int i = 1; i <= amount; ++i)
            {
                images[i] = new PictureBox();
                images[i].Left = Global.coordX[amount, i];
                images[i].Top = Global.coordY[amount, i];
                images[i].Height = Global.height[amount, i];
                images[i].Width = Global.width[amount, i];
                if (comboBox1.Text == "Монета")
                    images[i].Image = Global.coinPictures[rand.Next(0, CoinProperties.possibleExodusNumber)];
                else
                    images[i].Image = Global.dicePictures[rand.Next(0, DiceProperties.possibleExodusNumber)];
                images[i].SizeMode = PictureBoxSizeMode.Zoom;
                panel1.Controls.Add(images[i]);
            }
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            numericUpDown1_ValueChanged_1(this, e);
        }

        private void електроннийПыдручникToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("Електр підр ТЙ для ПІ.docx");
            }
            catch (Exception )
            { }
        }

        private void студентToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BeforeTestForm beforeTestForm = new BeforeTestForm();
            beforeTestForm.Show();
        }

        private void викладачToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new PasswordForm().Show();
        }

        private void проПрограмуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StatForm statForm = new StatForm();
            statForm.Show();
        }

        private void типовіЗадачіToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://yukhym.com/uk/kontrolni-z-jmovirnosti/rozv-iazky-zavdan-z-teorii-imovirnosti.html");

        }

        private void терміниToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void історичніПостатіToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=0j9ZFMiDqtA");
        }

        private void проПрограмуToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DeveloperForm developer = new DeveloperForm();
            developer.Show();
        }

      

        private void TimeNow_Tick_1(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.Day.ToString() +"/"+ DateTime.Now.Month.ToString()+ "/"+ DateTime.Now.Year.ToString()+ "   " + DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString();
            TimeNow.Start();
        }

        private void зІсторіїToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://uk.wikipedia.org/wiki/%D0%86%D1%81%D1%82%D0%BE%D1%80%D1%96%D1%8F_%D1%82%D0%B5%D0%BE%D1%80%D1%96%D1%97_%D0%B9%D0%BC%D0%BE%D0%B2%D1%96%D1%80%D0%BD%D0%BE%D1%81%D1%82%D1%96");
        }

        private void абеткаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://images.ua.prom.st/365759558_stend-gretska-i.jpg");
        }
    }
}
