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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabDayCalendar = new System.Windows.Forms.TabPage();
            this.pnlDayCalendar_Control = new System.Windows.Forms.Panel();
            this.lblDayCalendar_Error = new System.Windows.Forms.Label();
            this.btnDayCalendar_Today = new System.Windows.Forms.Button();
            this.btnDayCalendar_NextDate = new System.Windows.Forms.Button();
            this.btnDayCalendar_PreviousDate = new System.Windows.Forms.Button();
            this.cmbDayCalendar_Lunar_Day = new System.Windows.Forms.ComboBox();
            this.cmbDayCalendar_Solar_Day = new System.Windows.Forms.ComboBox();
            this.lblDayCalendar_Lunar_Year = new System.Windows.Forms.Label();
            this.lblDayCalendar_Solar_Year = new System.Windows.Forms.Label();
            this.cmbDayCalendar_Lunar_Month = new System.Windows.Forms.ComboBox();
            this.cmbDayCalendar_Solar_Month = new System.Windows.Forms.ComboBox();
            this.lblDayCalendar_Lunar_Month = new System.Windows.Forms.Label();
            this.lblDayCalendar_Solar_Month = new System.Windows.Forms.Label();
            this.lblDayCalendar_Lunar_Day = new System.Windows.Forms.Label();
            this.lblLunarDayCalendar_Solar_Day = new System.Windows.Forms.Label();
            this.txtDayCalendar_Lunar_Year = new System.Windows.Forms.TextBox();
            this.txtDayCalendar_Solar_Year = new System.Windows.Forms.TextBox();
            this.rdbDayCalendar_Lunar = new System.Windows.Forms.RadioButton();
            this.rdbDayCalendar_Solar = new System.Windows.Forms.RadioButton();
            this.cldLunarDayCalendar = new LunarCalendar.LunarDayCalendar();
            this.tabMonthCalendar = new System.Windows.Forms.TabPage();
            this.cldLunarMonthCalendar = new LunarCalendar.LunarMonthCalendar();
            this.pnlLunarMonthCalendar_Control = new System.Windows.Forms.Panel();
            this.txtMonthCalendar_Year = new System.Windows.Forms.TextBox();
            this.lblMonthCalendar_Year = new System.Windows.Forms.Label();
            this.btnMonthCalendar_Today = new System.Windows.Forms.Button();
            this.cmbMonthCalendar_Month = new System.Windows.Forms.ComboBox();
            this.btnMonthCalendar_NextMonth = new System.Windows.Forms.Button();
            this.btnMonthCalendar_PreviousMonth = new System.Windows.Forms.Button();
            this.lblMonthCalendar_Month = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabControlMain.SuspendLayout();
            this.tabDayCalendar.SuspendLayout();
            this.pnlDayCalendar_Control.SuspendLayout();
            this.tabMonthCalendar.SuspendLayout();
            this.pnlLunarMonthCalendar_Control.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabDayCalendar);
            this.tabControlMain.Controls.Add(this.tabMonthCalendar);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Multiline = true;
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(634, 551);
            this.tabControlMain.TabIndex = 6;
            // 
            // tabDayCalendar
            // 
            this.tabDayCalendar.Controls.Add(this.pnlDayCalendar_Control);
            this.tabDayCalendar.Controls.Add(this.cldLunarDayCalendar);
            this.tabDayCalendar.Location = new System.Drawing.Point(4, 29);
            this.tabDayCalendar.Name = "tabDayCalendar";
            this.tabDayCalendar.Padding = new System.Windows.Forms.Padding(3);
            this.tabDayCalendar.Size = new System.Drawing.Size(626, 518);
            this.tabDayCalendar.TabIndex = 0;
            this.tabDayCalendar.Text = "Lịch ngày";
            this.tabDayCalendar.UseVisualStyleBackColor = true;
            // 
            // pnlDayCalendar_Control
            // 
            this.pnlDayCalendar_Control.Controls.Add(this.lblDayCalendar_Error);
            this.pnlDayCalendar_Control.Controls.Add(this.btnDayCalendar_Today);
            this.pnlDayCalendar_Control.Controls.Add(this.btnDayCalendar_NextDate);
            this.pnlDayCalendar_Control.Controls.Add(this.btnDayCalendar_PreviousDate);
            this.pnlDayCalendar_Control.Controls.Add(this.cmbDayCalendar_Lunar_Day);
            this.pnlDayCalendar_Control.Controls.Add(this.cmbDayCalendar_Solar_Day);
            this.pnlDayCalendar_Control.Controls.Add(this.lblDayCalendar_Lunar_Year);
            this.pnlDayCalendar_Control.Controls.Add(this.lblDayCalendar_Solar_Year);
            this.pnlDayCalendar_Control.Controls.Add(this.cmbDayCalendar_Lunar_Month);
            this.pnlDayCalendar_Control.Controls.Add(this.cmbDayCalendar_Solar_Month);
            this.pnlDayCalendar_Control.Controls.Add(this.lblDayCalendar_Lunar_Month);
            this.pnlDayCalendar_Control.Controls.Add(this.lblDayCalendar_Solar_Month);
            this.pnlDayCalendar_Control.Controls.Add(this.lblDayCalendar_Lunar_Day);
            this.pnlDayCalendar_Control.Controls.Add(this.lblLunarDayCalendar_Solar_Day);
            this.pnlDayCalendar_Control.Controls.Add(this.txtDayCalendar_Lunar_Year);
            this.pnlDayCalendar_Control.Controls.Add(this.txtDayCalendar_Solar_Year);
            this.pnlDayCalendar_Control.Controls.Add(this.rdbDayCalendar_Lunar);
            this.pnlDayCalendar_Control.Controls.Add(this.rdbDayCalendar_Solar);
            this.pnlDayCalendar_Control.Location = new System.Drawing.Point(8, 6);
            this.pnlDayCalendar_Control.Name = "pnlDayCalendar_Control";
            this.pnlDayCalendar_Control.Size = new System.Drawing.Size(231, 500);
            this.pnlDayCalendar_Control.TabIndex = 0;
            // 
            // lblDayCalendar_Error
            // 
            this.lblDayCalendar_Error.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblDayCalendar_Error.ForeColor = System.Drawing.Color.Red;
            this.lblDayCalendar_Error.Location = new System.Drawing.Point(0, 450);
            this.lblDayCalendar_Error.Name = "lblDayCalendar_Error";
            this.lblDayCalendar_Error.Size = new System.Drawing.Size(231, 50);
            this.lblDayCalendar_Error.TabIndex = 0;
            this.lblDayCalendar_Error.Text = "Lỗi:";
            this.lblDayCalendar_Error.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDayCalendar_Error.Visible = false;
            // 
            // btnDayCalendar_Today
            // 
            this.btnDayCalendar_Today.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDayCalendar_Today.Location = new System.Drawing.Point(34, 405);
            this.btnDayCalendar_Today.Name = "btnDayCalendar_Today";
            this.btnDayCalendar_Today.Size = new System.Drawing.Size(156, 30);
            this.btnDayCalendar_Today.TabIndex = 10;
            this.btnDayCalendar_Today.Text = "Hôm nay";
            this.btnDayCalendar_Today.UseVisualStyleBackColor = true;
            this.btnDayCalendar_Today.Click += new System.EventHandler(this.btnDayCalendar_Today_Click);
            // 
            // btnDayCalendar_NextDate
            // 
            this.btnDayCalendar_NextDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDayCalendar_NextDate.Location = new System.Drawing.Point(115, 369);
            this.btnDayCalendar_NextDate.Name = "btnDayCalendar_NextDate";
            this.btnDayCalendar_NextDate.Size = new System.Drawing.Size(75, 30);
            this.btnDayCalendar_NextDate.TabIndex = 9;
            this.btnDayCalendar_NextDate.Text = "→";
            this.toolTip1.SetToolTip(this.btnDayCalendar_NextDate, "Ngày sau");
            this.btnDayCalendar_NextDate.UseVisualStyleBackColor = true;
            this.btnDayCalendar_NextDate.Click += new System.EventHandler(this.btnDayCalendar_NextDate_Click);
            // 
            // btnDayCalendar_PreviousDate
            // 
            this.btnDayCalendar_PreviousDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDayCalendar_PreviousDate.Location = new System.Drawing.Point(34, 369);
            this.btnDayCalendar_PreviousDate.Name = "btnDayCalendar_PreviousDate";
            this.btnDayCalendar_PreviousDate.Size = new System.Drawing.Size(75, 30);
            this.btnDayCalendar_PreviousDate.TabIndex = 8;
            this.btnDayCalendar_PreviousDate.Text = "←";
            this.toolTip1.SetToolTip(this.btnDayCalendar_PreviousDate, "Ngày trước");
            this.btnDayCalendar_PreviousDate.UseVisualStyleBackColor = true;
            this.btnDayCalendar_PreviousDate.Click += new System.EventHandler(this.btnDayCalendar_PreviousDate_Click);
            // 
            // cmbDayCalendar_Lunar_Day
            // 
            this.cmbDayCalendar_Lunar_Day.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbDayCalendar_Lunar_Day.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDayCalendar_Lunar_Day.Enabled = false;
            this.cmbDayCalendar_Lunar_Day.FormattingEnabled = true;
            this.cmbDayCalendar_Lunar_Day.Location = new System.Drawing.Point(90, 292);
            this.cmbDayCalendar_Lunar_Day.Name = "cmbDayCalendar_Lunar_Day";
            this.cmbDayCalendar_Lunar_Day.Size = new System.Drawing.Size(100, 28);
            this.cmbDayCalendar_Lunar_Day.Sorted = true;
            this.cmbDayCalendar_Lunar_Day.TabIndex = 7;
            this.cmbDayCalendar_Lunar_Day.SelectedIndexChanged += new System.EventHandler(this.cmbDayCalendar_Lunar_Day_SelectedIndexChanged);
            this.cmbDayCalendar_Lunar_Day.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLunarCalendar_KeyPress);
            // 
            // cmbDayCalendar_Solar_Day
            // 
            this.cmbDayCalendar_Solar_Day.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbDayCalendar_Solar_Day.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDayCalendar_Solar_Day.FormattingEnabled = true;
            this.cmbDayCalendar_Solar_Day.Location = new System.Drawing.Point(90, 113);
            this.cmbDayCalendar_Solar_Day.Name = "cmbDayCalendar_Solar_Day";
            this.cmbDayCalendar_Solar_Day.Size = new System.Drawing.Size(100, 28);
            this.cmbDayCalendar_Solar_Day.Sorted = true;
            this.cmbDayCalendar_Solar_Day.TabIndex = 3;
            this.cmbDayCalendar_Solar_Day.SelectedIndexChanged += new System.EventHandler(this.cmbDayCalendar_Solar_Day_SelectedIndexChanged);
            this.cmbDayCalendar_Solar_Day.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLunarCalendar_KeyPress);
            // 
            // lblDayCalendar_Lunar_Year
            // 
            this.lblDayCalendar_Lunar_Year.AutoSize = true;
            this.lblDayCalendar_Lunar_Year.Location = new System.Drawing.Point(42, 228);
            this.lblDayCalendar_Lunar_Year.Name = "lblDayCalendar_Lunar_Year";
            this.lblDayCalendar_Lunar_Year.Size = new System.Drawing.Size(42, 20);
            this.lblDayCalendar_Lunar_Year.TabIndex = 0;
            this.lblDayCalendar_Lunar_Year.Text = "Năm";
            // 
            // lblDayCalendar_Solar_Year
            // 
            this.lblDayCalendar_Solar_Year.AutoSize = true;
            this.lblDayCalendar_Solar_Year.Location = new System.Drawing.Point(42, 49);
            this.lblDayCalendar_Solar_Year.Name = "lblDayCalendar_Solar_Year";
            this.lblDayCalendar_Solar_Year.Size = new System.Drawing.Size(42, 20);
            this.lblDayCalendar_Solar_Year.TabIndex = 0;
            this.lblDayCalendar_Solar_Year.Text = "Năm";
            // 
            // cmbDayCalendar_Lunar_Month
            // 
            this.cmbDayCalendar_Lunar_Month.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbDayCalendar_Lunar_Month.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDayCalendar_Lunar_Month.Enabled = false;
            this.cmbDayCalendar_Lunar_Month.FormattingEnabled = true;
            this.cmbDayCalendar_Lunar_Month.Location = new System.Drawing.Point(90, 258);
            this.cmbDayCalendar_Lunar_Month.Name = "cmbDayCalendar_Lunar_Month";
            this.cmbDayCalendar_Lunar_Month.Size = new System.Drawing.Size(100, 28);
            this.cmbDayCalendar_Lunar_Month.Sorted = true;
            this.cmbDayCalendar_Lunar_Month.TabIndex = 6;
            this.cmbDayCalendar_Lunar_Month.SelectedIndexChanged += new System.EventHandler(this.cmbDayCalendar_Lunar_Month_SelectedIndexChanged);
            this.cmbDayCalendar_Lunar_Month.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLunarCalendar_KeyPress);
            // 
            // cmbDayCalendar_Solar_Month
            // 
            this.cmbDayCalendar_Solar_Month.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbDayCalendar_Solar_Month.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDayCalendar_Solar_Month.FormattingEnabled = true;
            this.cmbDayCalendar_Solar_Month.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.cmbDayCalendar_Solar_Month.Location = new System.Drawing.Point(90, 79);
            this.cmbDayCalendar_Solar_Month.Name = "cmbDayCalendar_Solar_Month";
            this.cmbDayCalendar_Solar_Month.Size = new System.Drawing.Size(100, 28);
            this.cmbDayCalendar_Solar_Month.Sorted = true;
            this.cmbDayCalendar_Solar_Month.TabIndex = 2;
            this.cmbDayCalendar_Solar_Month.SelectedIndexChanged += new System.EventHandler(this.cmbDayCalendar_Solar_Month_SelectedIndexChanged);
            this.cmbDayCalendar_Solar_Month.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLunarCalendar_KeyPress);
            // 
            // lblDayCalendar_Lunar_Month
            // 
            this.lblDayCalendar_Lunar_Month.AutoSize = true;
            this.lblDayCalendar_Lunar_Month.Location = new System.Drawing.Point(30, 261);
            this.lblDayCalendar_Lunar_Month.Name = "lblDayCalendar_Lunar_Month";
            this.lblDayCalendar_Lunar_Month.Size = new System.Drawing.Size(54, 20);
            this.lblDayCalendar_Lunar_Month.TabIndex = 0;
            this.lblDayCalendar_Lunar_Month.Text = "Tháng";
            // 
            // lblDayCalendar_Solar_Month
            // 
            this.lblDayCalendar_Solar_Month.AutoSize = true;
            this.lblDayCalendar_Solar_Month.Location = new System.Drawing.Point(30, 82);
            this.lblDayCalendar_Solar_Month.Name = "lblDayCalendar_Solar_Month";
            this.lblDayCalendar_Solar_Month.Size = new System.Drawing.Size(54, 20);
            this.lblDayCalendar_Solar_Month.TabIndex = 0;
            this.lblDayCalendar_Solar_Month.Text = "Tháng";
            // 
            // lblDayCalendar_Lunar_Day
            // 
            this.lblDayCalendar_Lunar_Day.AutoSize = true;
            this.lblDayCalendar_Lunar_Day.Location = new System.Drawing.Point(39, 295);
            this.lblDayCalendar_Lunar_Day.Name = "lblDayCalendar_Lunar_Day";
            this.lblDayCalendar_Lunar_Day.Size = new System.Drawing.Size(45, 20);
            this.lblDayCalendar_Lunar_Day.TabIndex = 0;
            this.lblDayCalendar_Lunar_Day.Text = "Ngày";
            // 
            // lblLunarDayCalendar_Solar_Day
            // 
            this.lblLunarDayCalendar_Solar_Day.AutoSize = true;
            this.lblLunarDayCalendar_Solar_Day.Location = new System.Drawing.Point(39, 116);
            this.lblLunarDayCalendar_Solar_Day.Name = "lblLunarDayCalendar_Solar_Day";
            this.lblLunarDayCalendar_Solar_Day.Size = new System.Drawing.Size(45, 20);
            this.lblLunarDayCalendar_Solar_Day.TabIndex = 0;
            this.lblLunarDayCalendar_Solar_Day.Text = "Ngày";
            // 
            // txtDayCalendar_Lunar_Year
            // 
            this.txtDayCalendar_Lunar_Year.Enabled = false;
            this.txtDayCalendar_Lunar_Year.Location = new System.Drawing.Point(90, 225);
            this.txtDayCalendar_Lunar_Year.MaxLength = 4;
            this.txtDayCalendar_Lunar_Year.Name = "txtDayCalendar_Lunar_Year";
            this.txtDayCalendar_Lunar_Year.Size = new System.Drawing.Size(100, 26);
            this.txtDayCalendar_Lunar_Year.TabIndex = 5;
            this.txtDayCalendar_Lunar_Year.Text = "2016";
            this.txtDayCalendar_Lunar_Year.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDayCalendar_Year_KeyDown);
            this.txtDayCalendar_Lunar_Year.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLunarCalendar_KeyPress);
            this.txtDayCalendar_Lunar_Year.Validating += new System.ComponentModel.CancelEventHandler(this.txtDayCalendar_Lunar_Year_Validating);
            this.txtDayCalendar_Lunar_Year.Validated += new System.EventHandler(this.txtDayCalendar_Lunar_Year_Validated);
            // 
            // txtDayCalendar_Solar_Year
            // 
            this.txtDayCalendar_Solar_Year.Location = new System.Drawing.Point(90, 46);
            this.txtDayCalendar_Solar_Year.MaxLength = 4;
            this.txtDayCalendar_Solar_Year.Name = "txtDayCalendar_Solar_Year";
            this.txtDayCalendar_Solar_Year.Size = new System.Drawing.Size(100, 26);
            this.txtDayCalendar_Solar_Year.TabIndex = 1;
            this.txtDayCalendar_Solar_Year.Text = "2016";
            this.txtDayCalendar_Solar_Year.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDayCalendar_Year_KeyDown);
            this.txtDayCalendar_Solar_Year.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLunarCalendar_KeyPress);
            this.txtDayCalendar_Solar_Year.Validating += new System.ComponentModel.CancelEventHandler(this.txtDayCalendar_Solar_Year_Validating);
            this.txtDayCalendar_Solar_Year.Validated += new System.EventHandler(this.txtDayCalendar_Solar_Year_Validated);
            // 
            // rdbDayCalendar_Lunar
            // 
            this.rdbDayCalendar_Lunar.AutoSize = true;
            this.rdbDayCalendar_Lunar.Location = new System.Drawing.Point(20, 194);
            this.rdbDayCalendar_Lunar.Name = "rdbDayCalendar_Lunar";
            this.rdbDayCalendar_Lunar.Size = new System.Drawing.Size(78, 24);
            this.rdbDayCalendar_Lunar.TabIndex = 4;
            this.rdbDayCalendar_Lunar.TabStop = true;
            this.rdbDayCalendar_Lunar.Text = "Âm lịch";
            this.rdbDayCalendar_Lunar.UseVisualStyleBackColor = true;
            this.rdbDayCalendar_Lunar.CheckedChanged += new System.EventHandler(this.rdbDayCalendar_CheckedChanged);
            // 
            // rdbDayCalendar_Solar
            // 
            this.rdbDayCalendar_Solar.AutoSize = true;
            this.rdbDayCalendar_Solar.Checked = true;
            this.rdbDayCalendar_Solar.Location = new System.Drawing.Point(20, 15);
            this.rdbDayCalendar_Solar.Name = "rdbDayCalendar_Solar";
            this.rdbDayCalendar_Solar.Size = new System.Drawing.Size(102, 24);
            this.rdbDayCalendar_Solar.TabIndex = 0;
            this.rdbDayCalendar_Solar.TabStop = true;
            this.rdbDayCalendar_Solar.Text = "Dương lịch";
            this.rdbDayCalendar_Solar.UseVisualStyleBackColor = true;
            this.rdbDayCalendar_Solar.CheckedChanged += new System.EventHandler(this.rdbDayCalendar_CheckedChanged);
            // 
            // cldLunarDayCalendar
            // 
            this.cldLunarDayCalendar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cldLunarDayCalendar.BackgroundImage")));
            this.cldLunarDayCalendar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cldLunarDayCalendar.Location = new System.Drawing.Point(245, 6);
            this.cldLunarDayCalendar.Name = "cldLunarDayCalendar";
            this.cldLunarDayCalendar.SelectedDate = new System.DateTime(2017, 3, 9, 0, 0, 0, 0);
            this.cldLunarDayCalendar.Size = new System.Drawing.Size(375, 500);
            this.cldLunarDayCalendar.TabIndex = 1;
            this.cldLunarDayCalendar.SelectedDateChanged += new LunarCalendar.LunarDayCalendar.SelectedDateChangedEventHandler(this.cldLunarDayCalendar_SelectedDateChanged);
            // 
            // tabMonthCalendar
            // 
            this.tabMonthCalendar.Controls.Add(this.cldLunarMonthCalendar);
            this.tabMonthCalendar.Controls.Add(this.pnlLunarMonthCalendar_Control);
            this.tabMonthCalendar.Location = new System.Drawing.Point(4, 29);
            this.tabMonthCalendar.Name = "tabMonthCalendar";
            this.tabMonthCalendar.Padding = new System.Windows.Forms.Padding(3);
            this.tabMonthCalendar.Size = new System.Drawing.Size(626, 518);
            this.tabMonthCalendar.TabIndex = 1;
            this.tabMonthCalendar.Text = "Lịch tháng";
            this.tabMonthCalendar.UseVisualStyleBackColor = true;
            // 
            // cldLunarMonthCalendar
            // 
            this.cldLunarMonthCalendar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cldLunarMonthCalendar.BackgroundImage")));
            this.cldLunarMonthCalendar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cldLunarMonthCalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cldLunarMonthCalendar.Location = new System.Drawing.Point(6, 74);
            this.cldLunarMonthCalendar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cldLunarMonthCalendar.Name = "cldLunarMonthCalendar";
            this.cldLunarMonthCalendar.SelectedMonth = new System.DateTime(2016, 5, 15, 0, 0, 0, 0);
            this.cldLunarMonthCalendar.Size = new System.Drawing.Size(620, 437);
            this.cldLunarMonthCalendar.TabIndex = 1;
            this.cldLunarMonthCalendar.SelectedMonthChanged += new LunarCalendar.LunarMonthCalendar.SelectedMonthChangedEventHandler(this.cldLunarMonthCalendar_SelectedMonthChanged);
            // 
            // pnlLunarMonthCalendar_Control
            // 
            this.pnlLunarMonthCalendar_Control.Controls.Add(this.txtMonthCalendar_Year);
            this.pnlLunarMonthCalendar_Control.Controls.Add(this.lblMonthCalendar_Year);
            this.pnlLunarMonthCalendar_Control.Controls.Add(this.btnMonthCalendar_Today);
            this.pnlLunarMonthCalendar_Control.Controls.Add(this.cmbMonthCalendar_Month);
            this.pnlLunarMonthCalendar_Control.Controls.Add(this.btnMonthCalendar_NextMonth);
            this.pnlLunarMonthCalendar_Control.Controls.Add(this.btnMonthCalendar_PreviousMonth);
            this.pnlLunarMonthCalendar_Control.Controls.Add(this.lblMonthCalendar_Month);
            this.pnlLunarMonthCalendar_Control.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLunarMonthCalendar_Control.Location = new System.Drawing.Point(3, 3);
            this.pnlLunarMonthCalendar_Control.Name = "pnlLunarMonthCalendar_Control";
            this.pnlLunarMonthCalendar_Control.Size = new System.Drawing.Size(620, 70);
            this.pnlLunarMonthCalendar_Control.TabIndex = 0;
            // 
            // txtMonthCalendar_Year
            // 
            this.txtMonthCalendar_Year.Location = new System.Drawing.Point(71, 6);
            this.txtMonthCalendar_Year.MaxLength = 4;
            this.txtMonthCalendar_Year.Name = "txtMonthCalendar_Year";
            this.txtMonthCalendar_Year.Size = new System.Drawing.Size(100, 26);
            this.txtMonthCalendar_Year.TabIndex = 0;
            this.txtMonthCalendar_Year.Text = "2016";
            this.txtMonthCalendar_Year.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMonthCalendar_Year_KeyDown);
            this.txtMonthCalendar_Year.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLunarCalendar_KeyPress);
            this.txtMonthCalendar_Year.Validating += new System.ComponentModel.CancelEventHandler(this.txtMonthCalendar_Year_Validating);
            this.txtMonthCalendar_Year.Validated += new System.EventHandler(this.txtMonthCalendar_Year_Validated);
            // 
            // lblMonthCalendar_Year
            // 
            this.lblMonthCalendar_Year.AutoSize = true;
            this.lblMonthCalendar_Year.Location = new System.Drawing.Point(23, 9);
            this.lblMonthCalendar_Year.Name = "lblMonthCalendar_Year";
            this.lblMonthCalendar_Year.Size = new System.Drawing.Size(42, 20);
            this.lblMonthCalendar_Year.TabIndex = 0;
            this.lblMonthCalendar_Year.Text = "Năm";
            // 
            // btnMonthCalendar_Today
            // 
            this.btnMonthCalendar_Today.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMonthCalendar_Today.Location = new System.Drawing.Point(459, 37);
            this.btnMonthCalendar_Today.Name = "btnMonthCalendar_Today";
            this.btnMonthCalendar_Today.Size = new System.Drawing.Size(156, 30);
            this.btnMonthCalendar_Today.TabIndex = 4;
            this.btnMonthCalendar_Today.Text = "Hôm nay";
            this.btnMonthCalendar_Today.UseVisualStyleBackColor = true;
            this.btnMonthCalendar_Today.Click += new System.EventHandler(this.btnMonthCalendar_Today_Click);
            // 
            // cmbMonthCalendar_Month
            // 
            this.cmbMonthCalendar_Month.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbMonthCalendar_Month.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMonthCalendar_Month.FormattingEnabled = true;
            this.cmbMonthCalendar_Month.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.cmbMonthCalendar_Month.Location = new System.Drawing.Point(71, 35);
            this.cmbMonthCalendar_Month.Name = "cmbMonthCalendar_Month";
            this.cmbMonthCalendar_Month.Size = new System.Drawing.Size(100, 28);
            this.cmbMonthCalendar_Month.Sorted = true;
            this.cmbMonthCalendar_Month.TabIndex = 1;
            this.cmbMonthCalendar_Month.SelectedIndexChanged += new System.EventHandler(this.cmbMonthCalendar_Month_SelectedIndexChanged);
            // 
            // btnMonthCalendar_NextMonth
            // 
            this.btnMonthCalendar_NextMonth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMonthCalendar_NextMonth.Location = new System.Drawing.Point(540, 4);
            this.btnMonthCalendar_NextMonth.Name = "btnMonthCalendar_NextMonth";
            this.btnMonthCalendar_NextMonth.Size = new System.Drawing.Size(75, 30);
            this.btnMonthCalendar_NextMonth.TabIndex = 3;
            this.btnMonthCalendar_NextMonth.Text = "→";
            this.toolTip1.SetToolTip(this.btnMonthCalendar_NextMonth, "Tháng sau");
            this.btnMonthCalendar_NextMonth.UseVisualStyleBackColor = true;
            this.btnMonthCalendar_NextMonth.Click += new System.EventHandler(this.btnMonthCalendar_NextMonth_Click);
            // 
            // btnMonthCalendar_PreviousMonth
            // 
            this.btnMonthCalendar_PreviousMonth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMonthCalendar_PreviousMonth.Location = new System.Drawing.Point(459, 4);
            this.btnMonthCalendar_PreviousMonth.Name = "btnMonthCalendar_PreviousMonth";
            this.btnMonthCalendar_PreviousMonth.Size = new System.Drawing.Size(75, 30);
            this.btnMonthCalendar_PreviousMonth.TabIndex = 2;
            this.btnMonthCalendar_PreviousMonth.Text = "←";
            this.toolTip1.SetToolTip(this.btnMonthCalendar_PreviousMonth, "Tháng trước");
            this.btnMonthCalendar_PreviousMonth.UseVisualStyleBackColor = true;
            this.btnMonthCalendar_PreviousMonth.Click += new System.EventHandler(this.btnMonthCalendar_PreviousMonth_Click);
            // 
            // lblMonthCalendar_Month
            // 
            this.lblMonthCalendar_Month.AutoSize = true;
            this.lblMonthCalendar_Month.Location = new System.Drawing.Point(11, 38);
            this.lblMonthCalendar_Month.Name = "lblMonthCalendar_Month";
            this.lblMonthCalendar_Month.Size = new System.Drawing.Size(54, 20);
            this.lblMonthCalendar_Month.TabIndex = 0;
            this.lblMonthCalendar_Month.Text = "Tháng";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 551);
            this.Controls.Add(this.tabControlMain);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Âm dương lịch";
            this.tabControlMain.ResumeLayout(false);
            this.tabDayCalendar.ResumeLayout(false);
            this.pnlDayCalendar_Control.ResumeLayout(false);
            this.pnlDayCalendar_Control.PerformLayout();
            this.tabMonthCalendar.ResumeLayout(false);
            this.pnlLunarMonthCalendar_Control.ResumeLayout(false);
            this.pnlLunarMonthCalendar_Control.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabMonthCalendar;
        private System.Windows.Forms.TabPage tabDayCalendar;
        private LunarDayCalendar cldLunarDayCalendar;
        private System.Windows.Forms.Panel pnlDayCalendar_Control;
        private System.Windows.Forms.ComboBox cmbDayCalendar_Solar_Day;
        private System.Windows.Forms.Label lblDayCalendar_Solar_Year;
        private System.Windows.Forms.ComboBox cmbDayCalendar_Solar_Month;
        private System.Windows.Forms.Label lblDayCalendar_Solar_Month;
        private System.Windows.Forms.Label lblLunarDayCalendar_Solar_Day;
        private System.Windows.Forms.TextBox txtDayCalendar_Solar_Year;
        private System.Windows.Forms.RadioButton rdbDayCalendar_Solar;
        private System.Windows.Forms.Button btnDayCalendar_Today;
        private System.Windows.Forms.Button btnDayCalendar_NextDate;
        private System.Windows.Forms.Button btnDayCalendar_PreviousDate;
        private System.Windows.Forms.ComboBox cmbDayCalendar_Lunar_Day;
        private System.Windows.Forms.Label lblDayCalendar_Lunar_Year;
        private System.Windows.Forms.ComboBox cmbDayCalendar_Lunar_Month;
        private System.Windows.Forms.Label lblDayCalendar_Lunar_Month;
        private System.Windows.Forms.Label lblDayCalendar_Lunar_Day;
        private System.Windows.Forms.TextBox txtDayCalendar_Lunar_Year;
        private System.Windows.Forms.RadioButton rdbDayCalendar_Lunar;
        private System.Windows.Forms.Button btnMonthCalendar_Today;
        private System.Windows.Forms.Button btnMonthCalendar_NextMonth;
        private System.Windows.Forms.Button btnMonthCalendar_PreviousMonth;
        private System.Windows.Forms.Label lblMonthCalendar_Year;
        private System.Windows.Forms.ComboBox cmbMonthCalendar_Month;
        private System.Windows.Forms.Label lblMonthCalendar_Month;
        private System.Windows.Forms.TextBox txtMonthCalendar_Year;
        private System.Windows.Forms.Panel pnlLunarMonthCalendar_Control;
        private LunarMonthCalendar cldLunarMonthCalendar;
        private System.Windows.Forms.Label lblDayCalendar_Error;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

