namespace LunarCalendar
{
    partial class Main
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            mainTabControl = new TabControl();
            dayCalendarTabPage = new TabPage();
            dayCalendarTableLayoutPanel = new TableLayoutPanel();
            lunarDayCalendar = new LunarDayCalendar();
            dayCalendarControlPanel = new Panel();
            errorLabel = new Label();
            todayButton = new Button();
            nextDateButton = new Button();
            previousDateButton = new Button();
            lunarDayComboBox = new ComboBox();
            solarDayComboBox = new ComboBox();
            lunarYearLabel = new Label();
            solarYearLabel = new Label();
            lunarMonthComboBox = new ComboBox();
            solarMonthComboBox = new ComboBox();
            lunarMonthLabel = new Label();
            solarMonthLabel = new Label();
            lunarDayLabel = new Label();
            solarDayLabel = new Label();
            lunarYearTextBox = new TextBox();
            solarYearTextBox = new TextBox();
            lunarCalendarRadioButton = new RadioButton();
            solarCalendarRadioButton = new RadioButton();
            monthCalendarTabPage = new TabPage();
            tableLayoutPanel2 = new TableLayoutPanel();
            lunarMonthCalendar = new LunarMonthCalendar();
            monthCalendarControlPanel = new Panel();
            yearTextBox = new TextBox();
            yearLabel = new Label();
            thisMonthButton = new Button();
            monthComboBox = new ComboBox();
            nextMonthButton = new Button();
            previousMonthButton = new Button();
            monthLabel = new Label();
            toolTip1 = new ToolTip(components);
            mainTabControl.SuspendLayout();
            dayCalendarTabPage.SuspendLayout();
            dayCalendarTableLayoutPanel.SuspendLayout();
            dayCalendarControlPanel.SuspendLayout();
            monthCalendarTabPage.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            monthCalendarControlPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainTabControl
            // 
            mainTabControl.Controls.Add(dayCalendarTabPage);
            mainTabControl.Controls.Add(monthCalendarTabPage);
            mainTabControl.Dock = DockStyle.Fill;
            mainTabControl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            mainTabControl.Location = new Point(0, 0);
            mainTabControl.Margin = new Padding(4, 3, 4, 3);
            mainTabControl.Multiline = true;
            mainTabControl.Name = "mainTabControl";
            mainTabControl.SelectedIndex = 0;
            mainTabControl.Size = new Size(784, 561);
            mainTabControl.TabIndex = 6;
            // 
            // dayCalendarTabPage
            // 
            dayCalendarTabPage.Controls.Add(dayCalendarTableLayoutPanel);
            dayCalendarTabPage.Location = new Point(4, 29);
            dayCalendarTabPage.Margin = new Padding(4, 3, 4, 3);
            dayCalendarTabPage.Name = "dayCalendarTabPage";
            dayCalendarTabPage.Padding = new Padding(4, 3, 4, 3);
            dayCalendarTabPage.Size = new Size(776, 528);
            dayCalendarTabPage.TabIndex = 0;
            dayCalendarTabPage.Text = "Lịch ngày";
            dayCalendarTabPage.UseVisualStyleBackColor = true;
            // 
            // dayCalendarTableLayoutPanel
            // 
            dayCalendarTableLayoutPanel.ColumnCount = 2;
            dayCalendarTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            dayCalendarTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            dayCalendarTableLayoutPanel.Controls.Add(dayCalendarControlPanel, 0, 0);
            dayCalendarTableLayoutPanel.Controls.Add(lunarDayCalendar, 1, 0);
            dayCalendarTableLayoutPanel.Dock = DockStyle.Fill;
            dayCalendarTableLayoutPanel.Location = new Point(4, 3);
            dayCalendarTableLayoutPanel.Name = "dayCalendarTableLayoutPanel";
            dayCalendarTableLayoutPanel.RowCount = 1;
            dayCalendarTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            dayCalendarTableLayoutPanel.Size = new Size(768, 522);
            dayCalendarTableLayoutPanel.TabIndex = 0;
            // 
            // lunarDayCalendar
            // 
            lunarDayCalendar.BackgroundImage = (Image)resources.GetObject("lunarDayCalendar.BackgroundImage");
            lunarDayCalendar.BackgroundImageLayout = ImageLayout.Stretch;
            lunarDayCalendar.Dock = DockStyle.Fill;
            lunarDayCalendar.Location = new Point(311, 3);
            lunarDayCalendar.Margin = new Padding(4, 3, 4, 3);
            lunarDayCalendar.Name = "lunarDayCalendar";
            lunarDayCalendar.SelectedDate = new DateTime(2017, 3, 9, 0, 0, 0, 0);
            lunarDayCalendar.Size = new Size(453, 516);
            lunarDayCalendar.TabIndex = 1;
            lunarDayCalendar.SelectedDateChanged += LunarDayCalendar_SelectedDateChanged;
            // 
            // dayCalendarControlPanel
            // 
            dayCalendarControlPanel.Controls.Add(errorLabel);
            dayCalendarControlPanel.Controls.Add(todayButton);
            dayCalendarControlPanel.Controls.Add(nextDateButton);
            dayCalendarControlPanel.Controls.Add(previousDateButton);
            dayCalendarControlPanel.Controls.Add(lunarDayComboBox);
            dayCalendarControlPanel.Controls.Add(solarDayComboBox);
            dayCalendarControlPanel.Controls.Add(lunarYearLabel);
            dayCalendarControlPanel.Controls.Add(solarYearLabel);
            dayCalendarControlPanel.Controls.Add(lunarMonthComboBox);
            dayCalendarControlPanel.Controls.Add(solarMonthComboBox);
            dayCalendarControlPanel.Controls.Add(lunarMonthLabel);
            dayCalendarControlPanel.Controls.Add(solarMonthLabel);
            dayCalendarControlPanel.Controls.Add(lunarDayLabel);
            dayCalendarControlPanel.Controls.Add(solarDayLabel);
            dayCalendarControlPanel.Controls.Add(lunarYearTextBox);
            dayCalendarControlPanel.Controls.Add(solarYearTextBox);
            dayCalendarControlPanel.Controls.Add(lunarCalendarRadioButton);
            dayCalendarControlPanel.Controls.Add(solarCalendarRadioButton);
            dayCalendarControlPanel.Dock = DockStyle.Fill;
            dayCalendarControlPanel.Location = new Point(4, 3);
            dayCalendarControlPanel.Margin = new Padding(4, 3, 4, 3);
            dayCalendarControlPanel.Name = "dayCalendarControlPanel";
            dayCalendarControlPanel.Size = new Size(299, 516);
            dayCalendarControlPanel.TabIndex = 0;
            // 
            // errorLabel
            // 
            errorLabel.Dock = DockStyle.Bottom;
            errorLabel.ForeColor = Color.Red;
            errorLabel.Location = new Point(0, 462);
            errorLabel.Margin = new Padding(4, 0, 4, 0);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(299, 54);
            errorLabel.TabIndex = 0;
            errorLabel.Text = "Lỗi:";
            errorLabel.TextAlign = ContentAlignment.MiddleCenter;
            errorLabel.Visible = false;
            // 
            // todayButton
            // 
            todayButton.Cursor = Cursors.Hand;
            todayButton.Location = new Point(53, 410);
            todayButton.Margin = new Padding(4, 3, 4, 3);
            todayButton.Name = "todayButton";
            todayButton.Size = new Size(182, 35);
            todayButton.TabIndex = 10;
            todayButton.Text = "Hôm nay";
            todayButton.UseVisualStyleBackColor = true;
            todayButton.Click += TodayButton_Click;
            // 
            // nextDateButton
            // 
            nextDateButton.Cursor = Cursors.Hand;
            nextDateButton.Location = new Point(148, 369);
            nextDateButton.Margin = new Padding(4, 3, 4, 3);
            nextDateButton.Name = "nextDateButton";
            nextDateButton.Size = new Size(88, 35);
            nextDateButton.TabIndex = 9;
            nextDateButton.Text = "→";
            toolTip1.SetToolTip(nextDateButton, "Ngày sau");
            nextDateButton.UseVisualStyleBackColor = true;
            nextDateButton.Click += NextDateButton_Click;
            // 
            // previousDateButton
            // 
            previousDateButton.Cursor = Cursors.Hand;
            previousDateButton.Location = new Point(53, 369);
            previousDateButton.Margin = new Padding(4, 3, 4, 3);
            previousDateButton.Name = "previousDateButton";
            previousDateButton.Size = new Size(88, 35);
            previousDateButton.TabIndex = 8;
            previousDateButton.Text = "←";
            toolTip1.SetToolTip(previousDateButton, "Ngày trước");
            previousDateButton.UseVisualStyleBackColor = true;
            previousDateButton.Click += PreviousDateButton_Click;
            // 
            // lunarDayComboBox
            // 
            lunarDayComboBox.Cursor = Cursors.Hand;
            lunarDayComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            lunarDayComboBox.Enabled = false;
            lunarDayComboBox.FormattingEnabled = true;
            lunarDayComboBox.Location = new Point(105, 313);
            lunarDayComboBox.Margin = new Padding(4, 3, 4, 3);
            lunarDayComboBox.Name = "lunarDayComboBox";
            lunarDayComboBox.Size = new Size(116, 28);
            lunarDayComboBox.Sorted = true;
            lunarDayComboBox.TabIndex = 7;
            lunarDayComboBox.SelectedIndexChanged += LunarDayComboBox_SelectedIndexChanged;
            lunarDayComboBox.KeyPress += KeyPressControl;
            // 
            // solarDayComboBox
            // 
            solarDayComboBox.Cursor = Cursors.Hand;
            solarDayComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            solarDayComboBox.FormattingEnabled = true;
            solarDayComboBox.Location = new Point(105, 130);
            solarDayComboBox.Margin = new Padding(4, 3, 4, 3);
            solarDayComboBox.Name = "solarDayComboBox";
            solarDayComboBox.Size = new Size(116, 28);
            solarDayComboBox.Sorted = true;
            solarDayComboBox.TabIndex = 3;
            solarDayComboBox.SelectedIndexChanged += SolarDayComboBox_SelectedIndexChanged;
            solarDayComboBox.KeyPress += KeyPressControl;
            // 
            // lunarYearLabel
            // 
            lunarYearLabel.AutoSize = true;
            lunarYearLabel.Location = new Point(49, 239);
            lunarYearLabel.Margin = new Padding(4, 0, 4, 0);
            lunarYearLabel.Name = "lunarYearLabel";
            lunarYearLabel.Size = new Size(42, 20);
            lunarYearLabel.TabIndex = 0;
            lunarYearLabel.Text = "Năm";
            // 
            // solarYearLabel
            // 
            solarYearLabel.AutoSize = true;
            solarYearLabel.Location = new Point(49, 57);
            solarYearLabel.Margin = new Padding(4, 0, 4, 0);
            solarYearLabel.Name = "solarYearLabel";
            solarYearLabel.Size = new Size(42, 20);
            solarYearLabel.TabIndex = 0;
            solarYearLabel.Text = "Năm";
            // 
            // lunarMonthComboBox
            // 
            lunarMonthComboBox.Cursor = Cursors.Hand;
            lunarMonthComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            lunarMonthComboBox.Enabled = false;
            lunarMonthComboBox.FormattingEnabled = true;
            lunarMonthComboBox.Location = new Point(105, 274);
            lunarMonthComboBox.Margin = new Padding(4, 3, 4, 3);
            lunarMonthComboBox.Name = "lunarMonthComboBox";
            lunarMonthComboBox.Size = new Size(116, 28);
            lunarMonthComboBox.Sorted = true;
            lunarMonthComboBox.TabIndex = 6;
            lunarMonthComboBox.SelectedIndexChanged += LunarMonthComboBox_SelectedIndexChanged;
            lunarMonthComboBox.KeyPress += KeyPressControl;
            // 
            // solarMonthComboBox
            // 
            solarMonthComboBox.Cursor = Cursors.Hand;
            solarMonthComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            solarMonthComboBox.FormattingEnabled = true;
            solarMonthComboBox.Items.AddRange(new object[] { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12" });
            solarMonthComboBox.Location = new Point(105, 91);
            solarMonthComboBox.Margin = new Padding(4, 3, 4, 3);
            solarMonthComboBox.Name = "solarMonthComboBox";
            solarMonthComboBox.Size = new Size(116, 28);
            solarMonthComboBox.Sorted = true;
            solarMonthComboBox.TabIndex = 2;
            solarMonthComboBox.SelectedIndexChanged += SolarMonthComboBox_SelectedIndexChanged;
            solarMonthComboBox.KeyPress += KeyPressControl;
            // 
            // lunarMonthLabel
            // 
            lunarMonthLabel.AutoSize = true;
            lunarMonthLabel.Location = new Point(35, 277);
            lunarMonthLabel.Margin = new Padding(4, 0, 4, 0);
            lunarMonthLabel.Name = "lunarMonthLabel";
            lunarMonthLabel.Size = new Size(54, 20);
            lunarMonthLabel.TabIndex = 0;
            lunarMonthLabel.Text = "Tháng";
            // 
            // solarMonthLabel
            // 
            solarMonthLabel.AutoSize = true;
            solarMonthLabel.Location = new Point(35, 95);
            solarMonthLabel.Margin = new Padding(4, 0, 4, 0);
            solarMonthLabel.Name = "solarMonthLabel";
            solarMonthLabel.Size = new Size(54, 20);
            solarMonthLabel.TabIndex = 0;
            solarMonthLabel.Text = "Tháng";
            // 
            // lunarDayLabel
            // 
            lunarDayLabel.AutoSize = true;
            lunarDayLabel.Location = new Point(46, 316);
            lunarDayLabel.Margin = new Padding(4, 0, 4, 0);
            lunarDayLabel.Name = "lunarDayLabel";
            lunarDayLabel.Size = new Size(45, 20);
            lunarDayLabel.TabIndex = 0;
            lunarDayLabel.Text = "Ngày";
            // 
            // solarDayLabel
            // 
            solarDayLabel.AutoSize = true;
            solarDayLabel.Location = new Point(46, 134);
            solarDayLabel.Margin = new Padding(4, 0, 4, 0);
            solarDayLabel.Name = "solarDayLabel";
            solarDayLabel.Size = new Size(45, 20);
            solarDayLabel.TabIndex = 0;
            solarDayLabel.Text = "Ngày";
            // 
            // lunarYearTextBox
            // 
            lunarYearTextBox.Enabled = false;
            lunarYearTextBox.Location = new Point(105, 236);
            lunarYearTextBox.Margin = new Padding(4, 3, 4, 3);
            lunarYearTextBox.MaxLength = 4;
            lunarYearTextBox.Name = "lunarYearTextBox";
            lunarYearTextBox.Size = new Size(116, 26);
            lunarYearTextBox.TabIndex = 5;
            lunarYearTextBox.Text = "2016";
            lunarYearTextBox.KeyDown += TextBox_KeyDown;
            lunarYearTextBox.KeyPress += KeyPressControl;
            lunarYearTextBox.Validating += LunarYearTextBox_Validating;
            lunarYearTextBox.Validated += LunarYearTextBox_Validated;
            // 
            // solarYearTextBox
            // 
            solarYearTextBox.Location = new Point(105, 53);
            solarYearTextBox.Margin = new Padding(4, 3, 4, 3);
            solarYearTextBox.MaxLength = 4;
            solarYearTextBox.Name = "solarYearTextBox";
            solarYearTextBox.Size = new Size(116, 26);
            solarYearTextBox.TabIndex = 1;
            solarYearTextBox.Text = "2016";
            solarYearTextBox.KeyDown += TextBox_KeyDown;
            solarYearTextBox.KeyPress += KeyPressControl;
            solarYearTextBox.Validating += SolarYearTextBox_Validating;
            solarYearTextBox.Validated += SolarYearTextBox_Validated;
            // 
            // lunarCalendarRadioButton
            // 
            lunarCalendarRadioButton.AutoSize = true;
            lunarCalendarRadioButton.Location = new Point(23, 200);
            lunarCalendarRadioButton.Margin = new Padding(4, 3, 4, 3);
            lunarCalendarRadioButton.Name = "lunarCalendarRadioButton";
            lunarCalendarRadioButton.Size = new Size(78, 24);
            lunarCalendarRadioButton.TabIndex = 4;
            lunarCalendarRadioButton.TabStop = true;
            lunarCalendarRadioButton.Text = "Âm lịch";
            lunarCalendarRadioButton.UseVisualStyleBackColor = true;
            lunarCalendarRadioButton.CheckedChanged += DayCalendarRadioButton_CheckedChanged;
            // 
            // solarCalendarRadioButton
            // 
            solarCalendarRadioButton.AutoSize = true;
            solarCalendarRadioButton.Checked = true;
            solarCalendarRadioButton.Location = new Point(23, 17);
            solarCalendarRadioButton.Margin = new Padding(4, 3, 4, 3);
            solarCalendarRadioButton.Name = "solarCalendarRadioButton";
            solarCalendarRadioButton.Size = new Size(102, 24);
            solarCalendarRadioButton.TabIndex = 0;
            solarCalendarRadioButton.TabStop = true;
            solarCalendarRadioButton.Text = "Dương lịch";
            solarCalendarRadioButton.UseVisualStyleBackColor = true;
            solarCalendarRadioButton.CheckedChanged += DayCalendarRadioButton_CheckedChanged;
            // 
            // monthCalendarTabPage
            // 
            monthCalendarTabPage.Controls.Add(tableLayoutPanel2);
            monthCalendarTabPage.Location = new Point(4, 29);
            monthCalendarTabPage.Margin = new Padding(4, 3, 4, 3);
            monthCalendarTabPage.Name = "monthCalendarTabPage";
            monthCalendarTabPage.Padding = new Padding(4, 3, 4, 3);
            monthCalendarTabPage.Size = new Size(776, 528);
            monthCalendarTabPage.TabIndex = 1;
            monthCalendarTabPage.Text = "Lịch tháng";
            monthCalendarTabPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(lunarMonthCalendar, 0, 1);
            tableLayoutPanel2.Controls.Add(monthCalendarControlPanel, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(4, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 90F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(768, 522);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // lunarMonthCalendar
            // 
            lunarMonthCalendar.BackgroundImage = (Image)resources.GetObject("lunarMonthCalendar.BackgroundImage");
            lunarMonthCalendar.BackgroundImageLayout = ImageLayout.Stretch;
            lunarMonthCalendar.Dock = DockStyle.Fill;
            lunarMonthCalendar.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lunarMonthCalendar.Location = new Point(5, 96);
            lunarMonthCalendar.Margin = new Padding(5, 6, 5, 6);
            lunarMonthCalendar.Name = "lunarMonthCalendar";
            lunarMonthCalendar.SelectedMonth = new DateTime(2016, 5, 15, 0, 0, 0, 0);
            lunarMonthCalendar.Size = new Size(758, 420);
            lunarMonthCalendar.TabIndex = 1;
            lunarMonthCalendar.SelectedMonthChanged += LunarMonthCalendar_SelectedMonthChanged;
            // 
            // monthCalendarControlPanel
            // 
            monthCalendarControlPanel.Controls.Add(yearTextBox);
            monthCalendarControlPanel.Controls.Add(yearLabel);
            monthCalendarControlPanel.Controls.Add(thisMonthButton);
            monthCalendarControlPanel.Controls.Add(monthComboBox);
            monthCalendarControlPanel.Controls.Add(nextMonthButton);
            monthCalendarControlPanel.Controls.Add(previousMonthButton);
            monthCalendarControlPanel.Controls.Add(monthLabel);
            monthCalendarControlPanel.Location = new Point(4, 3);
            monthCalendarControlPanel.Margin = new Padding(4, 3, 4, 3);
            monthCalendarControlPanel.Name = "monthCalendarControlPanel";
            monthCalendarControlPanel.Size = new Size(760, 81);
            monthCalendarControlPanel.TabIndex = 0;
            // 
            // yearTextBox
            // 
            yearTextBox.Location = new Point(83, 7);
            yearTextBox.Margin = new Padding(4, 3, 4, 3);
            yearTextBox.MaxLength = 4;
            yearTextBox.Name = "yearTextBox";
            yearTextBox.Size = new Size(116, 26);
            yearTextBox.TabIndex = 0;
            yearTextBox.Text = "2016";
            yearTextBox.KeyDown += YearTextBox_KeyDown;
            yearTextBox.KeyPress += KeyPressControl;
            yearTextBox.Validating += YearTextBox_Validating;
            yearTextBox.Validated += YearTextBox_Validated;
            // 
            // yearLabel
            // 
            yearLabel.AutoSize = true;
            yearLabel.Location = new Point(27, 10);
            yearLabel.Margin = new Padding(4, 0, 4, 0);
            yearLabel.Name = "yearLabel";
            yearLabel.Size = new Size(42, 20);
            yearLabel.TabIndex = 0;
            yearLabel.Text = "Năm";
            // 
            // thisMonthButton
            // 
            thisMonthButton.Cursor = Cursors.Hand;
            thisMonthButton.Location = new Point(536, 43);
            thisMonthButton.Margin = new Padding(4, 3, 4, 3);
            thisMonthButton.Name = "thisMonthButton";
            thisMonthButton.Size = new Size(182, 35);
            thisMonthButton.TabIndex = 4;
            thisMonthButton.Text = "Hôm nay";
            thisMonthButton.UseVisualStyleBackColor = true;
            thisMonthButton.Click += ThisMonthButton_Click;
            // 
            // monthComboBox
            // 
            monthComboBox.Cursor = Cursors.Hand;
            monthComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            monthComboBox.FormattingEnabled = true;
            monthComboBox.Items.AddRange(new object[] { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12" });
            monthComboBox.Location = new Point(83, 40);
            monthComboBox.Margin = new Padding(4, 3, 4, 3);
            monthComboBox.Name = "monthComboBox";
            monthComboBox.Size = new Size(116, 28);
            monthComboBox.Sorted = true;
            monthComboBox.TabIndex = 1;
            monthComboBox.SelectedIndexChanged += MonthComboBox_SelectedIndexChanged;
            // 
            // nextMonthButton
            // 
            nextMonthButton.Cursor = Cursors.Hand;
            nextMonthButton.Location = new Point(630, 5);
            nextMonthButton.Margin = new Padding(4, 3, 4, 3);
            nextMonthButton.Name = "nextMonthButton";
            nextMonthButton.Size = new Size(88, 35);
            nextMonthButton.TabIndex = 3;
            nextMonthButton.Text = "→";
            toolTip1.SetToolTip(nextMonthButton, "Tháng sau");
            nextMonthButton.UseVisualStyleBackColor = true;
            nextMonthButton.Click += NextMonthButton_Click;
            // 
            // previousMonthButton
            // 
            previousMonthButton.Cursor = Cursors.Hand;
            previousMonthButton.Location = new Point(536, 5);
            previousMonthButton.Margin = new Padding(4, 3, 4, 3);
            previousMonthButton.Name = "previousMonthButton";
            previousMonthButton.Size = new Size(88, 35);
            previousMonthButton.TabIndex = 2;
            previousMonthButton.Text = "←";
            toolTip1.SetToolTip(previousMonthButton, "Tháng trước");
            previousMonthButton.UseVisualStyleBackColor = true;
            previousMonthButton.Click += PreviousMonthButton_Click;
            // 
            // monthLabel
            // 
            monthLabel.AutoSize = true;
            monthLabel.Location = new Point(13, 44);
            monthLabel.Margin = new Padding(4, 0, 4, 0);
            monthLabel.Name = "monthLabel";
            monthLabel.Size = new Size(54, 20);
            monthLabel.TabIndex = 0;
            monthLabel.Text = "Tháng";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(mainTabControl);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Âm dương lịch";
            mainTabControl.ResumeLayout(false);
            dayCalendarTabPage.ResumeLayout(false);
            dayCalendarTableLayoutPanel.ResumeLayout(false);
            dayCalendarControlPanel.ResumeLayout(false);
            dayCalendarControlPanel.PerformLayout();
            monthCalendarTabPage.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            monthCalendarControlPanel.ResumeLayout(false);
            monthCalendarControlPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl mainTabControl;
        private TabPage monthCalendarTabPage;
        private TabPage dayCalendarTabPage;
        private LunarDayCalendar lunarDayCalendar;
        private Panel dayCalendarControlPanel;
        private ComboBox solarDayComboBox;
        private Label solarYearLabel;
        private ComboBox solarMonthComboBox;
        private Label solarMonthLabel;
        private Label solarDayLabel;
        private TextBox solarYearTextBox;
        private RadioButton solarCalendarRadioButton;
        private Button todayButton;
        private Button nextDateButton;
        private Button previousDateButton;
        private ComboBox lunarDayComboBox;
        private Label lunarYearLabel;
        private ComboBox lunarMonthComboBox;
        private Label lunarMonthLabel;
        private Label lunarDayLabel;
        private TextBox lunarYearTextBox;
        private RadioButton lunarCalendarRadioButton;
        private Button thisMonthButton;
        private Button nextMonthButton;
        private Button previousMonthButton;
        private Label yearLabel;
        private ComboBox monthComboBox;
        private Label monthLabel;
        private TextBox yearTextBox;
        private Panel monthCalendarControlPanel;
        private LunarMonthCalendar lunarMonthCalendar;
        private Label errorLabel;
        private ToolTip toolTip1;
        private TableLayoutPanel dayCalendarTableLayoutPanel;
        private TableLayoutPanel tableLayoutPanel2;
    }
}

