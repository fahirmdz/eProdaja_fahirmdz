using System;

namespace eProdaja.WebAPI.Exceptions
{
    public class UserException:Exception
    {
        public UserException(string message):base(message)
        {
            
        }
    }
}