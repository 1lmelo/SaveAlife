using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Save.Application.PostCovidData
{
    public class PostCovidDataResponse
    {
        public string Message { get; set; }
        public string StatusCode { get; set; }
        public List<Data> Data { get; set; }
    }
}
