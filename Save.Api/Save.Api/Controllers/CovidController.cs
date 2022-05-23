using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Save.Application.GetCovidData;
using Save.Application.PostCovidData;
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
        private readonly GetCovidDataQuery _covidDataQuery;
        private readonly PostCovidDataQuery _postCovidDataQuery;

        public CovidController(ILogger<CovidController> logger, GetCovidDataQuery covidDataQuery, PostCovidDataQuery postCovidDataQuery)
        {
            _logger = logger;
            _covidDataQuery = covidDataQuery;
            _postCovidDataQuery = postCovidDataQuery;
        }

        [HttpGet]
        [Route("GetDataCovid")]
        public GetCovidDataResponse GetDataCovid()
        {
            var dataCovid = _covidDataQuery.GetData();

            return dataCovid;
        }

        [HttpPost]
        [Route("PostDataCovid")]
        public PostCovidDataResponse PostDataCovid(PostCovidDataRequest request)
        {
            var sendCovid = _postCovidDataQuery.PostData(request);

            return sendCovid;
        }
    }
}
