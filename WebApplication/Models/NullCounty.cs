using WebApplication.Interfaces;

namespace WebApplication.Models
{
    public class NullCounty: ICounty
    {
        public int GetLength()
        {
            return 0;
        }

        public string GetCountyInfo()
        {
            return string.Empty;
        }
    }
}