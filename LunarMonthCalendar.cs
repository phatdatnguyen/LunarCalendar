using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

                int startColumn = 1;

                DateTime FirstDayOfMonth = new DateTime(selectedMonth.Year, selectedMonth.Month, 1);
                switch (FirstDayOfMonth.DayOfWeek)
                {
                    case DayOfWeek.Sunday:
                        startColumn = 0;
                        break;
                    case DayOfWeek.Monday:
                        startColumn = 1;
                        break;
                    case DayOfWeek.Tuesday:
                        startColumn = 2;
                        break;
                    case DayOfWeek.Wednesday:
                        startColumn = 3;
                        break;
                    case DayOfWeek.Thursday:
                        startColumn = 4;
                        break;
                    case DayOfWeek.Friday:
                        startColumn = 5;
                        break;
                    default:
                        startColumn = 6;
                        break;
                }

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

                long startDateJulianDayNumber = (new SolarDate(startDate.Day, startDate.Month, startDate.Year)).JulianDayNumber;
                
                for (int i = 0; i < 6; i++)
                    for (int j = 0; j < 7; j++)
                    {
                        DateEntry currentDateEntry = null;

                        foreach (Control control in Controls)
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


                        //DateEntry currentDateEntry = de11; //(DateEntry)tlpLunarMonthCalendar.GetControlFromPosition(j, i);
                        if (currentDateEntry != null)
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
                            SolarDate solarDate = new SolarDate(startDate.AddDays(k));
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
        public event SelectedMonthChangedEventHandler SelectedMonthChanged;

        protected virtual void OnSelectedMonthChanged(EventArgs e)
        {
            if (SelectedMonthChanged != null)
                SelectedMonthChanged(this, e);
        }
        #endregion

        #region Constructor
        public LunarMonthCalendar()
        {
            InitializeComponent();

            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            SetStyle(ControlStyles.UserPaint, true);

            selectedMonth = DateTime.Today;
        }
        #endregion
    }
}
