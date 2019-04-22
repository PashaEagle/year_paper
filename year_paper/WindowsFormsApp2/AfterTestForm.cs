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
    public partial class AfterTestForm : Form
    {
        public AfterTestForm()
        {
            InitializeComponent();
        }

        private void AfterTestForm_Load(object sender, EventArgs e)
        {
            button1.Text = "На головну";
            button2.Text = "Детальніше";

            label1.Text = "Ваш результат " + Global.finalPoints.ToString() + " балів";
//            label1.Location = new Point(ActiveForm.Width / 4, ActiveForm.Height / 3);
            Global.participants.Add(new TestParticipant(Global.activeParticipantName, Global.activeParticipantGroup, Global.finalPoints, DateTime.Now.ToString()));

            var json = JsonConvert.SerializeObject(Global.participants);
            File.WriteAllText(Global.pathToDefaultParticipantFile, json);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new AnalyzeTestForm().Show();
        }
    }
}
