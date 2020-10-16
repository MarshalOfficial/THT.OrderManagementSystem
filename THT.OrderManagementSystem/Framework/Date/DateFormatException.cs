using System;
namespace THT.OrderManagementSystem.Framework.Date
{
    class DateFormatException : Exception
    {
        public DateFormatException(string message)
            : base(message)
        {
        }
    }
}