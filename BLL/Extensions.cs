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

        //Used to test for invalid chars
        public static bool TestForSpecialChars(this string testSpecials)
        {
            
            foreach (char stringLetter in testSpecials)
            {
                foreach (char invalids in Changebles.invalidChars)
                {
                    if(stringLetter == invalids) return true;
                }
            }

            return true;

        }
    }

}
