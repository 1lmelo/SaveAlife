using Microsoft.EntityFrameworkCore.ChangeTracking;
using Save.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Save.Application.PostCovidData
{
    public class PostCovidDataAdapter
    {

        public Covid MapperPostCovid(Data request)
        {
            var resultcovid = new Covid()
            {
                Country = request.Country,
                Cases = request.Cases,
                Confirmed = request.Confirmed,
                Deaths = request.Deaths,
                Recovered = request.Recovered,
                Update_at = Convert.ToDateTime(request.Update_at)
            };

            return resultcovid;
        }
    }
}
