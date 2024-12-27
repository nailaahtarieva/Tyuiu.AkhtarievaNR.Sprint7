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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            textBoxSrLen_ANR = new TextBox();
            textBox4 = new TextBox();
            textBoxMaxLen_ANR = new TextBox();
            textBox3 = new TextBox();
            textBoxMinLen_ANR = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            chartContract_ANR = new System.Windows.Forms.DataVisualization.Charting.Chart();
            splitter2 = new Splitter();
            panel3 = new Panel();
            groupBoxViewTable_ANR = new GroupBox();
            dataGridViewTable_ANR = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            toolTip = new ToolTip(components);
            saveFileDialogTask = new SaveFileDialog();
            openFileDialogTask = new OpenFileDialog();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartContract_ANR).BeginInit();
            panel3.SuspendLayout();
            groupBoxViewTable_ANR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTable_ANR).BeginInit();
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
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(927, 61);
            panel1.TabIndex = 0;
            // 
            // buttonHelp_ANR
            // 
            buttonHelp_ANR.Anchor = AnchorStyles.Top | AnchorStyles.Right;
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
            buttonInfo_ANR.Anchor = AnchorStyles.Top | AnchorStyles.Right;
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
            buttonSaveFile_ANR.Enabled = false;
            buttonSaveFile_ANR.Image = (Image)resources.GetObject("buttonSaveFile_ANR.Image");
            buttonSaveFile_ANR.Location = new Point(307, 7);
            buttonSaveFile_ANR.Name = "buttonSaveFile_ANR";
            buttonSaveFile_ANR.Size = new Size(58, 45);
            buttonSaveFile_ANR.TabIndex = 6;
            toolTip.SetToolTip(buttonSaveFile_ANR, "Сохранить файл");
            buttonSaveFile_ANR.UseVisualStyleBackColor = true;
            buttonSaveFile_ANR.Click += buttonSaveFile_ANR_Click;
            // 
            // buttonCreateTable_ANR
            // 
            buttonCreateTable_ANR.Enabled = false;
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
            buttonSearch_ANR.Click += buttonSearch_ANR_Click;
            // 
            // buttonCreateChart_ANR
            // 
            buttonCreateChart_ANR.Enabled = false;
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
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(485, 61);
            panel2.Name = "panel2";
            panel2.Size = new Size(442, 568);
            panel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.BackColor = SystemColors.GradientInactiveCaption;
            groupBox1.Controls.Add(buttonDone_ANR);
            groupBox1.Controls.Add(textBoxSrLen_ANR);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBoxMaxLen_ANR);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBoxMinLen_ANR);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(chartContract_ANR);
            groupBox1.Location = new Point(4, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(438, 568);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Сроки действия трудовых договоров:";
            // 
            // buttonDone_ANR
            // 
            buttonDone_ANR.Enabled = false;
            buttonDone_ANR.Location = new Point(246, 504);
            buttonDone_ANR.Name = "buttonDone_ANR";
            buttonDone_ANR.Size = new Size(158, 43);
            buttonDone_ANR.TabIndex = 10;
            buttonDone_ANR.Text = "Выполнить";
            buttonDone_ANR.UseVisualStyleBackColor = true;
            buttonDone_ANR.Click += buttonDone_ANR_Click;
            // 
            // textBoxSrLen_ANR
            // 
            textBoxSrLen_ANR.Location = new Point(21, 520);
            textBoxSrLen_ANR.Name = "textBoxSrLen_ANR";
            textBoxSrLen_ANR.ReadOnly = true;
            textBoxSrLen_ANR.Size = new Size(170, 27);
            textBoxSrLen_ANR.TabIndex = 9;
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
            // chartContract_ANR
            // 
            chartArea2.Name = "ChartArea1";
            chartContract_ANR.ChartAreas.Add(chartArea2);
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            chartContract_ANR.Legends.Add(legend2);
            chartContract_ANR.Location = new Point(21, 26);
            chartContract_ANR.Name = "chartContract_ANR";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartContract_ANR.Series.Add(series2);
            chartContract_ANR.Size = new Size(404, 297);
            chartContract_ANR.TabIndex = 1;
            chartContract_ANR.Text = "chart1";
            // 
            // splitter2
            // 
            splitter2.Location = new Point(0, 0);
            splitter2.Name = "splitter2";
            splitter2.Size = new Size(4, 568);
            splitter2.TabIndex = 0;
            splitter2.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.InactiveCaption;
            panel3.Controls.Add(groupBoxViewTable_ANR);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 61);
            panel3.Name = "panel3";
            panel3.Size = new Size(485, 568);
            panel3.TabIndex = 2;
            // 
            // groupBoxViewTable_ANR
            // 
            groupBoxViewTable_ANR.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxViewTable_ANR.BackColor = SystemColors.GradientInactiveCaption;
            groupBoxViewTable_ANR.Controls.Add(dataGridViewTable_ANR);
            groupBoxViewTable_ANR.Font = new Font("Segoe UI", 9F);
            groupBoxViewTable_ANR.ForeColor = SystemColors.ActiveCaptionText;
            groupBoxViewTable_ANR.Location = new Point(0, 0);
            groupBoxViewTable_ANR.Name = "groupBoxViewTable_ANR";
            groupBoxViewTable_ANR.Size = new Size(485, 568);
            groupBoxViewTable_ANR.TabIndex = 0;
            groupBoxViewTable_ANR.TabStop = false;
            groupBoxViewTable_ANR.Text = "Общая информация о работниках компании:";
            // 
            // dataGridViewTable_ANR
            // 
            dataGridViewTable_ANR.BackgroundColor = SystemColors.InactiveCaption;
            dataGridViewTable_ANR.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTable_ANR.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column8, Column6, Column7, Column9 });
            dataGridViewTable_ANR.Dock = DockStyle.Fill;
            dataGridViewTable_ANR.GridColor = Color.DarkGray;
            dataGridViewTable_ANR.Location = new Point(3, 23);
            dataGridViewTable_ANR.Name = "dataGridViewTable_ANR";
            dataGridViewTable_ANR.RowHeadersVisible = false;
            dataGridViewTable_ANR.RowHeadersWidth = 51;
            dataGridViewTable_ANR.Size = new Size(479, 542);
            dataGridViewTable_ANR.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "Full name";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 300;
            // 
            // Column2
            // 
            Column2.HeaderText = "Adress";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 300;
            // 
            // Column3
            // 
            Column3.HeaderText = "Phone number";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Function";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Salary";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // Column8
            // 
            Column8.HeaderText = "Currency";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.Width = 125;
            // 
            // Column6
            // 
            Column6.HeaderText = "№ of contract";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 125;
            // 
            // Column7
            // 
            Column7.HeaderText = "Validity period of the TD";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Width = 125;
            // 
            // Column9
            // 
            Column9.HeaderText = "Years";
            Column9.MinimumWidth = 6;
            Column9.Name = "Column9";
            Column9.Width = 125;
            // 
            // openFileDialogTask
            // 
            openFileDialogTask.FileName = "openFileDialogTask";
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
            Load += FormMain_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartContract_ANR).EndInit();
            panel3.ResumeLayout(false);
            groupBoxViewTable_ANR.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewTable_ANR).EndInit();
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
        private DataGridView dataGridViewTable_ANR;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartContract_ANR;
        private GroupBox groupBox1;
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
        private TextBox textBoxSrLen_ANR;
        private Button buttonDone_ANR;
        private SaveFileDialog saveFileDialogTask;
        private Button buttonHelp_ANR;
        private OpenFileDialog openFileDialogTask;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column9;
    }
}
