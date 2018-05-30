using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class Extensions
    {
        public static string convertDateToStringDDMMYYYY(this DateTime dateTime)
        {
            string[] YYYYMMDD = dateTime.ToString().Split(' ');
            string[] arrayYYYYMMDD = YYYYMMDD[0].Split('/');

            string year = arrayYYYYMMDD[0];
            string month = arrayYYYYMMDD[1];
            string day = arrayYYYYMMDD[2];

            string newStringDate = string.Format($"{day}-{month}-{year}");
            return newStringDate;
        }

        public static bool TestForSpecialChars(this String testSpecials)
        {

            foreach (char stringLetter in testSpecials)
            {
                foreach (char invalids in Changebles.invalidChars)
                {
                    if (stringLetter == invalids) return true;
                }
            }

            return true;


        }


        public static DateTime ToDateTime(this string dateTimeString)
        {
            // 31-01-2012

            string[] date = dateTimeString.Split('-');
            DateTime dateTime = new DateTime(int.Parse(date[2]), int.Parse(date[1]), int.Parse(date[0]));
            return dateTime;

        }
    }

}
