using Microsoft.EntityFrameworkCore.ChangeTracking;
using Save.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Save.Domain.Interfaces
{
    public interface ICovidRepository
    {
        List<Covid> FindAllDataCovid();
        EntityEntry<Covid> PostDataCovid(Covid covid);
        void UpdateDataCovid(Covid covid);
    }
}
