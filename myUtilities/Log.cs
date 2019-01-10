using System;
namespace myUtilities
{
    public class Log
    {

        public string Logger(string msg)
        {
            return DateTime.Now.ToString("s") + msg;
        }

    }
}