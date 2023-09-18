using System.Collections;

namespace LunarCalendar
{
    public class LunarDate
    {
        #region Fields
        private readonly int day;
        private readonly int month;
        private readonly bool isLeapMonth;
        private readonly int year;
        private readonly int timeZone;
        #endregion

        #region Properties
        public int Day
        {
            get { return day; }
        }
        public string DayName
        {
            get
            {
                SolarDate relatedSolarDate = ToSolarDate();
                string CelestialStem = (relatedSolarDate.JulianDayNumber % 10) switch
                {
                    0 => "Quý",
                    1 => "Giáp",
                    2 => "Ất",
                    3 => "Bính",
                    4 => "Đinh",
                    5 => "Mậu",
                    6 => "Kỷ",
                    7 => "Canh",
                    8 => "Tân",
                    _ => "Nhâm",
                };
                string EarthlyBranch = (relatedSolarDate.JulianDayNumber % 12) switch
                {
                    0 => "Sửu",
                    1 => "Dần",
                    2 => "Mão",
                    3 => "Thìn",
                    4 => "Tỵ",
                    5 => "Ngọ",
                    6 => "Mùi",
                    7 => "Thân",
                    8 => "Dậu",
                    9 => "Tuất",
                    10 => "Hợi",
                    _ => "Tý",
                };
                return CelestialStem + " " + EarthlyBranch;
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
                string CelestialStem = ((year * 12 + month + 3) % 10) switch
                {
                    0 => "Giáp",
                    1 => "Ất",
                    2 => "Bính",
                    3 => "Đinh",
                    4 => "Mậu",
                    5 => "Kỷ",
                    6 => "Canh",
                    7 => "Tân",
                    8 => "Nhâm",
                    _ => "Quý",
                };
                string EarthlyBranch = month switch
                {
                    1 => "Dần",
                    2 => "Mão",
                    3 => "Thìn",
                    4 => "Tỵ",
                    5 => "Ngọ",
                    6 => "Mùi",
                    7 => "Thân",
                    8 => "Dậu",
                    9 => "Tuất",
                    10 => "Hợi",
                    11 => "Tý",
                    _ => "Sửu",
                };
                return CelestialStem + " " + EarthlyBranch;
            }
        }
        public bool IsLeapMonth
        {
            get { return isLeapMonth; }
        }
        public int Year
        {
            get { return year; }
        }
        public string YearName
        {
            get
            {
                string CelestialStem = (year % 10) switch
                {
                    0 => "Canh",
                    1 => "Tân",
                    2 => "Nhâm",
                    3 => "Quý",
                    4 => "Giáp",
                    5 => "Ất",
                    6 => "Bính",
                    7 => "Đinh",
                    8 => "Mậu",
                    _ => "Kỷ",
                };
                string EarthlyBranch = (year % 12) switch
                {
                    0 => "Thân",
                    1 => "Dậu",
                    2 => "Tuất",
                    3 => "Hợi",
                    4 => "Tý",
                    5 => "Sửu",
                    6 => "Dần",
                    7 => "Mão",
                    8 => "Thìn",
                    9 => "Tỵ",
                    10 => "Ngọ",
                    _ => "Mùi",
                };
                return CelestialStem + " " + EarthlyBranch;
            }
        }
        public int TimeZone
        {
            get { return timeZone; }
        }
        public long JulianDayNumber
        {
            get { return CalendarConversion.JulianDayNumberFromLunarDate(this); }
        }
        #endregion

        #region Constructor
        public LunarDate(int day, int month, bool isLeapMonth, int year, int timeZone)
        {
            this.day = day;
            this.month = month;
            this.year = year;
            this.isLeapMonth = isLeapMonth;
            this.timeZone = timeZone;
        }
        #endregion

        #region Methods
        public SolarDate ToSolarDate()
        {
            return CalendarConversion.ConvertLunarDateToSolarDate(this);
        }

        public static List<string> GetMonths(int year, int timeZone)
        {
            List<string> months = new();
            LunarDate lunarDate1 = new(1, 1, false, year, timeZone);

            LunarDate newMoonDay = lunarDate1;
            SolarDate testDate_Solar;
            LunarDate testDate_Lunar;

            do
            {
                string month = newMoonDay.Month.ToString("00");
                if (newMoonDay.IsLeapMonth)
                    month += " nhuận";
                months.Add(month);

                if (year == 9999 && month == "12")
                    break;
                testDate_Solar = new(newMoonDay.JulianDayNumber + 32);
                testDate_Lunar = testDate_Solar.ToLunarDate(timeZone);

                newMoonDay = new(1, testDate_Lunar.Month, testDate_Lunar.isLeapMonth, year, timeZone);
            }
            while (testDate_Lunar.Year == year);

            return months;
        }

        public static int GetNumberOfDaysInMonth(int month, bool isLeapMonth, int year, int timeZone)
        {
            if (year == 9999 && month == 12)
                return 29;

            LunarDate newMoonDay_Lunar = new(1, month, isLeapMonth, year, timeZone);
            SolarDate newMoonDay_Solar = newMoonDay_Lunar.ToSolarDate();

            SolarDate testDate_Solar = new(newMoonDay_Solar.JulianDayNumber + 32);
            LunarDate testDate_Lunar = testDate_Solar.ToLunarDate(timeZone);

            LunarDate nextNewMoonDay_Lunar = new(1, testDate_Lunar.Month, testDate_Lunar.isLeapMonth, testDate_Lunar.Year, timeZone);
            SolarDate nextNewMoonDay_Solar = nextNewMoonDay_Lunar.ToSolarDate();

            return (int)(nextNewMoonDay_Solar.JulianDayNumber - newMoonDay_Solar.JulianDayNumber);
        }
        #endregion
    }
}
