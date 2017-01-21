using System;
using System.Threading.Tasks;

namespace WebApplication.Interfaces
{
        public interface IBridgesRepository
        {
            Task<IBridge> GetBridgeById(int id);

            Task<IBridge> GetBridgesByName(string name);
        }

}

