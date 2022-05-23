using Save.Domain.Model;
using System.Collections.Generic;

namespace Save.Application.GetCovidData
{
    public class GetCovidDataResponse
    {
        public string Message { get; set; }
        public string StatusCode { get; set; }
        public List<Covid> Data { get; set; }
    }
}
