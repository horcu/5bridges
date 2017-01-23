using WebApplication.Interfaces;

namespace WebApplication.Models
{
    public class PrinceGeorge: MarylandCounties
    {
        public PrinceGeorge()
        {

        }

        public new string GetCountyInfo()
        {
            return Information;
        }

        public PrinceGeorge(int id, string name, string information, int population)

            : base(id, name, information, population)
        {
        }
    }
}