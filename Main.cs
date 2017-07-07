using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LunarCalendar
{
    public partial class Main : Form
    {
        #region Fields
        private int timeZone = 7;
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

            DayCalendar_FillValue();
            MonthCalendar_FillValue();

            cldLunarDayCalendar.SelectedDate = DateTime.Today;
            cldLunarMonthCalendar.SelectedMonth = DateTime.Today;
        }
        #endregion

        #region Methods
        //KeyPress
        private void txtLunarCalendar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar) || Char.IsControl(e.KeyChar)))
                e.Handled = true;
        }

        //Tab DayCalendar
        private void txtDayCalendar_Year_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDayCalendar_Today.Focus();
                ((TextBox)sender).Focus();
            }
        }

        private void DayCalendar_FillValue()
        {
            //Solar Date
                //Year
            txtDayCalendar_Solar_Year.Text = currentSolarDate.Year.ToString("0000");
                //Month
            cmbDayCalendar_Solar_Month.Text = currentSolarDate.Month.ToString("00");
                //Day
            cmbDayCalendar_Solar_Day.Items.Clear();
            int n = SolarDate.GetNumberOfDaysInMonth(currentSolarDate.Month, currentSolarDate.Year);
            for (int i = 1; i <= n; i++)
                cmbDayCalendar_Solar_Day.Items.Add((i).ToString("00"));
            cmbDayCalendar_Solar_Day.Text = currentSolarDate.Day.ToString("00");

            //Lunar Date
                //Year
            txtDayCalendar_Lunar_Year.Text = currentLunarDate.Year.ToString("0000");
                //Month
            cmbDayCalendar_Lunar_Month.Items.Clear();
            foreach (string month in LunarDate.GetMonths(currentLunarDate.Year, timeZone))
                cmbDayCalendar_Lunar_Month.Items.Add(month);
            string str = currentLunarDate.Month.ToString("00");
            if (currentLunarDate.IsLeapMonth)
                str += " nhuận";
            cmbDayCalendar_Lunar_Month.Text = str;
                //Day
            cmbDayCalendar_Lunar_Day.Items.Clear();
            int m = LunarDate.GetNumberOfDaysInMonth(currentLunarDate.Month, currentLunarDate.IsLeapMonth, currentLunarDate.Year, timeZone);
            for (int i = 1; i <= m; i++)
                cmbDayCalendar_Lunar_Day.Items.Add(i.ToString("00"));
            cmbDayCalendar_Lunar_Day.Text = currentLunarDate.Day.ToString("00");
        }
        
        private void cldLunarDayCalendar_SelectedDateChanged(object sender, EventArgs e)
        {
            currentSolarDate = new SolarDate(cldLunarDayCalendar.SelectedDate);
            currentLunarDate = currentSolarDate.ToLunarDate(timeZone);

            DayCalendar_UpdateValue();

            if (currentSolarDate == SolarDate.MinValue)
                btnDayCalendar_PreviousDate.Enabled = false;
            else
                btnDayCalendar_PreviousDate.Enabled = true;

            if (currentSolarDate == SolarDate.MaxValue)
                btnDayCalendar_NextDate.Enabled = false;
            else
                btnDayCalendar_NextDate.Enabled = true;
        }

        private void DayCalendar_UpdateValue()
        {
            //Solar Date
                //Year
            txtDayCalendar_Solar_Year.Text = currentSolarDate.Year.ToString("0000");
                //Month
            cmbDayCalendar_Solar_Month.Text = currentSolarDate.Month.ToString("00");
                //Day
            cmbDayCalendar_Solar_Day.Items.Clear();
            int n = SolarDate.GetNumberOfDaysInMonth(currentSolarDate.Month, currentSolarDate.Year);
            for (int i = 1; i <= n; i++)
                cmbDayCalendar_Solar_Day.Items.Add(i.ToString("00"));
            cmbDayCalendar_Solar_Day.Text = currentSolarDate.Day.ToString("00");

            //Lunar Date
                //Year
            txtDayCalendar_Lunar_Year.Text = currentLunarDate.Year.ToString("0000");
                //Month
            if (currentLunarDate.Year > 0)
            {                
                cmbDayCalendar_Lunar_Month.Items.Clear();
                ArrayList months = months = LunarDate.GetMonths(currentLunarDate.Year, timeZone);
                foreach (string month in months)
                    cmbDayCalendar_Lunar_Month.Items.Add(month);
                string str = currentLunarDate.Month.ToString("00");
                if (currentLunarDate.IsLeapMonth)
                    str += " nhuận";
                cmbDayCalendar_Lunar_Month.Text = str;
            }
            else if (currentLunarDate.Year == 0)
            {
                cmbDayCalendar_Lunar_Month.Items.Clear();
                cmbDayCalendar_Lunar_Month.Items.Add("11");
                cmbDayCalendar_Lunar_Month.Items.Add("12");
                cmbDayCalendar_Lunar_Month.Text = currentLunarDate.Month.ToString("00");
            }

            //Day
            if (currentLunarDate.Year > 0 || (currentLunarDate.Year == 0 && currentLunarDate.Month > 11))
            {
                cmbDayCalendar_Lunar_Day.Items.Clear();
                int m = LunarDate.GetNumberOfDaysInMonth(currentLunarDate.Month, currentLunarDate.IsLeapMonth, currentLunarDate.Year, timeZone);
                for (int i = 1; i <= m; i++)
                    cmbDayCalendar_Lunar_Day.Items.Add((i).ToString("00"));
                cmbDayCalendar_Lunar_Day.Text = currentLunarDate.Day.ToString("00");
            }
            else if (currentLunarDate.Year == 0 && currentLunarDate.Month == 11)
            {
                cmbDayCalendar_Lunar_Day.Items.Clear();
                for (int i = 19; i <= 30; i++)
                    cmbDayCalendar_Lunar_Day.Items.Add(i.ToString());
                cmbDayCalendar_Lunar_Day.Text = currentLunarDate.Day.ToString("00");
            }
        }

        private void txtDayCalendar_Solar_Year_Validating(object sender, CancelEventArgs e)
        {
            //Kiểm tra giá trị năm
            if (currentSolarDate.Year == int.Parse(txtDayCalendar_Solar_Year.Text))
                return;

            try
            {
                int year = int.Parse(txtDayCalendar_Solar_Year.Text);
                if (year < 1 || year > 9999)
                    throw new Exception();
                txtDayCalendar_Solar_Year.Text = year.ToString("0000");
            }
            catch
            {
                MessageBox.Show("Nhập lại giá trị năm", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDayCalendar_Solar_Year.SelectAll();
                e.Cancel = true;
            }
        }

        private void txtDayCalendar_Solar_Year_Validated(object sender, EventArgs e)
        {
            int currentSolarYear = int.Parse(txtDayCalendar_Solar_Year.Text);
            DayCalendar_ModifySelectedDate_Solar(currentSolarDate.Month, currentSolarYear);
            cldLunarDayCalendar.SelectedDate = new DateTime(currentSolarYear, currentSolarDate.Month, currentSolarDate.Day);
        }

        private void cmbDayCalendar_Solar_Month_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDayCalendar_Solar_Month.SelectedIndex == -1)
                return;

            int currentSolarMonth = int.Parse(cmbDayCalendar_Solar_Month.Text);
            DayCalendar_ModifySelectedDate_Solar(currentSolarMonth, currentSolarDate.Year);
            cldLunarDayCalendar.SelectedDate = new DateTime(currentSolarDate.Year, currentSolarMonth, currentSolarDate.Day);
        }

        private void DayCalendar_ModifySelectedDate_Solar(int solarMonth, int solarYear)
        {
            //Day
            int n = SolarDate.GetNumberOfDaysInMonth(solarMonth, solarYear);
            if (currentSolarDate.Day > n)
                currentSolarDate = new SolarDate(n, solarMonth, solarYear);
        }

        private void cmbDayCalendar_Solar_Day_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDayCalendar_Solar_Day.SelectedIndex == -1)
                return;

            int currentSolarDay = int.Parse(cmbDayCalendar_Solar_Day.Text);
            cldLunarDayCalendar.SelectedDate = new DateTime(currentSolarDate.Year, currentSolarDate.Month, currentSolarDay);
        }

        private void txtDayCalendar_Lunar_Year_Validating(object sender, CancelEventArgs e)
        {
            //Kiểm tra giá trị năm
            if (currentLunarDate.Year == int.Parse(txtDayCalendar_Lunar_Year.Text))
                return;

            try
            {
                int year = int.Parse(txtDayCalendar_Lunar_Year.Text);
                if (year < 0 || year > 9999)
                    throw new Exception();
                
                txtDayCalendar_Lunar_Year.Text = year.ToString("0000");
            }
            catch
            {
                MessageBox.Show("Nhập lại giá trị năm", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDayCalendar_Lunar_Year.SelectAll();
                e.Cancel = true;
            }
        }

        private void txtDayCalendar_Lunar_Year_Validated(object sender, EventArgs e)
        {
            try
            {
                lblDayCalendar_Error.Visible = false;
                btnDayCalendar_PreviousDate.Enabled = true;
                btnDayCalendar_NextDate.Enabled = true;

                int currentLunarYear = int.Parse(txtDayCalendar_Lunar_Year.Text);
                DayCalendar_ModifySelectedDate_Lunar(currentLunarDate.Month, currentLunarDate.IsLeapMonth, currentLunarYear);
                cldLunarDayCalendar.SelectedDate = new DateTime(currentSolarDate.Year, currentSolarDate.Month, currentSolarDate.Day);
            }
            catch (Exception exc)
            {
                lblDayCalendar_Error.Text = "Lỗi: " + exc.Message;
                lblDayCalendar_Error.Visible = true;
                btnDayCalendar_PreviousDate.Enabled = false;
                btnDayCalendar_NextDate.Enabled = false;
            }
        }

        private void cmbDayCalendar_Lunar_Month_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDayCalendar_Lunar_Month.SelectedIndex == -1)
                return;

            try
            {
                lblDayCalendar_Error.Visible = false;
                btnDayCalendar_PreviousDate.Enabled = true;
                btnDayCalendar_NextDate.Enabled = true;

                int currentLunarMonth = int.Parse(cmbDayCalendar_Lunar_Month.Text.Substring(0, 2));
                bool currentLunarIsLeapMonth;
                if (cmbDayCalendar_Lunar_Month.Text.Length > 2)
                    currentLunarIsLeapMonth = true;
                else
                    currentLunarIsLeapMonth = false;
                DayCalendar_ModifySelectedDate_Lunar(currentLunarMonth, currentLunarIsLeapMonth, currentLunarDate.Year);
                cldLunarDayCalendar.SelectedDate = new DateTime(currentSolarDate.Year, currentSolarDate.Month, currentSolarDate.Day);
            }
            catch (Exception exc)
            {
                lblDayCalendar_Error.Text = "Lỗi: " + exc.Message;
                lblDayCalendar_Error.Visible = true;
                btnDayCalendar_PreviousDate.Enabled = false;
                btnDayCalendar_NextDate.Enabled = false;
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
            ArrayList months = LunarDate.GetMonths(lunarYear, timeZone);
            if (lunarIsLeapMonth)
            {
                bool flag = false;
                foreach (string month in months)
                {
                    if (month.Length > 2 && month.Substring(0, 2) == lunarMonth.ToString("00"))
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

        private void cmbDayCalendar_Lunar_Day_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDayCalendar_Lunar_Day.SelectedIndex == -1)
                return;

            try
            {
                lblDayCalendar_Error.Visible = false;
                btnDayCalendar_PreviousDate.Enabled = true;
                btnDayCalendar_NextDate.Enabled = true;

                int currentLunarDay = int.Parse(cmbDayCalendar_Lunar_Day.Text);
                currentLunarDate = new LunarDate(currentLunarDay, currentLunarDate.Month, currentLunarDate.IsLeapMonth, currentLunarDate.Year, timeZone);
                currentSolarDate = currentLunarDate.ToSolarDate();
                cldLunarDayCalendar.SelectedDate = new DateTime(currentSolarDate.Year, currentSolarDate.Month, currentSolarDate.Day);
            }
            catch (Exception exc)
            {
                lblDayCalendar_Error.Text = "Lỗi: " + exc.Message;
                lblDayCalendar_Error.Visible = true;
                btnDayCalendar_PreviousDate.Enabled = false;
                btnDayCalendar_NextDate.Enabled = false;
            }
        }

        private void btnDayCalendar_PreviousDate_Click(object sender, EventArgs e)
        {
            cldLunarDayCalendar.SelectedDate = cldLunarDayCalendar.SelectedDate.AddDays(-1);
        }

        private void btnDayCalendar_NextDate_Click(object sender, EventArgs e)
        {
            cldLunarDayCalendar.SelectedDate = cldLunarDayCalendar.SelectedDate.AddDays(1);
        }

        private void btnDayCalendar_Today_Click(object sender, EventArgs e)
        {
            cldLunarDayCalendar.SelectedDate = DateTime.Today;
        }
        
        private void rdbDayCalendar_CheckedChanged(object sender, EventArgs e)
        {
            txtDayCalendar_Solar_Year.Enabled = rdbDayCalendar_Solar.Checked;
            cmbDayCalendar_Solar_Month.Enabled = rdbDayCalendar_Solar.Checked;
            cmbDayCalendar_Solar_Day.Enabled = rdbDayCalendar_Solar.Checked;

            txtDayCalendar_Lunar_Year.Enabled = rdbDayCalendar_Lunar.Checked;
            cmbDayCalendar_Lunar_Month.Enabled = rdbDayCalendar_Lunar.Checked;
            cmbDayCalendar_Lunar_Day.Enabled = rdbDayCalendar_Lunar.Checked;
        }
        //Tab MonthCalendar
        private void txtMonthCalendar_Year_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnMonthCalendar_Today.Focus();
                ((TextBox)sender).Focus();
            }
        }

        private void MonthCalendar_FillValue()
        {
            txtMonthCalendar_Year.Text = currentYear.ToString("0000");
            cmbMonthCalendar_Month.Text = currentMonth.ToString("00");
        }

        private void cldLunarMonthCalendar_SelectedMonthChanged(object sender, EventArgs e)
        {
            currentMonth = cldLunarMonthCalendar.SelectedMonth.Month;
            currentYear = cldLunarMonthCalendar.SelectedMonth.Year;

            txtMonthCalendar_Year.Text = cldLunarMonthCalendar.SelectedMonth.Year.ToString("0000");
            cmbMonthCalendar_Month.Text = cldLunarMonthCalendar.SelectedMonth.Month.ToString("00");

            if (currentYear == 1 && currentMonth == 1)
                btnMonthCalendar_PreviousMonth.Enabled = false;
            else
                btnMonthCalendar_PreviousMonth.Enabled = true;

            if (currentYear == 9999 && currentMonth == 12)
                btnMonthCalendar_NextMonth.Enabled = false;
            else
                btnMonthCalendar_NextMonth.Enabled = true;
        }

        private void txtMonthCalendar_Year_Validating(object sender, CancelEventArgs e)
        {
            //Kiểm tra giá trị năm
            if (currentYear == int.Parse(txtMonthCalendar_Year.Text))
                return;

            try
            {
                int year = int.Parse(txtMonthCalendar_Year.Text);
                if (year < 1 || year > 9999)
                    throw new Exception();
                txtMonthCalendar_Year.Text = year.ToString("0000");
            }
            catch
            {
                MessageBox.Show("Nhập lại giá trị năm", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMonthCalendar_Year.SelectAll();
                e.Cancel = true;
            }
        }

        private void txtMonthCalendar_Year_Validated(object sender, EventArgs e)
        {
            currentYear = int.Parse(txtMonthCalendar_Year.Text);
            cldLunarMonthCalendar.SelectedMonth = new DateTime(currentYear, currentMonth, 1);
        }

        private void cmbMonthCalendar_Month_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentMonth = int.Parse(cmbMonthCalendar_Month.Text);
            cldLunarMonthCalendar.SelectedMonth = new DateTime(currentYear, currentMonth, 1);
        }

        private void btnMonthCalendar_PreviousMonth_Click(object sender, EventArgs e)
        {
            if (currentMonth == 1)
                cldLunarMonthCalendar.SelectedMonth = new DateTime(currentYear - 1, 12, 1);
            else
                cldLunarMonthCalendar.SelectedMonth = new DateTime(currentYear, currentMonth - 1, 1);
        }

        private void btnMonthCalendar_NextMonth_Click(object sender, EventArgs e)
        {
            if (currentMonth == 12)
                cldLunarMonthCalendar.SelectedMonth = new DateTime(currentYear + 1, 1, 1);
            else
                cldLunarMonthCalendar.SelectedMonth = new DateTime(currentYear, currentMonth + 1, 1);
        }

        private void btnMonthCalendar_Today_Click(object sender, EventArgs e)
        {
            cldLunarMonthCalendar.SelectedMonth = DateTime.Today;
        }
        #endregion
    }
}
