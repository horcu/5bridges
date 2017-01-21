using WebApplication.Interfaces;

namespace WebApplication.Models
{
    public class HarfordBridge :IBridge
    {
        public int GetLength()
        {
            return 30;
        }
    }
}