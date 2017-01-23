using Microsoft.SqlServer.Server;
using WebApplication.Interfaces;

namespace WebApplication.Models
{
    public class AnnArundel: MarylandCounties
    {
        public AnnArundel()
        {

        }
        public AnnArundel(int id, string name, string information, long population)
                   : base(id,name,information,population) {}

        public new string GetCountyInfo()
        {
            return Information;
        }
    }
}