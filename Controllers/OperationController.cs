using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using XalqSıgortaTasks.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Logging;

namespace XalqSıgortaTasks.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OperationController : Controller
    {
        private IDateService _dateService;
        public OperationController(IDateService dateService)
        {
            _dateService = dateService;
        }
        [HttpGet]
        [Route("GetDayOfWeek")]
        public async Task<IActionResult> GetDayOfWeekAsync(DateTime datetime)
        {
            string dayOfWeek = await _dateService.GetDayOfWeek(datetime);
            return Ok(dayOfWeek);
        }
        [HttpGet]
        [Route("CheckDigit")]
        public async Task<IActionResult> CheckDigitAsync(string someData)
        {
            string response = await _dateService.GetValue(someData);
            return Ok(response);
        }
        [HttpGet]
        [Route("CheckOfWord")]
        public async Task<IActionResult> CheckOfWordAsync(string checkString)
        {
            string check = await _dateService.CheckOfString(checkString);
            return Ok(check);
        }
    }
}
