using Microsoft.SqlServer.Server;
using WebApplication.Interfaces;

namespace WebApplication.Models
{
    public class AnnArundel:IBridge
    {
        public int GetLength()
        {
            return 20;
        }
    }
}