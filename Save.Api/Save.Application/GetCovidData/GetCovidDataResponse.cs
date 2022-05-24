using Save.Domain.Model;
using System.Collections.Generic;

namespace Save.Application.GetCovidData
{
    public class GetCovidDataResponse
    {
        public List<Covid> Data { get; set; }
    }
}
