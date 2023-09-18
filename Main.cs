using System.ComponentModel;

namespace LunarCalendar
{
    public partial class Main : Form
    {
        #region Fields
        private readonly int timeZone = 7; // múi giờ Việt Nam
        //DayCalendar Tab
        private SolarDate currentSolarDate;
        private LunarDate currentLunarDate;
        //MonthCalendar Tab
        private int currentMonth;
        private int currentYear;
        #endregion

        #region Constructor
        public Main()
        {
            InitializeComponent();

            currentSolarDate = new SolarDate(DateTime.Today);
            currentLunarDate = currentSolarDate.ToLunarDate(timeZone);
            currentMonth = DateTime.Today.Month;
            currentYear = DateTime.Today.Year;

            DayCalendar_FillValues();
            MonthCalendar_FillValues();

            lunarDayCalendar.SelectedDate = DateTime.Today;
            lunarMonthCalendar.SelectedMonth = DateTime.Today;
        }
        #endregion

        #region Methods
        //KeyPress
        private void KeyPressControl(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar) || Char.IsControl(e.KeyChar)))
                e.Handled = true;
        }

        //Tab DayCalendar
        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                todayButton.Focus();
                ((TextBox)sender).Focus();
            }
        }

        private void DayCalendar_FillValues()
        {
            //Solar Date
            //Year
            solarYearTextBox.Text = currentSolarDate.Year.ToString("0000");
            //Month
            solarMonthComboBox.Text = currentSolarDate.Month.ToString("00");
            //Day
            solarDayComboBox.Items.Clear();
            int n = SolarDate.GetNumberOfDaysInMonth(currentSolarDate.Month, currentSolarDate.Year);
            for (int i = 1; i <= n; i++)
                solarDayComboBox.Items.Add((i).ToString("00"));
            solarDayComboBox.Text = currentSolarDate.Day.ToString("00");

            //Lunar Date
            //Year
            lunarYearTextBox.Text = currentLunarDate.Year.ToString("0000");
            //Month
            lunarMonthComboBox.Items.Clear();
            foreach (string month in LunarDate.GetMonths(currentLunarDate.Year, timeZone))
                lunarMonthComboBox.Items.Add(month);
            string str = currentLunarDate.Month.ToString("00");
            if (currentLunarDate.IsLeapMonth)
                str += " nhuận";
            lunarMonthComboBox.Text = str;
            //Day
            lunarDayComboBox.Items.Clear();
            int m = LunarDate.GetNumberOfDaysInMonth(currentLunarDate.Month, currentLunarDate.IsLeapMonth, currentLunarDate.Year, timeZone);
            for (int i = 1; i <= m; i++)
                lunarDayComboBox.Items.Add(i.ToString("00"));
            lunarDayComboBox.Text = currentLunarDate.Day.ToString("00");
        }

        private void LunarDayCalendar_SelectedDateChanged(object sender, EventArgs e)
        {
            currentSolarDate = new SolarDate(lunarDayCalendar.SelectedDate);
            currentLunarDate = currentSolarDate.ToLunarDate(timeZone);

            DayCalendar_UpdateValue();

            if (currentSolarDate == SolarDate.MinValue)
                previousDateButton.Enabled = false;
            else
                previousDateButton.Enabled = true;

            if (currentSolarDate == SolarDate.MaxValue)
                nextDateButton.Enabled = false;
            else
                nextDateButton.Enabled = true;
        }

        private void DayCalendar_UpdateValue()
        {
            //Solar Date
            //Year
            solarYearTextBox.Text = currentSolarDate.Year.ToString("0000");
            //Month
            solarMonthComboBox.Text = currentSolarDate.Month.ToString("00");
            //Day
            solarDayComboBox.Items.Clear();
            int n = SolarDate.GetNumberOfDaysInMonth(currentSolarDate.Month, currentSolarDate.Year);
            for (int i = 1; i <= n; i++)
                solarDayComboBox.Items.Add(i.ToString("00"));
            solarDayComboBox.Text = currentSolarDate.Day.ToString("00");

            //Lunar Date
            //Year
            lunarYearTextBox.Text = currentLunarDate.Year.ToString("0000");
            //Month
            if (currentLunarDate.Year > 0)
            {
                lunarMonthComboBox.Items.Clear();
                List<string> months = LunarDate.GetMonths(currentLunarDate.Year, timeZone);
                foreach (string month in months)
                    lunarMonthComboBox.Items.Add(month);
                string str = currentLunarDate.Month.ToString("00");
                if (currentLunarDate.IsLeapMonth)
                    str += " nhuận";
                lunarMonthComboBox.Text = str;
            }
            else if (currentLunarDate.Year == 0)
            {
                lunarMonthComboBox.Items.Clear();
                lunarMonthComboBox.Items.Add("11");
                lunarMonthComboBox.Items.Add("12");
                lunarMonthComboBox.Text = currentLunarDate.Month.ToString("00");
            }

            //Day
            if (currentLunarDate.Year > 0 || (currentLunarDate.Year == 0 && currentLunarDate.Month > 11))
            {
                lunarDayComboBox.Items.Clear();
                int m = LunarDate.GetNumberOfDaysInMonth(currentLunarDate.Month, currentLunarDate.IsLeapMonth, currentLunarDate.Year, timeZone);
                for (int i = 1; i <= m; i++)
                    lunarDayComboBox.Items.Add((i).ToString("00"));
                lunarDayComboBox.Text = currentLunarDate.Day.ToString("00");
            }
            else if (currentLunarDate.Year == 0 && currentLunarDate.Month == 11)
            {
                lunarDayComboBox.Items.Clear();
                for (int i = 19; i <= 30; i++)
                    lunarDayComboBox.Items.Add(i.ToString());
                lunarDayComboBox.Text = currentLunarDate.Day.ToString("00");
            }
        }

        private void SolarYearTextBox_Validating(object sender, CancelEventArgs e)
        {
            //Kiểm tra giá trị năm
            if (currentSolarDate.Year == int.Parse(solarYearTextBox.Text))
                return;

            try
            {
                int year = int.Parse(solarYearTextBox.Text);
                if (year < 1 || year > 9999)
                    throw new Exception();
                solarYearTextBox.Text = year.ToString("0000");
            }
            catch
            {
                MessageBox.Show("Nhập lại giá trị năm", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                solarYearTextBox.SelectAll();
                e.Cancel = true;
            }
        }

        private void SolarYearTextBox_Validated(object sender, EventArgs e)
        {
            int currentSolarYear = int.Parse(solarYearTextBox.Text);
            DayCalendar_ModifySelectedDate_Solar(currentSolarDate.Month, currentSolarYear);
            lunarDayCalendar.SelectedDate = new DateTime(currentSolarYear, currentSolarDate.Month, currentSolarDate.Day);
        }

        private void SolarMonthComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (solarMonthComboBox.SelectedIndex == -1)
                return;

            int currentSolarMonth = int.Parse(solarMonthComboBox.Text);
            DayCalendar_ModifySelectedDate_Solar(currentSolarMonth, currentSolarDate.Year);
            lunarDayCalendar.SelectedDate = new DateTime(currentSolarDate.Year, currentSolarMonth, currentSolarDate.Day);
        }

        private void DayCalendar_ModifySelectedDate_Solar(int solarMonth, int solarYear)
        {
            //Day
            int n = SolarDate.GetNumberOfDaysInMonth(solarMonth, solarYear);
            if (currentSolarDate.Day > n)
                currentSolarDate = new SolarDate(n, solarMonth, solarYear);
        }

        private void SolarDayComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (solarDayComboBox.SelectedIndex == -1)
                return;

            int currentSolarDay = int.Parse(solarDayComboBox.Text);
            lunarDayCalendar.SelectedDate = new DateTime(currentSolarDate.Year, currentSolarDate.Month, currentSolarDay);
        }

        private void LunarYearTextBox_Validating(object sender, CancelEventArgs e)
        {
            //Kiểm tra giá trị năm
            if (currentLunarDate.Year == int.Parse(lunarYearTextBox.Text))
                return;

            try
            {
                int year = int.Parse(lunarYearTextBox.Text);
                if (year < 0 || year > 9999)
                    throw new Exception();

                lunarYearTextBox.Text = year.ToString("0000");
            }
            catch
            {
                MessageBox.Show("Nhập lại giá trị năm", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lunarYearTextBox.SelectAll();
                e.Cancel = true;
            }
        }

        private void LunarYearTextBox_Validated(object sender, EventArgs e)
        {
            try
            {
                errorLabel.Visible = false;
                previousDateButton.Enabled = true;
                nextDateButton.Enabled = true;

                int currentLunarYear = int.Parse(lunarYearTextBox.Text);
                DayCalendar_ModifySelectedDate_Lunar(currentLunarDate.Month, currentLunarDate.IsLeapMonth, currentLunarYear);
                lunarDayCalendar.SelectedDate = new DateTime(currentSolarDate.Year, currentSolarDate.Month, currentSolarDate.Day);
            }
            catch (Exception exc)
            {
                errorLabel.Text = "Lỗi: " + exc.Message;
                errorLabel.Visible = true;
                previousDateButton.Enabled = false;
                nextDateButton.Enabled = false;
            }
        }

        private void LunarMonthComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lunarMonthComboBox.SelectedIndex == -1)
                return;

            try
            {
                errorLabel.Visible = false;
                previousDateButton.Enabled = true;
                nextDateButton.Enabled = true;

                int currentLunarMonth = int.Parse(lunarMonthComboBox.Text[..2]);
                bool currentLunarIsLeapMonth;
                if (lunarMonthComboBox.Text.Length > 2)
                    currentLunarIsLeapMonth = true;
                else
                    currentLunarIsLeapMonth = false;
                DayCalendar_ModifySelectedDate_Lunar(currentLunarMonth, currentLunarIsLeapMonth, currentLunarDate.Year);
                lunarDayCalendar.SelectedDate = new DateTime(currentSolarDate.Year, currentSolarDate.Month, currentSolarDate.Day);
            }
            catch (Exception exc)
            {
                errorLabel.Text = "Lỗi: " + exc.Message;
                errorLabel.Visible = true;
                previousDateButton.Enabled = false;
                nextDateButton.Enabled = false;
            }
        }

        private void DayCalendar_ModifySelectedDate_Lunar(int lunarMonth, bool lunarIsLeapMonth, int lunarYear)
        {
            //Check mininum value
            if (lunarYear == 0)
            {
                if (currentLunarDate.Month < 11)
                {
                    currentLunarDate = new LunarDate(19, 11, false, 0, timeZone);
                }
                else if (currentLunarDate.Month == 11)
                {
                    if (currentLunarDate.Day < 19)
                        currentLunarDate = new LunarDate(19, 11, false, 0, timeZone);
                    else
                        currentLunarDate = new LunarDate(currentLunarDate.Day, 11, false, 0, timeZone);
                }
            }

            //Month
            List<string> months = LunarDate.GetMonths(lunarYear, timeZone);
            if (lunarIsLeapMonth)
            {
                bool flag = false;
                foreach (string month in months)
                {
                    if (month.Length > 2 && month[..2] == lunarMonth.ToString("00"))
                    {
                        flag = true;
                        break;
                    }
                }
                if (!flag)
                    currentLunarDate = new LunarDate(currentLunarDate.Day, lunarMonth, false, lunarYear, timeZone);
            }

            //Day
            int n = LunarDate.GetNumberOfDaysInMonth(lunarMonth, lunarIsLeapMonth, lunarYear, timeZone);
            if (currentLunarDate.Day > n)
                currentLunarDate = new LunarDate(n, lunarMonth, lunarIsLeapMonth, lunarYear, timeZone);
            else
                currentLunarDate = new LunarDate(currentLunarDate.Day, lunarMonth, lunarIsLeapMonth, lunarYear, timeZone);
            currentSolarDate = currentLunarDate.ToSolarDate();
        }

        private void LunarDayComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lunarDayComboBox.SelectedIndex == -1)
                return;

            try
            {
                errorLabel.Visible = false;
                previousDateButton.Enabled = true;
                nextDateButton.Enabled = true;

                int currentLunarDay = int.Parse(lunarDayComboBox.Text);
                currentLunarDate = new LunarDate(currentLunarDay, currentLunarDate.Month, currentLunarDate.IsLeapMonth, currentLunarDate.Year, timeZone);
                currentSolarDate = currentLunarDate.ToSolarDate();
                lunarDayCalendar.SelectedDate = new DateTime(currentSolarDate.Year, currentSolarDate.Month, currentSolarDate.Day);
            }
            catch (Exception exc)
            {
                errorLabel.Text = "Lỗi: " + exc.Message;
                errorLabel.Visible = true;
                previousDateButton.Enabled = false;
                nextDateButton.Enabled = false;
            }
        }

        private void PreviousDateButton_Click(object sender, EventArgs e)
        {
            lunarDayCalendar.SelectedDate = lunarDayCalendar.SelectedDate.AddDays(-1);
        }

        private void NextDateButton_Click(object sender, EventArgs e)
        {
            lunarDayCalendar.SelectedDate = lunarDayCalendar.SelectedDate.AddDays(1);
        }

        private void TodayButton_Click(object sender, EventArgs e)
        {
            lunarDayCalendar.SelectedDate = DateTime.Today;
        }

        private void DayCalendarRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            solarYearTextBox.Enabled = solarCalendarRadioButton.Checked;
            solarMonthComboBox.Enabled = solarCalendarRadioButton.Checked;
            solarDayComboBox.Enabled = solarCalendarRadioButton.Checked;

            lunarYearTextBox.Enabled = lunarCalendarRadioButton.Checked;
            lunarMonthComboBox.Enabled = lunarCalendarRadioButton.Checked;
            lunarDayComboBox.Enabled = lunarCalendarRadioButton.Checked;
        }

        //Tab MonthCalendar
        private void YearTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                thisMonthButton.Focus();
                ((TextBox)sender).Focus();
            }
        }

        private void MonthCalendar_FillValues()
        {
            yearTextBox.Text = currentYear.ToString("0000");
            monthComboBox.Text = currentMonth.ToString("00");
        }

        private void LunarMonthCalendar_SelectedMonthChanged(object sender, EventArgs e)
        {
            currentMonth = lunarMonthCalendar.SelectedMonth.Month;
            currentYear = lunarMonthCalendar.SelectedMonth.Year;

            yearTextBox.Text = lunarMonthCalendar.SelectedMonth.Year.ToString("0000");
            monthComboBox.Text = lunarMonthCalendar.SelectedMonth.Month.ToString("00");

            if (currentYear == 1 && currentMonth == 1)
                previousMonthButton.Enabled = false;
            else
                previousMonthButton.Enabled = true;

            if (currentYear == 9999 && currentMonth == 12)
                nextMonthButton.Enabled = false;
            else
                nextMonthButton.Enabled = true;
        }

        private void YearTextBox_Validating(object sender, CancelEventArgs e)
        {
            //Kiểm tra giá trị năm
            if (currentYear == int.Parse(yearTextBox.Text))
                return;

            try
            {
                int year = int.Parse(yearTextBox.Text);
                if (year < 1 || year > 9999)
                    throw new Exception();
                yearTextBox.Text = year.ToString("0000");
            }
            catch
            {
                MessageBox.Show("Nhập lại giá trị năm", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                yearTextBox.SelectAll();
                e.Cancel = true;
            }
        }

        private void YearTextBox_Validated(object sender, EventArgs e)
        {
            currentYear = int.Parse(yearTextBox.Text);
            lunarMonthCalendar.SelectedMonth = new DateTime(currentYear, currentMonth, 1);
        }

        private void MonthComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentMonth = int.Parse(monthComboBox.Text);
            lunarMonthCalendar.SelectedMonth = new DateTime(currentYear, currentMonth, 1);
        }

        private void PreviousMonthButton_Click(object sender, EventArgs e)
        {
            if (currentMonth == 1)
                lunarMonthCalendar.SelectedMonth = new DateTime(currentYear - 1, 12, 1);
            else
                lunarMonthCalendar.SelectedMonth = new DateTime(currentYear, currentMonth - 1, 1);
        }

        private void NextMonthButton_Click(object sender, EventArgs e)
        {
            if (currentMonth == 12)
                lunarMonthCalendar.SelectedMonth = new DateTime(currentYear + 1, 1, 1);
            else
                lunarMonthCalendar.SelectedMonth = new DateTime(currentYear, currentMonth + 1, 1);
        }

        private void ThisMonthButton_Click(object sender, EventArgs e)
        {
            lunarMonthCalendar.SelectedMonth = DateTime.Today;
        }
        #endregion
    }
}
