using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Renda_Interview_API_To_ReturnSimpleResult.Services;

namespace Renda_Interview_API_To_ReturnSimpleResult.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Renda_InterviewController : ControllerBase
    {
        private readonly IWeatherInfo _weatherInfo;

        public Renda_InterviewController(IWeatherInfo weatherInfo)
        {
            _weatherInfo = weatherInfo;
        }
        public List<string> GetWeatherInfo()
        {
            return _weatherInfo.GetWeatherInfo();
        }
    }
}
