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
            this.bOpen = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.bBack = new System.Windows.Forms.Button();
            this.bCreate = new System.Windows.Forms.Button();
            this.bExport = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bOpen
            // 
            this.bOpen.Location = new System.Drawing.Point(34, 21);
            this.bOpen.Name = "bOpen";
            this.bOpen.Size = new System.Drawing.Size(131, 41);
            this.bOpen.TabIndex = 1;
            this.bOpen.Text = "Редагувати з файлу..";
            this.bOpen.UseVisualStyleBackColor = true;
            this.bOpen.Click += new System.EventHandler(this.bOpen_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bExport);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.bSaveAs);
            this.panel1.Controls.Add(this.bSave);
            this.panel1.Location = new System.Drawing.Point(34, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(754, 520);
            this.panel1.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.bAddNew);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.bDelete);
            this.panel3.Controls.Add(this.bEdit);
            this.panel3.Controls.Add(this.qbox);
            this.panel3.Location = new System.Drawing.Point(41, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(667, 65);
            this.panel3.TabIndex = 34;
            // 
            // bAddNew
            // 
            this.bAddNew.Location = new System.Drawing.Point(566, 14);
            this.bAddNew.Name = "bAddNew";
            this.bAddNew.Size = new System.Drawing.Size(98, 41);
            this.bAddNew.TabIndex = 38;
            this.bAddNew.Text = "Добавити";
            this.bAddNew.UseVisualStyleBackColor = true;
            this.bAddNew.Click += new System.EventHandler(this.bAddNew_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "label1";
            // 
            // bDelete
            // 
            this.bDelete.Location = new System.Drawing.Point(453, 14);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(98, 41);
            this.bDelete.TabIndex = 36;
            this.bDelete.Text = "Видалити";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // bEdit
            // 
            this.bEdit.Location = new System.Drawing.Point(3, 14);
            this.bEdit.Name = "bEdit";
            this.bEdit.Size = new System.Drawing.Size(131, 41);
            this.bEdit.TabIndex = 35;
            this.bEdit.Text = "Редагувати";
            this.bEdit.UseVisualStyleBackColor = true;
            this.bEdit.Click += new System.EventHandler(this.bEdit_Click);
            // 
            // qbox
            // 
            this.qbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.qbox.FormattingEnabled = true;
            this.qbox.Location = new System.Drawing.Point(206, 25);
            this.qbox.Name = "qbox";
            this.qbox.Size = new System.Drawing.Size(233, 21);
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
            this.panel2.Location = new System.Drawing.Point(41, 83);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(667, 377);
            this.panel2.TabIndex = 31;
            // 
            // bSaveQuestion
            // 
            this.bSaveQuestion.Location = new System.Drawing.Point(246, 320);
            this.bSaveQuestion.Name = "bSaveQuestion";
            this.bSaveQuestion.Size = new System.Drawing.Size(131, 41);
            this.bSaveQuestion.TabIndex = 34;
            this.bSaveQuestion.Text = "Зберегти питання";
            this.bSaveQuestion.UseVisualStyleBackColor = true;
            this.bSaveQuestion.Click += new System.EventHandler(this.bSaveQuestion_Click);
            // 
            // rb4
            // 
            this.rb4.AutoSize = true;
            this.rb4.Location = new System.Drawing.Point(75, 282);
            this.rb4.Name = "rb4";
            this.rb4.Size = new System.Drawing.Size(40, 17);
            this.rb4.TabIndex = 37;
            this.rb4.TabStop = true;
            this.rb4.Text = "rb4";
            this.rb4.UseVisualStyleBackColor = true;
            // 
            // rb3
            // 
            this.rb3.AutoSize = true;
            this.rb3.Location = new System.Drawing.Point(75, 254);
            this.rb3.Name = "rb3";
            this.rb3.Size = new System.Drawing.Size(40, 17);
            this.rb3.TabIndex = 36;
            this.rb3.TabStop = true;
            this.rb3.Text = "rb3";
            this.rb3.UseVisualStyleBackColor = true;
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Location = new System.Drawing.Point(75, 228);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(40, 17);
            this.rb2.TabIndex = 35;
            this.rb2.TabStop = true;
            this.rb2.Text = "rb2";
            this.rb2.UseVisualStyleBackColor = true;
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Location = new System.Drawing.Point(75, 202);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(40, 17);
            this.rb1.TabIndex = 34;
            this.rb1.TabStop = true;
            this.rb1.Text = "rb1";
            this.rb1.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(174, 282);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(417, 20);
            this.textBox4.TabIndex = 33;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(174, 256);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(417, 20);
            this.textBox3.TabIndex = 32;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(174, 230);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(417, 20);
            this.textBox2.TabIndex = 31;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(174, 204);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(417, 20);
            this.textBox1.TabIndex = 30;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(75, 36);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(516, 140);
            this.richTextBox1.TabIndex = 29;
            this.richTextBox1.Text = "";
            // 
            // bSaveAs
            // 
            this.bSaveAs.Location = new System.Drawing.Point(577, 466);
            this.bSaveAs.Name = "bSaveAs";
            this.bSaveAs.Size = new System.Drawing.Size(131, 41);
            this.bSaveAs.TabIndex = 19;
            this.bSaveAs.Text = "Зберегти як..";
            this.bSaveAs.UseVisualStyleBackColor = true;
            this.bSaveAs.Click += new System.EventHandler(this.bSaveAs_Click);
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(422, 466);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(131, 41);
            this.bSave.TabIndex = 18;
            this.bSave.Text = "Зберегти";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // bBack
            // 
            this.bBack.Location = new System.Drawing.Point(611, 21);
            this.bBack.Name = "bBack";
            this.bBack.Size = new System.Drawing.Size(131, 41);
            this.bBack.TabIndex = 16;
            this.bBack.Text = "Назад";
            this.bBack.UseVisualStyleBackColor = true;
            // 
            // bCreate
            // 
            this.bCreate.Location = new System.Drawing.Point(234, 21);
            this.bCreate.Name = "bCreate";
            this.bCreate.Size = new System.Drawing.Size(131, 41);
            this.bCreate.TabIndex = 17;
            this.bCreate.Text = "Створити новий тест";
            this.bCreate.UseVisualStyleBackColor = true;
            this.bCreate.Click += new System.EventHandler(this.bCreate_Click);
            // 
            // bExport
            // 
            this.bExport.Location = new System.Drawing.Point(41, 466);
            this.bExport.Name = "bExport";
            this.bExport.Size = new System.Drawing.Size(131, 41);
            this.bExport.TabIndex = 18;
            this.bExport.Text = "Експорт в Word-файл";
            this.bExport.UseVisualStyleBackColor = true;
            this.bExport.Click += new System.EventHandler(this.bExport_Click);
            // 
            // EditTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 609);
            this.Controls.Add(this.bCreate);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bOpen);
            this.Controls.Add(this.bBack);
            this.Name = "EditTestForm";
            this.Text = "EditTestForm";
            this.Load += new System.EventHandler(this.EditTestForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bOpen;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bSaveAs;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Button bBack;
        private System.Windows.Forms.Button bCreate;
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
    }
}