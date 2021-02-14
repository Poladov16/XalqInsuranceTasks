using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XalqSıgortaTasks.Services
{
    public interface IDateService
    {
        Task<string> GetDayOfWeek(DateTime dateTime);
        Task<string> GetValue(string someData);
        Task<string> CheckOfString(string checkString);
    }
}
