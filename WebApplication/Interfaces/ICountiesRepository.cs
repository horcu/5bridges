using System;
using System.Threading.Tasks;

namespace WebApplication.Interfaces
{
        public interface ICountiesRepository
        {
            Task<ICounty> GetCountyByIndex(int id);

            Task<ICounty> GetCountyByName(string name);
        }

}

