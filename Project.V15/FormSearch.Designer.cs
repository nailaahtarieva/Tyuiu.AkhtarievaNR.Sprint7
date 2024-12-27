namespace Project.V15
{
    partial class FormSearch
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
            groupBox1 = new GroupBox();
            textBoxNumber_ANR = new TextBox();
            textBox1 = new TextBox();
            groupBox2 = new GroupBox();
            textBoxRub_ANR = new TextBox();
            buttonOpen_ANR = new Button();
            buttonSearch_ANR = new Button();
            buttonClose_ANR = new Button();
            textBoxValidity_ANR = new TextBox();
            textBoxSalary_ANR = new TextBox();
            textBoxFunction_ANR = new TextBox();
            textBoxPhone_ANR = new TextBox();
            textBoxAdress_ANR = new TextBox();
            textBoxFullName_ANR = new TextBox();
            textBox8 = new TextBox();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            openFileDialog_ANR = new OpenFileDialog();
            textBoxYears_ANR = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxNumber_ANR);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(569, 80);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Введите номер трудового договора";
            // 
            // textBoxNumber_ANR
            // 
            textBoxNumber_ANR.Location = new Point(238, 35);
            textBoxNumber_ANR.Name = "textBoxNumber_ANR";
            textBoxNumber_ANR.Size = new Size(220, 27);
            textBoxNumber_ANR.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.MenuBar;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(21, 37);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(210, 20);
            textBox1.TabIndex = 0;
            textBox1.Text = "Номер трудового договора:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBoxYears_ANR);
            groupBox2.Controls.Add(textBoxRub_ANR);
            groupBox2.Controls.Add(buttonOpen_ANR);
            groupBox2.Controls.Add(buttonSearch_ANR);
            groupBox2.Controls.Add(buttonClose_ANR);
            groupBox2.Controls.Add(textBoxValidity_ANR);
            groupBox2.Controls.Add(textBoxSalary_ANR);
            groupBox2.Controls.Add(textBoxFunction_ANR);
            groupBox2.Controls.Add(textBoxPhone_ANR);
            groupBox2.Controls.Add(textBoxAdress_ANR);
            groupBox2.Controls.Add(textBoxFullName_ANR);
            groupBox2.Controls.Add(textBox8);
            groupBox2.Controls.Add(textBox7);
            groupBox2.Controls.Add(textBox6);
            groupBox2.Controls.Add(textBox5);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 80);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(569, 484);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Данные сотрудника";
            // 
            // textBoxRub_ANR
            // 
            textBoxRub_ANR.BackColor = SystemColors.MenuBar;
            textBoxRub_ANR.BorderStyle = BorderStyle.None;
            textBoxRub_ANR.Location = new Point(475, 262);
            textBoxRub_ANR.Name = "textBoxRub_ANR";
            textBoxRub_ANR.Size = new Size(82, 20);
            textBoxRub_ANR.TabIndex = 15;
            // 
            // buttonOpen_ANR
            // 
            buttonOpen_ANR.Location = new Point(21, 412);
            buttonOpen_ANR.Name = "buttonOpen_ANR";
            buttonOpen_ANR.Size = new Size(111, 50);
            buttonOpen_ANR.TabIndex = 14;
            buttonOpen_ANR.Text = "Открыть файл";
            buttonOpen_ANR.UseVisualStyleBackColor = true;
            buttonOpen_ANR.Click += buttonOpen_ANR_Click;
            // 
            // buttonSearch_ANR
            // 
            buttonSearch_ANR.Location = new Point(153, 412);
            buttonSearch_ANR.Name = "buttonSearch_ANR";
            buttonSearch_ANR.Size = new Size(105, 50);
            buttonSearch_ANR.TabIndex = 13;
            buttonSearch_ANR.Text = "Поиск";
            buttonSearch_ANR.UseVisualStyleBackColor = true;
            buttonSearch_ANR.Click += buttonSearch_ANR_Click;
            // 
            // buttonClose_ANR
            // 
            buttonClose_ANR.Location = new Point(448, 412);
            buttonClose_ANR.Name = "buttonClose_ANR";
            buttonClose_ANR.Size = new Size(109, 50);
            buttonClose_ANR.TabIndex = 12;
            buttonClose_ANR.Text = "Закрыть";
            buttonClose_ANR.UseVisualStyleBackColor = true;
            buttonClose_ANR.Click += buttonClose_ANR_Click;
            // 
            // textBoxValidity_ANR
            // 
            textBoxValidity_ANR.Location = new Point(180, 323);
            textBoxValidity_ANR.Name = "textBoxValidity_ANR";
            textBoxValidity_ANR.Size = new Size(278, 27);
            textBoxValidity_ANR.TabIndex = 11;
            // 
            // textBoxSalary_ANR
            // 
            textBoxSalary_ANR.Location = new Point(180, 262);
            textBoxSalary_ANR.Name = "textBoxSalary_ANR";
            textBoxSalary_ANR.Size = new Size(278, 27);
            textBoxSalary_ANR.TabIndex = 10;
            // 
            // textBoxFunction_ANR
            // 
            textBoxFunction_ANR.Location = new Point(180, 203);
            textBoxFunction_ANR.Name = "textBoxFunction_ANR";
            textBoxFunction_ANR.Size = new Size(278, 27);
            textBoxFunction_ANR.TabIndex = 9;
            // 
            // textBoxPhone_ANR
            // 
            textBoxPhone_ANR.Location = new Point(180, 151);
            textBoxPhone_ANR.Name = "textBoxPhone_ANR";
            textBoxPhone_ANR.Size = new Size(278, 27);
            textBoxPhone_ANR.TabIndex = 8;
            // 
            // textBoxAdress_ANR
            // 
            textBoxAdress_ANR.Location = new Point(180, 96);
            textBoxAdress_ANR.Name = "textBoxAdress_ANR";
            textBoxAdress_ANR.Size = new Size(278, 27);
            textBoxAdress_ANR.TabIndex = 7;
            // 
            // textBoxFullName_ANR
            // 
            textBoxFullName_ANR.Location = new Point(180, 41);
            textBoxFullName_ANR.Name = "textBoxFullName_ANR";
            textBoxFullName_ANR.Size = new Size(278, 27);
            textBoxFullName_ANR.TabIndex = 6;
            // 
            // textBox8
            // 
            textBox8.BackColor = SystemColors.MenuBar;
            textBox8.BorderStyle = BorderStyle.None;
            textBox8.Location = new Point(21, 326);
            textBox8.Multiline = true;
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(143, 71);
            textBox8.TabIndex = 5;
            textBox8.Text = "Срок действия трудового договора:";
            // 
            // textBox7
            // 
            textBox7.BackColor = SystemColors.MenuBar;
            textBox7.BorderStyle = BorderStyle.None;
            textBox7.Location = new Point(21, 269);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(143, 20);
            textBox7.TabIndex = 4;
            textBox7.Text = "Оклад:";
            // 
            // textBox6
            // 
            textBox6.BackColor = SystemColors.MenuBar;
            textBox6.BorderStyle = BorderStyle.None;
            textBox6.Location = new Point(21, 210);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(143, 20);
            textBox6.TabIndex = 3;
            textBox6.Text = "Должность:";
            // 
            // textBox5
            // 
            textBox5.BackColor = SystemColors.MenuBar;
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Location = new Point(21, 158);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(143, 20);
            textBox5.TabIndex = 2;
            textBox5.Text = "Номер телефона:";
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.MenuBar;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Location = new Point(21, 103);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(143, 20);
            textBox4.TabIndex = 1;
            textBox4.Text = "Адрес сотрудника:";
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.MenuBar;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Location = new Point(21, 48);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(143, 20);
            textBox3.TabIndex = 0;
            textBox3.Text = "ФИО сотрудника:";
            // 
            // openFileDialog_ANR
            // 
            openFileDialog_ANR.FileName = "openFileDialog_ANR";
            // 
            // textBoxYears_ANR
            // 
            textBoxYears_ANR.BackColor = SystemColors.MenuBar;
            textBoxYears_ANR.BorderStyle = BorderStyle.None;
            textBoxYears_ANR.Location = new Point(475, 323);
            textBoxYears_ANR.Name = "textBoxYears_ANR";
            textBoxYears_ANR.Size = new Size(82, 20);
            textBoxYears_ANR.TabIndex = 17;
            // 
            // FormSearch
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(569, 564);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormSearch";
            Text = "Поиск сотрудника";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox textBoxNumber_ANR;
        private TextBox textBox1;
        private TextBox textBox8;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBoxFullName_ANR;
        private TextBox textBoxPhone_ANR;
        private TextBox textBoxAdress_ANR;
        private TextBox textBoxFunction_ANR;
        private Button buttonOpen_ANR;
        private Button buttonSearch_ANR;
        private Button buttonClose_ANR;
        private TextBox textBoxValidity_ANR;
        private TextBox textBoxSalary_ANR;
        private OpenFileDialog openFileDialog_ANR;
        private TextBox textBoxRub_ANR;
        private TextBox textBoxYears_ANR;
    }
}