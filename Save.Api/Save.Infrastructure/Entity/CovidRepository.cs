using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Save.Domain.Interfaces;
using Save.Domain.Model;
using Save.Infrastructure.Entity.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace Save.Infrastructure.Entity
{
    public class CovidRepository : ICovidRepository, IDisposable
    {
        private readonly SaveContext _saveContext;

        public CovidRepository(SaveContext saveContext)
        {
            _saveContext = saveContext;
        }

        public List<Covid> FindAllDataCovid()
        {
            return _saveContext.SearchCovid.ToList();
        }


        public EntityEntry<Covid> PostDataCovid(Covid covid)
        {
            var request = _saveContext.SearchCovid.Add(new Covid()
            {
                Country = covid.Country,
                Cases = covid.Cases,
                Confirmed = covid.Confirmed, 
                Deaths = covid.Deaths, 
                Recovered = covid.Recovered,
                Update_at = covid.Update_at
            });

            _saveContext.SaveChanges();

            return request;
        }

        public void UpdateDataCovid(Covid covid)
        {
            _saveContext.Entry(covid).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _saveContext.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
