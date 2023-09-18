using System.ComponentModel;
using System.Reflection;

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

                SolarDate solarDate = new(selectedDate.Day, selectedDate.Month, selectedDate.Year);
                solarDayLabel.Text = solarDate.Day.ToString();
                solarMonthNameLabel.Text = solarDate.MonthName;
                solarYearLabel.Text = solarDate.Year.ToString();
                solarDayOfWeekLabel.Text = solarDate.DayOfWeek;

                LunarDate lunarDate = solarDate.ToLunarDate(timeZone);
                lunarDayLabel.Text = lunarDate.Day.ToString();
                lunarMonthLabel.Text = lunarDate.Month.ToString();
                lunarYearLabel.Text = lunarDate.Year.ToString();
                lunarDayNameLabel.Text = lunarDate.DayName;
                lunarMonthNameLabel.Text = lunarDate.MonthName;
                lunarYearNameLabel.Text = lunarDate.YearName;
                lunarLeapMonthLabel.Visible = lunarDate.IsLeapMonth;

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
        public event SelectedDateChangedEventHandler? SelectedDateChanged;

        protected virtual void OnSelectedDateChanged(EventArgs e)
        {
            SelectedDateChanged?.Invoke(this, e);
        }
        #endregion

        #region Constructor
        public LunarDayCalendar()
        {
            InitializeComponent();

            // Enable double buffering
            typeof(Panel).InvokeMember("DoubleBuffered",
                BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
                null, panel, new object[] { true });

            selectedDate = DateTime.Today;
        }
        #endregion
    }
}
