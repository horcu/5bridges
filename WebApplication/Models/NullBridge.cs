using WebApplication.Interfaces;

namespace WebApplication.Models
{
    public class NullBridge:IBridge
    {
        public int GetLength()
        {

            return 0;
        }
    }
}