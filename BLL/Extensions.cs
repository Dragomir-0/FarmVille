using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class Extensions
    {
    	
    	 public static string SplitInfo(this string info, int chosenArrayPosition)
        {
            string[] lines = info.Split(',');
            return lines[chosenArrayPosition];
        }

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

        public static DateTime ToDateTimeDTP(this string dateTimeString)
        {
        	DateTime dateTime;
        	string[] date = dateTimeString.Split(' ');
        	if(date[1].Equals("January")) dateTime 		= new DateTime(int.Parse(date[2],1,date[0]));
        	if(date[1].Equals("Febuary")) dateTime 		= new DateTime(int.Parse(date[2],2,date[0]));
        	if(date[1].Equals("March")) dateTime 		= new DateTime(int.Parse(date[2],3,date[0]));

        	if(date[1].Equals("April")) dateTime 		= new DateTime(int.Parse(date[2],4,date[0]));
        	if(date[1].Equals("May")) dateTime 			= new DateTime(int.Parse(date[2],5,date[0]));
        	if(date[1].Equals("June")) dateTime 		= new DateTime(int.Parse(date[2],6,date[0]));

        	if(date[1].Equals("July")) dateTime 		= new DateTime(int.Parse(date[2],7,date[0]));
        	if(date[1].Equals("August")) dateTime 		= new DateTime(int.Parse(date[2],8,date[0]));
        	if(date[1].Equals("September")) dateTime 	= new DateTime(int.Parse(date[2],9,date[0]));

        	if(date[1].Equals("November")) dateTime 	= new DateTime(int.Parse(date[2],10,date[0]));
        	if(date[1].Equals("October")) dateTime 		= new DateTime(int.Parse(date[2],11,date[0]));
        	if(date[1].Equals("December")) dateTime 	= new DateTime(int.Parse(date[2],12,date[0]));
        	return dateTime;


        }
    }

}


/*
Lamda
Delegate
Threading
Sockets
Links
serialization binary XML ++ and theory
FileHander + DataHandler ++
Server 10 marks+
*/

