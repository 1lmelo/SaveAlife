using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Save.Domain.Model
{
    public class Covid 
    {
        public int Id { get; set; }
        public string Country { get; set; }
        public int Cases { get; set; }
        public int Confirmed { get; set; }
        public int Deaths { get; set; }
        public int Recovered { get; set; }
        public DateTime Update_at { get; set; }
    }
}
