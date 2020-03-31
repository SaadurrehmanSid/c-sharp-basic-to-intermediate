using System;
using System.Runtime.Serialization;

namespace CustomExecption
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                try
                {
                    throw new UserLoginExecption("the user cannot login twice on one device");
                }
                catch (UserLoginExecption ex)
                {
                    throw new Exception("this is the thrown exception",ex);
                }
            }
            catch (Exception excp)
            {
                Console.WriteLine("thrown Exception" + excp.Message);
                Console.WriteLine("Inner exception :"+ excp.InnerException.Message);
            }

        }
    }


    [Serializable]
    class UserLoginExecption : Exception 
    {
        public UserLoginExecption() :base()
        {
        }

        public UserLoginExecption(string message): base(message)
        {
        }

        public UserLoginExecption(string message,Exception exception) : base(message,exception)
        {
        }

        public UserLoginExecption(SerializationInfo info, StreamingContext
              context) : base(info,context)
        {
        }
    }
}
