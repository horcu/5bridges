using WebApplication.Interfaces;

namespace WebApplication.Models
{
    public class Baltimore : MarylandCounties
    {
        public Baltimore()
        {

        }

        public new string GetCountyInfo()
        {
            return Information;
        }

        public Baltimore(int id, string name, string information, int population) : base(id, name, information, population)
        {
        }
    }
}