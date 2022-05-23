using Microsoft.EntityFrameworkCore.ChangeTracking;
using Save.Domain.Interfaces;
using Save.Domain.Model;
using Save.Infrastructure.Entity;
using Save.Infrastructure.Entity.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Save.Application.PostCovidData
{
    public class PostCovidDataQuery
    {
        private readonly ICovidRepository _covidRepository;

        public PostCovidDataQuery(ICovidRepository covidRepository)
        {
            _covidRepository = new CovidRepository(new SaveContext());
        }

        public PostCovidDataResponse PostData(PostCovidDataRequest request)
        {
            var adapter = new PostCovidDataAdapter();

            foreach (var item in request.Data)
            {
                var registers = _covidRepository.FindAllDataCovid();
                var isRegisters = registers.Where(x => x.Country == item.Country).Any();
                var mapperPost = adapter.MapperPostCovid(item);

                if (isRegisters == true)
                {
                    _covidRepository.UpdateDataCovid(mapperPost);
                }
                else
                {
                    var postData = _covidRepository.PostDataCovid(mapperPost);
                }
            }

            var response = new PostCovidDataResponse()
            {
                Message = "Sucess",
                StatusCode = "200",
                Data = request.Data
            };

            return response;
        }
    }
}
