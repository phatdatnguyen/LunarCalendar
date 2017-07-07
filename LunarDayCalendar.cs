using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LunarCalendar
{
    public partial class LunarDayCalendar : UserControl
    {
        #region Enum
        public enum LunarCalendarType { Vietnamese, Chinese }
        #endregion

        #region Fields
        private LunarCalendarType calendarType = LunarCalendarType.Vietnamese;
        private int timeZone = 7;
        private DateTime selectedDate = DateTime.Today;
        #endregion

        #region Properties
        [Description("Calendar type"),
        Category("Behavior"),
        Browsable(true),
        DefaultValue(typeof(LunarCalendarType), "Vietnamese")]
        public LunarCalendarType CalendarType 
        {
            get { return calendarType; }
            set
            {
                calendarType = value;
                switch (calendarType)
                {
                    case LunarCalendarType.Vietnamese:
                        timeZone = 7;
                        break;
                    case LunarCalendarType.Chinese:
                        timeZone = 8;
                        break;
                }

                Invalidate();
            }
        }
        
        [Description("Solar date"),
        Category("Behavior"),
        Browsable(true)]
        public DateTime SelectedDate
        {
            get { return selectedDate; }
            set
            {
                if (selectedDate == value)
                    return;

                selectedDate = value;

                SolarDate solarDate = new SolarDate(selectedDate.Day, selectedDate.Month, selectedDate.Year);
                lblSolar_Day.Text = solarDate.Day.ToString();
                lblSolar_MonthName.Text = solarDate.MonthName;
                lblSolar_Year.Text = solarDate.Year.ToString();
                lblSolar_DayOfWeek.Text = solarDate.DayOfWeek;

                LunarDate lunarDate = solarDate.ToLunarDate(timeZone);
                lblLunar_Day.Text = lunarDate.Day.ToString();
                lblLunar_Month.Text = lunarDate.Month.ToString();
                lblLunar_Year.Text = lunarDate.Year.ToString();
                lblLunar_DayName.Text = lunarDate.DayName;
                lblLunar_MonthName.Text = lunarDate.MonthName;
                lblLunar_YearName.Text = lunarDate.YearName;
                lblLunar_LeapMonth.Visible = lunarDate.IsLeapMonth;

                Invalidate();

                OnSelectedDateChanged(EventArgs.Empty);
            }
        }
        #endregion

        #region Event
        public delegate void SelectedDateChangedEventHandler(object sender, EventArgs e);

        [Description("Occur when the selected date is changed"),
        Category("Behavior"),
        Browsable(true)]
        public event SelectedDateChangedEventHandler SelectedDateChanged;

        protected virtual void OnSelectedDateChanged(EventArgs e)
        {
            if (SelectedDateChanged != null)
                SelectedDateChanged(this, e);
        }
        #endregion

        #region Constructor
        public LunarDayCalendar()
        {
            InitializeComponent();

            selectedDate = DateTime.Today;
        }
        #endregion
    }
}
