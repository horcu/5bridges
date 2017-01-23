using WebApplication.Interfaces;

namespace WebApplication.Models
{
    public class NullCounty: ICounty
    {
        public string GetCountyInfo()
        {
            return string.Empty;
        }
    }
}