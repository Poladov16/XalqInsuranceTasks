using XalqSıgortaTasks.Services;
using Microsoft.Extensions.Logging;
using NLog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace FirstCoreProject.Repository
{
    public class OperationRepository : IDateService
    {
        public async Task<string> GetDayOfWeek(DateTime dateTime)
        {
           // File.AppendAllText("log.txt", dateTime.ToString());
            DateTime dt = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day);
            string week = dt.DayOfWeek.ToString();
            return week;
        }
        public async Task<string> GetValue(string digit)
        {
            //File.AppendAllText("log.txt", digit);
            for (int i = 0; i <= digit.Length - 1; i++)
            {
                if (char.IsNumber(digit[i]))
                {
                    return $"digit {digit[i]} at position {i}";
                }
                //if (digit[i] >= '0' && digit[i] <= '9')
                //{
                //    return $"digit {digit[i]} at position {i}";
                //}
            }
            return "No digit found!";

        }
        public async Task<string> CheckOfString(string checkString)
        {
            //  File.AppendAllText("log.txt", checkString);//logging
            for (int i = 0; i < checkString.Length; i++)
            {
                if (checkString[i] == ' ' || i == 0) 
                {
                    bool isUpper = char.IsLower(checkString[i + 1]);
                    if (isUpper)
                    {
                        if (i == 0)
                        {
                            checkString = checkString.Remove(i, 1);
                        }
                        else
                        {
                            checkString = checkString.Remove(i + 1, 1);
                        }
                    }
                }
            }
            return checkString;
         
        }

    }
}
