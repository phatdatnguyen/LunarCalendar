using System.ComponentModel;
using System.Reflection;

namespace LunarCalendar
{
    public partial class LunarMonthCalendar : UserControl
    {
        #region Enum
        public enum LunarCalendarType { Vietnamese, Chinese }
        #endregion

        #region Fields
        private DateTime selectedMonth;
        private int timeZone = 7;
        private LunarCalendarType calendarType = LunarCalendarType.Vietnamese;
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

        [Description("Selected month"),
        Category("Behavior"),
        Browsable(true)]
        public DateTime SelectedMonth
        {
            get { return selectedMonth; }
            set
            {
                if (selectedMonth == value)
                    return;

                selectedMonth = value;
                DateTime FirstDayOfMonth = new(selectedMonth.Year, selectedMonth.Month, 1);
                int startColumn = FirstDayOfMonth.DayOfWeek switch
                {
                    DayOfWeek.Sunday => 0,
                    DayOfWeek.Monday => 1,
                    DayOfWeek.Tuesday => 2,
                    DayOfWeek.Wednesday => 3,
                    DayOfWeek.Thursday => 4,
                    DayOfWeek.Friday => 5,
                    _ => 6,
                };
                DateTime startDate;
                int k;
                if (selectedMonth.Year == 1 && selectedMonth.Month == 1)    //MinValue
                {
                    startDate = FirstDayOfMonth;
                    k = -startColumn;
                }
                else
                {
                    startDate = FirstDayOfMonth.AddDays(-startColumn);
                    k = 0;
                }

                for (int i = 0; i < 6; i++)
                    for (int j = 0; j < 7; j++)
                    {
                        DateEntry? currentDateEntry = null;

                        foreach (Control control in tableLayoutPanel.Controls)
                        {
                            if (control.GetType() != typeof(DateEntry))
                                continue;

                            DateEntry dateEntry = (DateEntry)control;
                            if (dateEntry.Name.Substring(2, 1) == (i + 1).ToString() && dateEntry.Name.Substring(3, 1) == (j + 1).ToString())
                            {
                                currentDateEntry = dateEntry;
                                break;
                            }
                        }

                        if (currentDateEntry != null)
                        {
                            currentDateEntry.Visible = true;

                            if (k < 0)  //MinValue
                            {
                                currentDateEntry.Visible = false;
                                k++;
                            }

                            else if (selectedMonth.Year == 9999 && selectedMonth.Month == 12 && k > startColumn + 30)   //MaxValue
                            {
                                currentDateEntry.Visible = false;
                                k++;
                            }

                            else
                            {
                                SolarDate solarDate = new(startDate.AddDays(k));
                                LunarDate lunarDate = solarDate.ToLunarDate(timeZone);
                                currentDateEntry.SolarDate = solarDate.Day;
                                currentDateEntry.LunarDate = lunarDate.Day;
                                if (lunarDate.IsLeapMonth)
                                    currentDateEntry.ToolTip = "Dương lịch:\n\t" +
                                        solarDate.DayOfWeek + "\n\t" +
                                        "Ngày " + solarDate.Day + "\n\t" +
                                        "Tháng " + solarDate.Month + "\n\t" +
                                        "Năm " + solarDate.Year + "\n" +
                                        "Âm lịch:\n\t" +
                                        "Ngày " + lunarDate.Day + " - " + lunarDate.DayName + "\n\t" +
                                        "Tháng " + lunarDate.Month + " nhuận - " + lunarDate.MonthName + "\n\t" +
                                        "Năm " + lunarDate.Year + " - " + lunarDate.YearName;
                                else
                                    currentDateEntry.ToolTip = "Dương lịch:\n\t" +
                                        solarDate.DayOfWeek + "\n\t" +
                                        "Ngày " + solarDate.Day + "\n\t" +
                                        "Tháng " + solarDate.Month + "\n\t" +
                                        "Năm " + solarDate.Year + "\n" +
                                        "Âm lịch:\n\t" +
                                        "Ngày " + lunarDate.Day + " - " + lunarDate.DayName + "\n\t" +
                                        "Tháng " + lunarDate.Month + " - " + lunarDate.MonthName + "\n\t" +
                                        "Năm " + lunarDate.Year + " - " + lunarDate.YearName;
                                if (solarDate.ToDateTime() == DateTime.Today)
                                    currentDateEntry.BackColor = Color.Pink;
                                else
                                    currentDateEntry.BackColor = Color.Transparent;

                                if (solarDate.Month != selectedMonth.Month)
                                    currentDateEntry.ForeColor = Color.Gray;
                                else if (solarDate.DayOfWeek == "Thứ bảy")
                                    currentDateEntry.ForeColor = Color.Blue;
                                else if (solarDate.DayOfWeek == "Chủ nhật")
                                    currentDateEntry.ForeColor = Color.Red;
                                else
                                    currentDateEntry.ForeColor = Color.Black;

                                k++;
                            }
                        }
                    }

                Invalidate();

                OnSelectedMonthChanged(EventArgs.Empty);
            }
        }
        #endregion

        #region Event
        public delegate void SelectedMonthChangedEventHandler(object sender, EventArgs e);

        [Description("Occur when the selected month is changed"),
        Category("Behavior"),
        Browsable(true)]
        public event SelectedMonthChangedEventHandler? SelectedMonthChanged;

        protected virtual void OnSelectedMonthChanged(EventArgs e)
        {
            SelectedMonthChanged?.Invoke(this, e);
        }
        #endregion

        #region Constructor
        public LunarMonthCalendar()
        {
            InitializeComponent();

            // Enable double buffering
            typeof(Panel).InvokeMember("DoubleBuffered",
                BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
                null, tableLayoutPanel, new object[] { true });

            selectedMonth = DateTime.Today;
        }
        #endregion
    }
}
