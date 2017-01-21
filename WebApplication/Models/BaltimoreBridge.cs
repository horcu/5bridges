using WebApplication.Interfaces;

namespace WebApplication.Models
{
    public class BaltimoreBridge : IBridge
    {
        public int GetLength()
        {
            return 15;
        }
    }
}