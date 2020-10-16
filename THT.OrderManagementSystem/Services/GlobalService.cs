using THT.OrderManagementSystem.Data;

namespace THT.OrderManagementSystem.Services
{
    public class GlobalService
    {
        public static Repository Repository;
        public static Users LoginUser;

        public static void Initialize()
        {
            Repository = new Repository();
        }
    }
}