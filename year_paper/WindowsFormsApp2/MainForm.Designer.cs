namespace WindowsFormsApp2
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.тестуванняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.студентToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.викладачToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.електроннийПыдручникToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.цікавіЗадачіToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.історичніПостатіToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.типовіЗадачіToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зІсторіїToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.парадоксиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проПрограмуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проПрограмуToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.TimeNow = new System.Windows.Forms.Timer(this.components);
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Location = new System.Drawing.Point(29, 150);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(781, 406);
            this.panel1.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(584, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 35);
            this.button1.TabIndex = 19;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Монета",
            "Кубик"});
            this.comboBox1.Location = new System.Drawing.Point(262, 52);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(182, 28);
            this.comboBox1.TabIndex = 24;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(263, 98);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(181, 26);
            this.numericUpDown1.TabIndex = 25;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 18);
            this.label1.TabIndex = 26;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 18);
            this.label2.TabIndex = 27;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 590);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 18);
            this.label3.TabIndex = 28;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 633);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 18);
            this.label4.TabIndex = 29;
            this.label4.Text = "label4";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.RosyBrown;
            this.menuStrip1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.проПрограмуToolStripMenuItem,
            this.проПрограмуToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(822, 30);
            this.menuStrip1.TabIndex = 30;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.тестуванняToolStripMenuItem,
            this.електроннийПыдручникToolStripMenuItem,
            this.цікавіЗадачіToolStripMenuItem});
            this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(154, 26);
            this.toolStripMenuItem1.Text = "Додатково..";
            // 
            // тестуванняToolStripMenuItem
            // 
            this.тестуванняToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.студентToolStripMenuItem,
            this.викладачToolStripMenuItem});
            this.тестуванняToolStripMenuItem.Name = "тестуванняToolStripMenuItem";
            this.тестуванняToolStripMenuItem.Size = new System.Drawing.Size(286, 26);
            this.тестуванняToolStripMenuItem.Text = "Тестування";
            // 
            // студентToolStripMenuItem
            // 
            this.студентToolStripMenuItem.Name = "студентToolStripMenuItem";
            this.студентToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.студентToolStripMenuItem.Text = "Студент";
            this.студентToolStripMenuItem.Click += new System.EventHandler(this.студентToolStripMenuItem_Click);
            // 
            // викладачToolStripMenuItem
            // 
            this.викладачToolStripMenuItem.Name = "викладачToolStripMenuItem";
            this.викладачToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.викладачToolStripMenuItem.Text = "Викладач";
            this.викладачToolStripMenuItem.Click += new System.EventHandler(this.викладачToolStripMenuItem_Click);
            // 
            // електроннийПыдручникToolStripMenuItem
            // 
            this.електроннийПыдручникToolStripMenuItem.Name = "електроннийПыдручникToolStripMenuItem";
            this.електроннийПыдручникToolStripMenuItem.Size = new System.Drawing.Size(286, 26);
            this.електроннийПыдручникToolStripMenuItem.Text = "Електронний підручник";
            this.електроннийПыдручникToolStripMenuItem.Click += new System.EventHandler(this.електроннийПыдручникToolStripMenuItem_Click);
            // 
            // цікавіЗадачіToolStripMenuItem
            // 
            this.цікавіЗадачіToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.історичніПостатіToolStripMenuItem,
            this.типовіЗадачіToolStripMenuItem,
            this.зІсторіїToolStripMenuItem,
            this.парадоксиToolStripMenuItem});
            this.цікавіЗадачіToolStripMenuItem.Name = "цікавіЗадачіToolStripMenuItem";
            this.цікавіЗадачіToolStripMenuItem.Size = new System.Drawing.Size(286, 26);
            this.цікавіЗадачіToolStripMenuItem.Text = "Інтернет-ресурси";
            // 
            // історичніПостатіToolStripMenuItem
            // 
            this.історичніПостатіToolStripMenuItem.Name = "історичніПостатіToolStripMenuItem";
            this.історичніПостатіToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.історичніПостатіToolStripMenuItem.Text = "Терміни";
            this.історичніПостатіToolStripMenuItem.Click += new System.EventHandler(this.історичніПостатіToolStripMenuItem_Click);
            // 
            // типовіЗадачіToolStripMenuItem
            // 
            this.типовіЗадачіToolStripMenuItem.Name = "типовіЗадачіToolStripMenuItem";
            this.типовіЗадачіToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.типовіЗадачіToolStripMenuItem.Text = "Типові задачі";
            this.типовіЗадачіToolStripMenuItem.Click += new System.EventHandler(this.типовіЗадачіToolStripMenuItem_Click);
            // 
            // зІсторіїToolStripMenuItem
            // 
            this.зІсторіїToolStripMenuItem.Name = "зІсторіїToolStripMenuItem";
            this.зІсторіїToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.зІсторіїToolStripMenuItem.Text = "З історії..";
            // 
            // парадоксиToolStripMenuItem
            // 
            this.парадоксиToolStripMenuItem.Name = "парадоксиToolStripMenuItem";
            this.парадоксиToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.парадоксиToolStripMenuItem.Text = "Парадокси ТЙ";
            // 
            // проПрограмуToolStripMenuItem
            // 
            this.проПрограмуToolStripMenuItem.BackColor = System.Drawing.Color.RosyBrown;
            this.проПрограмуToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("проПрограмуToolStripMenuItem.Image")));
            this.проПрограмуToolStripMenuItem.Name = "проПрограмуToolStripMenuItem";
            this.проПрограмуToolStripMenuItem.Size = new System.Drawing.Size(138, 26);
            this.проПрограмуToolStripMenuItem.Text = "Статистика";
            this.проПрограмуToolStripMenuItem.Click += new System.EventHandler(this.проПрограмуToolStripMenuItem_Click);
            // 
            // проПрограмуToolStripMenuItem1
            // 
            this.проПрограмуToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("проПрограмуToolStripMenuItem1.Image")));
            this.проПрограмуToolStripMenuItem1.Name = "проПрограмуToolStripMenuItem1";
            this.проПрограмуToolStripMenuItem1.Size = new System.Drawing.Size(160, 26);
            this.проПрограмуToolStripMenuItem1.Text = "Про програму";
            this.проПрограмуToolStripMenuItem1.Click += new System.EventHandler(this.проПрограмуToolStripMenuItem1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.White;
            this.statusStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 669);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(822, 22);
            this.statusStrip1.TabIndex = 31;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // TimeNow
            // 
            this.TimeNow.Tick += new System.EventHandler(this.TimeNow_Tick_1);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(197, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(822, 691);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Assistant";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem тестуванняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem студентToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem викладачToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem електроннийПыдручникToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проПрограмуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проПрограмуToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem цікавіЗадачіToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem історичніПостатіToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem типовіЗадачіToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зІсторіїToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem парадоксиToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Timer TimeNow;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

