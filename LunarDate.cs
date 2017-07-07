using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunarCalendar
{
    public class LunarDate
    {
        #region Fields
        private int day;
        private int month;
        private bool isLeapMonth;
        private int year;
        private int timeZone;
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
                string CelestialStem = "";
                switch (relatedSolarDate.JulianDayNumber % 10)
                {
                    case 0:
                        CelestialStem = "Quý";
                        break;
                    case 1:
                        CelestialStem = "Giáp";
                        break;
                    case 2:
                        CelestialStem = "Ất";
                        break;
                    case 3:
                        CelestialStem = "Bính";
                        break;
                    case 4:
                        CelestialStem = "Đinh";
                        break;
                    case 5:
                        CelestialStem = "Mậu";
                        break;
                    case 6:
                        CelestialStem = "Kỷ";
                        break;
                    case 7:
                        CelestialStem = "Canh";
                        break;
                    case 8:
                        CelestialStem = "Tân";
                        break;
                    default:
                        CelestialStem = "Nhâm";
                        break;
                }
                string EarthlyBranch = "";
                switch (relatedSolarDate.JulianDayNumber % 12)
                {
                    case 0:
                        EarthlyBranch = "Sửu";
                        break;
                    case 1:
                        EarthlyBranch = "Dần";
                        break;
                    case 2:
                        EarthlyBranch = "Mão";
                        break;
                    case 3:
                        EarthlyBranch = "Thìn";
                        break;
                    case 4:
                        EarthlyBranch = "Tỵ";
                        break;
                    case 5:
                        EarthlyBranch = "Ngọ";
                        break;
                    case 6:
                        EarthlyBranch = "Mùi";
                        break;
                    case 7:
                        EarthlyBranch = "Thân";
                        break;
                    case 8:
                        EarthlyBranch = "Dậu";
                        break;
                    case 9:
                        EarthlyBranch = "Tuất";
                        break;
                    case 10:
                        EarthlyBranch = "Hợi";
                        break;
                    default:
                        EarthlyBranch = "Tý";
                        break;
                }
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
                string CelestialStem = "";
                switch ((year * 12 + month + 3) % 10)
                {
                    case 0:
                        CelestialStem = "Giáp";
                        break;
                    case 1:
                        CelestialStem = "Ất";
                        break;
                    case 2:
                        CelestialStem = "Bính";
                        break;
                    case 3:
                        CelestialStem = "Đinh";
                        break;
                    case 4:
                        CelestialStem = "Mậu";
                        break;
                    case 5:
                        CelestialStem = "Kỷ";
                        break;
                    case 6:
                        CelestialStem = "Canh";
                        break;
                    case 7:
                        CelestialStem = "Tân";
                        break;
                    case 8:
                        CelestialStem = "Nhâm";
                        break;
                    default:
                        CelestialStem = "Quý";
                        break;
                }
                string EarthlyBranch = "";
                switch (month)
                {
                    case 1:
                        EarthlyBranch = "Dần";
                        break;
                    case 2:
                        EarthlyBranch = "Mão";
                        break;
                    case 3:
                        EarthlyBranch = "Thìn";
                        break;
                    case 4:
                        EarthlyBranch = "Tỵ";
                        break;
                    case 5:
                        EarthlyBranch = "Ngọ";
                        break;
                    case 6:
                        EarthlyBranch = "Mùi";
                        break;
                    case 7:
                        EarthlyBranch = "Thân";
                        break;
                    case 8:
                        EarthlyBranch = "Dậu";
                        break;
                    case 9:
                        EarthlyBranch = "Tuất";
                        break;
                    case 10:
                        EarthlyBranch = "Hợi";
                        break;
                    case 11:
                        EarthlyBranch = "Tý";
                        break;
                    default:
                        EarthlyBranch = "Sửu";
                        break;
                }
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
                string CelestialStem = "";
                switch (year % 10)
                {
                    case 0:
                        CelestialStem = "Canh";
                        break;
                    case 1:
                        CelestialStem = "Tân";
                        break;
                    case 2:
                        CelestialStem = "Nhâm";
                        break;
                    case 3:
                        CelestialStem = "Quý";
                        break;
                    case 4:
                        CelestialStem = "Giáp";
                        break;
                    case 5:
                        CelestialStem = "Ất";
                        break;
                    case 6:
                        CelestialStem = "Bính";
                        break;
                    case 7:
                        CelestialStem = "Đinh";
                        break;
                    case 8:
                        CelestialStem = "Mậu";
                        break;
                    default:
                        CelestialStem = "Kỷ";
                        break;
                }
                string EarthlyBranch = "";
                switch (year % 12)
                {
                    case 0:
                        EarthlyBranch = "Thân";
                        break;
                    case 1:
                        EarthlyBranch = "Dậu";
                        break;
                    case 2:
                        EarthlyBranch = "Tuất";
                        break;
                    case 3:
                        EarthlyBranch = "Hợi";
                        break;
                    case 4:
                        EarthlyBranch = "Tý";
                        break;
                    case 5:
                        EarthlyBranch = "Sửu";
                        break;
                    case 6:
                        EarthlyBranch = "Dần";
                        break;
                    case 7:
                        EarthlyBranch = "Mão";
                        break;
                    case 8:
                        EarthlyBranch = "Thìn";
                        break;
                    case 9:
                        EarthlyBranch = "Tỵ";
                        break;
                    case 10:
                        EarthlyBranch = "Ngọ";
                        break;
                    default:
                        EarthlyBranch = "Mùi";
                        break;
                }
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

        public static ArrayList GetMonths(int year, int timeZone)
        {
            ArrayList months = new ArrayList();
            LunarDate lunarDate1 = new LunarDate(1, 1, false, year, timeZone);

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
                testDate_Solar = new SolarDate(newMoonDay.JulianDayNumber + 32);
                testDate_Lunar = testDate_Solar.ToLunarDate(timeZone);

                newMoonDay = new LunarDate(1, testDate_Lunar.Month, testDate_Lunar.isLeapMonth, year, timeZone);
            }
            while (testDate_Lunar.Year == year);

            return months;
        }

        public static int GetNumberOfDaysInMonth(int month, bool isLeapMonth, int year, int timeZone)
        {
            if (year == 9999 && month == 12)
                return 29;

            LunarDate newMoonDay_Lunar = new LunarDate(1, month, isLeapMonth, year, timeZone);
            SolarDate newMoonDay_Solar = newMoonDay_Lunar.ToSolarDate();

            SolarDate testDate_Solar = new SolarDate(newMoonDay_Solar.JulianDayNumber + 32);
            LunarDate testDate_Lunar = testDate_Solar.ToLunarDate(timeZone);

            LunarDate nextNewMoonDay_Lunar = new LunarDate(1, testDate_Lunar.Month, testDate_Lunar.isLeapMonth, testDate_Lunar.Year, timeZone);
            SolarDate nextNewMoonDay_Solar = nextNewMoonDay_Lunar.ToSolarDate();

            return (int)(nextNewMoonDay_Solar.JulianDayNumber - newMoonDay_Solar.JulianDayNumber);
        }
        #endregion
    }
}
