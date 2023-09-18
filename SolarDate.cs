namespace LunarCalendar
{
    public class SolarDate
    {
        #region Fields
        private readonly int day;
        private readonly int month;
        private readonly int year;
        private readonly long julianDayNumber;
        #endregion

        #region Properties
        public int Day
        {
            get { return day; }
        }
        public string DayOfWeek
        {
            get
            {
                DateTime date = new(year, month, day);
                return date.DayOfWeek switch
                {
                    System.DayOfWeek.Monday => "Thứ hai",
                    System.DayOfWeek.Tuesday => "Thứ ba",
                    System.DayOfWeek.Wednesday => "Thứ tư",
                    System.DayOfWeek.Thursday => "Thứ năm",
                    System.DayOfWeek.Friday => "Thứ sáu",
                    System.DayOfWeek.Saturday => "Thứ bảy",
                    _ => "Chủ nhật",
                };
            }
        }
        public int Month
        {
            get { return month; }
        }
        public string MonthName
        {
            get
            {
                return month switch
                {
                    1 => "Tháng một",
                    2 => "Tháng hai",
                    3 => "Tháng ba",
                    4 => "Tháng tư",
                    5 => "Tháng năm",
                    6 => "Tháng sáu",
                    7 => "Tháng bảy",
                    8 => "Tháng tám",
                    9 => "Tháng chín",
                    10 => "Tháng mười",
                    11 => "Tháng mười một",
                    _ => "Tháng mười hai",
                };
            }
        }
        public int Year
        {
            get { return year; }
        }
        public long JulianDayNumber
        {
            get { return julianDayNumber; }
        }
        public static SolarDate MinValue
        {
            get { return new SolarDate(1, 1, 1); }
        }
        public static SolarDate MaxValue
        {
            get { return new SolarDate(31, 12, 9999); }
        }
        #endregion

        #region Operators
        public static bool operator ==(SolarDate solarDate1, SolarDate solarDate2)
        {
            return solarDate1.Year == solarDate2.Year && solarDate1.Month == solarDate2.Month && solarDate1.Day == solarDate2.Day;
        }

        public static bool operator !=(SolarDate solarDate1, SolarDate solarDate2)
        {
            if (solarDate1.Year != solarDate2.Year || solarDate1.Month != solarDate2.Month || solarDate1.Day != solarDate2.Day)
                return true;
            else
                return false;
        }

        public override bool Equals(object? obj)
        {
            if (obj == null || obj.GetType() != typeof(SolarDate))
                return false;

            SolarDate solarDate = (SolarDate)obj;
            return solarDate.Year != year || solarDate.Month != month || solarDate.Day != day;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        #endregion

        #region Constructors
        public SolarDate(int Day, int Month, int Year)
        {
            day = Day;
            month = Month;
            year = Year;

            int a = (14 - month) / 12;
            int y = year + 4800 - a;
            int m = month + 12 * a - 3;
            julianDayNumber = day + (153 * m + 2) / 5 + 365 * y + y / 4 - y / 100 + y / 400 - 32045;
            if (julianDayNumber < 2299161)
                julianDayNumber = day + (153 * m + 2) / 5 + 365 * y + y / 4 - 32083;
        }

        public SolarDate(DateTime Date)
        {
            day = Date.Day;
            month = Date.Month;
            year = Date.Year;

            int a = (14 - month) / 12;
            int y = year + 4800 - a;
            int m = month + 12 * a - 3;
            julianDayNumber = day + (153 * m + 2) / 5 + 365 * y + y / 4 - y / 100 + y / 400 - 32045;
            if (julianDayNumber < 2299161)
                julianDayNumber = day + (153 * m + 2) / 5 + 365 * y + y / 4 - 32083;
        }

        public SolarDate(long JulianDayNumber)
        {
            julianDayNumber = JulianDayNumber;
            long a;
            long b;
            long c;
            if (JulianDayNumber > 2299160)
            {
                a = JulianDayNumber + 32044;
                b = (4 * a + 3) / 146097;
                c = a - (b * 146097) / 4;
            }
            else
            {
                b = 0;
                c = JulianDayNumber + 32082;
            }
            long d = (4 * c + 3) / 1461;
            long e = c - (1461 * d) / 4;
            long m = (5 * e + 2) / 153;
            day = (int)(e - (153 * m + 2) / 5 + 1);
            month = (int)(m + 3 - 12 * (m / 10));
            year = (int)(b * 100 + d - 4800 + m / 10);
        }
        #endregion

        #region Methods
        public LunarDate ToLunarDate(int TimeZone)
        {
            return CalendarConversion.ConvertSolarDateToLunarDate(this, TimeZone);
        }

        public DateTime ToDateTime()
        {
            return new DateTime(year, month, day);
        }

        public static int GetNumberOfDaysInMonth(int month, int year)
        {
            int numberOfDaysInMonth;
            switch (month)
            {
                case 1:
                    numberOfDaysInMonth = 31;
                    break;
                case 2:
                    if (year % 4 == 0 && !(year % 100 == 0 && !(year % 400 == 0)))
                        numberOfDaysInMonth = 29;
                    else
                        numberOfDaysInMonth = 28;
                    break;
                case 3:
                    numberOfDaysInMonth = 31;
                    break;
                case 4:
                    numberOfDaysInMonth = 30;
                    break;
                case 5:
                    numberOfDaysInMonth = 31;
                    break;
                case 6:
                    numberOfDaysInMonth = 30;
                    break;
                case 7:
                    numberOfDaysInMonth = 31;
                    break;
                case 8:
                    numberOfDaysInMonth = 31;
                    break;
                case 9:
                    numberOfDaysInMonth = 30;
                    break;
                case 10:
                    numberOfDaysInMonth = 31;
                    break;
                case 11:
                    numberOfDaysInMonth = 30;
                    break;
                default:
                    numberOfDaysInMonth = 31;
                    break;
            }
            return numberOfDaysInMonth;
        }
        #endregion
    }
}
