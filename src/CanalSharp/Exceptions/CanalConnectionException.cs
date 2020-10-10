using System;

namespace CanalSharp
{
    public class CanalConnectionException:Exception
    {
        public CanalConnectionException(string message):base(message)
        {
            
        }

        public CanalConnectionException(string message,Exception inner) : base(message,inner)
        {

        }
    }
}