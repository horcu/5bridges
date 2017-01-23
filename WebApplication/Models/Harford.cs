using WebApplication.Interfaces;

namespace WebApplication.Models
{
    public class Harford : MarylandCounties
    {
        public Harford()
        {

        }


        public new string GetCountyInfo()
        {
            return Information;
        }

        public Harford(int id, string name, string information, int population) : base(id, name, information, population)
        {
        }
    }
}