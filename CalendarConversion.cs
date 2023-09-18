namespace LunarCalendar
{
    public static class CalendarConversion
    {
        #region Methods
        //Tính ngày Julius của thời điểm Sóc thứ k kể từ điểm Sóc lúc 13:51 GMT ngày 1/1/1900 (ngày Julius 2415021.076998695). 
        private static double NewMoon(long k)
        {
            double T = k / 1236.85; // Time in Julian centuries from 1900 January 0.5
            double T2 = T * T;
            double T3 = T2 * T;
            double dr = Math.PI / 180;
            double Jd1 = 2415020.75933 + 29.53058868 * k + 0.0001178 * T2 - 0.000000155 * T3;
            Jd1 += 0.00033 * Math.Sin((166.56 + 132.87 * T - 0.009173 * T2) * dr); // Mean new moon
            double M = 359.2242 + 29.10535608 * k - 0.0000333 * T2 - 0.00000347 * T3; // Sun's mean anomaly
            double Mpr = 306.0253 + 385.81691806 * k + 0.0107306 * T2 + 0.00001236 * T3; // Moon's mean anomaly
            double F = 21.2964 + 390.67050646 * k - 0.0016528 * T2 - 0.00000239 * T3; // Moon's argument of latitude
            double C1 = (0.1734 - 0.000393 * T) * Math.Sin(M * dr) + 0.0021 * Math.Sin(2 * dr * M);
            C1 = C1 - 0.4068 * Math.Sin(Mpr * dr) + 0.0161 * Math.Sin(dr * 2 * Mpr);
            C1 -= 0.0004 * Math.Sin(dr * 3 * Mpr);
            C1 = C1 + 0.0104 * Math.Sin(dr * 2 * F) - 0.0051 * Math.Sin(dr * (M + Mpr));
            C1 = C1 - 0.0074 * Math.Sin(dr * (M - Mpr)) + 0.0004 * Math.Sin(dr * (2 * F + M));
            C1 = C1 - 0.0004 * Math.Sin(dr * (2 * F - M)) - 0.0006 * Math.Sin(dr * (2 * F + Mpr));
            C1 = C1 + 0.0010 * Math.Sin(dr * (2 * F - Mpr)) + 0.0005 * Math.Sin(dr * (2 * Mpr + M));
            double dt;
            if (T < -11)
                dt = 0.001 + 0.000839 * T + 0.0002261 * T2 - 0.00000845 * T3 - 0.000000081 * T * T3;
            else
                dt = -0.000278 + 0.000265 * T + 0.000262 * T2;
            return Jd1 + C1 - dt;
        }

        public static long GetNewMoonDay(long k, int timeZone)
        {
            return (long)Math.Floor(NewMoon(k) + 0.5 + timeZone / 24.0);
        }

        //Để biết Trung khí nào nằm trong tháng âm lịch nào, ta chỉ cần tính xem mặt trời nằm ở khoảng nào trên đường hoàng đạo
        //vào thời điểm bắt đầu một tháng âm lịch. Ta chia đường hoàng đạo làm 12 phần và đánh số các cung này từ 0 đến 11.
        //Cho jdn là số ngày Julius của bất kỳ một ngày, phương pháp sau này sẽ trả lại số cung nói trên.
        private static double SunLongitude(double julianDayNumber)
        {
            double T = (julianDayNumber - 2451545.0) / 36525; // Time in Julian centuries from 2000-01-01 12:00:00 GMT
            double T2 = T * T;
            double dr = Math.PI / 180; // degree to radian
            double M = 357.5291 + 35999.0503 * T - 0.0001559 * T2 - 0.00000048 * T * T2; // mean anomaly, degree
            double L0 = 280.46645 + 36000.76983 * T + 0.0003032 * T2; // mean longitude, degree
            double dL = (1.9146 - 0.004817 * T - 0.000014 * T2) * Math.Sin(dr * M);
            dL = dL + (0.019993 - 0.000101 * T) * Math.Sin(dr * 2 * M) + 0.00029 * Math.Sin(dr * 3 * M);
            double L = L0 + dL; // true longitude, degree
            L *= dr;
            L -= Math.PI * 2 * (Math.Floor(L / (Math.PI * 2))); // Normalize to (0, 2*PI)
            return L;
        }

        private static long GetSunLongitude(double dayNumber, int timeZone)
        {
            return (long)Math.Floor(SunLongitude(dayNumber - 0.5 - timeZone / 24.0) / Math.PI * 6);
        }

        //Đông chí thường nằm vào khoảng 19/12-22/12, như vậy trước hết ta tìm ngày Sóc trước ngày 31/12 (trả về số ngày Julius).
        //Nếu tháng bắt đầu vào ngày đó không chứa Đông chí thì ta phải lùi lại 1 tháng nữa.
        private static long GetLunarMonth11(int year, int timeZone)
        {
            SolarDate solarDate = new(31, 12, year);
            double off = solarDate.JulianDayNumber - 2415021.076998695;
            long k = (long)Math.Floor(off / 29.530588853);
            long nm = GetNewMoonDay(k, timeZone);
            double sunLong = GetSunLongitude(nm, timeZone); // sun longitude at local midnight
            if (sunLong >= 9)
                nm = GetNewMoonDay(k - 1, timeZone);
            return nm;
        }

        //Nếu giữa hai tháng 11 âm lịch có 13 tháng âm lịch thì năm âm lịch đó có tháng nhuận.
        //Để xác định tháng nhuận, ta sử dụng hàm GetSunLongitude như đã nói ở trên.
        //Cho a11 là ngày bắt đầu tháng 11 âm lịch mà một trong 13 tháng sau đó là tháng nhuận.
        //Hàm sau cho biết tháng nhuận nằm ở vị trí nào sau tháng 11 này.
        private static int GetLeapMonthOffset(double a11, int timeZone)
        {
            long k = (long)Math.Floor((a11 - 2415021.076998695) / 29.530588853 + 0.5);
            long last;
            int i = 1; // We start with the month following lunar month 11
            long arc = GetSunLongitude(GetNewMoonDay(k + i, timeZone), timeZone);
            do
            {
                last = arc;
                i++;
                arc = GetSunLongitude(GetNewMoonDay(k + i, timeZone), timeZone);
            }
            while (arc != last && i < 14);
            return i - 1;
        }

        public static LunarDate ConvertSolarDateToLunarDate(SolarDate solarDate, int timeZone)
        {
            long dayNumber = solarDate.JulianDayNumber;
            long k = (long)Math.Floor((dayNumber - 2415021.076998695) / 29.530588853);
            long monthStart = GetNewMoonDay(k + 1, timeZone);
            if (monthStart > dayNumber)
                monthStart = GetNewMoonDay(k, timeZone);
            long a11 = GetLunarMonth11(solarDate.Year, timeZone);
            long b11 = a11;
            int lunarYear;
            if (a11 >= monthStart)
            {
                lunarYear = solarDate.Year;
                a11 = GetLunarMonth11(solarDate.Year - 1, timeZone);
            }
            else
            {
                lunarYear = solarDate.Year + 1;
                b11 = GetLunarMonth11(solarDate.Year + 1, timeZone);
            }
            int lunarDay = (int)(dayNumber - monthStart + 1);
            int diff = (int)Math.Floor((double)((monthStart - a11) / 29));
            bool lunarLeap = false;
            int lunarMonth = diff + 11;
            if (b11 - a11 > 365)
            {
                int leapMonthDiff = GetLeapMonthOffset(a11, timeZone);
                if (diff >= leapMonthDiff)
                {
                    lunarMonth = diff + 10;
                    if (diff == leapMonthDiff)
                        lunarLeap = true;
                }
            }
            if (lunarMonth > 12)
                lunarMonth -= 12;
            if (lunarMonth >= 11 && diff < 4)
                lunarYear -= 1;
            return new LunarDate(lunarDay, lunarMonth, lunarLeap, lunarYear, timeZone);
        }

        public static SolarDate ConvertLunarDateToSolarDate(LunarDate lunarDate)
        {
            long julianDayNumber = JulianDayNumberFromLunarDate(lunarDate);
            return new SolarDate(julianDayNumber);
        }

        public static long JulianDayNumberFromLunarDate(LunarDate LunarDate)
        {
            long a11;
            long b11;
            if (LunarDate.Month < 11)
            {
                a11 = GetLunarMonth11(LunarDate.Year - 1, LunarDate.TimeZone);
                b11 = GetLunarMonth11(LunarDate.Year, LunarDate.TimeZone);
            }
            else
            {
                a11 = GetLunarMonth11(LunarDate.Year, LunarDate.TimeZone);
                b11 = GetLunarMonth11(LunarDate.Year + 1, LunarDate.TimeZone);
            }
            long k = (long)Math.Floor(0.5 + (a11 - 2415021.07699869) / 29.530588853);
            int off = LunarDate.Month - 11;
            if (off < 0)
            {
                off += 12;
            }
            if (b11 - a11 > 365)
            {
                int leapOff = GetLeapMonthOffset(a11, LunarDate.TimeZone);
                int leapMonth = leapOff - 2;
                if (leapMonth < 0)
                {
                    leapMonth += 12;
                }
                if (LunarDate.IsLeapMonth && LunarDate.Month != leapMonth)
                {
                    throw new Exception("Không thể thực hiện chuyển đổi!");
                }
                if (LunarDate.IsLeapMonth || off >= leapOff)
                {
                    off++;
                }
            }
            long monthStart = GetNewMoonDay(k + off, LunarDate.TimeZone);
            return monthStart + LunarDate.Day - 1;
        }
        #endregion
    }
}
