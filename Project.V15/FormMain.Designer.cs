namespace Project.V15
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panel1 = new Panel();
            buttonHelp_ANR = new Button();
            buttonInfo_ANR = new Button();
            buttonSaveFile_ANR = new Button();
            buttonCreateTable_ANR = new Button();
            buttonSearch_ANR = new Button();
            buttonCreateChart_ANR = new Button();
            buttonOpenFile_ANR = new Button();
            splitter1 = new Splitter();
            panel2 = new Panel();
            groupBox1 = new GroupBox();
            buttonDone_ANR = new Button();
            textBox6 = new TextBox();
            textBox4 = new TextBox();
            textBoxMaxLen_ANR = new TextBox();
            textBox3 = new TextBox();
            textBoxMinLen_ANR = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            splitter2 = new Splitter();
            panel3 = new Panel();
            groupBoxViewTable_ANR = new GroupBox();
            dataGridView1 = new DataGridView();
            ColumnName = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            toolTip = new ToolTip(components);
            saveFileDialogTask = new SaveFileDialog();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            panel3.SuspendLayout();
            groupBoxViewTable_ANR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuBar;
            panel1.Controls.Add(buttonHelp_ANR);
            panel1.Controls.Add(buttonInfo_ANR);
            panel1.Controls.Add(buttonSaveFile_ANR);
            panel1.Controls.Add(buttonCreateTable_ANR);
            panel1.Controls.Add(buttonSearch_ANR);
            panel1.Controls.Add(buttonCreateChart_ANR);
            panel1.Controls.Add(buttonOpenFile_ANR);
            panel1.Controls.Add(splitter1);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(927, 61);
            panel1.TabIndex = 0;
            // 
            // buttonHelp_ANR
            // 
            buttonHelp_ANR.Image = (Image)resources.GetObject("buttonHelp_ANR.Image");
            buttonHelp_ANR.Location = new Point(785, 7);
            buttonHelp_ANR.Name = "buttonHelp_ANR";
            buttonHelp_ANR.Size = new Size(59, 44);
            buttonHelp_ANR.TabIndex = 8;
            toolTip.SetToolTip(buttonHelp_ANR, "Помощь");
            buttonHelp_ANR.UseVisualStyleBackColor = true;
            buttonHelp_ANR.Click += buttonHelp_ANR_Click;
            // 
            // buttonInfo_ANR
            // 
            buttonInfo_ANR.Image = (Image)resources.GetObject("buttonInfo_ANR.Image");
            buttonInfo_ANR.Location = new Point(860, 7);
            buttonInfo_ANR.Name = "buttonInfo_ANR";
            buttonInfo_ANR.Size = new Size(55, 44);
            buttonInfo_ANR.TabIndex = 7;
            toolTip.SetToolTip(buttonInfo_ANR, "О программе");
            buttonInfo_ANR.UseVisualStyleBackColor = true;
            buttonInfo_ANR.Click += buttonInfo_ANR_Click;
            // 
            // buttonSaveFile_ANR
            // 
            buttonSaveFile_ANR.Image = (Image)resources.GetObject("buttonSaveFile_ANR.Image");
            buttonSaveFile_ANR.Location = new Point(307, 7);
            buttonSaveFile_ANR.Name = "buttonSaveFile_ANR";
            buttonSaveFile_ANR.Size = new Size(58, 45);
            buttonSaveFile_ANR.TabIndex = 6;
            toolTip.SetToolTip(buttonSaveFile_ANR, "Сохранить файл");
            buttonSaveFile_ANR.UseVisualStyleBackColor = true;
            // 
            // buttonCreateTable_ANR
            // 
            buttonCreateTable_ANR.Image = (Image)resources.GetObject("buttonCreateTable_ANR.Image");
            buttonCreateTable_ANR.Location = new Point(87, 7);
            buttonCreateTable_ANR.Name = "buttonCreateTable_ANR";
            buttonCreateTable_ANR.Size = new Size(58, 44);
            buttonCreateTable_ANR.TabIndex = 5;
            toolTip.SetToolTip(buttonCreateTable_ANR, "Создать таблицу");
            buttonCreateTable_ANR.UseVisualStyleBackColor = true;
            buttonCreateTable_ANR.Click += buttonCreateTable_ANR_Click;
            // 
            // buttonSearch_ANR
            // 
            buttonSearch_ANR.Image = (Image)resources.GetObject("buttonSearch_ANR.Image");
            buttonSearch_ANR.Location = new Point(233, 7);
            buttonSearch_ANR.Name = "buttonSearch_ANR";
            buttonSearch_ANR.Size = new Size(56, 45);
            buttonSearch_ANR.TabIndex = 4;
            toolTip.SetToolTip(buttonSearch_ANR, "Найти работника");
            buttonSearch_ANR.UseVisualStyleBackColor = true;
            // 
            // buttonCreateChart_ANR
            // 
            buttonCreateChart_ANR.Image = (Image)resources.GetObject("buttonCreateChart_ANR.Image");
            buttonCreateChart_ANR.Location = new Point(160, 7);
            buttonCreateChart_ANR.Name = "buttonCreateChart_ANR";
            buttonCreateChart_ANR.Size = new Size(57, 44);
            buttonCreateChart_ANR.TabIndex = 3;
            toolTip.SetToolTip(buttonCreateChart_ANR, "Создать график");
            buttonCreateChart_ANR.UseVisualStyleBackColor = true;
            buttonCreateChart_ANR.Click += buttonCreateChart_ANR_Click;
            // 
            // buttonOpenFile_ANR
            // 
            buttonOpenFile_ANR.Image = (Image)resources.GetObject("buttonOpenFile_ANR.Image");
            buttonOpenFile_ANR.Location = new Point(12, 7);
            buttonOpenFile_ANR.Name = "buttonOpenFile_ANR";
            buttonOpenFile_ANR.Size = new Size(59, 45);
            buttonOpenFile_ANR.TabIndex = 2;
            toolTip.SetToolTip(buttonOpenFile_ANR, "Открыть файл");
            buttonOpenFile_ANR.UseVisualStyleBackColor = true;
            buttonOpenFile_ANR.Click += buttonOpenFile_ANR_Click;
            // 
            // splitter1
            // 
            splitter1.Dock = DockStyle.Bottom;
            splitter1.Location = new Point(0, 57);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(927, 4);
            splitter1.TabIndex = 0;
            splitter1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightBlue;
            panel2.Controls.Add(groupBox1);
            panel2.Controls.Add(splitter2);
            panel2.Location = new Point(485, 59);
            panel2.Name = "panel2";
            panel2.Size = new Size(442, 567);
            panel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.GradientInactiveCaption;
            groupBox1.Controls.Add(buttonDone_ANR);
            groupBox1.Controls.Add(textBox6);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBoxMaxLen_ANR);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBoxMinLen_ANR);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(chart1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(4, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(438, 567);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Сроки действия трудовых договоров:";
            // 
            // buttonDone_ANR
            // 
            buttonDone_ANR.Location = new Point(246, 504);
            buttonDone_ANR.Name = "buttonDone_ANR";
            buttonDone_ANR.Size = new Size(158, 43);
            buttonDone_ANR.TabIndex = 10;
            buttonDone_ANR.Text = "Выполнить";
            buttonDone_ANR.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(21, 520);
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new Size(170, 27);
            textBox6.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.GradientInactiveCaption;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Location = new Point(21, 468);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(196, 48);
            textBox4.TabIndex = 7;
            textBox4.Text = "Средний срок действия трудового договора:";
            // 
            // textBoxMaxLen_ANR
            // 
            textBoxMaxLen_ANR.Location = new Point(243, 426);
            textBoxMaxLen_ANR.Name = "textBoxMaxLen_ANR";
            textBoxMaxLen_ANR.ReadOnly = true;
            textBoxMaxLen_ANR.Size = new Size(161, 27);
            textBoxMaxLen_ANR.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.GradientInactiveCaption;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Location = new Point(243, 378);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(161, 42);
            textBox3.TabIndex = 5;
            textBox3.Text = "Max срок действия трудового договора:";
            // 
            // textBoxMinLen_ANR
            // 
            textBoxMinLen_ANR.Location = new Point(21, 426);
            textBoxMinLen_ANR.Name = "textBoxMinLen_ANR";
            textBoxMinLen_ANR.ReadOnly = true;
            textBoxMinLen_ANR.Size = new Size(170, 27);
            textBoxMinLen_ANR.TabIndex = 4;
            textBoxMinLen_ANR.TextChanged += textBoxMinLen_ANR_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.GradientInactiveCaption;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Location = new Point(21, 378);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(170, 42);
            textBox2.TabIndex = 3;
            textBox2.Text = "Min срок действия трудового договора:";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.GradientInactiveCaption;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(21, 341);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(116, 20);
            textBox1.TabIndex = 2;
            textBox1.Text = "Статистика:";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(21, 26);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(404, 297);
            chart1.TabIndex = 1;
            chart1.Text = "chart1";
            // 
            // splitter2
            // 
            splitter2.Location = new Point(0, 0);
            splitter2.Name = "splitter2";
            splitter2.Size = new Size(4, 567);
            splitter2.TabIndex = 0;
            splitter2.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.InactiveCaption;
            panel3.Controls.Add(groupBoxViewTable_ANR);
            panel3.Location = new Point(0, 59);
            panel3.Name = "panel3";
            panel3.Size = new Size(486, 567);
            panel3.TabIndex = 2;
            // 
            // groupBoxViewTable_ANR
            // 
            groupBoxViewTable_ANR.BackColor = SystemColors.GradientInactiveCaption;
            groupBoxViewTable_ANR.Controls.Add(dataGridView1);
            groupBoxViewTable_ANR.Dock = DockStyle.Fill;
            groupBoxViewTable_ANR.Font = new Font("Segoe UI", 9F);
            groupBoxViewTable_ANR.ForeColor = SystemColors.ActiveCaptionText;
            groupBoxViewTable_ANR.Location = new Point(0, 0);
            groupBoxViewTable_ANR.Name = "groupBoxViewTable_ANR";
            groupBoxViewTable_ANR.Size = new Size(486, 567);
            groupBoxViewTable_ANR.TabIndex = 0;
            groupBoxViewTable_ANR.TabStop = false;
            groupBoxViewTable_ANR.Text = "Общая информация о работниках компании:";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.InactiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColumnName, Column2 });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.GridColor = Color.DarkGray;
            dataGridView1.Location = new Point(3, 23);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(480, 541);
            dataGridView1.TabIndex = 0;
            // 
            // ColumnName
            // 
            ColumnName.HeaderText = "Наименование организации:";
            ColumnName.MinimumWidth = 6;
            ColumnName.Name = "ColumnName";
            ColumnName.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(927, 629);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormMain";
            Text = "Главная страница";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            panel3.ResumeLayout(false);
            groupBoxViewTable_ANR.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Splitter splitter1;
        private Splitter splitter2;
        private Button buttonOpenFile_ANR;
        private GroupBox groupBoxViewTable_ANR;
        private DataGridView dataGridView1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private GroupBox groupBox1;
        private DataGridViewTextBoxColumn ColumnName;
        private DataGridViewTextBoxColumn Column2;
        private ToolTip toolTip;
        private Button buttonCreateChart_ANR;
        private Button buttonSearch_ANR;
        private Button buttonCreateTable_ANR;
        private Button buttonSaveFile_ANR;
        private TextBox textBoxMinLen_ANR;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button buttonInfo_ANR;
        private TextBox textBox3;
        private TextBox textBoxMaxLen_ANR;
        private TextBox textBox4;
        private TextBox textBox6;
        private Button buttonDone_ANR;
        private SaveFileDialog saveFileDialogTask;
        private Button buttonHelp_ANR;
    }
}
