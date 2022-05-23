using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Save.Application.PostCovidData
{
    public class PostCovidDataRequest
    {
        public List<Data> Data { get; set; }
    }

    public class Data
    {
        public string Country { get; set; }
        public int Cases { get; set; }
        public int Confirmed { get; set; }
        public int Deaths { get; set; }
        public int Recovered { get; set; }
        public string Update_at { get; set; }
    }
}
