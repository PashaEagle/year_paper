namespace WindowsFormsApp2
{
    partial class EditTestForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditTestForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bExport = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bAddNew = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bDelete = new System.Windows.Forms.Button();
            this.bEdit = new System.Windows.Forms.Button();
            this.qbox = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bSaveQuestion = new System.Windows.Forms.Button();
            this.rb4 = new System.Windows.Forms.RadioButton();
            this.rb3 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.bSaveAs = new System.Windows.Forms.Button();
            this.bSave = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.редагуватиНаявнийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.створитиНовийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.назадToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bExport);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.bSaveAs);
            this.panel1.Controls.Add(this.bSave);
            this.panel1.Location = new System.Drawing.Point(12, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(754, 544);
            this.panel1.TabIndex = 16;
            // 
            // bExport
            // 
            this.bExport.BackColor = System.Drawing.Color.White;
            this.bExport.FlatAppearance.BorderSize = 2;
            this.bExport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bExport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bExport.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bExport.Location = new System.Drawing.Point(22, 487);
            this.bExport.Name = "bExport";
            this.bExport.Size = new System.Drawing.Size(213, 41);
            this.bExport.TabIndex = 18;
            this.bExport.Text = "Експорт в Word-файл";
            this.bExport.UseVisualStyleBackColor = false;
            this.bExport.Click += new System.EventHandler(this.bExport_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.bAddNew);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.bDelete);
            this.panel3.Controls.Add(this.bEdit);
            this.panel3.Controls.Add(this.qbox);
            this.panel3.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(16, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(725, 86);
            this.panel3.TabIndex = 34;
            // 
            // bAddNew
            // 
            this.bAddNew.BackColor = System.Drawing.Color.White;
            this.bAddNew.FlatAppearance.BorderSize = 2;
            this.bAddNew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bAddNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAddNew.Location = new System.Drawing.Point(381, 15);
            this.bAddNew.Name = "bAddNew";
            this.bAddNew.Size = new System.Drawing.Size(106, 56);
            this.bAddNew.TabIndex = 38;
            this.bAddNew.Text = "Додати";
            this.bAddNew.UseVisualStyleBackColor = false;
            this.bAddNew.Click += new System.EventHandler(this.bAddNew_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 18);
            this.label1.TabIndex = 37;
            this.label1.Text = "label1";
            // 
            // bDelete
            // 
            this.bDelete.BackColor = System.Drawing.Color.White;
            this.bDelete.FlatAppearance.BorderSize = 2;
            this.bDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bDelete.Location = new System.Drawing.Point(493, 15);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(106, 56);
            this.bDelete.TabIndex = 36;
            this.bDelete.Text = "Видалити";
            this.bDelete.UseVisualStyleBackColor = false;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // bEdit
            // 
            this.bEdit.BackColor = System.Drawing.Color.White;
            this.bEdit.FlatAppearance.BorderSize = 2;
            this.bEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bEdit.Location = new System.Drawing.Point(605, 14);
            this.bEdit.Name = "bEdit";
            this.bEdit.Size = new System.Drawing.Size(106, 56);
            this.bEdit.TabIndex = 35;
            this.bEdit.Text = "Редагувати";
            this.bEdit.UseVisualStyleBackColor = false;
            this.bEdit.Click += new System.EventHandler(this.bEdit_Click);
            // 
            // qbox
            // 
            this.qbox.BackColor = System.Drawing.Color.White;
            this.qbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.qbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qbox.FormattingEnabled = true;
            this.qbox.Location = new System.Drawing.Point(3, 44);
            this.qbox.Name = "qbox";
            this.qbox.Size = new System.Drawing.Size(359, 24);
            this.qbox.TabIndex = 34;
            this.qbox.SelectedIndexChanged += new System.EventHandler(this.qbox_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bSaveQuestion);
            this.panel2.Controls.Add(this.rb4);
            this.panel2.Controls.Add(this.rb3);
            this.panel2.Controls.Add(this.rb2);
            this.panel2.Controls.Add(this.rb1);
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.richTextBox1);
            this.panel2.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(41, 104);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(667, 368);
            this.panel2.TabIndex = 31;
            // 
            // bSaveQuestion
            // 
            this.bSaveQuestion.BackColor = System.Drawing.Color.White;
            this.bSaveQuestion.FlatAppearance.BorderSize = 2;
            this.bSaveQuestion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bSaveQuestion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bSaveQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSaveQuestion.Location = new System.Drawing.Point(235, 313);
            this.bSaveQuestion.Name = "bSaveQuestion";
            this.bSaveQuestion.Size = new System.Drawing.Size(204, 41);
            this.bSaveQuestion.TabIndex = 34;
            this.bSaveQuestion.Text = "Зберегти питання";
            this.bSaveQuestion.UseVisualStyleBackColor = false;
            this.bSaveQuestion.Click += new System.EventHandler(this.bSaveQuestion_Click);
            // 
            // rb4
            // 
            this.rb4.AutoSize = true;
            this.rb4.Location = new System.Drawing.Point(15, 265);
            this.rb4.Name = "rb4";
            this.rb4.Size = new System.Drawing.Size(56, 22);
            this.rb4.TabIndex = 37;
            this.rb4.TabStop = true;
            this.rb4.Text = "rb4";
            this.rb4.UseVisualStyleBackColor = true;
            // 
            // rb3
            // 
            this.rb3.AutoSize = true;
            this.rb3.Location = new System.Drawing.Point(15, 225);
            this.rb3.Name = "rb3";
            this.rb3.Size = new System.Drawing.Size(56, 22);
            this.rb3.TabIndex = 36;
            this.rb3.TabStop = true;
            this.rb3.Text = "rb3";
            this.rb3.UseVisualStyleBackColor = true;
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Location = new System.Drawing.Point(15, 186);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(56, 22);
            this.rb2.TabIndex = 35;
            this.rb2.TabStop = true;
            this.rb2.Text = "rb2";
            this.rb2.UseVisualStyleBackColor = true;
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Location = new System.Drawing.Point(15, 144);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(56, 22);
            this.rb1.TabIndex = 34;
            this.rb1.TabStop = true;
            this.rb1.Text = "rb1";
            this.rb1.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(162, 264);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(489, 26);
            this.textBox4.TabIndex = 33;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(162, 221);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(489, 26);
            this.textBox3.TabIndex = 32;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(162, 182);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(489, 26);
            this.textBox2.TabIndex = 31;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(162, 144);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(489, 26);
            this.textBox1.TabIndex = 30;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(16, 15);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(635, 109);
            this.richTextBox1.TabIndex = 29;
            this.richTextBox1.Text = "";
            // 
            // bSaveAs
            // 
            this.bSaveAs.BackColor = System.Drawing.Color.White;
            this.bSaveAs.FlatAppearance.BorderSize = 2;
            this.bSaveAs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bSaveAs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bSaveAs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSaveAs.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSaveAs.Location = new System.Drawing.Point(529, 487);
            this.bSaveAs.Name = "bSaveAs";
            this.bSaveAs.Size = new System.Drawing.Size(212, 41);
            this.bSaveAs.TabIndex = 19;
            this.bSaveAs.Text = "Зберегти як..";
            this.bSaveAs.UseVisualStyleBackColor = false;
            this.bSaveAs.Click += new System.EventHandler(this.bSaveAs_Click);
            // 
            // bSave
            // 
            this.bSave.BackColor = System.Drawing.Color.White;
            this.bSave.FlatAppearance.BorderSize = 2;
            this.bSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSave.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSave.Location = new System.Drawing.Point(276, 487);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(204, 41);
            this.bSave.TabIndex = 18;
            this.bSave.Text = "Зберегти";
            this.bSave.UseVisualStyleBackColor = false;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.RosyBrown;
            this.menuStrip1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.редагуватиНаявнийToolStripMenuItem,
            this.створитиНовийToolStripMenuItem,
            this.назадToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(775, 30);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // редагуватиНаявнийToolStripMenuItem
            // 
            this.редагуватиНаявнийToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("редагуватиНаявнийToolStripMenuItem.Image")));
            this.редагуватиНаявнийToolStripMenuItem.Name = "редагуватиНаявнийToolStripMenuItem";
            this.редагуватиНаявнийToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.редагуватиНаявнийToolStripMenuItem.Text = "Редагувати наявний";
            this.редагуватиНаявнийToolStripMenuItem.Click += new System.EventHandler(this.редагуватиНаявнийToolStripMenuItem_Click);
            // 
            // створитиНовийToolStripMenuItem
            // 
            this.створитиНовийToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("створитиНовийToolStripMenuItem.Image")));
            this.створитиНовийToolStripMenuItem.Name = "створитиНовийToolStripMenuItem";
            this.створитиНовийToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.створитиНовийToolStripMenuItem.Text = "Створити новий";
            this.створитиНовийToolStripMenuItem.Click += new System.EventHandler(this.створитиНовийToolStripMenuItem_Click);
            // 
            // назадToolStripMenuItem
            // 
            this.назадToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("назадToolStripMenuItem.Image")));
            this.назадToolStripMenuItem.Name = "назадToolStripMenuItem";
            this.назадToolStripMenuItem.Size = new System.Drawing.Size(92, 26);
            this.назадToolStripMenuItem.Text = "Назад";
            this.назадToolStripMenuItem.Click += new System.EventHandler(this.назадToolStripMenuItem_Click);
            // 
            // EditTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(775, 593);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "EditTestForm";
            this.Text = "EditTestForm";
            this.Load += new System.EventHandler(this.EditTestForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bSaveAs;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rb4;
        private System.Windows.Forms.RadioButton rb3;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button bSaveQuestion;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button bAddNew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.Button bEdit;
        private System.Windows.Forms.ComboBox qbox;
        private System.Windows.Forms.Button bExport;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem редагуватиНаявнийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem створитиНовийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem назадToolStripMenuItem;
    }
}