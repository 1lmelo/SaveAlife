using Save.Domain.Interfaces;
using Save.Domain.Model;
using Save.Infrastructure.Entity;
using Save.Infrastructure.Entity.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Save.Application.GetCovidData
{
    public class GetCovidDataQuery
    {

        private readonly ICovidRepository _covidRepository;

        public GetCovidDataQuery(ICovidRepository covidRepository)
        {
            _covidRepository = new CovidRepository(new SaveContext());
        }

        public List<Covid> GetData()
        {
            var response = _covidRepository.FindAllDataCovid();

            return response;
        }
    }
}
