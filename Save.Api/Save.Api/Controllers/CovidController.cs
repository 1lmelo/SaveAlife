using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Save.Application.GetCovidData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Save.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CovidController : ControllerBase
    {
        private readonly ILogger<CovidController> _logger;

        public CovidController(ILogger<CovidController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("GetDataCovid")]
        public GetCovidDataResponse GetDataCovid([FromBody] GetCovidDataRequest request)
        {
            var response = new GetCovidDataResponse();
            return response;
        }
    }
}
